using System;

namespace baitap
{
    class Student
    {
        private int mssv;
        private string hoten;
        private int tuoi;

        public int Mssv { get => mssv; set => mssv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public Student(int mssv, string hoten, int tuoi)
        {
            this.Mssv = mssv;
            this.Hoten = hoten;
            this.Tuoi = tuoi;
        }

       
      

        public override string ToString()
        {
            return $"MSSV: {mssv}, Ho Ten: {hoten}, Tuoi: {tuoi}";
        }
    }
}
