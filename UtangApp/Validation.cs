using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtangApp
{
	internal class Validation
	{
		public static bool isEmptyStringField(string[] strArray)
		{
			foreach (string str in strArray)
			{
				// Check if the TextBox has a value
				if (string.IsNullOrWhiteSpace(str))
				{
					MessageBox.Show("Please enter a value in the required TextBox.");
					return true;
				} 
			}

			return false;

		}

	}
}
