using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
			string output;

		    if (string.IsNullOrEmpty(input))
		        return "";
		    var inputAsCharArray = input.ToCharArray();
            Array.Reverse(inputAsCharArray);
            output = new string(inputAsCharArray);
			return output;
		}
	}
}
