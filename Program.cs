using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Anh", 21);
            Student s2 = new Student(2, "Hien", 20);
            Student s3 = new Student(3, "Phap", 15);
            Student s4 = new Student(4, "An", 18);
            Student s5 = new Student(5, "Thien", 21);
            List<Student> students = new List<Student> { s1, s2, s3, s4, s5 };


            Console.WriteLine("Danh sach sinh vien:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }



            Console.WriteLine("\n\nXuat danh sach tuoi tu 15 -> 18:");
            var s = students.Where(x => x.Tuoi >= 15 && x.Tuoi <= 18).ToList();
            foreach (var x in s)
            {
                Console.WriteLine(x.ToString());
            }



            Console.WriteLine("\n\nDanh sach bat dau tu chu A:");
            var sa= students.Where(x => x.Hoten.StartsWith("A"));
            foreach (var student in sa)
            {
                Console.WriteLine(student);
            }


           
            int tongTuoi = students.Sum(x => x.Tuoi);
            Console.WriteLine("\ntong so tuoi:"+tongTuoi);


            Console.WriteLine("\n\nDS sinh vien co so tuoi lon nhat:");
            var tuoiMax = students.Max(x => x.Tuoi);
            var svTuoiMax = students.Where(x => x.Tuoi == tuoiMax);
            foreach (var student in svTuoiMax)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n\nDS sap xep theo tuoi:");
            var svsx = students.OrderBy(x => x.Tuoi);
            foreach (var student in svsx)
            {
                Console.WriteLine(student);
            }
        }
    }
}
