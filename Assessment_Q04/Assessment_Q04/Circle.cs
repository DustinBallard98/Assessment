using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Q04{
    class Circle{

        private double Radius = 0.0;
        PointClass Point = new PointClass();
        

        public Circle(double XPass, double YPass, double Rad){
            Point.x = XPass;
            Point.y = YPass;
            Radius = Rad;
            

        }

        public string Status(Circle Circ1, Circle Circ2){

            double cDist = 0;
            double SumofRadi = Circ1.Radius + Circ2.Radius;

                cDist = Math.Pow((Circ2.Point.x - Circ1.Point.x),2) + Math.Pow((Circ2.Point.y - Circ1.Point.y),2);
                cDist = Math.Sqrt(cDist);

           
            //if equal distances tangent

               if (SumofRadi == cDist){

                   return "The circles are tangent.";

               }else if (SumofRadi > cDist && cDist != 0){//if overlapping

                  return "The Circles overlap.";

               }else if (SumofRadi < cDist || Circ1.Point.x == Circ2.Point.x && Circ1.Point.y == Circ2.Point.y){//determine if inside
                                                                                                                    
                  if (Circ1.Radius != Circ2.Radius){

                      if (cDist < Circ2.Radius){

                          return "Circle 2 is inside Circle 1.";

                      }else if (cDist < Circ1.Radius){

                          return "Circle 1 is inside Circle 2.";

                      }else if(cDist != 0){

                          return "The circles do not touch.";   
                        
                      }//end nested if


                      //Unfinished.......

                  }//end if
               }//end else if

            

            return "The circles are the same.";
    
        } //end status




    }//end class
}//end name