#include <Arduino.h>

#include "Display.h"

const int ledRed = 4;
const int buttonRight = 8;
int count = 0;

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
    
  if (count != 10)
  {
    if (rightButton == LOW)
    {
      count = count + 1;
      Serial.println(count);
      Display.show(count);
    }
  }

  if (count == 10)
  {
    int j = 0;
    while (j < 3)
    {
      digitalWrite(ledRed, HIGH);
      delay(150);
      digitalWrite(ledRed, LOW);
      delay(150);
      j++;
    }
  }
  delay(500);
}
