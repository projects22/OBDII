/* 
 * File:   obd2_tft_876.h
 * Author: moty22.co.uk
 *
 * Created on 15 February 2024, 02:07
 */

#ifndef OBD_TFT_VER_876_H
#define	OBD_TFT_VER_876_H

#ifdef	__cplusplus
extern "C" {
#endif
    
#include <htc.h>
    
#pragma config LVP=OFF, FOSC=HS, CP=OFF, CPD=OFF, WDTE=OFF, BOREN=OFF

#define _XTAL_FREQ 8000000
#define INT RC1		//pin12
#define SCK RC3	//pin14
#define SDA RC5	//SI pin16
#define SDI RC4	//SO pin15
#define CS RC2	//pin13
#define CStft RB0	//pin21
#define dc RB1	//A0 pin22
#define rst RB2	//pin23
#define next RB4	//pin25
#define txID 0x7DF  //0x7E9
    
 // Color definitions
#define	BLACK   0x0000
#define	BLUE    0x001F
#define	RED     0xF800
#define	GREEN   0x07E0
#define CYAN    0x07FF
#define MAGENTA 0xF81F
#define YELLOW  0xFFE0  
#define WHITE   0xFFFF
#define PINK    0xFC58
#define ORANGE  0xFC00
#define bgr  WHITE     

    //prototypes
void command(unsigned char cmd);
void LCDinit(void);
void send_data(unsigned char data);
void area(unsigned char x0,unsigned char y0, unsigned char x1,unsigned char y1);
void rectan(unsigned char x0,unsigned char y0, unsigned char x1,unsigned char y1, unsigned int color);
void draw(unsigned char x, unsigned char y, unsigned char c, unsigned int color, unsigned char size);
void MCP2515_SELECT();
void MCP2515_UNSELECT();
unsigned char SPI(unsigned char val);
void query(unsigned char pid);
void display(unsigned char row);
void drawLine(unsigned char f1, unsigned char f2, unsigned char f3, unsigned int val, unsigned char u1, 
                                            unsigned char u2, unsigned char u3);

#ifdef	__cplusplus
}
#endif

#endif	/* OBD_TFT_VER_876_H */

