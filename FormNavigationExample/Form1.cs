using System;
using System.Windows.Forms;

namespace FormNavigationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForm2Button_Click(object sender, EventArgs e)
        {
            Form2 FormTwo = new Form2
            {
                Tag = this
            };
            FormTwo.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
