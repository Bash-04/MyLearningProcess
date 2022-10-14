#include <Arduino.h>
#include "Display.h"

const int ledRed = 4;
const int ledGreen = 5;
const int ledBlue = 6;
const int ledYellow = 7;

const int buttonRight = 8;
const int buttonLeft = 9;

const int knob = A0;

const int buzzer = 3;

String sequenceNumber;

int value = 0;

int toneCalc = 0;

int sequence[8];
int count = 0;

// 
int oneHundredPercent = 255;
int seventyFivePercent = 190;
int fiftyPercent = 127;
int twentyFivePercent = 63;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  Display.show(0);

  pinMode(ledRed, OUTPUT);
  pinMode(ledGreen, OUTPUT);
  pinMode(ledBlue, OUTPUT);
  pinMode(ledYellow, OUTPUT);
  pinMode(buzzer, OUTPUT);

  pinMode(knob, INPUT_PULLUP);
  pinMode(buttonLeft, INPUT_PULLUP);
  pinMode(buttonRight, INPUT_PULLUP);
}

void checkButtonAndBeep() {
  int leftButtonPressed = digitalRead(buttonLeft);
  int rightButtonPressed = digitalRead(buttonRight);

  if (leftButtonPressed == LOW)
  {
    Serial.println(toneCalc + 500);
    tone(buzzer, toneCalc + 500, 0.1);

    sequence[count] = toneCalc + 500;
    Display.show(count + 1);
    count++;

    delay(200);
  }
  else if (rightButtonPressed == LOW)
  {
    Serial.println(toneCalc + 150);
    tone(buzzer, toneCalc + 150, 0.1);

    sequence[count] = toneCalc + 150;
    Display.show(count + 1);
    count++;
    
    delay(200);
  }
  else if (leftButtonPressed == HIGH && rightButtonPressed == HIGH)
  {
    noTone(buzzer);
  }
}

void beepSequence() {
  delay(1000);
  for (int i = 0; i < 8; i++)
  {
    tone(buzzer, sequence[i], 0.1);
    Serial.println(sequence[i]);
    delay(200);
    Display.show(i + 1);
  }
}

void checkKnob() {
  if (value == oneHundredPercent)
  {
    checkButtonAndBeep();
    digitalWrite(ledRed, HIGH);
  }
  else if (value >= seventyFivePercent)
  {
    checkButtonAndBeep();
    digitalWrite(ledRed, LOW);
    digitalWrite(ledGreen, HIGH);
  }
  else if(value >= fiftyPercent)
  {
    checkButtonAndBeep();
    digitalWrite(ledGreen, LOW);
    digitalWrite(ledBlue, HIGH);
  }
  else if (value >= twentyFivePercent)
  {
    checkButtonAndBeep();
    digitalWrite(ledBlue, LOW);
    digitalWrite(ledYellow, HIGH);
  }
  else
  {
    checkButtonAndBeep();
    digitalWrite(ledYellow, LOW);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  value = analogRead(knob);
  value = map(value, 0, 1023, 0, 255);
  toneCalc = map(value, 0, 1023, 0, 18000);

  if (count == 8)
  {
    beepSequence();
    count = 0;
    delay(500);
    Display.show(count);
  }

  checkKnob();

  if (Serial.available() > 0)
  {
    char received = Serial.read();
    if (received == '\n')
    {
      Serial.println(sequenceNumber);
      sequence[count] = sequenceNumber.toInt() + 150;
      sequenceNumber = "";
      count++;
      Display.show(count);
    }
    else
    {
      sequenceNumber += received;
    }
  }
}
