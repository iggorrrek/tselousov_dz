using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            Console.WriteLine("Задание номер 1");

            double kek = Math.E;
            double kek2 = Math.Round(kek, 1);
            Console.WriteLine(kek2);
            string qwe = " ";

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 2");

            int kek3 = 10;
            int kek4 = 50;
            Console.WriteLine(kek3);
            Console.WriteLine(kek4);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 3");

            Console.WriteLine(228);
            Console.WriteLine(115);
            Console.WriteLine(159);
            Console.WriteLine(7);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 4");

            string chislo = Console.ReadLine();
            int chislo2 = Int32.Parse(chislo);
            Console.WriteLine(chislo2 + 10);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 5");

            int storonaKvadrata = 10;
            Console.WriteLine(storonaKvadrata*4);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 6");

            int rad = 10;
            double ploshad = Math.PI * rad * rad;
            double dlina = Math.PI * rad * 2;
            Console.Write(ploshad);
            Console.WriteLine(dlina);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 7");

            int x = 30;
            Console.WriteLine(Math.Cos(x));

            /*Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 8");

            int verh = 2;
            int niz = 8;                ТУТ ВООБЩЕ НИЧЕГО НЕ ПОЛУЧАЕТСЯ ХОТЯ КОД БЫЛ ПРОВЕРЕН НА ДРУГОМ КОМПЕ И РАБОТАЕТ
            int vus = 4;
            double peremennay2 = 2;
            int razn = (niz - verh) / peremennay2;
            double summatrap = Math.Pow(razn, peremennay2) + Math.Pow(vus, peremennay2);
            double bok = Math.Sqrt(summatrap);
            double perimetr = (bok * peremennay2 + verh + niz);
            Console.WriteLine(perimetr);*/

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 9");

            double konfkg = 980;
            double kukikg = 520;
            double applekg = 190; 
            double konf = 3; //c рандомом у меня ВООООБЩЕЕЕЕЕЕ НИЧЕГОООООООООООО НЕ ПОЛУЧАЕТСЯ, ОШИИИИИИИИИИИИбка
            double kuki = 4;
            double apple = 5;
            Console.WriteLine(konfkg * konf + kukikg * kuki + applekg * apple);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 10");

            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("   Труд");
            Console.WriteLine("       Май");

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 11");

            string input1 = Console.ReadLine(); 
            string input2 = Console.ReadLine();
            float num1 = Int32.Parse(input2);
            float num2 = Int32.Parse(input1);
            float perem= num1;
            num1 = num2;
            num2 = perem;
            Console.WriteLine(num2);
            Console.WriteLine(num1);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 12");

            Console.WriteLine("Выберите фигуру: ");
            Console.WriteLine("1 - Треугольник");
            Console.WriteLine("2 - Четырехугольник");
            Console.WriteLine("3 - Круг");
            int figura = int.Parse(Console.ReadLine());
            if (figura == 1)
            {
                Console.WriteLine("Что вы хотите посчитать?");
                Console.WriteLine("1 - Площадь");
                Console.WriteLine("2 - Периметр");
                int vubor = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите стороны треугольника");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if (vubor == 1)
                    {
                    double poluperimetr = (a + b + c)/2;
                    Console.WriteLine(Math.Sqrt(poluperimetr*(poluperimetr-a)*(poluperimetr-b)*(poluperimetr-c)));
                }
                if (vubor == 2)
                {
                    Console.WriteLine(a+ b + c);
                }
            }
            if (figura == 2)
            {
                Console.WriteLine("Что вы хотите посчитать?");
                Console.WriteLine("1 - Площадь");
                Console.WriteLine("2 - Периметр");
                int vubor = int.Parse(Console.ReadLine());
                if (vubor == 1)
                {
                    Console.WriteLine("Введите диагонали и синус угла между ними");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * b * c / 2);
                }
                if (vubor == 2)
                {
                    Console.WriteLine("Введите четыре все стороны ");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+b+c+d);
                }
            }
            if (figura == 3)
            {
                Console.WriteLine("Что вы хотите посчитать?");
                Console.WriteLine("1 - Площадь");
                Console.WriteLine("2 - Периметр");
                int vubor = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите радиус окружности");
                int radius = int.Parse(Console.ReadLine());
                if (vubor == 1)
                {
                    Console.WriteLine(radius*radius*Math.PI);
                }
                if (vubor == 2)
                {
                    Console.WriteLine(radius*2*Math.PI);
                }

            }
            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 13");

            Console.WriteLine("Введите число:");
            int abc = int.Parse(Console.ReadLine());
            Console.Write("Вы ввели число: ");
            Console.WriteLine(abc);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 14");

            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 15");

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                int randomchislo = random.Next(1, 100);
                Console.WriteLine(randomchislo);
            }
            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 16");

            Console.WriteLine("Введите 3 коэфицента квдратного уравнения");
            int we = int.Parse(Console.ReadLine());
            int er = int.Parse(Console.ReadLine());
            int rt = int.Parse(Console.ReadLine());
            double discr = Math.Sqrt(er*er - 4*er*rt);
            Console.WriteLine((-er + discr) / 2 * we);
            Console.WriteLine((-er - discr) / 2 * we);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 17");

            int a17 = 2;
            int b17 = 4;
            Console.WriteLine((a17+b17)/2);
            Console.WriteLine(Math.Sqrt(a17 * b17));

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 18");

            int a18 = 1;
            int b18 = 2;
            int c18 = 4;
            int d18 = 5;
            Console.WriteLine(Math.Sqrt((a18 - c18) * (a18 - c18) + (b18 - d18) * (b18 - d18)));

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 19");

            int a19 = 2;
            int b19 = 4;
            int c19 = 5;
            Console.WriteLine("Выберите вариант перемешивания 1 или 2");
            int abc19 = int.Parse(Console.ReadLine());
            if (abc19 == 1)
            {
                int perv19 = a19;
                int vtor19 = b19;
                int tret19 = c19;
                b19 = tret19;
                a19 = vtor19;
                c19 = perv19;
            }
            else
            {
                int perv19 = a19;
                int vtor19 = b19;
                int tret19 = c19;
                b19 = perv19;
                a19 = tret19;
                c19 = vtor19;
            }
            Console.WriteLine(a19);
            Console.WriteLine(b19);
            Console.WriteLine(c19);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 20");

            int sec20 = 3600;
            Console.WriteLine(sec20 / 3600);
            Console.WriteLine((sec20 % 3600) / 60);
            Console.WriteLine(sec20 % 60);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 21");

            int a21 = 543;
            int b21 = 130;
            int c21 = a21 / b21;
            Console.WriteLine(c21);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 22");

            int a22 = 234;
            int b22 = a22 % 10;
            int c22 = a22 / 100;
            int d22 = a22 % 100 / 10;
            Console.WriteLine(c22 + d22 * 10 + b22 * 100);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 23");

            int n23 = 234664;
            int a23 = n23 / 1000 ;
            int b23 = n23 / 100 ;
            Console.WriteLine(a23);
            Console.WriteLine(b23);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 24");

            int n24 = 2345;
            int a1000 = n24 / 1000 ;
            int b100 = n24 % 1000 / 100 ;
            int c10 = n24 % 100 / 10 ;
            int d1 = n24 % 10 ;
            Console.WriteLine(a1000 + b100*10 + c10*100 + d1*1000);
            Console.WriteLine(a1000 * 100 + b100 * 1000 + c10 + d1 * 10);
            Console.WriteLine(a1000 * 1000 + b100 * 10 + c10 * 100 + d1);
            Console.WriteLine(a1000*10 + b100 + c10 * 1000 + d1 * 100);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 25");

            Console.WriteLine("Введите случайное число от 101 до 999");
            int n163 = int.Parse(Console.ReadLine());
            double a25 = n163 / 100; 
            double b25 = n163 % 100 / 10;  
            double c25 = n163 % 10; 
            Console.WriteLine(a25 + b25 * 100 + c25 * 10);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 26");

            int h26 = 6;
            int m26 = 45;
            int s26 = 30;
            double schet1 = h26 % 12 / 12 * 360;
            double schet2 = m26 / (60 * 12) * 360;
            double schet3 = s26 / (60 * 60 * 12) * 360;
            Console.WriteLine(schet1 + schet2 + schet3);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 27");

            double n = double.Parse(Console.ReadLine());
            double grad = n * 180;
            double gradost = grad % 30;
            double otngrad = gradost / 30;
            double gradmin = otngrad * 360; 
            double polchas = grad / 30;
            double polmin = gradmin / 6;
            Console.WriteLine(gradmin);
            Console.WriteLine(Convert.ToInt32(polchas));
            Console.WriteLine(Convert.ToInt32(polmin));

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 28");

            Console.WriteLine("Введите 3 вещественных числа");
            int a28 = int.Parse(Console.ReadLine());
            int b28 = int.Parse(Console.ReadLine());
            int c28 = int.Parse(Console.ReadLine());
            int min28 = a28;
            if (b28 < min28)
            {
                min28 = b28;
            }
            else
            {
                if (c28 < min28)
                {
                    min28 = c28;
                }
                else
                {
                    min28 = a28;
                }
            }
            Console.WriteLine(min28);
            Console.WriteLine(qwe);

            Console.WriteLine("Задание номер 29");
            Console.WriteLine("Введите 3 вещественных числа");

            int a29 = int.Parse(Console.ReadLine());
            int b29 = int.Parse(Console.ReadLine());
            int c29 = int.Parse(Console.ReadLine());
            int min29 = a29;
            if (b29 < min29)
            {
                min29 = b29;
            }
            else
            {
                if (c29 < min29)
                {
                    min29 = c29;
                }
                else
                {
                    min29 = a29;
                }
            }
            //max
            int max29 = a29;
            if (b29 > max29)
            {
                max29 = b29;
            }
            else
            {
                if (c29 > max29)
                {
                    max29 = c29;
                }
                else
                {
                    max29 = a29;
                }
            }
            Console.WriteLine(max29+min29);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 30");

            int count30 = 0;
            int chislo30 = int.Parse(Console.ReadLine());
            for (int i = 0; i < count30; ++i)
            { 
                if (chislo30 % i == 0)
                {
                    count30 = count30 + 1;
                }
                else
                {
                    count30 = count30 + 0;
                }
            }
            Console.WriteLine(count30);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 31");

            Console.WriteLine("Введите 4 аргумента кубического уравнения");
            int a666 = int.Parse(Console.ReadLine());
            int b666 = int.Parse(Console.ReadLine());
            int c666 = int.Parse(Console.ReadLine());
            int d666 = int.Parse(Console.ReadLine());

            double per1 = b666 / a666;
            double per2 = c666 / a666;
            double per3 = d666 / a666;

            double vtor1 = -(per1 * per1 / 3) + per2;
            double vtor2 = 2 * per1 * per1 * per1 / 27 - per1 * per2 / 3 + per3;

            double otvet = Math.Pow(-vtor2 / 2, 1 / 3) + Math.Sqrt(vtor2 / 4) + vtor1 * vtor1 * vtor1 / 27 + Math.Pow(-vtor2 / 2, 1 / 3) + Math.Sqrt(vtor2 / 2) + vtor1 / 9;

            // это я смог найти формулу, но дальше предлагается подбор я крутил огромное количество вариантов через циклы но ничего не получалось, чатгпт предлагает совсем другое решение непонятное мне,
            // когда я ему подсунул свое и предложил продолжить то ничего не получалось ( нормально гпт не умею пользоватьяс

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 32");

            int n32 = int.Parse(Console.ReadLine());
            int a32 = 2;
            int b32 = 6;
            int razn = b32 - a32;
            Console.WriteLine(razn * n - 2);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 33");

            string student = "студент";
            string pens = "пенсионер";
            string trud = "трудоустроен";

            Console.WriteLine("Если вы относитесь к одной из этих групп напишите пожалуйста название, если не относитесь то добавте не: 'студент','пенсионер','трудоустроен', в таком же порядке ");
            string studotv = Console.ReadLine();
            string pensotv = Console.ReadLine();
            string trudotv = Console.ReadLine();
            int a33 = 0;
            int b33 = 0;
            int c33 = 0;
            if (student == studotv)
            {
                 a33 = 1;
            }
            else
            {
                 a33 = 0;
            }
            if (pens == pensotv)
            {
                 b33 = 1;
            }
            else
            {
                 b33 = 1;
            }
            if (trud == trudotv)
            {
                 c33 = 1;
            }
            else
            {
                 c33 = 0;
            }
            if ((( a33 == 1 || b33 == 1) && c33 != 1) && (a33 + b33) != 2)
            {
                Console.WriteLine("дадут кредит");
            }
            else
            {
                Console.WriteLine("Не дадут кредит");
            }

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 34");

            Console.WriteLine("Введите пожалуйста свое имя");
            string imya = Console.ReadLine();
            Console.WriteLine(imya);
            Console.Write("Привет!");
            Console.WriteLine(imya);

            Console.WriteLine(qwe);
            Console.WriteLine("Задание номер 35");
            
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string imya35 = Console.ReadLine();
            Console.Write("Приыет! ");
            Console.WriteLine(imya35);
            Console.ReadLine();
            Console.WriteLine("да");
            Console.ReadLine();
            Console.WriteLine("нет"); 
            

            StartTimer();

            Console.ReadLine();


        }   
        static void StartTimer()
        {
            Task.Run(async () =>
            {
                await Task.Delay(5000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("но могу показать");
                Console.ResetColor();

                Console.WriteLine(qwe);
                Console.WriteLine("Задание номер 36");
                Console.ReadKey();
            });
        }
        



    }

}
