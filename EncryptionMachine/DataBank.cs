using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data;

namespace kyrsovaiy
{
   static class DataBank
    {
       public static string Action;
       public static string Key;
       static public char[,] Vigen_arr = new char[27, 27];
       public static string Shifr;
       public static string Word;
       public static string NickName; 

       public static DataSet ds = new DataSet();

    }
}
