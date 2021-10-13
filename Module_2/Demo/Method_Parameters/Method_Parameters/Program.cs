using System;

namespace Method_Parameters
{
    class Program
    {
		static void Main(string[] args)
		{
            		#region value-type parameter

           		// The value of the parameter is already assigned
           		int operand_1 = 4;
			int operand_2 = 5;

           		//method 'multiply' is called
			int result = multiply(operand_1, operand_2);
			Console.WriteLine(result);
            		Console.ReadLine();
			#endregion value-type parameter


			#region reference-type parameter

			//assigning value
			string name = "Nandini";

			//passing as a reference parameter
			ChangeName(ref name);
			Console.WriteLine(name);
			Console.ReadLine();
			#endregion reference-type parameter


			#region optional parameter

			//calling method with optional parameter
			operation(5, 3);
			#endregion optional parameter


			#region named parameter

			//calling method with named parameters without order
			operation_on_exp(input_2: 5, input_1: 3, input_3: -2);
			#endregion named parameter


			#region out parameter

			//assigning values
			int num;

			//passing as an out parameter
			Multiply_Num(out num);
			Console.WriteLine(num);
			Console.ReadLine();
			#endregion out parameter
		}

        	public static int multiply(int input_1, int input_2)
		{
			return input_1 * input_2;
            	}

		public static void ChangeName(ref string ref_name)
		{
			ref_name = "Bhattacharya";
		}

		public static void operation(int input_1, int input_2, int input_3= 6)
		{
			int resultant = input_1 * input_2 * input_3;
			Console.WriteLine("Final result is " + resultant);
			Console.ReadLine();
		}

		public static void operation_on_exp(int input_1, int input_2, int input_3)
		{
			int total = input_1 * input_2 * input_3;
			Console.WriteLine("Final result is " + total);
			Console.ReadLine();
		}

		public static void Multiply_Num(out int value)
		{
			value = 2;

			//multiplying values
			value *= value;
		}
	}
    
}
