#include <Arduino.h>

int state;
const int blinkState = 1;
const int randomState = 2;
const int shuffleState = 3;

const int buttonLeft = 9;
const int buttonRight = 8;

const int ledRed = 4;
const int ledGreen = 5;
const int ledBlue = 6;
const int ledYellow = 7;

int previousLeftButtonState = HIGH;
int previousRightButtonState = HIGH;


void blinkLed(int led)
{
  digitalWrite(led, HIGH); //ledOn
  delay(100);
  digitalWrite(led, LOW); //ledOff
  delay(100);
}

void blinkLed(int led, int nrOfTimes)
{
  for (int i = 0; i < nrOfTimes; i++) //function blink led x times
  {
    blinkLed(led);
  }
}

void blinkRandom(int nrOfTimes)
{
  int led = random(4,8);
  blinkLed(led, nrOfTimes);
}


void handleState()
{
  switch (state)
  {
  case blinkState:
    //blink
    Serial.println("handleBlinkState");
    blinkLed(ledRed, 5);
    break;
  case randomState:
  //random
    Serial.println("handleRandomState");
    blinkRandom(50);
  break;
  case shuffleState:
  //shuffle
    Serial.println("handleShuffleState");
  break;

  default:
    break;
  }
}


void switchState()
{
  switch (state)
  {
  case blinkState:
    state = randomState;
    Serial.println("randomState");
    break;
  case randomState:
    state = shuffleState;
    Serial.println("shuffleState");
    break;
  case shuffleState:
    state = blinkState;
    Serial.println("blinkState");
    break;

  default:
    break;
  }
}


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(buttonLeft, INPUT_PULLUP);
  pinMode(buttonRight, INPUT_PULLUP);

  pinMode(ledRed, OUTPUT);
  pinMode(ledGreen, OUTPUT);
  pinMode(ledBlue, OUTPUT);
  pinMode(ledYellow, OUTPUT);

  state = blinkState;

}

void loop() {
  // put your main code here, to run repeatedly:
  int leftButtonState = digitalRead(buttonLeft);
  int rightButtonState = digitalRead(buttonRight);

  if (leftButtonState == LOW && previousLeftButtonState != leftButtonState)
  {
    switchState();
  }
  
  if (rightButtonState == LOW && previousRightButtonState != rightButtonState)
  {
    handleState();
  } 

  previousLeftButtonState = leftButtonState;
  previousRightButtonState = rightButtonState;
}
