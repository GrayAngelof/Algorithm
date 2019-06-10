using System;
using System.CodeDom.Compiler;
using System.IO;

namespace HW_ClassLibrary
{
    public static class ReadMatrix
    {
        public static int[,] Read(string filename)
        {
            int size=0;
            using (StreamReader first = new StreamReader(filename, System.Text.Encoding.Default))
            {
                string str = first.ReadLine();
                if (int.TryParse(str, out int intNum))
                {
                    size = intNum;
                }
            }

            int[,] result = new int[size,size];

            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
            {
                sr.ReadLine();
                string line;
                int row = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] tempString = line.Split(' ');
                    for (int col = 0; col < tempString.Length; col++)
                    {
                        if (int.TryParse(tempString[col], out int res))
                        {
                            result[row, col] = res;
                        }
                    }

                    row++;
                }
            }

            return result;
        }
    }
}