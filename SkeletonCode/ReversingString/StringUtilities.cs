using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
			string output = string.Empty;

            //original method
			//for(int i = input.Length - 1; i >= 0; i--)
			//{
			//	output += input[i];
			//}
		    if (string.IsNullOrEmpty(input))
		        return "";
		    var inputAsCharArray = input.ToCharArray();
            Array.Reverse(inputAsCharArray);
            output = new string(inputAsCharArray);
			return output;
		}
	}
}
