using System;

namespace c_sharp_odev_operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 360;


            num = num + 2;
            Console.WriteLine(num);
            num += 2; 
            Console.WriteLine(num);           
            num /= 2;
            Console.WriteLine(num);
            num *= 2;
            Console.WriteLine(num);
            num -= 2;
            Console.WriteLine(num);


            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){
                Console.WriteLine("A");  
            }

            if(isSuccess || isCompleted){
                Console.WriteLine("B");  
            }

            if(isSuccess && !isCompleted){
                Console.WriteLine("c");  
            }


            int num1 = 3;
            int num2 = 6;


            bool resultBool = num1 < num2;
            Console.WriteLine(resultBool);
            resultBool = num1 > num2;
            Console.WriteLine(resultBool);
            resultBool = num1 == num2;
            Console.WriteLine(resultBool);
            resultBool = num1 != num2;
            Console.WriteLine(resultBool);
            resultBool = num1 >= num2;
            Console.WriteLine(resultBool);
            resultBool = num1 <= num2;
            Console.WriteLine(resultBool);


            int resultInt = num2 / num1;
            Console.WriteLine(resultInt);
            resultInt = num1 * num2;
            Console.WriteLine(resultInt);
            resultInt = num1 + num2;
            Console.WriteLine(resultInt);
            resultInt = num2 - num1;
            Console.WriteLine(resultInt);
            resultInt = num2 % num1;
            Console.WriteLine(resultInt);









            Console.WriteLine("Hello World!");
        }
    }
}
