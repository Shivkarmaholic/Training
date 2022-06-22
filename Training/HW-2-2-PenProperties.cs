using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Nib
    {
        public string NibMaterialType { get; set; }
        public float NibWidth { get; set; }
    }

    class Refill : Nib
    {
        public string RefillInkColor { get; set; }
        public int RefillLength { get; set; }
        public string RefillTip { get; set; }
    }


    class Pen : Refill
    {
        public string PenRefill { get; set; }
        public int PenCapLength { get; set; }
        public string PenBrand { get; set; }
    }
    class HW_2_2_PenProperties
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.NibMaterialType = "BallPen";
            p1.NibWidth = 0.002f;
            p1.RefillLength = 8;
            p1.RefillTip = "slim";
            p1.RefillInkColor = "Blue";
            p1.PenCapLength = 3;
            p1.PenRefill = "renold";


            Console.WriteLine("" +
                "\nPen Refill:       " + p1.PenRefill +
                "\nPen Cap Length    " + p1.PenCapLength +
                "\nRefill Ink Color  " + p1.RefillInkColor +
                "\nRefill Tip        " + p1.RefillTip +
                "\nRefill Length     " + p1.RefillLength +
                "\nNib Material      " + p1.NibMaterialType +
                "\nNib Width         " + p1.NibWidth

                );

        }
    }
}
