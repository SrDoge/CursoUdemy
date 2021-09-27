using System;
using System.Globalization;

namespace Section7
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 10;
            //var y = 20.0;
            //var z = "Maria";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //int x = int.Parse(Console.ReadLine());
            //string day;

            //switch (x)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    case 4:
            //        day = "Wednesday";
            //        break;
            //    case 5:
            //        day = "Thursday";
            //        break;
            //    case 6:
            //        day = "Friday";
            //        break;
            //    case 7:
            //        day = "Saturday";
            //        break;
            //    default:
            //        day = "Invalid value";
            //        break;
            //}

            //Console.WriteLine("Day: " + day);

            //double pureco = double.parse(console.readline(), cultureinfo.invariantculture);

            //double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //Console.WriteLine(desconto);

            //string original = "abcde FGHIJ ABC abc DEFG    ";

            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();

            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");

            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3, 5);

            //string s6 = original.Replace('a', 'x');
            //string s7 = original.Replace("abc", "xy");

            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);

            //Console.WriteLine("Original: " + original + "-");
            //Console.WriteLine("ToUpper: " + s1 + "-");
            //Console.WriteLine("ToLower: " + s2 + "-");
            //Console.WriteLine("Trim: " + s3 + "-");
            //Console.WriteLine("IndexOf('bc'): " + n1);
            //Console.WriteLine("LastIndexOf('bc'): " + n2);
            //Console.WriteLine("Substring(3): -" + s4 + "-");
            //Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            //Console.WriteLine("Replace('a', 'x'): -" + s6 + "- ");
            //Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "- ");
            //Console.WriteLine("IsNullOrEmpty: " + b1);
            //Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            //DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:59", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //TimeSpan t1 = TimeSpan.FromDays(1.5);
            //TimeSpan t2 = TimeSpan.FromHours(1.5);
            //TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            //TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);

            //DateTime d1 = new DateTime(2005, 10, 15);
            //DateTime d2 = new DateTime(2006, 10, 15);

            //TimeSpan t = d2.Subtract(d1);
            //Console.WriteLine(t);

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(0, 10, 5);

            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t2.Multiply(2.0);
            //TimeSpan div = t2.Divide(2.0);

            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("d1: " + d1);
            //Console.WriteLine("d1 Kind: " + d1.Kind);
            //Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            //Console.WriteLine();

            //Console.WriteLine("d2: " + d2);
            //Console.WriteLine("d2 Kind: " + d2.Kind);
            //Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            //Console.WriteLine();

            //Console.WriteLine("d3: " + d3);
            //Console.WriteLine("d3 Kind: " + d3.Kind);
            //Console.WriteLine("d3 to Local: " + d3.ToLocalTime()); 
            //Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));



        }   
    }       
}
