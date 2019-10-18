using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fightsimv1
{
    class Fighter
    {
        public int hp = 100;

        static Random generator = new Random();

        public string name;

        public int Attack()
        {
            int minAttack = 5;
            int maxAttack = 20;

            return generator.Next(minAttack, maxAttack);            
        }

        public void Hurt(int amount)
        {
            hp = hp - amount;

            if(hp <= 0)
            {
                hp = 0;
            }
        }

        public bool isAlive()
        {
            if(hp == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetHp()
        {
            return hp;
        }
    }
}
