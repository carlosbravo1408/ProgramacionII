/*
 * Variacion del archivo _02_EnvioMultiplesDatos.ino
 * Envio de 3 datos (puede ampliarse el número de datos)
 * cada 750 milisegundos.
 * Estos se envian si y solo si existe un valor cualquiera
 * que se ingresa por el puerto serial. (Véase el comportamiento
 * de este programa en el monitor Serial)
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
  if(Serial.available())
  {
    Serial.print(analogRead(A0));
    Serial.print(",");
    Serial.print(analogRead(A1));
    Serial.print(",");
    Serial.println(analogRead(A2));
    delay(750);
  }
}
