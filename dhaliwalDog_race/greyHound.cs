using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace dhaliwalDog_race
{
    public class greyHound
    {
        Random instance_Object = new Random();

        public String Name { get; set; }
        public int DogNo { get; set; }
        public int bet { get; set; }

        public int  Amountset(int dog,int amount,int bet,int winner) {
            if (dog > 0 && dog == winner)
            {
                return amount + bet;
            }else {
                return amount - bet;
            }

        }
        //generate a random no to move from one position to another using next function with the hellp of move method 
        public int genNo() {
            return instance_Object.Next(1, 30);
        }

        public int winner(PictureBox pb, int no) {
            if (pb.Left > 660)
            {
                return no;
            }
            else {
                return 0;
            }



        }
        // run the dog in the bet to  move in the race with the help of timer and picture box pass as a argument 
        public void move(PictureBox pb,int no) {
            pb.Left = pb.Left + no;
        }

    }
}
