/*
 * Código que devuelve lo que se ingresa por el monitor Serial
 * Nótese que el dato recibido se almacena en un valor de tipo 
 * entero (int), por ende lo que retorna es el equivalente en-
 * tero de cada caracter ingresado incluido el salto de línea.
*/
void setup() 
{
  Serial.begin(9600);
}
void loop()
{
  if(Serial.available())
  {
    int c = Serial.read();
    Serial.println(c);
  }
}
