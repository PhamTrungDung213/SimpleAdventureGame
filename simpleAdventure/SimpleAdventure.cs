using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace simpleAdventure
{
    public partial class SimpleAdventure : Form
    {
        private Player p1;

        public SimpleAdventure()
        {
            InitializeComponent();

            p1 = new Player(10,20,5,50,2);

            lbHitPoints.Text=p1.CurrentHitPoints.ToString();
            lbGold.Text=p1.Gold.ToString();
            lbExp.Text=p1.ExpPoints.ToString();
            lbLevel.Text = p1.Level.ToString();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
