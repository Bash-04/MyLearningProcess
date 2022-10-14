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


int value = 0;
int outputValue;

int toneCalc = 0;

int *sequence;
int count = 1;

int sequenceInput = 0;

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

void checkButtonAndBeep() {   // dit is de functie om te lezen welke knop in is gedrukt en te berekenen welke toon er gepiept moet worden
  int leftButtonPressed = digitalRead(buttonLeft);
  int rightButtonPressed = digitalRead(buttonRight);

  if (leftButtonPressed == LOW)
  {
    Serial.println(toneCalc + 500);
    tone(buzzer, toneCalc + 500, 0.1);

    sequence[count] = toneCalc + 500;
    Display.show(count);
    count++;

    delay(200);
  }
  else if (rightButtonPressed == LOW)
  {
    Serial.println(toneCalc + 150);
    tone(buzzer, toneCalc + 150, 0.1);

    sequence[count] = toneCalc + 150;
    Display.show(count);
    count++;
    
    delay(200);
  }
  else if (leftButtonPressed == HIGH && rightButtonPressed == HIGH)   // wanneer er geen knop in is gedrukt moet er geen toon gespeeld worden
  {
    noTone(buzzer);
  }
}

void beepSequence() {   // dit is de array
  delay(1000);
  for (int i = 1; i < sequenceInput; i++)
  {
    tone(buzzer, sequence[i], 0.1);
    Serial.println(sequence[i]);
    delay(200);
    Display.show(i);
  }
  noTone(buzzer);
  sequenceInput = 0;
}

void resetSequence() {    // dit resest alle zoomfrequencies in de array terug naar 0
  for (unsigned int i = 1; i < (sizeof(sequence) / sizeof(sequence[0])); i++)
  {
    sequence[i] = 0;
    Serial.println(sequence[i]);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  value = analogRead(knob);
  outputValue = map(value, 0, 1023, 0, 255);

  if (sequenceInput != 0)
  {
  toneCalc = map(outputValue, 0, 1023, 0, 18000);
    if (outputValue == oneHundredPercent)   // dit zorgt ervoor dat het rode lampje bij honderd procent brand
    {
      checkButtonAndBeep();
      digitalWrite(ledRed, HIGH);
    }
    else if (outputValue >= seventyFivePercent)   // dit zorgt ervoor dat het groene lampje boven de 75 procent brand
    {
      checkButtonAndBeep();
      digitalWrite(ledRed, LOW);
      digitalWrite(ledGreen, HIGH);
    }
    else if(outputValue >= fiftyPercent)   // dit zorgt ervoor dat het blauwe lampje boven de 50 procent brand
    {
      checkButtonAndBeep();
      digitalWrite(ledGreen, LOW);
      digitalWrite(ledBlue, HIGH);
    }
    else if (outputValue >= twentyFivePercent)   // dit zorgt ervoor dat het gele lampje boven de 25 procent brand
    {
      checkButtonAndBeep();
      digitalWrite(ledBlue, LOW);
      digitalWrite(ledYellow, HIGH);
    }
    else   // dit zorgt ervoor dat wanneer de knob onder de 25% staat niets brand
    {
      checkButtonAndBeep();
      digitalWrite(ledYellow, LOW);
    }
  }

  if (Serial.available() > 0)   // dit is waar je de totaal keer klikken invult in de Serial Monitor
  {
    int received = Serial.read() - 48;

    Serial.println(received);
    sequenceInput = received + 1;
  }
  
  if (count == sequenceInput)   // dit zorgt ervoor dat op het moment dat de array uit tien sequences bestaat dat dit afgespeeld wordt. 
  {
    beepSequence();
    count = 1;
    delay(500);
    Display.show(0);
    resetSequence();
  }
}
