using System;
namespace Sortingsystem {
   class Program {
         static int Min = 0;
         static int Max = 1000;
         static int[] arr = new int[1000]; 
      static void Main(string[] args) {

       
        Random randNum = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
         arr[i] = randNum.Next(Min, Max);
        }
        
         var watch = System.Diagnostics.Stopwatch.StartNew();
         
         //Bubblesort
        /*int temp;
         for (int j = 0; j <= arr.Length - 2; j++) {
            for (int i = 0; i <= arr.Length - 2; i++) {
               if (arr[i] > arr[i + 1]) {
                  temp= arr[i + 1];
                  arr[i + 1] = arr[i];
                  arr[i] = temp;
               }
            } 
         } */
         
         //Selectionsort
       /*
        for (int i = 1; i < arr.Length; i++)
	      {
		      for (int j = i; j > 0; j--)
		      {
			      if (arr[j] < arr[j - 1])
			      {	
				      int temp = arr[j - 1];
				      arr[j - 1] = arr[j];
				      arr[j] = temp;
			      }
			      else
			         break;
		         }
	         }   */
                  
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;   
            foreach (int p in arr)
            Console.Write(p + " ");
            Console.WriteLine("Time in ms " + elapsedMs);
            Console.Read(); 
      }   
   }
}