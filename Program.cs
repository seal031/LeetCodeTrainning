using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTrainning
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPath = "c2ltczovLy8xMDAwMSxzaW1zLDE1MzE5MjUwMzcyMDcsNGI0ZTRkZTE4NTVmOWMzYWRjNDUyNjE4MmE3NGQzYmE = ";
            byte[] outputb = Convert.FromBase64String(strPath);
            strPath = Encoding.Default.GetString(outputb);
        }
    }
}
