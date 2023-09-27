using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GorbunovAA.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            var left = 0;
            var right = value.Length - 1;

            while (left < right)
            {
                if (value[left] != value[right]) return false;
                left++;
                right--;
            }

            return true;
        }
    
    }

}
