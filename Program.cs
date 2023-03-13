using System;

namespace Exam1{
    class Program{
        static void Main(string[]args){
            Console.Write("Day of week (1-7) : ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Time of day (8-18) : ");
            int time = int.Parse(Console.ReadLine());
            
            int Bset = 5;
            int Wset = 2;
            int Coffee = 3;
            int num1 = 1;
            while (num1 == 1){                
                Console.WriteLine("***************************************");
                Console.WriteLine("Day : {0}",day);
                Console.WriteLine("Time : {0}",time);
                Console.WriteLine("Breakfast Set remain : {0}",Bset);
                Console.WriteLine("Weekend Set remain : {0}",Wset);
                Console.WriteLine("Coffee remain : {0}",Coffee);
                Console.WriteLine("***************************************");

                Console.Write("Which meal : ");
                string meal = Console.ReadLine();
                
                switch(meal){
                    case "Breakfast Set" :
                        if (time > 11){
                            Console.WriteLine("---Sorry your order is not available---");
                        }
                        else {
                            if(Bset == 0){
                                Console.WriteLine("---Sorry your order is out of stock---");
                            }
                            else{
                                Bset = Bset - 1;
                            }
                        }
                        break;
                    
                    case "Weekend Set" :
                        if (day <= 5){
                            Console.WriteLine("---Sorry your order is not available---");
                        }
                        else {
                            if (Wset == 0){
                                Console.WriteLine("---Sorry your order is out of stock---");
                            }
                            else {
                                Wset = Wset - 1;
                            }
                        }
                        break;

                    case "Coffee" :
                        if (Coffee == 0){
                            Console.WriteLine("---Sorry your order is out of stock---");
                        }
                        else {
                            Coffee = Coffee - 1;    
                        }
                    break;
                    
                    case "End" :
                        num1 = num1 - 1;
                        break;

                    default :
                        Console.WriteLine("---Please enter a valid menu---");
                        break;
                }
            }
        }
    }
}