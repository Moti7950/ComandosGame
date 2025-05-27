using System;

public class Weapon
{
    public string NameGun;
    public string ManuFactor;
    public int AmmunitionQuantity;
    public Weapon(string NameGun, string ManuFactor, int AmmunitionQuantity)
    {
        this.NameGun = NameGun;
        this.ManuFactor = ManuFactor;
        this.AmmunitionQuantity = AmmunitionQuantity;
    }

    
    public void Shoot()
    {
        if (AmmunitionQuantity<=0)
        {
            Console.WriteLine("NO ammunition!");
        }
        else
        {
            AmmunitionQuantity -= 1;
            Console.WriteLine($"AmmunitionQuantity: {AmmunitionQuantity}");
        }
    }
}