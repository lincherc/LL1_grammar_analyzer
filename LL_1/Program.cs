using System;

using System.Collections.Generic;

namespace LL_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StrTrans strTrans=new StrTrans();
            //strTrans.analTable[1, 3] = "1";
            Boolean isVali=true;
            string word="";
            
            Console.WriteLine("请输入词法分析的输出结果，以标记END结束：");
            while (true)
            {
                string perInputWord = Console.ReadLine();
                if(perInputWord!="")
                {
                    if (perInputWord != "END")
                    {
                        string perFormatWord = perInputWord.Replace(" ","");
                        //Console.WriteLine(perFormatWord);
                        //int perLength = perInputWordTrim.Length;
                        int startWordIndex = perFormatWord.IndexOf(",");
                        int startIndex = startWordIndex + 1;
                        //Console.WriteLine(startIndex);
                        string perWord = perFormatWord.Substring(startIndex, 1);
                        word = word + perWord;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Token:");
            Console.WriteLine(word);
            Console.WriteLine();  //准备输出结果
            //string word=Console.ReadLine();
            //string t = "+";
            //int ts = strTrans.StrToNum(t);
            //Console.WriteLine(ts);
            
            char[] ws = word.ToCharArray();
            int end = ws.Length;
            Stack<string> wordStack=new Stack<string>();
            Stack<string> analStack=new Stack<string>();
            Stack<string> fomuStack=new Stack<string>();
            //Console.WriteLine(end);
            wordStack.Push("#");
            analStack.Push("#");
            analStack.Push("S");
            for (int i = end-1; i >= 0; i--)
            {
               wordStack.Push(ws[i].ToString()); 
            }
            
            /*foreach (string str in wordStack)
            {
                Console.WriteLine(str);
            }*/
            
            
            
            /*stack.Push("T'");
            stack.Push("F");*/

            while (true)
            {
                string nowStr = wordStack.Peek();
                string X = analStack.Peek();
                if (X!="S"&&X!="A"&&X!="B"&&X!="C"&&X!="D"&&X!="E"&X!="F"&X!="G"&&X!="H"&&X!="#")
                {
                    if (X == nowStr)
                    {
                        wordStack.Pop();
                        analStack.Pop();
                        //Console.WriteLine("idenfied: "+X);
                    }
                    else
                    {
                        isVali = false;
                        break;
                    }
                }
                else
                {
                    if (X == "#")
                    {
                        if (X == nowStr)
                        {
                            //isVali = true;
                            break;
                        }
                        else
                        {
                            isVali = false;
                        }
                    }
                    else
                    {
                        int row = strTrans.StrToNum(X);
                        int col = strTrans.StrToNum(nowStr);
                        if (row != -1 && col != -1)
                        {
                            string strCon = strTrans.analTable[row, col]; //空串，termin不立即pop
                            if (strCon != "ERR")
                            {
                                string fomu = X + "->" + strCon;
                                fomuStack.Push(fomu);
                                analStack.Pop();
                                if (strCon != "@")
                                {
                                    //Console.WriteLine("daochu"+strCon);
                                    char[] strConRes = strCon.ToCharArray();
                                    int len = strConRes.Length;
                                    for (int i = len - 1; i >= 0; i--)
                                    {
                                        analStack.Push(strConRes[i].ToString());
                                    }
                                }

                            }
                            else
                            {
                                isVali = false;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("词法分析结果有误！");
                            isVali = false;
                            break;
                        }
                    }
                }
            }
            
            Console.WriteLine("预测分析表如下：（ERR代表出错标记）");
            strTrans.OutputAnalTable();
            
            Console.WriteLine("推导过程每一步的产生式的输出：");
            foreach (string str in fomuStack)
            {
                Console.WriteLine(str);
            }
            
            Console.WriteLine("语法判定结果:");
            if (isVali)
            {
                Console.WriteLine("accept!");
            }
            else
            {
                Console.WriteLine("出错了！");
            }

            Console.WriteLine("敲击任意键结束程序......");
            Console.ReadKey();

            /**/
            //Console.WriteLine(word[1]);
        }
    }
}