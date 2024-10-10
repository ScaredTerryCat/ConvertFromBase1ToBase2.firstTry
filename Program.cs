//this only works for natural numbers
using System;
using System.Collections;
public class Program{
	public static bool only0(string s){
		int len=s.Length;
		for(int i=0;i<len;i++){if(s[i]!='0'){return false;}}
		return true;
	}
	public static int pow(int a,int b){
		if(b==0){return 1;}
		int res=1;
		for(int i=0;i<b;i++){res*=a;}
	return res;}
	public static string Convert1(int n,int b){
		if(n==0){return "0";}
		string result="";
		Stack rev=new Stack();
		while(n!=0){
			int r=n%b;
			n/=b;
			rev.Push(r);}
	foreach(int elem in rev){
		result+=Convert.ToString(elem);
	}
	return result;
	}
	public static int Convert2(string s,int b){
		if(only0(s)){return 0;}
		int result=0;
		string rev="";
		int p=0;
		int len=s.Length;
		for(int i=len-1;i>=0;i--){
			int d1=s[i]-'0';
			int d2=pow(b,p);
			p++;
			result+=d1*d2;
		}

		return result;
	}
	public static string Convert3(string s,int b1,int b2){
		int x=Convert2(s,b1);
		string y=Convert1(x,b2);
		return y;
	}
	public static void Main(string[] args){
		int b1,b2;
		string number,result;
		Console.Write("Enter base 1:\t");
		b1=int.Parse(Console.ReadLine());
		Console.Write($"Enter number in base ({b1}):\t");
		number=Convert.ToString(Console.ReadLine());
		Console.Write("Enter base 2:\t");
		b2=int.Parse(Console.ReadLine());
		result=Convert3(number,b1,b2);
		Console.Write($"{number} ({b1}) = {result} ({b2})");
	}
}
