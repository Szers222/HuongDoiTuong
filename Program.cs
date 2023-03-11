using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so giay muon them vao: ");
            int nhap = Nhap();
            Time thoiGian= new Time(24,0,0);
            thoiGian.nextSecond();
            Console.WriteLine("So gio chuan: ");
            Console.WriteLine(thoiGian.toString());
            Console.WriteLine("So gio +1 giay");
            Console.WriteLine(thoiGian.nextSecond().toString());
            Console.WriteLine("So gio them giay bat ky");
            Console.WriteLine(thoiGian.nextSecond1(nhap).toString());
            Console.WriteLine("So gio -1 giay");
            Console.WriteLine(thoiGian.previousSecond().toString());
            Console.WriteLine("So gio them giay bat ky");
            Console.WriteLine(thoiGian.previousSecond1(nhap).toString());


        }
        public static int Nhap()
        {
            int input;
            int.TryParse(Console.ReadLine(), out input);
            return input;
        }
    }
}
