#include <Arduino.h>

#include "Display.h"

const int ledRed = 4;
const int buttonRight = 8;
int i = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  Display.show(0000);

  pinMode(ledRed, OUTPUT);
  pinMode(buttonRight, INPUT_PULLUP);

}

void loop() {
  // put your main code here, to run repeatedly:
  int rightButton = digitalRead(buttonRight);
    
  if (i != 10)
  {
    if (rightButton == LOW)
    {
      i = i + 1;
      Serial.println(i);
      Display.show(i);
    }
  }

  if (i == 10)
  {
      for (int i = 0; i < 3; i++)
    {
      digitalWrite(ledRed, HIGH);
      delay(150);
      digitalWrite(ledRed, LOW);
      delay(150);
    }
  }
  delay(500);
}
