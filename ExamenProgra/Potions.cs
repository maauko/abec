using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra
{
    class Potions : IshowData
    {
<<<<<<< HEAD
        float health
        public Potions(float health) 
        {
            this.health = health;
=======
        float Heal;
        public Potions(float Heal) 
        {
            this.Heal = Heal;
>>>>>>> 2f0ad356f176b9551133f6420ba983feba7a964a
        }

        public string ShowData()
        {
<<<<<<< HEAD
            return $"{health}"
=======
            return $"{Heal}";
>>>>>>> 2f0ad356f176b9551133f6420ba983feba7a964a
        }
    }
}
