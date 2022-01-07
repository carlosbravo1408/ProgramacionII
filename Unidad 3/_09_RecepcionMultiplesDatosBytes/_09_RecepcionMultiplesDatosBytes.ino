/*
 * Código que permite la recepcion de multiples valores 
 * de entrada de tipo byte, recordando que los bytes 
 * van de 0 a 255 en valores enteros.
 * Lo cual puede resultar útil para salidas de PWM de 
 * Arduino que trabajan de 0-255, los tres elementos 
 * del arreglo datos serán para el control de un led
 * RGB
*/
char datos[3];
void setup() 
{
    Serial.begin(9600);
}

void loop() 
{ 
  if(Serial.available())
  {
    Serial.readBytes(datos,3);
    analogWrite(7,datos[0]);
    analogWrite(8,datos[1]);
    analogWrite(9,datos[2]);
  }
}
