using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// The class responsible for checking if the user inputed data is correctly inputed.
    /// </summary>
    static class AssertManager
    {
        /// <summary>
        /// Checks if <paramref name="s"/> can be parsed to an int or not
        /// </summary>
        public static bool AssertParse(string s, string fieldName, ref string errorMsg)
        {
            if (AssertEmpty(s, fieldName, ref errorMsg))
            {
                int i;
                if (Int32.TryParse(s, out i))
                {
                    if (AssertNegative(i, fieldName, ref errorMsg))
                    {
                        return true;
                    }
                }
                else
                {
                    errorMsg = $"{fieldName} must be an integer!";
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if <paramref name="t"/> is an empty strign or not
        /// </summary>
        public static bool AssertEmpty<T>(T t, string fieldName, ref string errorMsg)
        {
            errorMsg = "";
            if (t.ToString() == "")
            {
                errorMsg = $"{fieldName} can not be empty!";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if <paramref name="selectedIndex"/> exists outside of the bounds of a checkbox/list
        /// </summary>
        public static bool AssertDropdown(int selectedIndex, string fieldName, ref string errorMsg)
        {
            errorMsg = "";
            if (selectedIndex == -1)
            {
                errorMsg = $"{fieldName} must be chosen!";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if <paramref name="i"/> is positive or not
        /// </summary>
        public static bool AssertNegative(int i, string fieldName, ref string errorMsg)
        {
            errorMsg = "";
            if (i < 0)
            {
                errorMsg = $"{fieldName} can not be negative!";
                return false;
            }
            return true;
        }
    }

}
