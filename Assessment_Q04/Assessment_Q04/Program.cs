using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q04{
    class Program{
        static void Main(string[] args){
            Circle Circ1 = new Circle(1,1,1);
            Circle Circ2 = new Circle(1,1,1);

            Console.WriteLine(Circ1.Status(Circ1,Circ2));
            

            Console.ReadKey();

        }//end main
    }//end class
}//end name
