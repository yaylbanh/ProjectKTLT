class Program

{

    static void Main(string[] args)

    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] tokens = Console.ReadLine().Split();

        int m = int.Parse(tokens[0]);

        int n = int.Parse(tokens[1]);

        int k = int.Parse(tokens[2]);

        int[,] a = new int[m, n];

        for (int i = 0; i < m; i++)

        {

            tokens = Console.ReadLine().Split();

            for (int j = 0; j < n; j++)

            {

                a[i, j] = int.Parse(tokens[j]);

            }

        }

        Console.WriteLine("Tổng các phần từ trên hàng k:" + hama(a, k));

        Console.WriteLine("Tổng các phần từ trên cột k:" + hamb(a, k));

        Console.WriteLine("Tổng các phần tử trong bảng a:" + hamc(a));

        Console.WriteLine("Tổng các phần tử là số chẳn trong bảng a:" + hamd(a));

        Console.WriteLine("Tổng các phần tử là số lẻ trong bảng a:" + hame(a));

        Console.WriteLine("Tổng giá trị trung bình của tất cả các phần tử trong bảng a:" + hamf(a));

        Console.ReadLine();

        static int hama(int[,] arr, int k)

        {

            int tong = 0;

            for (int j = 0; j < arr.GetLength(1); j++)

            {

                tong += arr[k, j];

            }

            return tong;

        }

        static int hamb(int[,] arr, int k)

        {

            int tong = 0;

            for (int i = 0; i < arr.GetLength(0); i++)

            {

                tong += arr[i, k];

            }

            return tong;

        }

        static int hamc(int[,] arr)

        {

            int tong = 0;

            foreach (var item in arr)

                tong += item;

            return tong;

        }

        static int hamd(int[,] arr)

        {

            int tong = 0;

            foreach (var item in arr)

            {

                if (item % 2 == 0)

                    tong += item;

            }

            return tong;

        }

        static int hame(int[,] arr)

        {

            int tong = 0;

            foreach (var item in arr)

            {

                if (item % 2 != 0)

                    tong += item;

            }

            return tong;

        }

        static double hamf(int[,] arr)

        {

            int tong = hamc(arr);

            return tong * (1.0) / arr.Length;

        }

    }

}
