using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandosGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SoliderStatus S1 = new SoliderStatus("Moti", "1", "Walk");
            Dictionary<Commando, Weapon> S1 = new Dictionary<Commando, Weapon>();
            
            Weapon SWeapon = new Weapon("Glok", "Ostri", 5);
            Commando SInfo = new Commando("Moti", "1", "Walk",SWeapon);
            S1.Add(SInfo,SWeapon);
            SInfo.Attack();
            
            
      
            //foreach (var c in S1.Keys)
            //{
            //    S1[c].Shoot();
            //    c.Attack(x);
                
            //}

           
        }
    }
}
