using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        // Backwards-compatible property expected by UI
        public int MaximumHitPoints { get => MaxHitPoints; set => MaxHitPoints = value; }

        public LivingCreature(int maxhitpoints,int currenthitpoints)
        {
            MaxHitPoints= maxhitpoints;
            CurrentHitPoints= currenthitpoints;
        }
    }
}
