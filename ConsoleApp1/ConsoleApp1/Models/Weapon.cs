using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Weapon
    {
        private int BulletCapacity;
        private int Bullets;
        private int DischargeSecond;
        private bool FireMode;


        public Weapon(int bulletcapacity, int bullets, int dischargesec, bool mode)
        {
            BulletCapacity = bulletcapacity;
            Bullets = bullets;
            DischargeSecond = dischargesec;
            FireMode = mode;
        }
        /*public int Shoo
        {
            get => BulletCapacity;
            set
            {

            }
        }*/
        public void Shoot()
        {

            if (Bullets > 0)
            {
                Bullets--;
                Console.WriteLine("Pew Pew");
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }

}
