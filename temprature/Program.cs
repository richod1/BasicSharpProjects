using System;

namespace Temprature{
    public class TempratureApp{
        public static void Main(String[] args){
            Console.WriteLine("Temprature Convecter ");
            Console.Write("Input temprature ");
            double temprature=Convert.ToDouble(Console.ReadLine());
            Console.Write(" type C or F to Convert to C/F :");
            string convertTo=Console.ReadLine().ToUpper();

            if(convertTo=="C"){
                double celcius=(temprature-32)*5/9;
                Console.WriteLine($"Temprature in celcuis :{celcius}");
            }else if(convertTo=="F"){
                double farenheit=(temprature*5/9)+32;
                Console.WriteLine($"Temprature in farenhiet: {farenheit} ");
            }else{
                Console.WriteLine("Invalid conversion unit!");
            }
        }
    }
}
