using System;

namespace Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p;
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);

            //p = new Point();
            //Console.WriteLine(p);

            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue) Console.WriteLine(x.Value);     
            //else Console.WriteLine("X is null");
            //if (y.HasValue) Console.WriteLine(y.Value);
            //else Console.WriteLine("Y is null");

            //double? x = null;
            //double? y = 10;

            //double a = x ?? 5;
            //double b = y ?? 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int n = int.Parse(Console.ReadLine());
            //double[] vect = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double sum = 0.0;
            //for (int i = 0; i < n;i++ )
            //{
            //    sum += vect[i];
            //}

            //double avg = sum / n;
            //Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //int n = int.Parse(Console.ReadLine());
            //Product[] vect = new Product[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Product { Name = name, Price = price };
            //}

            //double sum = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;
            //Console.WriteLine("Preço Médio: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //int s1 = Calculator.Sum( 2, 3 );
            //int s2 = Calculator.Sum( 2, 4, 3 );

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //int a = 10;
            //int triple;
            //Calculator.Triple(a, out triple);   
            //Console.WriteLine(triple);

            //int i = 123;
            //object o = i;  // implicit boxing

            //try
            //{
            //    int j = (int)o;  // attempt to unbox

            //    System.Console.WriteLine("Unboxing OK.");
            //}
            //catch (System.InvalidCastException e)
            //{
            //    System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            //}

            //string[] vet = new string[] { "Maria", "Alex", "Bob" };

            //for (int i = 0; i < vet.Length; i++)
            //{
            //    Console.WriteLine(vet[i]);
            //}
            //Console.WriteLine("--------------------------------------------");

            //foreach (string obj in vet)
            //{
            //    Console.WriteLine(obj);
            //}
            //List<string> list = new List<string>();

            //List<string> list2 = new List<string>() { "Maria", "Alex" } ;

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Anna");
            //list.Insert(2, "Marco");

            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}
            //Console.WriteLine("List count: " + list.Count);

            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("First 'A': " + s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last 'A': " + s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position 'A': " + pos1);

            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Last position 'A': " + pos2);

            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //Console.WriteLine("----------------------------------");
            //foreach (string obj in list2)
            //{
            //    Console.WriteLine(obj);
            //}

            //list.Remove("Alex");
            //Console.WriteLine("----------------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //list.RemoveAll(x => x[0] == 'M');
            //Console.WriteLine("----------------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //double[,] mat = new double[2, 3];

            //Console.WriteLine(mat.Length);

            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));

            //Console.WriteLine(mat.GetLength(1));


        }
    }
}
