using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Strandbal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Strandbal balA = new Strandbal();

        private void button1_Click(object sender, EventArgs e)
        {
            if (balA.Verderopblazen(balA.bal) == true)
            {
                this.Invalidate();
                this.Refresh();
                balA.bal += 50.0;
                draw();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw();
        }

        public void draw()
        { 
            Graphics dc = this.CreateGraphics(); ;
            Pen Redpen = new Pen(Color.Blue, 2);
            dc.DrawEllipse(Redpen, 300, 130, Convert.ToInt32(balA.bal), Convert.ToInt32(balA.bal));
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            draw();
        }
    }
}
