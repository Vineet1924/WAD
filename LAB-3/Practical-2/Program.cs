using System;
using Calc;
namespace Driver {
	public class Runner {
		public static void Main() {
			int add = Add.addition(7,10);
			int sub = Sub.subtraction(10,7);
			Console.WriteLine("Subtraction = " + sub);
			Console.WriteLine("Addition = " + add);
		}
	}
}