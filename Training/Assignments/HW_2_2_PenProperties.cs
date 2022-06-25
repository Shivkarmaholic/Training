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
        public string Nib { get; set; }
    }


    class Pen : Refill
    {
        public Refill r { get; set; }
        public int PenCapLength { get; set; }
        public string PenBrand { get; set; }
    }
    class HW_2_2_PenProperties
    {
        static void Main(string[] args)
        {

            Pen p1 = new Pen();            

            p1.RefillLength = 8;
            p1.RefillInkColor = "Blue";
            
            p1.PenCapLength = 3;
            p1.PenBrand = "renold";


            Console.WriteLine("" +
                "\nPen Brand         " +p1.PenBrand+
                "\nPen Cap Length    " + p1.PenCapLength +
                "\nRefill Ink Color  " + p1.RefillInkColor +
                
                "\nRefill Length     " + p1.RefillLength +
                "\nNib Material      " + p1.NibMaterialType +
                "\nNib Width         " + p1.NibWidth

                );

        }
    }
}
