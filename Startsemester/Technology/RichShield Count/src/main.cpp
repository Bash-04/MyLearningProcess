#include <Arduino.h>
#include "Display.h"

int count = 0;

void setup() {
  // put your setup code here, to run once:
  Display.show(0000);
}

void loop() {
  // put your main code here, to run repeatedly:
  count = count + 1;
  Serial.println(count);
  Display.show(count);
  delay(1000);
}

