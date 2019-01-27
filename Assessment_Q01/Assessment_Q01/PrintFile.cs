using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q01{
    class PrintFile : IndexClass{

        public static void CheckPrint(string Input){
            IndexClass IndexOf = new IndexClass();
            int Begin = 0;
            int index = 0;;

            if (Input.Contains("//")){//if single comment
                
                Begin = IndexOf.IndexOfSlash(Input);
                index = Begin;

                while(index < Input.Length){
                    Console.Write(Input[index]);
                    index++;
                }//end while

            }else if (Input.Contains("/*")){//if comment section starts

                int [] startEnd = IndexOf.IndexofCommentSection(Input);
                index = startEnd[0];

                while(index < Input.Length){
                    Console.Write(Input[index]);
                    index++;
                }//end while

            }else if (Input.Contains("*/")){//if comment section ends
                int [] startEnd = IndexOf.IndexofCommentSection(Input);
                index = 0;

                while (index <= startEnd[1] && (Input[index] != ' ' || Input[index] != '\t')){
                    Console.Write(Input[index]);
                    index++;
                }//end while
            }//end if
            Console.WriteLine();

            Begin = 0;

        }//end checkprint

    }//end class
}//end name
