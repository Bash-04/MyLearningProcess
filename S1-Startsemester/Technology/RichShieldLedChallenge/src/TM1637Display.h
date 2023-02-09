/*
 * TM1637Display.h
 *
 * Rich Shield Display driver
 *
 * Version: 1.0
 * Date: 17/11/2019
 * Author: gerald Hilderink <g.hilderink@fontys.nl
 */

#ifndef _RICHSHIELD_TM1637DISPLAY_H
#define _RICHSHIELD_TM1637DISPLAY_H

#include <Arduino.h>

//
// The digits.
//
const uint8_t DIGIT_0 = 0b00111111;
const uint8_t DIGIT_1 = 0b00000110;
const uint8_t DIGIT_2 = 0b01011011;
const uint8_t DIGIT_3 = 0b01001111;
const uint8_t DIGIT_4 = 0b01100110;
const uint8_t DIGIT_5 = 0b01101101;
const uint8_t DIGIT_6 = 0b01111101;
const uint8_t DIGIT_7 = 0b00000111;
const uint8_t DIGIT_8 = 0b01111111;
const uint8_t DIGIT_9 = 0b01101111;
const uint8_t DIGIT_A = 0b01110111;
const uint8_t DIGIT_C = 0b00111001;
const uint8_t DIGIT_E = 0b01111001;
const uint8_t DIGIT_F = 0b01110001;
const uint8_t DIGIT_G = 0b00111101;
const uint8_t DIGIT_H = 0b01110110;
const uint8_t DIGIT_I = 0b00000110;
const uint8_t DIGIT_J = 0b00001110;
const uint8_t DIGIT_L = 0b00111100;
const uint8_t DIGIT_N = 0b00110111;
const uint8_t DIGIT_O = 0b00111111;
const uint8_t DIGIT_P = 0b01110011;
const uint8_t DIGIT_R = 0b01110111;
const uint8_t DIGIT_S = 0b01101101;
const uint8_t DIGIT_U = 0b00111110;
const uint8_t DIGIT_Y = 0b01101110;
const uint8_t DIGIT_a = 0b01011111;
const uint8_t DIGIT_b = 0b01111100;
const uint8_t DIGIT_c = 0b01011000;
const uint8_t DIGIT_d = 0b01011110;
const uint8_t DIGIT_e = 0b01111011;
const uint8_t DIGIT_f = DIGIT_F;
const uint8_t DIGIT_g = DIGIT_9;
const uint8_t DIGIT_h = 0b01110100;
const uint8_t DIGIT_i = 0b00000100;
const uint8_t DIGIT_j = 0b00001100;
const uint8_t DIGIT_l = 0b00110000;
const uint8_t DIGIT_n = 0b01010100;
const uint8_t DIGIT_o = 0b01011100;
const uint8_t DIGIT_p = 0b01110011;
const uint8_t DIGIT_q = 0b01100111;
const uint8_t DIGIT_r = 0b01010000;
const uint8_t DIGIT_s = DIGIT_S;
const uint8_t DIGIT_t = 0b01111000;
const uint8_t DIGIT_u = 0b00011100;
const uint8_t DIGIT_y = DIGIT_Y;
const uint8_t DIGIT_EQUALS = 0b01001000;
const uint8_t DIGIT_LSB = 0b00111001;
const uint8_t DIGIT_RSB = 0b00001111;
const uint8_t DIGIT_DASH = 0b01000000;
const uint8_t DIGIT_UNDERSCORE = 0b00001000;
const uint8_t DIGIT_QUOTE = 0b00100010;
const uint8_t DIGIT_SLASH = 0b01010010;
const uint8_t DIGIT_BACKSLASH = 0b01100100;
const uint8_t DIGIT_SPACE = 0b00000000;

//
// The segments.
//
const uint8_t SEG_a = 0b00000001;
const uint8_t SEG_b = 0b00000010;
const uint8_t SEG_c = 0b00000100;
const uint8_t SEG_d = 0b00001000;
const uint8_t SEG_e = 0b00010000;
const uint8_t SEG_f = 0b00100000;
const uint8_t SEG_g = 0b01000000;
const uint8_t SEG_DOT = 0b10000000;
const uint8_t SEG_CLR = 0b00000000;

/**
 * The TM1637 display driver.
 *
 * Providing the low levels functions for the display.
 **/
class TM1637Display {
 public:
  /**
    \brief Create instance of the TM1637 display driver.

    \param clockPin
              The clock pin.
    \param dataPin
              The data pin.
  */
  TM1637Display(uint8_t clockPin = 10, uint8_t dataPin = 11);

  /**
     \brief Turn the display on.
  */
  void on();

  /**
     \brief Turn the display off.
  */
  void off();

  /**
     \brief Set the brightness of the display.

     \param value
              The brightness 0 = low, 7 is high.
  */
  void brightness(uint8_t value);

  /**
     \brief Show the specified character on the specified position.
     \param pos
              The position of the display. The most left position is pos = 0 and
     the most right position is pos = 3. \param character The character to show.
  */
  void showCharAt(uint8_t pos, char character);

  /**
     \brief Show the specified digit on the specified position.

     \param pos
              The position of the display. The most left position is pos = 0 and
     the most right position is pos = 3. \param digit The digit or segment
     pattern.
  */
  void showDigitAt(uint8_t pos, uint8_t digit);

  /**
     \brief Show the specified digit on the specified position with or without a
     dot.

     \param pos
              The position of the display. The most left position is pos = 0 and
     the most right position is pos = 3. \param digit The digit or segment
     pattern. \param showDot true to show the dot, false to hide the dot.
  */
  void showDigitAt(uint8_t pos, uint8_t digit, bool showDot);

  /**
     \brief Show the specified integer number, which is right aligned.

     \param value
              The integer number to display.
  */
  void show(int value);

  /**
     \brief Show the specified floating-point number, which is right aligned.

     \param value
              The floating-point number to display.
  */
  void show(float value);

  /**
     \brief Show the specified array of characters.

     \param str
              The string (char array) to display.
  */
  void show(const char str[]);

  /**
     \brief Show the specified string.

     \param str
              The string to display.
  */
  void show(String str);

  /**
     \brief Clear the display.
  */
  void clear();

  /**
     \brief Get the digit or segment pattern for the specified charcter.

     \param character
              The character,
     \return The digit or segment pattern.
  */
  uint8_t getDigit(char character);

 private:
  /**
     \brief Write the specified data to the TM1637 chip.

     \param
            Data byte.
  */
  void write(uint8_t data);

  /**
     \brief Send a start signal pulse to the TM1637 chip.
  */
  void startSignal();

  /**
     \brief Send a stop signal pulse to the TM1637 chip.
  */
  void stopSignal();

  /**
     \brief Send a clock signal pulse to the TM1637 chip.

  */
  void clockSignal();

  /**
     \brief Retreive the acknowledge signal from the TM1637 chip.
  */
  bool getAckSignal();

  /**
     \brief Delay one bit length.
  */
  void bitDelay();

  uint8_t _clockPin;  // Clock pin.
  uint8_t _dataPin;   // Data pin.
  bool _enabled;
};

#endif  // _RICHSHIELD_TM1637DISPLAY_H
