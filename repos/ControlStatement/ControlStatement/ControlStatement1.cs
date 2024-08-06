using System;

public class Class1
{
	static void Main(string[] args)
	{
		int arr[] = { 1, 2, 3 };
		int n = arr.Length;
		for (int i = 0; i < n; i++)
		{
			for (int j = i; j < n; j++)
			{
				if (arr[i] == arr[j])
				{
					Console.WriteLine(arr[i]);
				}
			}
		}
	}
}
