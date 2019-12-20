using System;

namespace ArgumentsOnMethod__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int PersegiPanjang1,
                PersegiPanjang2,
                PersegiPanjang3,
                PersegiPanjang4,
                Pengurangan1,
                Pengurangan2,
                Pengurangan3,
                Pengurangan4;

            int A = 6;
            int B = 7;

            PersegiPanjang1 = LuasPP1(10, 5);
            PersegiPanjang2 = LuasPP2();
            PersegiPanjang3 = LuasPP2(20, 10);
            PersegiPanjang4 = LuasPP2(P: 11, L: 7);
            Pengurangan1 = Pengurangan(8, 3);
            Pengurangan2 = Pengurangan(X: 8, Y: 3);
            Pengurangan3 = Pengurangan(X: 8, 3);
            Pengurangan4 = PenguranganJenis2();

            Console.WriteLine(PersegiPanjang1);
            Console.WriteLine(PersegiPanjang2);
            Console.WriteLine(PersegiPanjang3);
            Console.WriteLine(PersegiPanjang4);
            Console.WriteLine(Pengurangan1);
            Console.WriteLine(Pengurangan2);
            Console.WriteLine(Pengurangan3);
            Console.WriteLine(Pengurangan4);

            Kalikan(A);
            Console.WriteLine(A);

            KalikanPakaiRef(ref A);
            Console.WriteLine(A);

            DapatkanNilai(out A, out B);
            Console.WriteLine(A);

            Console.ReadLine();
        }

        static int LuasPP1(int P, int L)
        {
            return P * L;
        }

        static int LuasPP2(int P = 10, int L = 5)
        {
            return P * L;
        }

        static int Pengurangan(int X, int Y)
        {
            return X - Y;
        }

        static int PenguranganJenis2(int X = 8, int Y = 3)
        {
            return X - Y;
        }

        static int Kalikan(int X)
        {
            X = X * X;
            return X;
        }

        static int KalikanPakaiRef(ref int X)
        {
            X = X * X;
            return X;
        }

        static void DapatkanNilai(out int X, out int Y)
        {
            X = 5;
            Y = 12;
        }


    }
}
