/*
 * Programa que envia un dato único cada 500 milisegundos
 * observe el comportamiento en el monitor Serial
*/
void setup() 
{
  Serial.begin(9600);
}

void loop() 
{
  /*observe el comportamiento de estos dos métodos por separado en el 
  monitor Serial*/
  //Serial.print(analogRead(A0));
  Serial.println(analogRead(A0));
  delay(500);
}
