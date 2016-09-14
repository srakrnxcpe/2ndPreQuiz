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
