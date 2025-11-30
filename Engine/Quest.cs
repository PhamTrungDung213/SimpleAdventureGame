using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExpPoints { get; set; }
        public int RewardGold { get; set; }
        public Item ItemReward { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int id,string name,string description,int rewardexppoints,int rewardgold,Item itemrw = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExpPoints = rewardexppoints;
            RewardGold = rewardgold;
            ItemReward = itemrw;

            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
