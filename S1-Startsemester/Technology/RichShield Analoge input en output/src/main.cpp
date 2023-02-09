#include <Arduino.h>

const int ledBlue = 6;
const int knob = A0;

int value;
int oldValue;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  value = analogRead(knob);
  value = map(value, 0, 1023, 0, 255);
  analogWrite(ledBlue, value);
  if(oldValue != value)
  {
    Serial.println(value);
    oldValue = value;
  }
}
