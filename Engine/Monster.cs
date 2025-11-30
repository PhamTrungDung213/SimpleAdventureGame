using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster:LivingCreature
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int RewardExpPoints {  get; set; }
        public int RewardGold {  get; set; }

        public Monster(int id,string name,int maxhitpoints,int currenthitpoints,int maxdamage,int rewardexppoints,int rewardgold):base(maxhitpoints,currenthitpoints)
        {
            ID=id; 
            Name=name; 
            MaxDamage=maxdamage;
            RewardExpPoints=rewardexppoints;
            RewardGold=rewardgold;
        }
    }
}
