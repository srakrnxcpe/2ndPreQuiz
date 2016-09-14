// The most dangerous part of this code is, the maximum
// value of k might be up to 10^10000000000, which NO
// datatypes would be able to handle that number.
//
// We've learned that if k could be divided by 9, the sum
// of all digits in k would be divisible by 9 too. With
// this information, our code completely accepts large
// amount of number.

using System;
class MathContest{
	public static bool divisibleByNine(string num){
		int sumDigits = 0;
		foreach(char c in num){
			sumDigits += (int)Char.GetNumericValue(c);
		}
		return sumDigits%9==0;
	}
	public static void Main(){
		int t = Int32.Parse(Console.ReadLine());
		string tmp;
		bool[] answers = new bool[t];
		for(int i=0; i<t; i++){
			tmp = Console.ReadLine();
			answers[i] = divisibleByNine(tmp);
		}
		foreach(bool answer in answers){
			if(answer){
				Console.WriteLine("Yes");
			}
			else{
				Console.WriteLine("No");
			}
		}
	}
}
