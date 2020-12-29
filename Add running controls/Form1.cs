using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_running_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < 5; i++)
            {
                //Create a class with control type
                Button RunningButton = new Button();

                //Add properties
                RunningButton.Size = new Size(100, 22);
                RunningButton.Location = new Point(20, (25 * i));
                RunningButton.Name = "Button" + i;
                RunningButton.Text = "Button " + i;
                RunningButton.TextAlign = ContentAlignment.MiddleCenter;
                RunningButton.FlatStyle = FlatStyle.Flat;

                //Add control to form
                Controls.Add(RunningButton);

                //Add CLick event
                RunningButton.Click += new EventHandler(ButtonEvent);
            }

        }

        private void ButtonEvent(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Text.ToString());
        }

    }
}
