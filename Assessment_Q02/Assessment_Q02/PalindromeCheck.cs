using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q02{
    class PalindromeCheck{

        public bool CheckPal(string S1){
            string Reverse = "";
            
            for(int X = S1.Length - 1; X >= 0; X--){
                Reverse += S1[X];
            }

            if(S1 == Reverse){
                return true;
            }//end if

            return false;
        }//end check 

    }//end class
}//end name
