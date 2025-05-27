using Pizza_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class PizzaOptions : Form
    {
        public PizzaOptions()
        {
            InitializeComponent();
        }

       float GetSelectedSizeprice()
        {
            if(rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if(rbMedium.Checked)
            {
                 return Convert.ToSingle(rbMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
        }


        float GetSelectedCrust_TypePrice()
        {
            if(rbThin.Checked)
            {
                return Convert.ToSingle(rbThin.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThik.Tag);
            }
        }

        float GetWhereToEatPrice()
        {
            if(rbHome.Checked)
            {
               return Convert.ToSingle(rbHome.Tag);
            }
            else
            {
               return Convert.ToSingle(rbResturant.Tag);
            }
        }

        float GetSelectToppigs()
        {
            float Toppingsprice = 0;
             if (chkCheese.Checked)
             {
                Toppingsprice += Convert.ToSingle(chkCheese.Tag);
             }

             if (chkTomatoes.Checked)
             {
                Toppingsprice += Convert.ToSingle(chkTomatoes.Tag);
             }

             if(chkOnion.Checked)
             {
                Toppingsprice += Convert.ToSingle(chkOnion.Tag);
             }

             if(chkOlives.Checked)
             {
                Toppingsprice += Convert.ToSingle(chkOlives.Tag);
             }

             if(chkGreenPapper.Checked)
             {
                Toppingsprice += Convert.ToSingle(chkGreenPapper.Tag);
             }

             if(chkMushroum.Checked)
             {
                Toppingsprice += Convert.ToSingle(chkMushroum.Tag);
             }
            return Toppingsprice;
        }

        float CalculateTotalPrice()
        {
            return GetSelectedCrust_TypePrice() + GetSelectToppigs() + GetSelectedSizeprice() + GetWhereToEatPrice();
        }

        void UpdateTotalSalary()
        {
            lblSalary.Text = CalculateTotalPrice().ToString();
        }
        
       void updateSize()
        {
            UpdateTotalSalary();
            if(rbSmall.Checked)
            {
                lblSize.Text = "Small Size";
            }
            if(rbMedium.Checked)
            {
                lblSize.Text = "Medium size";
            }
            if (rbLarge.Checked)
            {
                lblSize.Text = "Large size";
            }
        }

        void updateCrust()
        {
            UpdateTotalSalary();
            if(rbThin.Checked)
            {
                lblcrust.Text = "Thin Crust";
            }
            else if(rbThik.Checked)
            {
                lblcrust.Text = "Thik Crust";
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalSalary();
            if(rbHome.Checked)
            {
                lblEat.Text = "In Home";
            }
            else if(rbResturant.Checked)
            {
                lblEat.Text = "In Resturant";
            }
        }
        void updateToppings()
        {
            UpdateTotalSalary();
            string Toppings = "";
            byte toppingsCount = 0;
            if(chkCheese.Checked)
            {
                Toppings += "Extra Cheese ";
                toppingsCount++;
                if(toppingsCount == 3)
                {
                    Toppings += "\n";
                }
            }
            if(chkGreenPapper.Checked)
            {
                Toppings += "Green papper ";
                toppingsCount++;
                if(toppingsCount == 3)
                {
                    Toppings += "\n";
                }

            }
            if(chkMushroum.Checked)
            {
                Toppings += "Mushroum ";
                toppingsCount++;
                if(toppingsCount == 3)
                {
                    Toppings += "\n";
                }

            }
            if(chkOlives.Checked)
            {
                Toppings += "Olives ";
                toppingsCount++;
                if (toppingsCount == 3)
                {
                    Toppings += "\n";
                }
            }
            if(chkOnion.Checked)
            {
                Toppings += "Onion ";
                toppingsCount++;
                if(toppingsCount == 3)
                {
                    Toppings += "\n";
                }
            }
            if (chkTomatoes.Checked) 
            {
                Toppings += "Tomatous ";
                toppingsCount++;
                if(toppingsCount == 3)
                {
                    Toppings += "\n";
                }
            }
            if (Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }

            if (Toppings == "")
                Toppings = "No Toppings";



            lblToppings.Text = Toppings;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Confirme Message", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("User enter OK");
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhere.Enabled = false;
                gbOrderSummary.Enabled = true;
                gbcrust.Enabled = false;

            }
            else
            {
                MessageBox.Show("User enter Cancel");
            }
        }


        void UpdateTotalPrice()
        {
            lblSalary.Text = "$" +  CalculateTotalPrice().ToString();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhere.Enabled = true;
            gbOrderSummary.Enabled = true;
            gbcrust.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Close ?", "Close program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("User enter OK");
                this.Close();
            }
            else
            {
                MessageBox.Show("User enter Cancel");

            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Small_Piza;
            label9.Text = "Small Pizza";
            updateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Medium_Pizza;
            label9.Text = "Medium Pizza";
            updateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Lar_3;
            label9.Text = "Large Pizza";
            updateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Thin_Pizza;
            label9.Text = "Thin Pizza";
            updateCrust();
        }

        private void rbThik_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Thik_pizza;
            label9.Text = "Thik Pizza";
            updateCrust();
        }

        private void rbHome_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.InHome;
            label9.Text = "Eat In Home";
            UpdateWhereToEat();
        }

        private void rbResturant_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.InResturant;
            label9.Text = "Eat In Resturant";
            UpdateWhereToEat();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Cheese;
            label9.Text = "Cheese";
            updateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Onion;
            label9.Text = "Onion";
            updateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Tommatos;
            label9.Text = "Tommatoes";
            updateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Olives;
            label9.Text = "Olives";
            updateToppings();
        }

        private void chkMushroum_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Mushroum;
            label9.Text = "Mushroum";
            updateToppings();
        }

        private void chkGreenPapper_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Green_Papper;
            label9.Text = "Green Papper";
            updateToppings();
        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        bool IsValidOrder()
        {
            if (rbSmall.Checked != true && rbMedium.Checked != true && rbLarge.Checked != true)
            {
                MessageBox.Show("Please choose a size!", "Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rbSmall.Checked != true && rbMedium.Checked != true)
            {
                MessageBox.Show("Please choose a crust type!", "Crust Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rbSmall.Checked != true && rbMedium.Checked != true)
            {
                MessageBox.Show("Please choose where to eat!", "Where To Eat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rbSmall.Checked != true && rbMedium.Checked != true && rbLarge.Checked != true && chkOnion.Checked != true && chkOlives.Checked != true && chkGreenPapper.Checked != true)
            {
                MessageBox.Show("Please choose Toppings!", "Toppings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                byte ChoosedToppings = 0;

                if (chkCheese.Checked == true) { ChoosedToppings++; }
                if (chkGreenPapper.Checked == true) { ChoosedToppings++; }
                if (chkOlives.Checked == true) { ChoosedToppings++; }
                if (chkOnion.Checked == true) { ChoosedToppings++; }
                if (chkTomatoes.Checked == true) { ChoosedToppings++; }
                if (chkMushroum.Checked == true) { ChoosedToppings++; }

                if (ChoosedToppings < 3)
                {
                    MessageBox.Show("Please at least choose 3 Toppings!", "Toppings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = numericUpDown1.Text.ToString();
        }

        
    }
}
