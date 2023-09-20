int baselineTemp = 0;
int celsius = 0;


contst int numLEDs = 3;
int ledPins[numLEDs] = {0,2,3};
int thresholds[numLEDs] = {10, 20, 30};

void setup(){
  pinMode(A0,INPUT);
  Serial.begin(9600);
  
  for(int i = 0; i < numLEDs; i++)
  {
  pinMode(ledPins[i], OUTPUT);
  }
}

void activateLEDs(int temp)
{
For(int i + 0; i < numLEDs; i++)
{
  if(temp >= baselineTemp + thresholds[i])
  {
    digitalWrite(ledPins{i},HIGH);
  }
  else
   {
    digitalWrite(ledPins[i],LOW);
  }

}


void loop()
{
  
//set threshold temp to activate LED
  baselineTemp = 40;

  //measure the temp in celcuis 
  celsius = map(((analogRead(A0)-20)*3.04), 0, 1023, -40, 125);
  Serial.print(celsius);
  Serial.print("c, ");

	activateLEDs(celcuis);
  delay(1000);
  
}  
