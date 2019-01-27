using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment_Q03{
    class Program{
        static void Main(string[] args){

            string Input = Console.ReadLine();

            string [] s_Ary = Input.Split();
            WriteFile(s_Ary);


        }//end main

        static void WriteFile(string [] s_Ary){

        //create streamwriter and determine largest string
            StreamWriter WriteToFile = new StreamWriter("C:\\Text documents\\RectangleText.txt");
            int Largest = 0;
            string PaddedString = "";
            
            foreach(string X in s_Ary){

                if (X.Length > Largest){
                    Largest = X.Length;
                }//end if
            }//end foreach

        
        //write *'s for first line
            for(int I = 0; I < Largest + 2; I++){

                WriteToFile.Write('*');
            }//end for


        //empty line
            WriteToFile.WriteLine();

        //write each string with * padding
            foreach(string X in s_Ary){
                PaddedString = ("*" + X.PadLeft(Largest - X.Length).PadRight(Largest) + "*");
                WriteToFile.WriteLine(PaddedString);
            }


        //write last line
            for(int I = 0; I < Largest + 2; I++){

                WriteToFile.Write('*');
            }

            WriteToFile.Close();

        }//end writefile

    }//end class
}//end namespace
