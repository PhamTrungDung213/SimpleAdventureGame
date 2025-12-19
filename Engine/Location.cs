using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description {  get; set; }
        public Item ItemRequired {  get; set; }
        [Obsolete("Use ItemRequired instead")]
        public Item ItemRequiredToEnter { get => ItemRequired; set => ItemRequired = value; }
        public Quest QuestAvailable { get; set; }
        [Obsolete("Use QuestAvailable instead")]
        public Quest QuestAvailableHere { get => QuestAvailable; set => QuestAvailable = value; }
        public Monster MonsterHere { get; set; }
        [Obsolete("Use MonsterHere instead")]
        public Monster MonsterLivingHere { get => MonsterHere; set => MonsterHere = value; }

        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id,string name,string description,
               Item itemrq=null,Quest questa = null,Monster monsterh = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequired = itemrq;
            QuestAvailable = questa;
            MonsterHere = monsterh;
        }
    }
}
