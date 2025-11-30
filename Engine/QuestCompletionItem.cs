using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    internal class QuestCompletionItem
    {
        public Quest Details {  get; set; }
        public int Quantity { get; set; }
        public QuestCompletionItem(Quest details, int quantity) 
        {
            Details = details;
            Quantity=quantity;
        }
    }
}
