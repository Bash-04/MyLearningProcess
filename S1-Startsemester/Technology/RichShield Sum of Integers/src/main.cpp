#include <Arduino.h>

int array[5];
int i;
int sum;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  array[0] = 8;
  array[1] = 12;
  array[2] = 25;
  array[3] = 32;
  array[4] = 46;

  for (i = 0; i < 5; i++)
  {
    sum += array[i];
    Serial.println(array[i]);
  } 
  Serial.println(sum);
}

void loop() {
  // put your main code here, to run repeatedly:  
}
