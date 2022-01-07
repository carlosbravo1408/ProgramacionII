/*
 * Código que permite la recepcion de multiples valores 
 * de entrada de tipo byte, recordando que los bytes 
 * van de 0 a 255 en valores enteros.
 * Lo cual puede resultar útil para salidas de PWM de 
 * Arduino que trabajan de 0-255, y para la libreria 
 * Servo.h que trabaja de 0°-180°
 * los primeros tres elementos del arreglo datos de 
 * cuatro elementos serán para el control de un led
 * RGB, y el último elemento será para un ServoMotor
*/
#include <Servo.h>
Servo servo;
void setup() 
{
    Serial.begin(9600);
    servo.attach(10);
}
int i=0;
void loop() 
{
  if(Serial.available())
  {
    int c=Serial.read();
    if(i==0)
    {
      analogWrite(13, c );
    }
    if(i==1)
    {
      analogWrite(12, c);
    }
    if(i==2)
    {
      analogWrite(11, c );
    }
    if(i==3)
    {
      servo.write( c );
      Serial.print(analogRead(A0));
      Serial.print(",");
      Serial.print(analogRead(A1));
      Serial.print(",");
      Serial.print(analogRead(A2));
      Serial.print(",");
      Serial.println(analogRead(A3));
    }
    i++;
    if(i==4)
      i=0;
  }
}
