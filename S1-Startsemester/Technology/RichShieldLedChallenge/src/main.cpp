#include <Arduino.h>

const int ledRed = 4;  // Pin4 = ledRed = Pin Led Red
const int ledGreen = 5;  // Pin5 = ledGreen = Pin Led Green
const int ledBlue = 6;  // Pin6 = ledBlue = Pin Led Blue
const int ledYellow = 7;  // Pin7 = ledYellow = Pin Led Yellow

const int buttonOne = 8;  // Pin8 = buttonOne = Pin Button one
const int buttonTwo = 9;  // Pin9 = buttonTwo = Pin Button two

int activeLed = ledRed; //ledRed = active on default
int activeLedTwo = ledBlue; //ledBlue = active on default


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(ledRed, OUTPUT);
  pinMode(ledGreen, OUTPUT);
  pinMode(ledBlue, OUTPUT);
  pinMode(ledYellow, OUTPUT);

  pinMode(buttonOne, INPUT_PULLUP);
  pinMode(buttonTwo, INPUT_PULLUP);

  digitalWrite(ledRed, HIGH);
  digitalWrite(ledBlue, HIGH);
}

void loop() {
  // put your main code here, to run repeatedly:
  int buttonPressed = digitalRead(buttonOne);
  int buttonPressed_2 = digitalRead(buttonTwo);
  
  if (buttonPressed == LOW)
  {
    if (activeLed == ledRed)
    {
      digitalWrite(ledRed, LOW);
      digitalWrite(ledGreen, HIGH);
      activeLed = ledGreen;
    }
    else if (activeLed == ledGreen)
    {
      digitalWrite(ledGreen, LOW);
      digitalWrite(ledRed, HIGH);
      activeLed = ledRed;
    }
        
    Serial.println("Button pressed");
  }

  if (buttonPressed_2 == LOW)
  {
    if (activeLedTwo == ledBlue)
    {
      digitalWrite(ledBlue, LOW);
      digitalWrite(ledYellow, HIGH);
      activeLedTwo = ledYellow;
    }
    else if (activeLedTwo == ledYellow)
    {
      digitalWrite(ledYellow, LOW);
      digitalWrite(ledBlue, HIGH);
      activeLedTwo = ledBlue;
    }
    
    Serial.println("Button pressed2");
  }
    delay(300);
  
}
