using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q0{
    class Program{
        static void Main(string[] args){

            int [] Int_Ary = {0, 1, 1, 0, 1, 0, 1, 0, 0, 1};
            bool Sorted = true;
            int EmptyCup;

            while (Sorted){//until sorted
                Sorted = false;
                for (int X = 1; X < Int_Ary.Length; X++){// move through entire array
                    
                    if (Int_Ary[X] < Int_Ary[X-1]){
                        
                            EmptyCup = Int_Ary[X-1];
                            Int_Ary[X-1] = Int_Ary[X];
                            Int_Ary[X] = EmptyCup;
                            Sorted = true;

                    }//end if

                }//end for
            }//end while
            foreach(int X in Int_Ary){

            Console.Write("{0}, ", X);
            }//end foreach
            Console.ReadKey();

        }//end main
    }//end class
}//end name
