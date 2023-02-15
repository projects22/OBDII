/* OBD2 LCD APP
 * By moty22.co.uk 
 * Lib written By: Cory J. Fowler  December 20th, 2016
 * https://github.com/coryjfowler/MCP_CAN_lib 
 */ 

#include <mcp_can.h>
#include <SPI.h>
#include <LiquidCrystal.h>

#define standard 1  //standard is 11 bits
#define pidPB 3  //+button

// initialize the lcd with the numbers of the interface pins
 LiquidCrystal lcd(5, 6, A2, A3, A4, A5);

unsigned long rxId;
byte len;
byte rxBuf[8];
unsigned int a, b;
unsigned char back=0, line;

MCP_CAN CAN0(10);                                // Set CAN0 CS to pin 10

void setup()
{
  Serial.begin(115200);
  while(!Serial);
  pinMode(3, INPUT_PULLUP);  //PID btn
  //pinMode(4, INPUT_PULLUP);  //-PID btn
  lcd.begin(16, 2);   // set up the LCD's number of columns and rows:  
  lcd.setCursor(6, 1);
  lcd.print("OBD2");

  // Initialize MCP2515 running at baudrate of 500kb/s . If your can board has 16MHz crystal change the setting.  
  if(CAN0.begin(MCP_STDEXT, CAN_500KBPS, MCP_8MHZ) == CAN_OK)
    Serial.println("Initialized Successfully!");
  else
    Serial.println("**Error Initializing**");

//  CAN0.init_Mask(0,0x7F00000);                // Init first mask...
  CAN0.init_Filt(0,0x7DF0000);                // Init first filter...
//  CAN0.init_Filt(1,0x7E10000);                // Init second filter...
//  CAN0.init_Mask(1,0x7F00000);                // Init second mask... 
  CAN0.init_Filt(2,0x7DF0000);                // Init third filter...
//  CAN0.init_Filt(3,0x7E10000);                // Init fouth filter...
  CAN0.init_Filt(4,0x7DF0000);                // Init fifth filter...
//  CAN0.init_Filt(5,0x7E10000);                // Init sixth filter...  
  
  CAN0.setMode(MCP_NORMAL);                          // Set operation mode to normal so the MCP2515 sends acks to received data.

}

void loop()
{
  if(!digitalRead(pidPB)){
    delay(500);
    if(line==0){req(0x04);}
    else if(line==1){req(0x05);}
    else if(line==2){req(0x06);}
    else if(line==3){req(0x07);}
    else if(line==4){req(0x0b);}
    else if(line==5){req(0x0c);}
    else if(line==6){req(0x0d);}
    else if(line==7){req(0x0e);}
    else if(line==8){req(0x0f);}
    else if(line==9){req(0x11);}
    else if(line==10){req(0x14);}
    else if(line==11){req(0x15);}
    ++line;
    if(line>11){line=0;}
  }


}

void req(unsigned char pid){
  unsigned char txData[] = {0x02,0x01,pid,0x0,0x0,0x0,0x0,0x0};

  CAN0.sendMsgBuf(0x7DF, 8, txData);
//    
//       Serial.print(txID, HEX);  //0x7E8 
//        Serial.print(" ");   //\t
//        for(byte i = 0; i<len; i++)    // print the data
//         {
//            Serial.print(txData[i], HEX);
//            Serial.print(" "); //\t            
//        }
//        Serial.println(); 
  delay(500);
  read();
  display(pid);     
}

void read(){
    if(!digitalRead(2)){
        for(byte i=0;i<20;++i){       //get 20 times unless reply arrived from the ECU 
        CAN0.readMsgBuf(&rxId, &len, rxBuf);     // Get CAN data - 03 41 0C 3D 0F
         if(rxId == 0x7E8){
//            Serial.print(rxId, HEX);  //0x7E8 
//            Serial.print("\t");
//            for(byte i = 0; i<len; i++)    // print the data
//            {
//                Serial.print(rxBuf[i], HEX);
//                Serial.print("\t");            
//            }
//            Serial.println();
            break;
        }

      }
    }   
} 

void display(unsigned char param){
  String unit, func;
  unsigned int val;
  
    a=rxBuf[3];
    b=rxBuf[4];

   lcd.clear();
   lcd.setCursor(1, 0); // top line
   if(param<10){lcd.print("0");}
   lcd.print(param);

   if(param==4){
    func="ENG LOAD";
    val=a*100/255; 
    unit="%"; 
   }
   else if(param==5){
    func="COOLANT";
    val=a-40; 
    unit="DEG C"; 
   }
   else if(param==6){
    func="SHORT FUEL";
    val=a*100/128-100; 
    unit="%"; 
   }
   else if(param==7){
    func="LONG FUEL";
    val=a*100/128-100; 
    unit="%"; 
   }
   else if(param==0x0b){
    func="INT PRESSURE";
    val=a; 
    unit="kPa"; 
   }
   else if(param==0x0c){
    func="RPM";
    val=(a*256 + b)/4; 
    unit="RPM"; 
   }
   else if(param==0x0d){
    func="SPEED";
    val=a; 
    unit="KM/H"; 
   }
   else if(param==0x0e){
    func="TIMING";
    val=a/2-64; 
    unit="DEG"; 
   }
   else if(param==0x0f){
    func="AIR TEMP";
    val=a-40; 
    unit="DEG C"; 
   }
   else if(param==0x11){
    func="THROTTLE";
    val=a*100/255; 
    unit="%"; 
   }
   else if(param==0x14){
    func="OXYGEN";
    val=a/200; 
    unit="V"; 
   }
   else if(param==0x15){
    func="OXYGEN";
    val=a/200; 
    unit="V"; 
   }
   lcd.setCursor(4, 0);
   lcd.print(func);
   lcd.setCursor(3, 1);
   lcd.print(val);
   lcd.print(" ");
   lcd.print(unit); 

}
