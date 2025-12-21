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

        // Helper methods used by the UI
        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            if (location == null)
                return false;

            // If no item is required, player can enter
            if (location.ItemRequired == null)
                return true;

            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == location.ItemRequired.ID && ii.Quantity > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasThisQuest(Quest quest)
        {
            foreach (PlayerQuest pq in Quests)
            {
                if (pq.Details.ID == quest.ID)
                    return true;
            }
            return false;
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach (PlayerQuest pq in Quests)
            {
                if (pq.Details.ID == quest.ID)
                    return pq.IsCompleted;
            }
            return false;
        }

        public bool HasAllQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool found = false;
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        if (ii.Quantity >= qci.Quantity)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                    return false;
            }
            return true;
        }

        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qci.Details.ID)
                    {
                        ii.Quantity -= qci.Quantity;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory(Item item)
        {
            bool added = false;
            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == item.ID)
                {
                    ii.Quantity++;
                    added = true;
                    break;
                }
            }
            if (!added)
            {
                Inventory.Add(new InventoryItem(item, 1));
            }
        }

        public void MarkQuestCompleted(Quest quest)
        {
            foreach (PlayerQuest pq in Quests)
            {
                if (pq.Details.ID == quest.ID)
                {
                    pq.IsCompleted = true;
                    break;
                }
            }
        }
    }
}
