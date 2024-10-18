using System.Reflection;

namespace kuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tutumu daxil edin : ");
            string input1 = Console.ReadLine();
            
            bool choose1 = int.TryParse(input1, out  int tutum);
            if (choose1)
            {
                tutum = int.Parse(input1);
            }
            else
            {
                Console.WriteLine("reqem daxil ele de teker");
            }

            Console.WriteLine("darak daxil edin");
            string input2 = Console.ReadLine();
            bool choose2 = int.TryParse(input2, out int darak);
            if (choose2)
            {
                darak = int.Parse(input2);
            }
            else
            {
                Console.WriteLine("reqem daxil ele de teker");
            }
            Weapon weapon = new Weapon(tutum , darak);

            do  
            {
                Console.WriteLine(" 0 - informasiyani daxil edin");
                Console.WriteLine("1 -  Shot metodu ucun");
                Console.WriteLine("2 - GetRemaniBullet ucun");
                Console.WriteLine("3 - Reload ucun");
                Console.WriteLine("4 - change mod ucun");
                Console.WriteLine("5 - proqrami dayandirmaq ucun");
                string input = Console.ReadLine();

                bool choose = int.TryParse(input, out int result);
                if (choose)
                {
                    result = int.Parse(input);  
                }
                else
                {
                    Console.WriteLine("reqem daxil ele de teker");
                }

                
                    int secim=int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 0:
                        Console.WriteLine("daragda olan gulle sayi" + tutum + "daragda qalan gulle sayi" + weapon.GetRemainBulletCount());
                        break;

                    case 1:
                        weapon.Shoot();
                        break;

                    case 2:
                        Console.WriteLine("daragin tam dolmasi ucun lazim olan gulle sayi : " + weapon.GetRemainBulletCount());
                        break;

                    case 3:
                        weapon.Reload();
                        break;

                    case 4:
                        weapon.ChangeMode();
                        break;

                    case 5:
                        Console.WriteLine("Proqram dayandirilir");
                        break;

                    
                        

                     
                    default: 
                        Console.WriteLine("ne ise duzgun getmedi verilenleri duzgun daxil edin");
                        return;


                }

            }while (true);
        }
    }
}
