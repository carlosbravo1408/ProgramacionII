/*
 * Código que devuelve lo que se ingresa por el monitor Serial
 * Nótese que el dato recibido se almacena en un valor de tipo 
 * cadena de caracter (String), por ende lo que retorna es el 
 * es la cadena ingresada.
 * Nótese el tiempo en el que se demora en realizar esta tarea.
*/
void setup() 
{
  Serial.begin(9600);
}
void loop()
{
  if(Serial.available())
  {
    String c = Serial.readString();
    Serial.println(c);
  }
}
