using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q04{
    class PointClass{
        //Auto Property
            public double x { get; set; }
            public double  y { get; set; }

        //Constructor
            public PointClass(double start_x = 0, double start_y = 0){
                x = start_x;
                y = start_y;
            }//end constructor

    }//end class
}//end name
