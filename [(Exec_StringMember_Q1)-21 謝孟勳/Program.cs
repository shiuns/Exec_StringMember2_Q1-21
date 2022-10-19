using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Exec_StringMember_Q1__21_謝孟勳
{
    //將" abc 左右的空白刪除"
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "  abc  ";
            Console.WriteLine(value.Trim());
        }
    }
}
