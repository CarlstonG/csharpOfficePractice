using System;
using System.Globalization;
using System.Linq;

namespace Program{

    class Test{
     public static void Main(){
        // for(int i = 1; i <= 100; i++){
        //     if(i % 3 == 0 && i % 5 == 0){
        //         Console.WriteLine(i + " fizzbuzz");
        //     }
        //     else if (i % 3 == 0){
        //         Console.WriteLine(i + " Fizz");
        //     }
        //     else if (i % 5 == 0){
        //         Console.WriteLine(i + " Buzz");
        //     }
        //     else{
        //         Console.WriteLine(i);
        //     }


        // }
           // Fizzubuzz();
          //  Palin();
          //  OddEven();
            Desc();
            Indice();
            Descs();
    }
        private static void Fizzubuzz(){
              for (int i = 1; i <= 100; i++){
                string output = (i % 3 == 0 && i % 5 == 0) ? i + " FizzBuzz"
                : (i % 3 == 0) ? i + " Fizz"
                : (i % 5 == 0) ? i + " Buzz" 
                : i.ToString();
                Console.WriteLine(output);
        }
        }

        private static void Palin() 
        {
            string str = "madam";
            string revStr = new string(str.ToCharArray().Reverse().ToArray());
            if (str == revStr){
                Console.WriteLine($"{str} is a palin");
            }
            else {
                Console.WriteLine($"{str} is not a palin");
            }
        }
        private static void OddEven()
        {
         Console.WriteLine("Enter a num: ");
         string num = Console.ReadLine();
         
         int input;
         if (int.TryParse(num, out input)){
            if(input % 2 == 0){
                Console.WriteLine("Even");
            }
            else{
                Console.WriteLine("Odd");
            }
         }
         else{
            Console.WriteLine("Invalid Input");
         }

        }
        private static void Desc(){
           int[] Num = {1,2,3,4,5};

           for (int i = Num.Length - 1; i >= 0; i--){
            Console.WriteLine(Num[i]);
           }
        }
        private static void Indice(){
            int[] Num = {1,2,3,4,5};
            int[] indices = new int[Num.Length];
            
            
            Console.Write("[");
            for(int i = 0; i < Num.Length; i++){
            
                indices[i] = Num.Length - 1 - i;
                Console.Write(indices[i]);
                if(i < indices.Length - 1)
                {
                    Console.Write(",");
                }
             
            }
            Console.Write("]");
        }
        private static void Descs()
{
    int[] Num = { 1, 2, 3, 4, 5 };
    int length = Num.Length - 1;  // We want indices up to Num.Length - 2

    Console.Write("[");
    for (int i = length - 1; i >= 0; i--)
    {
        Console.Write(i);
        if (i > 0)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

    
    }
}
