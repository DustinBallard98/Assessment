using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q01{
    class IndexClass{

        public int IndexOfSlash(string Input){

            for(int X = 1; X < Input.Length; X++){

                if (Input[X] == '/' && Input[X-1] == '/'){
                    return X-1;
                }

            }//end for
            return 0;
        }//end indexof


       //public int IndexOfnewLine(string Input){
       //    
       //    for(int X = 1; X < Input.Length; X++){
       //
       //        if (Input[X] == 'n' && Input[X-1] == '\'){
       //            return X-1;
       //        }
       //    }//end for   
       //    return 0;
       //}//end newline


        public int [] IndexofCommentSection(string Input){
            int [] startEnd = new int [2];
            int index = 0;

            for(int X = 1; X < Input.Length; X++){ 
                
                if(Input[X] == '*' && Input[X-1] == '/'){
                    startEnd[0] = index;
                }else if (Input[X] == '/' && Input[X-1] == '*'){
                    startEnd[1] = index + 1;

                }
                index++;
            }//end for

                return startEnd;
        }//end comment section

    }//end class
}//endname
