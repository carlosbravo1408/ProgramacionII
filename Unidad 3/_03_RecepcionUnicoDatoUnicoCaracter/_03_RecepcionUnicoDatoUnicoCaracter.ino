/*
 * Código para recibir un dato único, este es un caracter que puede ser
 * numérico, alfabético, simbolo, etc.
 * Como detalle, cada caracter no es mas que el producto de una conversión
 * de un número entero en el código ASCCII.
 * Nótese que al caracter recibido se lo almacena en una variable de tipo
 * (int)
 * Existen 255 valores dentro de la tabla de Código ASCCII.
*/
const int led1 = 13 , led2 = 12;
void setup() 
{
  Serial.begin(9600);
  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
}

void loop() 
{
  int c=Serial.read();
  if(c=='a')
  {
    digitalWrite(led1,HIGH);
  }
  if(c=='b')
  {
    digitalWrite(led1,LOW);
  }
  if(c=='1')
  {
    digitalWrite(led2,HIGH);
  }
  if(c=='2')
  {
    digitalWrite(led2,LOW);
  }
  if(c=='t')
  {
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
  }
  if(c=='n')
  {
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
  }
}
