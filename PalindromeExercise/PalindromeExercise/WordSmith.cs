using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPAlindrome(string str)
        {
            /*var reversed = "";
            if (str == null)
            {
                return false;
            }
            else
            {
                for(int i = str.Length - 1; i >= 0; i--)
                {
                    reversed += str.ToLower()[i];
                }
                return reversed == str.ToLower();
            }*/
            return (str == null) ? false : str.Replace(" ", "").ToLower().SequenceEqual(str.ToLower().Reverse()); ;
        }
    }
}
