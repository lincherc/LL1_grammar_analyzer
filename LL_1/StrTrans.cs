using System;

namespace LL_1
{
    public class StrTrans
    {
        public string[,] analTable= new string[9,15];
        
        public StrTrans()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    analTable[i, j] = "ERR";
                }
            }
            analTable[0, 13] = "xAyB";
            analTable[1, 1] = "CDC";
            analTable[1, 7] = "CDC";
            analTable[1, 8] = "CDC";
            analTable[2, 10] = "<";
            analTable[2, 11] = ">";
            analTable[2, 12] = "=";
            analTable[3, 7] = "ieC";
            analTable[4, 1] = "EG";
            analTable[4, 7] = "EG";
            analTable[4, 8] = "EG";
            analTable[5, 0] = "@";
            analTable[5, 2] = "@";
            analTable[5, 4] = "+E";
            analTable[5, 5] = "-E";
            analTable[5, 10] = "@";
            analTable[5, 11] = "@";
            analTable[5, 12] = "@";
            analTable[5, 14] = "@";
            analTable[7, 14] = "@";
            analTable[6, 1] = "FH";
            analTable[6, 7] = "FH";
            analTable[6, 8] = "FH";
            analTable[7, 0] = "@";
            analTable[7, 2] = "@";
            analTable[7, 3] = "*F";
            analTable[7, 4] = "@";
            analTable[7, 5] = "@";
            analTable[7, 6] = "/F";
            analTable[7, 10] = "@";
            analTable[7, 11] = "@";
            analTable[7, 12] = "@";
            analTable[8, 1] = "(C)";
            analTable[8, 7] = "i";
            analTable[8, 8] = "n";
        }

        public void OutputAnalTable()
        {
            Console.WriteLine("    #     (     )     *     +     -     /     i     n     e     <     >     =     x     y");
            //Console.WriteLine("=============================================================");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("===========================================================================================");
                switch (i)
                {
                    case 0:
                        Console.Write("S   ");
                        break;
                    case 1:
                        Console.Write("A   ");
                        break;
                    case 2:
                        Console.Write("D   ");
                        break;
                    case 3:
                        Console.Write("B   ");
                        break;
                    case 4:
                        Console.Write("C   ");
                        break;
                    case 5:
                        Console.Write("G   ");
                        break;
                    case 6:
                        Console.Write("E   ");
                        break;
                    case 7:
                        Console.Write("H   ");
                        break;
                    case 8:
                        Console.Write("F   ");
                        break;
                    default:
                        Console.Write("ERROR!");
                        break;
                }
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(analTable[i,j].PadRight(6));
                }
                Console.WriteLine();
            }
        }
        
        public int StrToNum(string str)
        {
            switch (str)
            {
                        case "S":
                            return 0;
                            break;
                        case "A":
                            return 1;
                            break;
                        case "D":
                            return 2;
                            break;
                        case "B":
                            return 3;
                        case "C":
                            return 4;
                        case "G":
                            return 5;
                        case "E":
                            return 6;
                        case "H":
                            return 7;
                        case "F":
                            return 8;
                        case "#":
                            return 0;
                        case "(":
                            return 1;
                        case ")":
                            return 2;
                        case "*":
                            return 3;
                        case "+":
                            return 4;
                        case "-":
                            return 5;
                        case "/":
                            return 6;
                        case "i":
                            return 7;
                        case "n":
                            return 8;
                        case "e":
                            return 9;
                        case "<":
                            return 10;
                        case ">":
                            return 11;
                        case "=":
                            return 12;
                        case "x":
                            return 13;
                        case "y":
                            return 14;
                        default:
                            return -1;
            }
        }
    }
}