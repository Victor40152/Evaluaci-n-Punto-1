using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprom_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, not4, not5, total;
            not1 = double.Parse(txtnot1.Text);
            not2 = double.Parse(txtnot2.Text);
            not3 = double.Parse(txtnot3.Text);
            not4 = double.Parse(txtnot4.Text);
            not5 = double.Parse(txtnot5.Text);
            total = ((not1 + not2 + not3 + not4 + not5) / 5);
            lblprom.Text = total.ToString();

            if (total <= 1)
            {
                MessageBox.Show("Reprueba la materia sin lograr realizar proceso de recuperación.");


            }
            else
            {

                if (total <= 2.9)
                    MessageBox.Show("Reprueba la materia y puede hacer la habilitación");

                else
                {
                    if (total <= 3.9)
                        MessageBox.Show("Aprueba la materia con plan de mejora");



                    else

                    {
                        if (total <= 4.5)
                            MessageBox.Show("Buen rendimiento");


                        else
                        {

                            if (total <= 4.9)
                                MessageBox.Show("Excelente");

                            else
                            {
                                MessageBox.Show("Graduado con honores");

                            }

                        }
                    }
                }
            }
        }
    }
}


               
                
            
            
            
                
            
            
            
                
            
                
            
            
        
        
    

