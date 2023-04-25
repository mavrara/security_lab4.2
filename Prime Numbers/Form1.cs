using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Prime_Numbers
{
    public partial class Form1 : Form
    {
        bool working = false;
        int minN = 0;
        int maxN = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsPrime(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0).SequenceEqual(new[] { 1, n });
            }

            return false;
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (!working) {
                try
                {
                    working = true;
                    maxN = int.Parse(maxNumber.Text);
                    minN = int.Parse(textBox1.Text);
                    results.Text = "";
                    progress.Maximum = maxN;
                    for (int i = minN; i <= maxN; i++)
                    {
                        Form1.ActiveForm.Update();
                        progress.Value = i;
                        if (IsPrime(i))
                        {
                            Console.WriteLine(i + " Просте число");
                            results.Text += i + "\r\n";
                            results.Update();
                        }
                        else
                        {
                            Console.WriteLine(i + " Не просте число");
                        }
                    }
                    working = false;
                }
                catch (Exception ex)
                {
                    progress.Value = 0;
                    working = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
