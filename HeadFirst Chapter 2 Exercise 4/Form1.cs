using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirst_Chapter_2_Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if (enableCheckBox.Checked == true)
            {
                if (labelToChange.TextAlign == ContentAlignment.MiddleCenter
                || labelToChange.TextAlign == ContentAlignment.MiddleRight)
                {
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                    labelToChange.Text = "Left";
                }
                else
                {
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                    labelToChange.Text = "Right";
                }
            }
            else
            {
                labelToChange.Text = "Text changing is disabled";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
