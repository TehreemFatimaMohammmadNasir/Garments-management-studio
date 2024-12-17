using System;
using System.Windows.Forms;

namespace garments_management_sytem
{
    public partial class NewOrder : Form 
    {
        public NewOrder()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
          
            user_client_order clientOrderControl = new user_client_order();

          
            clientOrderControl.Dock = DockStyle.Fill;

            this.Controls.Clear();
            this.Controls.Add(clientOrderControl);

            
            this.Text = "Client Order Page";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 3 clicked!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 4 clicked!");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 5 clicked!");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 6 clicked!");
        }

        
        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 7 clicked!");
        }

       
        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 8 clicked!");
        }

        
        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 9 clicked!");
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
