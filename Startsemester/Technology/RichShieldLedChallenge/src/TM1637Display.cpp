/*
 * TM1637Display.cpp
 *
 * Rich Shield Display driver
 *
 * Version: 1.0
 * Date: 17/11/2019
 * Author: gerald Hilderink <g.hilderink@fontys.nl>
 */

#include "TM1637Display.h"

//
// Display configuration properties.
//
const uint8_t NUM_DIGITS = 4;
const uint8_t SIGNAL_DELAY = 0;  // us

//
// TM1637 commands.
//
const uint8_t DATACOMMAND_DISPLAYWRITE = 0b01000100;
const uint8_t ADDRESSCOMMAND_DISPLAYREGADDRC0 = 0b11000000;
const uint8_t ADDRESSCOMMAND_DISPLAYREGADDRC1 = 0b11000001;
const uint8_t ADDRESSCOMMAND_DISPLAYREGADDRC2 = 0b11000010;
const uint8_t ADDRESSCOMMAND_DISPLAYREGADDRC3 = 0b11000011;
const uint8_t ADDRESSCOMMAND_DISPLAYREGADDRC4 = 0b11000100;
const uint8_t ADDRESSCOMMAND_DISPLAYREGADDRC5 = 0b11000101;
const uint8_t DISPLAYCOMMAND_DISPLAYON =
    0b10001000 + 0x0;  // 000 = 1/16, brightness 0x0..0x7
const uint8_t DISPLAYCOMMAND_DISPLAYOFF = 0b10000000;

TM1637Display::TM1637Display(uint8_t clockPin, uint8_t dataPin)
    : _clockPin(clockPin), _dataPin(dataPin), _enabled(true) {
  //
  // Set the pin directions.
  //
  pinMode(clockPin, OUTPUT);
  pinMode(dataPin, OUTPUT);

  //
  // Initial logic levels.
  //
  digitalWrite(clockPin, HIGH);
  digitalWrite(dataPin, HIGH);

  //
  // Set the TM1637 to display mode (not keyboard scanner).
  //
  startSignal();
  write(DATACOMMAND_DISPLAYWRITE);
  stopSignal();
    
  brightness(3);
}

uint8_t TM1637Display::getDigit(char character) {
  //
  // This function can be further optimized by using multiple switch structures:
  // one for '0'..'9', one for 'A'..'Z', one for 'a'..'z', one for the rest.
  //

  uint8_t digit;

  switch (character) {
    case '0':
      digit = DIGIT_0;
      break;
    case '1':
      digit = DIGIT_1;
      break;
    case '2':
      digit = DIGIT_2;
      break;
    case '3':
      digit = DIGIT_3;
      break;
    case '4':
      digit = DIGIT_4;
      break;
    case '5':
      digit = DIGIT_5;
      break;
    case '6':
      digit = DIGIT_6;
      break;
    case '7':
      digit = DIGIT_7;
      break;
    case '8':
      digit = DIGIT_8;
      break;
    case '9':
      digit = DIGIT_9;
      break;
    case 'A':
      digit = DIGIT_A;
      break;
    case 'C':
      digit = DIGIT_C;
      break;
    case 'E':
      digit = DIGIT_E;
      break;
    case 'F':
      digit = DIGIT_F;
      break;
    case 'G':
      digit = DIGIT_G;
      break;
    case 'H':
      digit = DIGIT_H;
      break;
    case 'I':
      digit = DIGIT_I;
      break;
    case 'J':
      digit = DIGIT_J;
      break;
    case 'L':
      digit = DIGIT_L;
      break;
    case 'N':
      digit = DIGIT_N;
      break;
    case 'O':
      digit = DIGIT_O;
      break;
    case 'P':
      digit = DIGIT_P;
      break;
    case 'R':
      digit = DIGIT_R;
      break;
    case 'S':
      digit = DIGIT_S;
      break;
    case 'U':
      digit = DIGIT_U;
      break;
    case 'Y':
      digit = DIGIT_Y;
      break;
    case 'a':
      digit = DIGIT_a;
      break;
    case 'b':
      digit = DIGIT_b;
      break;
    case 'c':
      digit = DIGIT_c;
      break;
    case 'd':
      digit = DIGIT_d;
      break;
    case 'e':
      digit = DIGIT_e;
      break;
    case 'f':
      digit = DIGIT_f;
      break;
    case 'g':
      digit = DIGIT_g;
      break;
    case 'h':
      digit = DIGIT_h;
      break;
    case 'i':
      digit = DIGIT_i;
      break;
    case 'j':
      digit = DIGIT_j;
      break;
    case 'l':
      digit = DIGIT_l;
      break;
    case 'n':
      digit = DIGIT_n;
      break;
    case 'o':
      digit = DIGIT_o;
      break;
    case 'p':
      digit = DIGIT_p;
      break;
    case 'q':
      digit = DIGIT_q;
      break;
    case 'r':
      digit = DIGIT_r;
      break;
    case 's':
      digit = DIGIT_s;
      break;
    case 't':
      digit = DIGIT_t;
      break;
    case 'u':
      digit = DIGIT_u;
      break;
    case 'y':
      digit = DIGIT_y;
      break;
    case '=':
      digit = DIGIT_EQUALS;
      break;
    case '(':
    case '{':
    case '[':
      digit = DIGIT_LSB;
      break;
    case ')':
    case '}':
    case ']':
      digit = DIGIT_RSB;
      break;
    case '-':
      digit = DIGIT_DASH;
      break;
    case '_':
      digit = DIGIT_UNDERSCORE;
      break;
    case '\"':
      digit = DIGIT_QUOTE;
      break;
    case '/':
      digit = DIGIT_SLASH;
      break;
    case '\\':
      digit = DIGIT_BACKSLASH;
      break;
    case ' ':
      digit = DIGIT_SPACE;
      break;
    default:
      digit = SEG_CLR;
      break;
  }
  return digit;
}

void TM1637Display::showCharAt(uint8_t pos, char character) {
  showDigitAt(pos, getDigit(character));
}

void TM1637Display::showDigitAt(uint8_t pos, uint8_t digit) {
  if (_enabled) {
    if (pos < NUM_DIGITS) {
      startSignal();
      write(ADDRESSCOMMAND_DISPLAYREGADDRC0 | pos);
      write(digit);
      stopSignal();
    }
  }
}

void TM1637Display::showDigitAt(uint8_t pos, uint8_t digit, bool showDot) {
  if (showDot) {
    // Show dot.
    showDigitAt(pos, digit | SEG_DOT);
  } else {
    // Clear dot.
    showDigitAt(pos, digit);
  }
}

void TM1637Display::show(int value) {
  // Check validity of value.
  if ((value < -999) || (value > 9999)) {
    show("Err ");
    return;
  }

  int absvalue = abs(value);

  // First digit.
  int pos = 3;
  char digit = (absvalue % 10) + '0';
  showCharAt(pos, digit);

  // Second, third and fourth digits.
  int signpos = 0;
  for (int pos = 2; pos >= 0; pos--) {
    absvalue = absvalue / 10;
    if (absvalue > 0) {
      // Show number digit.
      digit = (absvalue % 10) + '0';
    } else {
      if ((value < 0) && (signpos == 0)) {
        signpos = pos;
        // Show sign symbol.
        digit = '-';
      } else {
        // Fillup with spaces.
        digit = ' ';
      }
    }
    showCharAt(pos, digit);
  }
}

void TM1637Display::show(float value) {
  // Check validity of value.
  if ((value < -99) || (value > 999)) {
    show("Err ");
    return;
  }

  // Show the integer value.

  int pos = 0;
  if (value < 0.0) {
    // Show sign symbol.
    showCharAt(pos++, '-');
    value = fabs(value);
  }

  int divider = 100;
  int integer = floor(value);

  if (integer < 10) {
    showDigitAt(pos++, getDigit(integer + '0'), true);
  } else {
    while ((integer / divider) == 0) {
      divider /= 10;
    }
    int ii = integer;
    while (divider > 0) {
      int intdigit = ii / divider;
      ii = ii - (intdigit * divider);
      divider /= 10;
      uint8_t digit = getDigit(intdigit + '0');
      showDigitAt(pos++, digit, divider == 0);
    }
  }

  // Show the rest value.

  divider = 1;
  for (int i = pos; i < 3; i++) {
    divider *= 10;
  }

  int rest = (value - integer) * (divider * 10);

  while (divider > 0) {
    int intdigit = rest / divider;
    rest = rest - (intdigit * divider);
    divider /= 10;
    uint8_t digit = getDigit(intdigit + '0');
    showDigitAt(pos++, digit);
  }
}

void TM1637Display::show(const char str[]) {
  // Show the string.
  uint8_t i;
  for (i = 0; (i < NUM_DIGITS) && (str[i] != 0); i++) {
    showCharAt(i, str[i]);
  }

  // Fill up with spaces if string is smaller than 4.
  for (uint8_t j = i; (j < NUM_DIGITS); j++) {
    showCharAt(j, ' ');
  }
}

void TM1637Display::show(String str) { show(str.c_str()); }

void TM1637Display::clear() {
  for (uint8_t i = 0; i < NUM_DIGITS; i++) {
    showDigitAt(i, SEG_CLR);  // Clear digit.
  }
}

void TM1637Display::write(uint8_t data) {
  do {
    // Send bits of data in LSB order.
    for (uint8_t i = 0; i < 8; i++) {
      digitalWrite(_dataPin, data & 0x01);
      clockSignal();
      data = data >> 1;
    }

  } while (!getAckSignal());
}

void TM1637Display::on() {
  if (!_enabled) {
    startSignal();
    write(DISPLAYCOMMAND_DISPLAYON);
    stopSignal();
    _enabled = true;
  }
}

void TM1637Display::off() {
  if (_enabled) {
    _enabled = false;
    startSignal();
    write(DISPLAYCOMMAND_DISPLAYOFF);
    stopSignal();
  }
}

void TM1637Display::brightness(uint8_t value) {
  if (_enabled) {
    if (value > 0x7) {
      value = 0x7;
    }

    //
    // Adapt the brightness.
    //
    startSignal();
    write(DISPLAYCOMMAND_DISPLAYON | value);
    stopSignal();
  }
}

void TM1637Display::startSignal() {
  //
  // Start signal:
  // CLK is high and DIO changes from high to low.
  // DIO is initally high; see constructor and stopSignal().
  //
  digitalWrite(_clockPin, HIGH);  
  bitDelay();
  digitalWrite(_dataPin, LOW);
  bitDelay();
  digitalWrite(_clockPin, LOW);
}

void TM1637Display::stopSignal() {
  //
  // End signal:
  // CLK is high and DIO changes from low to high.
  //
  digitalWrite(_dataPin, LOW);
  bitDelay();
  digitalWrite(_clockPin, HIGH);
  bitDelay();
  digitalWrite(_dataPin, HIGH);  // Keep initially high.
}

void TM1637Display::clockSignal() {
  //
  // Raising edge and return to low.
  //
  digitalWrite(_clockPin, HIGH);  // high for some time.
  bitDelay();
  digitalWrite(_clockPin, LOW);  // return to low.
}

bool TM1637Display::getAckSignal() {
  pinMode(_dataPin, INPUT);
  int ack = digitalRead(_dataPin);
  bitDelay();
  clockSignal();
  pinMode(_dataPin, OUTPUT);
  return (ack == LOW);
}

void TM1637Display::bitDelay() {
  //
  // Datasheet timing TM1637
  // The clock pulse width time is minimum 400 ns (0.4 us).
  // The data setup time is minimum 100 ns (0.1 us).
  // The data hold time is minimum 100 ns (0.1 us).
  //
  // A delayMicroseconds(1) is even too long on the Arduino Uno.
  // A call to function takes enough time (> 0.1 us and < 1 us).

  // Tested by experiment:
  // Explicite delay not needed on the Arduino Udo (16 MHz).
  if (SIGNAL_DELAY > 0) {
    delayMicroseconds(SIGNAL_DELAY);
  }
}
