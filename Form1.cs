using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Void_Companion
{
    public partial class Form1 : Form
    {

        Tower[] towers = new Tower[] { new T1C(), new T2C(), new T3C(), new T4C(), new T1E(), new T2E(), new T3E(), new T4E(), new T1MD(), new T2MD(), new T3MD(), new T4MD()};
        Rotation[] rotations = new Rotation[] { new T1D(), new T2D(), new T3D(), new T4D(), new T1S(), new T2S(), new T3S(), new T4S(), new Int(), new ODD(), new ODS(), new T1Sab(), new T2Sab(), new T3Sab(), new T4Sab() };
        Item[] items = new Item[] { new akbronco(), new ash(), new bo(), new braton(), new bronco(), new burston(), new carrier(), new kamas(), new fang(), new forma(), new hikou(), new kavasa(), new lex(), new loki(), new nikana(), new nova(), new nyx(), new odonata(), new orthos(), new paris(), new saryn(), new scindo(), new soma(), new spira(), new trinity(), new vasto(), new vectis(), new volt(), new wyrm() };

        public Form1()
        {
            InitializeComponent();
        }

        private void cbxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = "";

            if (cbxItem.Text == "Paris Prime")
                lblLocation.Font = new Font(lblRotation.Font.Name, 10, lblRotation.Font.Style, lblRotation.Font.Unit);
            else if (cbxItem.Text == "Forma")
                lblLocation.Font = new Font(lblRotation.Font.Name, 8, lblRotation.Font.Style, lblRotation.Font.Unit);
            else
                lblLocation.Font = new Font(lblTower.Font.Name, 10, lblTower.Font.Style, lblTower.Font.Unit);

            foreach (Item item in items)
            {
                if (cbxItem.Text == item.name)
                {
                    t = item.name.ToUpper() + "\n";

                    for (int i = 0; i < item.pieces.Length; i++)
                    {
                        t += "\n" + item.pieces[i].ToUpper() + "\n";
                        for (int x = 0; x < item.locations[i].Length; x++)
                        {
                            t += item.locations[i][x] + " [" + item.chances[i][x] + "%]\n";
                        }
                    }

                    lblLocation.Text = t;
                }
            }
        }

        private void cbxTower_SelectedIndexChanged(object sender, EventArgs e)
        {
            string t = "";
            foreach (Tower tower in towers)
            {
                if (cbxTower.Text == tower.name)
                {
                    t = tower.name + "\n\n";
                    for (int i = 0; i < tower.items.Length; i++)
                    {
                        t += tower.items[i] + " [" + tower.chance[i] + "%]" + "\n";
                    }
                }
            }

            lblTower.Text = t;
        }

        private void cbxRot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
            string c = "";

            foreach (Rotation tower in rotations)
            {
                if (cbxRot.Text == tower.name)
                {
                    lblRotation.Text = tower.name;

                    a = "Rotation A\n\n";
                    for (int i = 0; i < tower.rotA.Length; i++)
                    {
                        a += tower.rotA[i] + " [" + tower.rotAchance[i] + "%]" + "\n";
                    }

                    b = "Rotation B\n\n";
                    for (int i = 0; i < tower.rotB.Length; i++)
                    {
                        b += tower.rotB[i] + " [" + tower.rotBchance[i] + "%]" + "\n";
                    }

                    c = "Rotation C\n\n";
                    for (int i = 0; i < tower.rotC.Length; i++)
                    {
                        c += tower.rotC[i] + " [" + tower.rotCchance[i] + "%]" + "\n";
                    }

                    lblRotA.Text = a;
                    lblRotB.Text = b;
                    lblRotC.Text = c;
                }
            }
        }
    }
}
