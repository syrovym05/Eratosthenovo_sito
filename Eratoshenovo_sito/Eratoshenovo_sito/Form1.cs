using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eratoshenovo_sito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Eratosthenovo síto";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);

                listBox1.Items.Clear();


                bool[] rada = new bool[n + 1];

                for (int i = 2; i < n + 1; i++)
                {
                    rada[i] = true;
                }

                for (int i = 2; i < n + 1; i++)
                {
                    if (rada[i])
                    {
                        listBox1.Items.Add(i);
                        for (int j = i + i; j < n + 1; j += i)
                        {
                            rada[j] = false;
                        }
                    }

                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
