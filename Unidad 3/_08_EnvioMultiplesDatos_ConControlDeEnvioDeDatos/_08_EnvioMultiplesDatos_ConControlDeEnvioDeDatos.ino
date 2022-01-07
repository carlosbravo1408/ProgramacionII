/*
 * Variacion del archivo _07_EnvioMultiplesDatos_ConControlDeInicio.ino
 * Envio de 3 datos (puede ampliarse el número de datos)
 * cada vez que el Puerto Serial recibe un dato
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
    int c=Serial.read();
    Serial.print(analogRead(A0));
    Serial.print(",");
    Serial.print(analogRead(A1));
    Serial.print(",");
    Serial.println(analogRead(A2));
  }
}
