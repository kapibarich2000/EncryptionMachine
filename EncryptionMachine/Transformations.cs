using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsovaiy
{
    static class Transformations
    {
        static public void Encrypt()
        {
            int KeySize;
            KeySize = DataBank.Key.Length;


            string[] World_arr = DataBank.Word.Split();


            int K_Id = 0; //To be able to use the key
           
            char[] TmpChar;
            // т.к. \0
            for (int i = 0; i < World_arr.Length; i++) 
            {
                TmpChar = new char[World_arr[i].Length];//Массив для записи кодированного текста
                int g = 0;//counter

                foreach (char ch in World_arr[i])
                {
                    int Rows=0;
                    int Cols=0;

                    if (K_Id == KeySize) 
                    { K_Id = 0; }

                    Rows = Vigener.id_number(ch);
                    Cols = Vigener.id_number(DataBank.Key[K_Id]);

                    //research on caps
                    if (char.IsUpper(ch))
                    {
                        TmpChar[g] = DataBank.Vigen_arr[Rows, Cols];//Запись

                        int TempInt = (int)TmpChar[g];
                        TempInt = TempInt - 32;

                        TmpChar[g] = (char)TempInt;
                    }
                    
                    else if(char.IsDigit(ch))
                    {
                        TmpChar[g] = ch;
                    }

                    else
                    {
                        TmpChar[g] = DataBank.Vigen_arr[Rows, Cols];//Запись
                    }
                    /////////////////////
                    

                    K_Id++;
                    g++;

                }
                string TmpStr = new string(TmpChar);
                DataBank.Shifr = DataBank.Shifr + TmpStr+" ";
            }
            DataBank.Shifr.Remove(DataBank.Shifr.Length - 1);
            
        }

        static public void Decrypt()
        {
            int KeySize;
            KeySize = DataBank.Key.Length;

            string[] Shifr_arr = DataBank.Shifr.Split();


            int K_Id = 0; //To be able to use the key
            char[] TmpChar;

            for (int i = 0; i < Shifr_arr.Length; i++)
            {
                TmpChar = new char[Shifr_arr[i].Length];//Массив для записи кодированного текста

                int g = 0;//counter
                foreach (char ch in Shifr_arr[i])
                {
                    int Rows = 0;
                    int Cols = 0;

                    if (K_Id == KeySize)
                    { K_Id = 0; }

                    Cols = Vigener.id_number(DataBank.Key[K_Id]);


                    //////////////  Make a low letter   
                    char ChForSearch =ch;

                    if (char.IsUpper(ch))
                    { 
                        int TempInt = (int)ch;
                        TempInt = TempInt + 32;
                        ChForSearch = (char)TempInt;   
                    }
                    //////////////////////////////////////


                    //search encryped element, going down on table
                    if (!char.IsDigit(ch))
                    {
                        do
                        {
                            Rows++;
                        }
                        while (DataBank.Vigen_arr[Rows, Cols] != ChForSearch);

                        TmpChar[g] = DataBank.Vigen_arr[Rows, 0];//Запись

                        if (char.IsLower(ch))
                        {                           
                            int TempInt = (int)TmpChar[g];
                            TempInt = TempInt + 32;

                            TmpChar[g] = (char)TempInt;
                        }
                    }

                    else if(char.IsDigit(ch))
                    {
                        TmpChar[g] = ch;
                    }

                    // Check and write on low writting
                    

                    K_Id++;
                    g++;
                }
                string TmpStr = new string(TmpChar);
                DataBank.Word = DataBank.Word + TmpStr + " ";
            }
        }
    }
}
