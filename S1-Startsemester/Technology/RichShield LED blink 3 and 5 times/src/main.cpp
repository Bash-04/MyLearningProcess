#include <Arduino.h>

const int ledRed = 4;

const int buttonLeft = 9;
const int buttonRight = 8;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(ledRed, OUTPUT);
  pinMode(buttonLeft, INPUT_PULLUP);
  pinMode(buttonRight, INPUT_PULLUP);
}

// The parameter is the thing that is unknown, in this case "int blinks"
// This parameter can be filled in when the function is called up on
void blinkLed(int blinks) {
  for (int i = 0; i < blinks; i++)
  {
  digitalWrite(ledRed, HIGH);
  delay(120);
  digitalWrite(ledRed, LOW);
  delay(120);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  int LeftbuttonPressed = digitalRead(buttonLeft);
  int RightbuttonPressed = digitalRead(buttonRight);

  if (LeftbuttonPressed == LOW)
  {
    Serial.println("blink 3x");
    blinkLed(3); // here you see the parameter that is called up on has been given the worth of "3"
  }
  else if (RightbuttonPressed == LOW)
  {
    Serial.println("blink 5x");
    blinkLed(5); // here you see the parameter that is called up on has been given the worth of "5"
  }
}
