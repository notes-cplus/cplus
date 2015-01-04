using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus
{
    public partial class UserControltime : UserControl
    {
        public UserControltime()
        {
            InitializeComponent();
        }
        private int hour;

        public int Hour
        {
            get {
                int h;
                int.TryParse(textBox1.Text,out h);
                return h;
            }
            set {
                textBox1.Text = value + "";
            }
        }
        private int min;

        public int Min
        {
            get
            {
                int r;
                int.TryParse(textBox2.Text, out r);
                return r;
            }
            set
            {
                textBox2.Text = value + "";
            }
           
        }

        public void sethour(int hour,int min)
        {
            this.hour = hour;
            this.min = min;
        }




        private void UserControltime_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
