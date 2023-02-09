#include <Arduino.h>

const int ledRed = 4;
const int ledBlue = 6;

const int buttonLeft = 9;
const int buttonRight = 8;

int sequence[4];
int count = 0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(ledRed, OUTPUT);
  pinMode(ledBlue, OUTPUT);
  
  pinMode(buttonLeft, INPUT_PULLUP);
  pinMode(buttonRight, INPUT_PULLUP);
}

void blink() {
  for (int i = 0; i < 4; i++)
  {
    digitalWrite(sequence[i], HIGH);
    delay(300);
    digitalWrite(sequence[i], LOW);
    delay(100);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  int leftButtonPressed = digitalRead(buttonLeft);
  int rightButtonPressed = digitalRead(buttonRight);
  
  if(leftButtonPressed == LOW)
  {
    sequence[count] = ledRed;
    Serial.println("sequence = rood");
    count++;
  }
  if(rightButtonPressed == LOW)
  {
    sequence[count] = ledBlue;
    Serial.println("sequence = blauw");
    count++;
  }
  delay(200);
  
  if (count == 4)
  {
    blink();

    count = 0;
  }
}
