using System;

namespace Calculator{
    public class CalculatorApp{
        public static void Main(String[] args){
            Console.WriteLine(" Calculator App");
            Console.Write("Input first number :");
            double num1=Convert.ToDouble(Console.ReadLine());

            // math operators
            Console.Write("Enter an operator (+,-,/,*) :");
            string op=Console.ReadLine();

            Console.Write("Input Second number ");
            double num2=Convert.ToDouble(Console.ReadLine());
            double result=0;
            bool validOperator=true;

            switch (op)
            {
                case "+":
                    result=num1 + num2;
                    break;
                case "-":
                    result=num1-num2;
                    break;
                case "/":
                    if(num2 !=0){
                        result=num1/num2;

                }else{
                    Console.WriteLine("Cannot divide zero");
                    validOperator=false;
                }             
                break;
                    case "*":
                    result=num1*num2;
                break;
                    default:
                    Console.WriteLine("Invalid Operator");
                    validOperator=false;
                break;

            
            }
            if(validOperator){
                Console.WriteLine($"Result :{result}");
            }
        }
    }
}