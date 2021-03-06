using System;
using System.Collections;
using System.Windows.Forms;

using KellControls.KellTable.Models;


namespace KellControls.KellTable.Sorting
{
	/// <summary>
	/// An IComparer for sorting Cells that contain strings
	/// </summary>
	public class TextComparer : ComparerBase
	{
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the TextComparer class with the specified 
		/// TableModel, Column index and SortOrder
		/// </summary>
		/// <param name="tableModel">The TableModel that contains the data to be sorted</param>
		/// <param name="column">The index of the Column to be sorted</param>
		/// <param name="sortOrder">Specifies how the Column is to be sorted</param>
		public TextComparer(TableModel tableModel, int column, SortOrder sortOrder) : base(tableModel, column, sortOrder)
		{
			
		}

		#endregion


		#region Methods
		
		/// <summary>
		/// Compares two objects and returns a value indicating whether one is less 
		/// than, equal to or greater than the other
		/// </summary>
		/// <param name="a">First object to compare</param>
		/// <param name="b">Second object to compare</param>
		/// <returns>-1 if a is less than b, 1 if a is greater than b, or 0 if a equals b</returns>
		public override int Compare(object a, object b)
		{
			Cell cell1 = (Cell) a;
			Cell cell2 = (Cell) b;
			
			// check for null cells
			if (cell1 == null && cell2 == null)
			{
				return 0;
			}
			else if (cell1 == null)
			{
				return -1;
			}
			else if (cell2 == null)
			{
				return 1;
			}

			// check for null data
			if (cell1.Text == null && cell2.Text == null)
			{
				return 0;
			}
			else if (cell1.Text == null)
			{
				return -1;
			}
			
			return cell1.Text.CompareTo(cell2.Text);
		}

		#endregion
	}
}
