using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ampere_uträkning
{
    public partial class Avsäkring : Form
    {
        public Avsäkring()
        {
            InitializeComponent();
        }

        private void Amp_Click(object sender, EventArgs e)  
        {
            try
            {
                decimal disk01 = Convert.ToDecimal(disk1.Text);
                decimal disk02 = Convert.ToDecimal(disk2.Text);
                decimal disk03 = Convert.ToDecimal(disk3.Text);
                decimal disk04 = Convert.ToDecimal(disk4.Text);
                decimal disk05 = Convert.ToDecimal(disk5.Text);
                decimal margin01 = Convert.ToDecimal(margin.Text);

                decimal result = (disk01 + disk02 + disk03 + disk04 + disk05) * margin01;

               
                if (Check_fas.Checked)
                {
                    result = result / 690;
                }

                else
                {
                    result = result / 230;
                }

                if (result < 10)
                {
                    MessageBox.Show("Disken behöver av avsäkrat med 10A säkring");
                }

                if (result >= 10 && (result <13)) 
                {
                    MessageBox.Show("Disken behöver att avsäkras med en 13A säkring");
                }

                if (result > 13 && (result <16))
                {
                    MessageBox.Show("Disken behöver att avsäkras med 16A säkring");
                }


                if (result > 16 && (result < 20))
                {
                    MessageBox.Show("Disken behöver att avsäkras med 20A säkring");
                }

                if (result > 20 && (result < 25))
                {
                    MessageBox.Show("Disken behöver att avsäkras med 25A säkring");
                }

                if (result > 25 && (result <32))
                {
                    MessageBox.Show("Disken behöver avsäkras med 32A säkring ");
                }

                if (result > 32 && (result < 34))
                {
                    MessageBox.Show("Disken behöver avsäkras med 34A säkring ");
                }

                if (result > 34 && (result < 40))
                {
                    MessageBox.Show("Disken behöver avsäkras med 40A säkring ");
                }

                if (result > 40)
                {
                    MessageBox.Show("STOP");
                }

            }
            catch (Exception ex)
            {
                

            }
        }

        private void Amp_Check(object sender, EventArgs e)
        {

        }
    }
}











        
       

        

        
        

        
    



