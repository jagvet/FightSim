using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fightsimv1
{
    class Fighter
    {
        int hp;

        Random generator = new Random();

        public string name;

        int Attack()
        {
            int minAttack = 5;
            int maxAttack = 20;

            return generator.Next(minAttack, maxAttack);            
        }

        void hurt(int amount)
        {
            hp = hp - amount;

            if(hp <= 0)
            {
                hp = 0;
            }
        }

        bool isAlive()
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

        int GetHp()
        {
            return hp;
        }
    }
}
