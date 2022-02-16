using System;
using System.Diagnostics;


class Program {

    public static Stopwatch watch;
	public static void Main(String[] args)
	{
		int Min = 0;
        int Max = 1000;
        int[] arr = new int[8000]; 
        watch = new Stopwatch();
        
     
        Random randNum = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
        arr[i] = randNum.Next(Min, Max);
        }
        
		mergeSort(arr, 0, arr.Length - 1);
		printArray(arr, arr.Length);
		Console.WriteLine("Time in ms " + watch.ElapsedMilliseconds);
	}
    
    public static void Watch_Start(){
        watch.Start();
    }
	public static void merge(int[] arr, int start, int mid,
					int end)
	{   
		int start2 = mid + 1;

		if (arr[mid] <= arr[start2]) {
			return;
		}

		while (start <= mid && start2 <= end) {

			if (arr[start] <= arr[start2]) {
				start++;
			}
			else {
				int value = arr[start2];
				int index = start2;

				while (index != start) {
					arr[index] = arr[index - 1];
					index--;
				}
				arr[start] = value;

				start++;
				mid++;
				start2++;
			}
		}
	}
	public static void mergeSort(int[] arr, int l, int r)
	{
		if (l < r)
        {
			int m = l + (r - l) / 2;

			mergeSort(arr, l, m);
			mergeSort(arr, m + 1, r);

			merge(arr, l, m, r);
		}
	}
        public static void Watch_Stop(){
        watch.Stop();
    }     
	public static void printArray(int[] A, int size)
	{
         
		int i;
		for (i = 0; i < size; i++)           
	        Console.Write(A[i] + " ");
		    Console.WriteLine(); 
	}
}


