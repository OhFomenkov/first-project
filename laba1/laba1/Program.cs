using System.Runtime;

namespace laba1
{


    class Company
    {
        String nme;
        String adress;
        String phonenumber;
        String fax;
        String site;
        static void Outinfo(Company comp)
        {
            Console.WriteLine("==========================================================================\n");
            Console.Write("Название компании: ");
            Console.Write(comp.nme);
            Console.Write("\nАдресс: ");
            Console.Write(comp.adress);
            Console.Write("\nНомер телефона: ");
            Console.Write(comp.phonenumber);
            Console.Write("\nФакс компании");
            Console.Write(comp.fax);
            Console.Write("\nСайт компании: ");
            Console.Write(comp.site);
            Console.WriteLine();
        }
        public Company(String nme, String adress, String phonenumber, String fax, String site)
        {
            this.nme = nme;
            this.adress = adress;
            this.phonenumber = phonenumber;
            this.fax = fax;
            this.site = site;

        }
        public class Manager
        {
            String surname;
            String name;
            String phone;
            String age;
            public static void Outmanager(Manager man)
            {
                Console.Write("\nМенеджр компании: ");
                Console.Write(man.surname);
                Console.Write("\nФамилия менеджера: ");
                Console.Write(man.name);
                Console.Write("\nВозраст Менеджера: ");
                Console.Write(man.age);
                Console.Write("\nНомер менеджера: ");
                Console.Write(man.phone);
            }
            public Manager(String surname, String name, String phone, String age)
            {
                this.surname= surname;
                this.name= name;
                this.phone= phone;
                this.age= age;
            }
        }
        //вложенный класс менеджер
        //конструктор company

        class project
        {
            public long Fibonacci(int n)
            {
                if (n <= 2)
                    return 1;
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            static void Main()
            {
                Console.WriteLine("Введите номер задачи");
                int z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    case 7:
                        int sum = 0;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            int g = Convert.ToInt32(Console.ReadLine());
                            sum = sum + g;
                        }
                        Console.WriteLine(sum);
                        break;

                    case 1:
                        Console.WriteLine("Введите 3 числа");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        int sum2 = a1 + a2 + a3;
                        Console.WriteLine("{0}+{1}+{2}={3)", a1, a2, a3, sum2);
                        Console.Write("/n", a1);
                        Console.Write('+');
                        Console.Write(a2);
                        Console.Write('+');
                        Console.Write(a3);
                        Console.Write('=');
                        Console.Write(sum2);
                        break;

                    case 2:
                        Console.WriteLine("Введитие радиус");
                        double r = Convert.ToInt32(Console.ReadLine());
                        double per = 2 * Math.PI * r;
                        double pl = 3.14 * Math.Pow(r, 2);
                        Console.Write("Периметр: ");
                        Console.Write(per);
                        Console.WriteLine("Площадь: ");
                        Console.Write(pl);
                        break;

                    case 3:
                        Company compani = new Company("Azati", "Ojheshko 22", "+375298657573", "fax2000", "c#.net");
                        Manager man = new Manager("Dolmatov", "Egrrr", "+375298657573", "18");
                        Outinfo(compani);
                        Company.Manager.Outmanager(man);


                        break;
                    case 4:
                        Console.WriteLine("Введите 2 положительных числа");
                        int f1 = Convert.ToInt32(Console.ReadLine());
                        int f2 = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        for (int i = f1; i <= f2; i++)
                        {
                            if (i % 5 == 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                        break;
                    case 5:
                        Console.WriteLine("Введите 2 числа");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(x1 > x2 ? x1 : x2);
                        break;
                    case 6:
                        Console.WriteLine("Введитет коэффиценты a, b ,c  квадратного уравнения");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        int c = Convert.ToInt32(Console.ReadLine());
                        int discr = b * b - 4 * a * c;
                        if (discr < 0)
                        {
                            Console.WriteLine("Нет действительных корней");
                            break;
                        }
                        else
                        {
                            double y1 = (-b + Math.Sqrt(discr)) / (2 * a);
                            double y2 = (-b - Math.Sqrt(discr)) / (2 * a);
                            Console.WriteLine(y1);
                            Console.WriteLine(y2);
                            if (y1 == y2)
                                Console.WriteLine(y2);
                            break;
                        }
                    case 8:
                        Console.WriteLine("Введите число");
                        int f = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= f; i++)
                        {
                            Console.Write("{0} ", i);
                            //   Console.Write(' ');
                        }

                        break;
                    case 9:
                        Console.Write(0);
                        ulong prev = 0;
                        ulong next = 1;
                        ulong suma;
                        for (int i = 1; i < 99; i++)
                        {
                            Console.Write(' ');
                            suma = next;
                            next += prev;
                            prev = suma;
                            Console.Write(suma);
                        }

                        /*                    int fib = 1;
                                            do
                                            {
                                                Console.Write(Fibonacci(fib));
                                                Console.Write(' ');
                                                fib++;
                                            } while (fib != 100);

                                            break;*/

                        break;
                    case 10:
                        double result = 1;
                        int n1 = 2;
                        String chisl = result.ToString();
                        while (true)
                        {
                            result += Math.Pow(-1, n1) * 1 / n1;
                            Console.WriteLine(result);
                            n1++;
                            chisl = result.ToString();
                            if (chisl.Length >= 5)
                            {
                                break;
                            }


                        }

                        Console.WriteLine(Math.Round(result, 3));
                        break;

                }
            }
        }
    }
}