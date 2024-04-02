using ConsoleApp1.Models;

namespace ConsoleApp1;
internal class Program
{
    static void Main()
    {
        {
            Start();
        }
    }
    static void Start()
    {
        Weapon weapon = new Weapon(30, 0, 0, true);

        while (true)
        {
        Restart:
            Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot(Only in Single Mode) metodu üçün\r\n2 - Fire(Only in Auto Mode) metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün\r\nqısayoldur.\n7 - Redakte et :");
            string input = Console.ReadLine();

            if (input == "6")
                break;
            switch (input)
            {
                case "0":
                    Console.WriteLine($"Bullets:{weapon.Bullets} \nFire Mode(True->Auto,False->Single):{weapon.FireMode}\nCapacity:{weapon.BulletCapacity}\nDischarge Second:{weapon.DischargeSecond}");
                    break;
                case "1":
                    weapon.Shoot();
                    break;
                case "2":
                    weapon.Fire();
                    break;
                case "3":
                    Console.WriteLine($"You need to {weapon.Capacity} bullets to fill full");
                    break;
                case "4":
                    weapon.Reload();
                    break;
                case "5":
                    weapon.Mode();
                    break;
                case "7":
                    NewWeapon(weapon);
                    break;

                default:
                    Console.WriteLine("Choose Right Number");
                    break;
            }
            Console.WriteLine("Press any key to clear . . .  ");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public static void NewWeapon(Weapon weapon)
    {
        while (true)
        {
            Console.WriteLine("T - Capacity Change\r\nS - Number of Bullets\r\nD - Discharge Second\nR-Return to Menu");
            string input = Console.ReadLine().ToUpper();

            Console.Clear();
            switch (input)
            {
                case "T":
                    Console.WriteLine("Enter new capacity");
                    int newcapacity = Convert.ToInt32(Console.ReadLine());
                    weapon.ChangeCapacity(newcapacity);
                    break;
                case "S":
                    Console.WriteLine("Enter new bullets number");
                    int newbullet = Convert.ToInt32(Console.ReadLine());
                    weapon.NewBullets(newbullet);
                    break;
                case "D":
                    Console.WriteLine("Enter new time");
                    int newtime = Convert.ToInt32(Console.ReadLine());
                    weapon.NewTime(newtime);
                    break;
                case "R":
                    /*Start();*/
                    /*goto Restart;*/
                    return;
            }
        }
    }
}
