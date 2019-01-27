using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment_Q01{
    class Program : PrintFile{
        static void Main(string[] args){

            StreamReader InputFile = new StreamReader("C:\\Text documents\\CheckerTextForAssess.cs");
            string [] SplitFile;

        //read to end
            SplitFile = InputFile.ReadToEnd().Split('\n');

           
            foreach(string X in SplitFile){

                if(X.Contains("//") || X.Contains("/*") || X.Contains("*/")){//check for comments

                    CheckPrint(X);
                }
            }
            Console.ReadKey();
        }//end main
    }//end class
}//end name
