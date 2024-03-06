
// OBD2  TFT
// by www.moty22.co.uk
// 
// pic16f876A
   
//#include <htc.h>
#include "obd_tft_ver_876.h"
#include "mcp_can.h"
#include "oled_font.c"

unsigned char i, press=0;
bit run=0;
unsigned long rxId;
unsigned char len;
unsigned char rxBuf[8];
unsigned int rpm, a, b;
unsigned char y;
unsigned char txData[8] = {0x02, 0x01, 0x0C, 0x55, 0x55, 0x55, 0x55, 0x55}; //PID to request 010C

void main(void)
{
	TRISC = 0b11010011;		//  
	TRISB = 0b11111000;
    TRISA = 0b11110000;
    nRBPU = 0;  //pullup
    
    //Timer1
    T1CON = 0b00110000; //1:8,osc-off
	//SPI init
	SSPCON = 0B100000;	//0B100000=full speed, enabled,clock idle=L   
	CKE=1;	//Data transmitted on rising edge of SCK

    CStft=1;
    rst=1;
    CS=1;

    __delay_ms(100);
    begin(MCP_STDEXT, CAN_500KBPS, MCP_8MHZ);
    
    init_Filt(0,0x7DF0000);
    init_Filt(2,0x7DF0000);
    init_Filt(4,0x7DF0000);

	setMode(MCP_NORMAL);
    
    LCDinit();
	
    rectan(0,0,127,159,WHITE); 	//bacbground

    draw(37,10,0x4f,MAGENTA,2);     //O
    draw(50,10,0x42,MAGENTA,2);     //B
    draw(63,10,0x44,MAGENTA,2);     //D
    draw(76,10,50,MAGENTA,2);     //2
    __delay_ms(100);
    
    while(1){
        if(!next && run){
            run=0; 
            while(!next){__delay_ms(100);}
        }
        if(!next && !run){
            run=1; 
            while(!next){__delay_ms(100);}
            rectan(37,10,89,26,bgr);
        }
        if(run){
            
            y=-10;
            query(04);
            query(05);
            query(06);
            query(07);
            query(0x0A);
            query(0x0B);
            query(0x0C);
            query(0x0D);
            query(0x0E);
            query(0x0F);
            query(0x10);
            query(0x11);            

            __delay_ms(100);
        }
	}	
}

void query(unsigned char pid){
    unsigned char j=0;
    
    txData[2]=pid;
    sendMsgBuf(txID, 8, txData); //request data from ECU
    
    TMR1ON=1;
    TMR1IF=0;
    while(INT){
        if(TMR1IF){
            TMR1IF=0; ++j;
            if(j>8){
               TMR1ON=0;
               y +=12;
               drawLine((pid/10)%10+48,pid%10+48,32,0,0x2d,0x2d,0x2d);
               return;  //when no reply go to next PID
            }
        }
    }
    readMsgBuf(&rxId, &len, rxBuf);     // Get CAN data - 03 41 0C 3D 0F
    if(rxId == 0x7E8){
        y +=12;
        display(pid);
    }
  
}

void display(unsigned char row){
    unsigned int val=0;
    
    switch (row){
        case 4:
            val = (rxBuf[3]*100)/255;
            drawLine(0x45,0x4c,32,val,0x25,32,32);
            break;
        case 5:
            val = rxBuf[3]-40;
            drawLine(0x43,0x54,32,val,0x7b,0x43,32);
            break;
        case 6:
            val = (rxBuf[3]*100)/128-100;
            drawLine(0x53,0x54,0x46,val,0x25,32,32);
            break;                
        case 7:
            val = (rxBuf[3]*100)/128-100;
            drawLine(0x4c,0x54,0x46,val,0x25,32,32);
            break;            
        case 0x0A:    //fuel press
            val = rxBuf[3]*3;
            drawLine(0x46,0x50,32,val,0x6b,0x50,0x61);
            break;
        case 0x0B:    //MAP
            val = rxBuf[3];
            drawLine(0x4d,0x41,0x50,val,0x6b,0x50,0x61);
            break;
        case 0x0C:    //RPM
            val = (rxBuf[3]*256+rxBuf[4])/4;
            drawLine(0x52,0x50,0x4d,val,0x72,0x70,0x6d);
            break;      
        case 0x0D:    //speed
            val = rxBuf[3];
            drawLine(0x56,0x53,32,val,0x6b,0x2f,0x68);
            break;
        case 0x0E:    //timing
            val = (rxBuf[3]/2)-64;
            drawLine(0x54,0x45,32,val,0x7b,32,32);
            break;    
        case 0x0F:    //inlet temp
            val = rxBuf[3]-40;
            drawLine(0x49,0x41,0x54,val,0x7b,0x43,32);
            break;        
        case 0x10:    //MAF
            val = ((rxBuf[3]*256)+rxBuf[4])/100;
            drawLine(0x4d,0x41,0x46,val,0x67,0x2f,0x73);
            break;
        case 0x11:    //Throtle
            val = (rxBuf[3]*100) / 255;
            drawLine(0x54,0x50,32,val,0x25,32,32);
            break;    
            
    }

}

void drawLine(unsigned char f1, unsigned char f2, unsigned char f3, unsigned int val, 
                        unsigned char u1, unsigned char u2, unsigned char u3){
    unsigned char d[4];
    
    d[3]=(val/1000) %10+48;
    d[2]=(val/100) %10+48;
    d[1]=(val/10) %10+48;
    d[0]=val %10+48;

    draw(2,y,f1,RED,1);     //VS
    draw(9,y,f2,RED,1);     //
    draw(16,y,f3,RED,1);     //
    
    if(val>999){draw(60,y,d[3],BLACK,1);}else{draw(60,y,32,BLACK,1);}     //
    if(val>99){draw(67,y,d[2],BLACK,1);}else{draw(67,y,32,BLACK,1);}     //
    if(val>9){draw(74,y,d[1],BLACK,1);}else{draw(74,y,32,BLACK,1);}     //
    draw(81,y,d[0],BLACK,1);     //
    
    draw(106,y,u1,BLUE,1);     //k
    draw(113,y,u2,BLUE,1);     //P
    draw(120,y,u3,BLUE,1);     //H
    
    if(!next && !run){
        run=1; 
        while(!next){__delay_ms(100);}
        rectan(37,10,89,26,bgr);
    }
}

void MCP2515_SELECT(){
    CS=0;
}

void MCP2515_UNSELECT(){
    CS=1;
}

unsigned char SPI(unsigned char val)		// send character over SPI
{
	SSPBUF = val;			// load character
	while (!BF);		// sent
	return SSPBUF;		// received character
}

void draw(unsigned char x, unsigned char y, unsigned char c, unsigned int color, unsigned char size) //character
{
	unsigned char i, j, line;
    for (i=0; i<6; i++ ) {
        if (i == 5) {
          line = 0x0;
        }else {
          line = font[(c-32)*5+i];
        }
        for (j = 0; j<8; j++) {
            if (line & 0x1) {
                rectan(x+(i*size), y+(j*size), x+(i*size)+size, y+(j*size)+size, color);
            }else{ 
                rectan(x+(i*size), y+(j*size), x+(i*size)+size, y+(j*size)+size, bgr);
            }
            line >>= 1;
        }
    }
}

void command(unsigned char cmd)
{
	dc=0;	// Command Mode
	CStft=0;	// Select the LCD	(active low)
	SPI(cmd);	// set up data on bus
	CStft=1;	// Deselect LCD (active low)
}

void send_data(unsigned char data)
{
	dc=1;       // data mode
	CStft=0;       // chip selected
	SPI(data);	// set up data on bus
	CStft=1;       // deselect chip
}

void LCDinit(void)
{
	unsigned char i;
	rst=1;			//hardware reset
	__delay_ms(200);
	rst=0;
	__delay_ms(10);
	rst=1;
	__delay_ms(10);
	
	command(0x01); // sw reset
	__delay_ms(200);

  	command(0x11); // Sleep out
 	__delay_ms(200);
	  
	  command(0x3A); //color mode
	  send_data(0x05);	//16 bits
	    
	  command(0x36); //Memory access ctrl (directions)
	  send_data(0B11000000);  //1.8" hor-0B01100000=0x60, 1.8" ver-0B11000000, 1.44" ver-0B00001000,
//	  command(0x21); //inversion on
	  
	command(0x2D);	//color look up table
	send_data(0); for(i=1;i<32;i++){send_data(i*2);}
	for(i=0;i<64;i++){send_data(i);}	
	send_data(0); for(i=1;i<32;i++){send_data(i*2);}	  
	  
	  command(0x13); //Normal display on
	  command(0x29); //Main screen turn on
}	  

void area(unsigned char x0,unsigned char y0, unsigned char x1,unsigned char y1)
{
  command(0x2A); // Column addr set
  send_data(0x00);
  send_data(x0);     // XSTART 
  send_data(0x00);
  send_data(x1);     // XEND

  command(0x2B); // Row addr set
  send_data(0x00);
  send_data(y0);     // YSTART
  send_data(0x00);
  send_data(y1);     // YEND

  command(0x2C); // write to RAM
}  
	
void rectan(unsigned char x0,unsigned char y0, unsigned char x1,unsigned char y1, unsigned int color) 
{
 unsigned int i;
  area(x0,y0,x1,y1);
  for(i=(y1 - y0 + 1) * (x1 - x0 + 1); i > 0; i--) {		  

	    dc=1;       // data mode
		CStft=0;
		SPI(color >> 8);
		SPI(color);
		CStft=1;
  }
}





