using System;
class Tax{
	public static void Main(){
		int t = Int32.Parse(Console.ReadLine());
		double[] tax = new double[t];
		int money;
		for(int i=0; i<t; i++){
			money = Int32.Parse(Console.ReadLine());
			tax[i] = TaxCal(money);
		}
		for(int i=0; i<t; i++){
			Console.WriteLine(tax[i]);
		}
	}
	public static double TaxCal(int money){
		if(money>4000000){
			return (money-4000000)*(37.0/100)+900000+100000+35000+5000+5000;
		}
		else if(money>1000000){
			return (money-1000000)*(30.0/100)+100000+35000+5000+5000;
		}
		else if(money>500000){
			return (money-500000)*(20.0/100)+35000+5000+5000;
		}
		else if(money>150000){
			return (money-150000)*(10.0/100)+5000+5000;
		}
		else if(money>100000){
			return (money-100000)*(10.0/100)+5000;
		}
		else if(money>0){
			return money*(5.0/100);
		}
		else{
			return -1;
		}
	}
}
			
