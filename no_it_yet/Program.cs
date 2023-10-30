using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no_it_yet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine("-------");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("press any key to exit");
            Console.ReadKey(true);

            // single weapon;
            // weapon ammo ammount;
            //int ammo;
            //fire();
            //Reload();
            //range check (0. .50);


            // multiple weapons
            // weapon ammo (for all weapons)
            // -pistol
            // -shotgun
            // spreader
            // rocket launcher

            //int pistolAmmo;

            // int shotGunAmmo;

            // int spreaderAmmo;

            // int rocketLauncherAmmo;

            // string currentWeapon;

            // int example of string current weapon int currentWeapon and then use an index 0 = pistol, 1 - shotgun, ect

            //fire()

            //if (currentWeapon =="pistol") ...
            //if (currentWeapon =="shotGun") ...

            // (USING MULTIPLE WEAPONS W/ARRAYS)

            int[] ammo;   //this is the declaration
            ammo = new int[4];         //...// instantization (NEW!) make sure there is memory! it could fail

            //...// initalization

            ammo[0] = 0;  // pistol 
            ammo[1] = 0; //shotgun
            ammo[2] = 0; // spreader
            ammo[3] = 0; // rocket launcher
                         // ammo[4] = 0;   this will not work, the count starts at 0 which means there is 4 enterys in the array even when there number value is at 3

            int currentweapon;
            currentweapon = 0; // remember 0 on the array for ammo means the pistol

            //fire(int current weapon)
            // PickUp(int weaponType)



        }
    }
}
