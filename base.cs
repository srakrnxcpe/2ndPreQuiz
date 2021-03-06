using System;
class Base{
	public static string baseConvert(string num, int oBase, int dBase){
		int length = num.Length-1;
		int dec = 0;
		string numberSystem = "0123456789ABCDEF";
		num = num.ToUpper();
		for(int i=0;i<num.Length;i++){
			dec += (int)(numberSystem.IndexOf(num[i])*Math.Pow(oBase,length));
			length--;
		}
		string converted = "";
		int remainder;
		while(dec>0){
			remainder = dec%dBase;
			converted = numberSystem[remainder] + converted;
			dec = dec/dBase;
		}
		return converted;
	}
	public static void Main(){
		string num = Console.ReadLine();
		int oBase = Int32.Parse(Console.ReadLine());
		int dBase = Int32.Parse(Console.ReadLine());
		Console.WriteLine(baseConvert(num,oBase,dBase));
	}
}
