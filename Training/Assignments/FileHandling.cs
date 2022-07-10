using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Training.Assignments
{
    class FileHandling
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("d://shaurya.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.WriteByte(65);
            fs.WriteByte(72);
            fs.Close();

            FileStream f2 = new FileStream("d://shaurya.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine(f2.ReadByte());
            Console.WriteLine(f2.ReadByte());

            f2.Close();

        }
    }

    class FileHandling2
    {
        static void Main(string[] args)
        {
            StreamWriter sw=null;
            try 
            {
                sw = new StreamWriter("d://shaurya2.txt",true);
                sw.WriteLine("my name is sonu");
                sw.WriteLine("my name is rskl");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }     
        }
    }

}
