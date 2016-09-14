using System;
class Projection{
	public static void Main(){
		int t = int.Parse(Console.ReadLine());
		string[] m = new string[3];
		double[] ans = new double[t];
		string inp;

		for(int i=0;i<t;i++){
			inp = Console.ReadLine();
			m = inp.Split(' ');
			ans[i] = -0.5*double.Parse(m[1])/double.Parse(m[0]);
		}
		for(int i=0;i<t;i++){
			Console.WriteLine(ans[i]);
		}
	}
}
