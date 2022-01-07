/*
 * Envio de 3 datos (puede ampliarse el número de datos)
 * cada 750 milisegundos.
 * Nótese que cada dato enviado se separa por una coma ','
 * y el ultimo dato se imprime conjunto un salto de linea
 * método println()
*/
void setup() 
{
  Serial.begin(9600);
}

void loop() 
{
  Serial.print(analogRead(A0));
  Serial.print(",");
  Serial.print(analogRead(A1));
  Serial.print(",");
  Serial.println(analogRead(A2));
  delay(750);
}
