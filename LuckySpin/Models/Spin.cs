using System;
namespace LuckySpin.Models
{
    public class Spin
    {

        Random random = new Random();
        private int a,b,c,luck; //instance variables

        //TODO: Create public getter and setter for Luck, referencing the instance variable
        public int Luck
        {
            get { return luck; }
            set { luck = value; }
        }

        //TODO: Create public getters for Random numbers, refernencing their instance variable
        public int A {
            get
            {
                a = random.Next(0, 10);
                return a;
            }
        }
        public int B {
            get
            {
                b = random.Next(0, 10);
                return b;
            }
        }
        public int C
        {
            get
            {
                c = random.Next(0, 10);
                return c;
            }
        }

        //TODO: Create a public getter that makes the decision to display the image or not by returning "block" or "none" for the Razor templates CSS
        public string Display
        {
            get
            {
                if (A == Luck || B == Luck || C == Luck)
                {
                    return "block";
                } 
                else
                {
                    return "none";
                }
              
            }
        }
    }
    
}
