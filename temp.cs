

using System;

namespace MyApplication{
    class Temperature{
        static void Call(int y, int x, int z, int i, int v, int c){
            Console.WriteLine("Temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            
            bool condition,condition2,condition3;
            condition = temp >= x && temp <= y;
            condition2 = temp >= z && temp <= i;
            condition3 = temp >= v && temp <= c;
            
            if (condition){
               Console.WriteLine("The Average Temperature");
            }
            if (condition2){
               Console.WriteLine("Its Very Hot In Here");
            }
            if (condition3){
               Console.WriteLine("Its Cold");
            }
        }
        static void Main(string[] args){
            Call(15,5,30,50,-20,0);
        }
    }
}
