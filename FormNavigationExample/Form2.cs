using System;
using System.Windows.Forms;

namespace FormNavigationExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShowForm1Button_Click(object sender, EventArgs e)
        {
            var FormOne = (Form1)Tag;
            FormOne.Show();
            Close();
        }
    }
}
