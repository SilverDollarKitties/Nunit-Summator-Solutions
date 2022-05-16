using System;
namespace Summator
{
	public class Summator
	{
		public static int Sum(int[] arr)
		{
			int sum = arr[0];

			for (int i = 1; i < arr.length; i++)
			{
				sum += arr[i];
			}
			return sum;
		}
	}
}