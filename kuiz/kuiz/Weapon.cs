using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuiz
{
    internal class Weapon
    {


        public Weapon(int tutum, int darag)
        {
            Darag = darag;
            gulleNum = tutum;
            Avtomatik = false;
        }

        private int darag;
        public bool Avtomatik;
        public int Darag
        {
            get
            {
                return darag;
            }


            set
            {
                if(value>0)
                {
                    darag = value;
                }
            }
        }

        private int gulleNum;
        public int GulleNum
        {
            get { return gulleNum; }
            set
            {
                if (value > 0 && value < Darag)
                {
                    gulleNum = value;
                }
            }
        }








        public void Shoot()
        {
            if (Darag <= 0)
            {
                Console.WriteLine("daragda gulle yoxdu");

            }
            else if (Avtomatik)
            {
                Console.WriteLine("butun gulleler atildi");
                gulleNum = 0;
            }
            else
            {
                Console.WriteLine("tekli atis basladi");
                gulleNum--;

            }

        }
        public int GetRemainBulletCount()
        {
            return Darag - gulleNum;
        }
        public void Reload()
        {
            Darag = gulleNum;
            Console.WriteLine("darag dolduruldu");
        }
        public void ChangeMode()
        {
            if (Avtomatik)
            {
                Avtomatik = false;
                Console.WriteLine("silah tekli moda kecirildi");
            }
            else
            {
                Avtomatik=true;
                Console.WriteLine("silah avtomatik moda kecirildi");
            }

        }
    }


}
