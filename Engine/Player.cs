using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player:LivingCreature
    {
        public int Gold { get; set; }
        public int ExpPoints { get; set; }
        public int Level { get; set; }
        
        public List<PlayerQuest> Quests { get; set; }
        public List<InventoryItem> Inventory { get; set; } 
        public Player(int maxhitpoints,int currenthitpoints,int gold,int exppoints,int level):base(maxhitpoints,currenthitpoints)
        {
            Gold= gold; 
            ExpPoints = exppoints; 
            Level = level;

            Quests= new List<PlayerQuest>();
            Inventory = new List<InventoryItem>();
        }
    }
}
