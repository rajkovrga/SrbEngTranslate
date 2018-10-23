using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EnglishTranslate
{
    public partial class Form1 : Form
    {

        private static int Global1;
        private static int Global2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            string[] file;
            try
            {
                file = File.ReadAllLines(@"../../translate.txt");
            }
            catch (FileNotFoundException er)
            {
                MessageBox.Show(er.ToString());
                return;
            }
            catch(IOException er)
            {
                MessageBox.Show(er.ToString());
                return;

            }
            catch (UnauthorizedAccessException er)
            {
                MessageBox.Show(er.ToString());
                return;

            }

            Translate tr = new Translate(word);
            foreach (string line in file)
                {

                    Global1 = tr.TranslaterEng(line.Split('-')[0]);
                    Global2 = tr.TranslaterSrb(line.Split('-')[1]);
                    if (Global1 == 1)
                    {
                        textBox2.Text = line.Split('-')[1];
                        return;
                    }
                    else if (Global2 == 1)
                    {
                        textBox2.Text = line.Split('-')[0];
                        return;
                    }
                    else
                    {
                        textBox2.Text = "Ne postoji uneta rec";
                        return;
                    }


                }
          
           
           
           
        }

       
    }
}
