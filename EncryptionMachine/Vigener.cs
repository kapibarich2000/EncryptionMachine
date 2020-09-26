using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsovaiy
{
    static class Vigener
    {
        public static int id_number(char letter)
        {
            
            int cislo = 0;
            switch (letter)
            {
                case 'a':
                    cislo = 1;
                    break;
                case 'A':
                    cislo = 1;
                    break;

                case 'b':
                    cislo = 2;
                    break;
                case 'B':
                    cislo = 2;
                    break;

                case 'c':
                    cislo = 3;
                    break;
                case 'C':
                    cislo = 3;
                    break;

                case 'd':
                    cislo = 4;
                    break;
                case 'D':
                    cislo = 4;
                    break;

                case 'e':
                    cislo = 5;
                    break;
                case 'E':
                    cislo = 5;
                    break;

                case 'f':
                    cislo = 6;
                    break;
                case 'F':
                    cislo = 6;
                    break;

                case 'g':
                    cislo = 7;
                    break;
                case 'G':
                    cislo = 7;
                    break;

                case 'h':
                    cislo = 8;
                    break;
                case 'H':
                    cislo = 8;
                    break;

                case 'i':
                    cislo = 9;
                    break;
                case 'I':
                    cislo = 9;
                    break;

                case 'j':
                    cislo = 10;
                    break;
                case 'J':
                    cislo = 10;
                    break;

                case 'k':
                    cislo = 11;
                    break;
                case 'K':
                    cislo = 11;
                    break;

                case 'l':
                    cislo = 12;
                    break;
                case 'L':
                    cislo = 12;
                    break;

                case 'm':
                    cislo = 13;
                    break;
                case 'M':
                    cislo = 13;
                    break;

                case 'n':
                    cislo = 14;
                    break;
                case 'N':
                    cislo = 14;
                    break;

                case 'o':
                    cislo = 15;
                    break;
                case 'O':
                    cislo = 15;
                    break;

                case 'p':
                    cislo = 16;
                    break;
                case 'P':
                    cislo = 16;
                    break;

                case 'q':
                    cislo = 17;
                    break;
                case 'Q':
                    cislo = 17;
                    break;

                case 'r':
                    cislo = 18;
                    break;
                case 'R':
                    cislo = 18;
                    break;

                case 's':
                    cislo = 19;
                    break;
                case 'S':
                    cislo = 19;
                    break;

                case 't':
                    cislo = 20;
                    break;
                case 'T':
                    cislo = 20;
                    break;

                case 'u':
                    cislo = 21;
                    break;
                case 'U':
                    cislo = 21;
                    break;

                case 'v':
                    cislo = 22;
                    break;
                case 'V':
                    cislo = 22;
                    break;

                case 'w':
                    cislo = 23;
                    break;
                case 'W':
                    cislo = 23;
                    break;

                case 'x':
                    cislo = 24;
                    break;
                case 'X':
                    cislo = 24;
                    break;

                case 'y':
                    cislo = 25;
                    break;
                case 'Y':
                    cislo = 25;
                    break;

                case 'z':
                    cislo = 26;
                    break;
                case 'Z':
                    cislo = 26;
                    break;

            }
            return cislo;
        }

        public static void Tabl(ref char[,] vigen)
        {
            char[] arr = { 'm', 's', 'c', 'h', 'e', 'z', 'g', 'o', 'i', 'q', 'p', 'u', 'a', 'y', 'd', 'k', 'j', 'r', 'b', 't', 'l', 'v', 'w', 'x', 'n', 'f' };


            vigen[0, 0] = ' ';

            //строку
            vigen[0, 1] = 'A';
            vigen[0, 2] = 'B';
            vigen[0, 3] = 'C';
            vigen[0, 4] = 'D';
            vigen[0, 5] = 'E';
            vigen[0, 6] = 'F';
            vigen[0, 7] = 'G';
            vigen[0, 8] = 'H';
            vigen[0, 9] = 'I';
            vigen[0, 10] = 'J';
            vigen[0, 11] = 'K';
            vigen[0, 12] = 'L';
            vigen[0, 13] = 'M';
            vigen[0, 14] = 'N';
            vigen[0, 15] = 'O';
            vigen[0, 16] = 'P';
            vigen[0, 17] = 'Q';
            vigen[0, 18] = 'R';
            vigen[0, 19] = 'S';
            vigen[0, 20] = 'T';
            vigen[0, 21] = 'U';
            vigen[0, 22] = 'V';
            vigen[0, 23] = 'W';
            vigen[0, 24] = 'X';
            vigen[0, 25] = 'Y';
            vigen[0, 26] = 'Z';



            //столбик
            vigen[1, 0] = 'A';
            vigen[2, 0] = 'B';
            vigen[3, 0] = 'C';
            vigen[4, 0] = 'D';
            vigen[5, 0] = 'E';
            vigen[6, 0] = 'F';
            vigen[7, 0] = 'G';
            vigen[8, 0] = 'H';
            vigen[9, 0] = 'I';
            vigen[10, 0] = 'J';
            vigen[11, 0] = 'K';
            vigen[12, 0] = 'l';
            vigen[13, 0] = 'M';
            vigen[14, 0] = 'N';
            vigen[15, 0] = 'O';
            vigen[16, 0] = 'P';
            vigen[17, 0] = 'Q';
            vigen[18, 0] = 'R';
            vigen[19, 0] = 'S';
            vigen[20, 0] = 'T';
            vigen[21, 0] = 'U';
            vigen[22, 0] = 'V';
            vigen[23, 0] = 'W';
            vigen[24, 0] = 'X';
            vigen[25, 0] = 'Y';
            vigen[26, 0] = 'Z';


            char smena;
            int razm;

            razm = arr.Length - 1;  /////////////////////////////


            for (int z = 0; z < razm + 1; z++)
            {
                vigen[1, z + 1] = arr[z];
            }

            int i = 0;

            while (i < razm)
            {
                smena = arr[0];

                for (int j = 0; j < razm; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[razm] = smena;

                for (int z = 0; z < razm + 1; z++)
                {
                    vigen[i + 2, z + 1] = arr[z];
                }

                i++;
            }

        }
    }
}
