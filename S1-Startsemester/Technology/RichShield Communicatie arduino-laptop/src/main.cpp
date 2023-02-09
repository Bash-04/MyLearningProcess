#include <Arduino.h>

String number;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int sum = number.toInt() * number.toInt();
  
  if (Serial.available() > 0)
  {
    char received = Serial.read();

    if (received == '\n') 
    {
      Serial.println("Arduino Received: " + number); 
      Serial.println(sum);
      number = "";
    }
    else
    {
      number += received;
    }
  }
}
