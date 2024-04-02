using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Weapon
    {
        public int BulletCapacity;
        public int Bullets;
        public int DischargeSecond;
        public bool FireMode;


        public Weapon(int bulletcapacity, int bullets, int dischargesec, bool mode)
        {
            BulletCapacity = bulletcapacity;
            Bullets = bullets;
            DischargeSecond = dischargesec;
            FireMode = mode;
        }
        public void Shoot()
        {
            if (!FireMode)
            {
                if (Bullets > 0)
                {
                    Bullets--;
                    Console.WriteLine("Pew Pew" + "\nBullets Remain:" + $"{Bullets}");
                }
                else
                {
                    Console.WriteLine("Empty");
                }
            }
            else
            {
                Console.WriteLine("You have to change to single mode");
            }

        }
        public void Fire()
        {
            if (FireMode)
            {
                if (Bullets > 0)
                {
                    Console.WriteLine($"Pew pew pew.. ({Bullets} bullets fired)");
                    Bullets = 0;
                }
                else
                {
                    Console.WriteLine("You dont have any bullets");
                }
            }
            else
            {
                Console.WriteLine("You have to change to Auto mode");
            }


        }
        public int Capacity
        {
            get => BulletCapacity - Bullets;
        }
        public void Reload()
        {
            /*if (Bullets == BulletCapacity)
            {
                Console.WriteLine("Full bullets");
                return;
            }
            else
            {
                Bullets = BulletCapacity;
            }*/
            if (Bullets < BulletCapacity)
            {
                Bullets = BulletCapacity;
                Console.WriteLine("Reloading");
            }
            else
            {
                Console.WriteLine("Full bullets");
            }
        }

        public bool Mode()
        {
            FireMode = !FireMode;
            Console.WriteLine("Fire mode changed:" + FireMode);
            return false;
        }

        public void ChangeCapacity(int newcapacity)
        {
            if (Bullets > newcapacity)
            {
                Bullets = 0;
                Console.WriteLine("All bullets are removing");
                Console.WriteLine($"New Capacity is{newcapacity}");
            }
            else
            {
                BulletCapacity = newcapacity;
                Console.WriteLine($"New capacity number is {newcapacity}");
            }
        }

        public void NewBullets(int newbullets)
        {
            if (newbullets <= BulletCapacity)
            {
                Bullets = newbullets;
                Console.WriteLine($"New bullet is:{newbullets}");

            }
            else
            {
                Console.WriteLine("Bullets cant bigger than capacity");
            }
        }

        public void NewTime(int newtime)
        {
            DischargeSecond = newtime;
            Console.WriteLine($"New Discharge Second is {newtime}");
        }
    }

}
