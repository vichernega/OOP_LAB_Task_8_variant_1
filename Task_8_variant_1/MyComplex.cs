using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_variant_1
{
    class MyComplex
    {
        private double Re, Im;
        public MyComplex(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        public double RE
        {
            get { return Re; }
        }
        public double IM
        {
            get { return Im; }
        }
        
        public static MyComplex operator +(MyComplex A, MyComplex B)
        {
            return new MyComplex(A.RE + B.RE, A.IM + B.IM);
        }
        public static MyComplex operator +(MyComplex A, double num)
        {
            return new MyComplex(A.RE + num, A.IM);
        }
        public static MyComplex operator +(double num, MyComplex A)
        {
            return new MyComplex(A.RE + num, A.IM);
        }
        public static MyComplex operator -(MyComplex A)
        {
            return new MyComplex(-A.RE, -A.IM);
        }
        // according to variant 1
        public static MyComplex operator -(MyComplex A, MyComplex B)
        {
            return new MyComplex(A.RE - B.RE, A.IM - B.IM);
        }
        public override string ToString()
        {
            string str;

            if (Im > 0) { str = Re.ToString() + "+" + Im.ToString() + "i"; }
            else if (Im == 0) { str = Re.ToString(); }
            else { str = Re.ToString() + Im.ToString() + "i"; }

            return str;
        }
    }
}
