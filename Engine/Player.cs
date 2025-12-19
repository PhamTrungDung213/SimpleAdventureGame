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
        public int ExperiencePoints { get; set; }
        [Obsolete("Use ExperiencePoints instead")]
        public int ExpPoints { get => ExperiencePoints; set => ExperiencePoints = value; }
        public int Level { get; set; }
        public Location CurrentLocation { get; set; }

        public List<PlayerQuest> Quests { get; set; }
        public List<InventoryItem> Inventory { get; set; } 
        public Player(int maxhitpoints,int currenthitpoints,int gold,int exppoints,int level):base(maxhitpoints,currenthitpoints)
        {
            Gold= gold; 
            ExperiencePoints = exppoints; 
            Level = level;

            Quests= new List<PlayerQuest>();
            Inventory = new List<InventoryItem>();
        }
    }
}
