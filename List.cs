using System;
using System.Collections.Generic;

namespace ACtivity {
    public class ListOperations{
        private List<int> numbers;
        public ListOperations(){
            numbers = new List<int>(); //list  int 
        }
        //add numbers 10
        public  void AddNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
        }
        //print numbers
        public void PrintNumbers(){
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void RemoveFirstAndLast(){
            //Remove first element
            if(numbers.Count > 0){
                numbers.RemoveAt(0);
            }
            if(numbers.Count > 0){
                numbers.RemoveAt(numbers.Count - 1);
            }

        }
    }
}

