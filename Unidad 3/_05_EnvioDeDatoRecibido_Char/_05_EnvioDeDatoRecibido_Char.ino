/*
 * Código que devuelve lo que se ingresa por el monitor Serial
 * Nótese que el dato recibido se almacena en un valor de tipo 
 * caracter (char), por ende lo que retorna es cada caracter 
 * ingresado incluido el salto de línea.
*/
void setup() 
{
  Serial.begin(9600);
}
void loop()
{
  if(Serial.available())
  {
    char c = Serial.read();
    Serial.println(c);
  }
}
