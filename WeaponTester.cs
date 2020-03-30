using System;

namespace WeaponShopV20
{
    public class WeaponTester
    {
        public void Run()
        {
            Console.WriteLine("Running Axe Test...");
            TestAxe();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Running Wand Test...");
            TestWand();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Running Sword Test...");
            TestSword();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Running SuperAxe Test...");
            TestSuperAxe();
        }

        private void TestWand()
        {
            Wand myWand = new Wand("Dragonhair");
            UseWeapon(myWand, 5);

            myWand.IsEnchanted = true;
            Console.WriteLine("Enchanted Wand...");
            UseWeapon(myWand, 5);

            myWand.IsEnchanted = false;
            Console.WriteLine("Disenchanted Wand...");
            UseWeapon(myWand, 5);
        }

        private void TestAxe()
        {
            Axe myAxe = new Axe("Redeemer");
            UseWeapon(myAxe, 10);

            myAxe.Sharpen();
            Console.WriteLine("Sharpened Axe...");
            UseWeapon(myAxe, 10);
        }

        private void TestSword()
        {
            Sword mySword = new Sword("Thunderfury");
            UseWeapon(mySword, 10);

            mySword.Sharpen();
            Console.WriteLine("Sharpened Sword...");
            UseWeapon(mySword, 10);
        }

        private void TestSuperAxe()
        {
            SuperAxe mySuperAxe = new SuperAxe("Redeemers Redeemer");
            UseWeapon(mySuperAxe, 10);

            mySuperAxe.Sharpen();
            Console.WriteLine("Sharpened SuperAxe...");
            UseWeapon(mySuperAxe, 10);
        }

        private void UseWeapon(Weapon theWeapon, int noOfUses)
        {
            Console.WriteLine($"Testing Wand {theWeapon.Description}");
            for (int i = 0; i < noOfUses; i++)
            {
                Console.WriteLine($"Damage dealt by {theWeapon.Description}: {theWeapon.DealDamage()}");
            }
            Console.WriteLine();
        }

/*         private void UseAxe(Axe theAxe, int noOfUses)
        {
            Console.WriteLine($"Testing Axe {theAxe.Description}");
            for (int i = 0; i < noOfUses; i++)
            {
                Console.WriteLine($"Damage dealt by {theAxe.Description}: {theAxe.DamageFromAxe()}");
            }
            Console.WriteLine();
        } */
    }
}