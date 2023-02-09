#include <Arduino.h>

#include "Display.h"

const int button1 = 8;
const int button2 = 9;

int count;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(button1, INPUT_PULLUP);
  pinMode(button2,INPUT_PULLUP);
  Display.show(0000);

}

void loop() {
int buttonpressed = digitalRead(button1);

if (buttonpressed == LOW)
{
  count++;
  Display.show(count);
  Serial.println(count);
}
delay(150);

int buttonpressed2 = digitalRead(button2);
if (buttonpressed2 == LOW)
{ 
  if (count != 0 ){
    count--;
    Display.show(count);
    Serial.println(count);
  }
}
}
