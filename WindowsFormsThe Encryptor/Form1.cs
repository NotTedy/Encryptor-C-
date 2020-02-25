using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsThe_Encryptor
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// implementerar min ssamlingsklass för alla mina chipers.
        /// </summary>
        private SamlingChiper samling = new SamlingChiper();

        /// <summary>
        /// fösrta sidan är för alla objekt, samt metoden för alla chiffers som samllas
        /// </summary>
        public Form1()
        {
           
            InitializeComponent();

            PopulateCipherBox();

            
        }

        /// <summary>
        /// knappen för att encrypta min input i textbox1.
        /// om encrypt knappen har tryckts på engång, då funkar den inte förs en decrypt har tryckts på. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //foreach (Chiper x in listBox2Chosen.Items)
            //{
            //    textBox1.Text = x.Encrypt(textBox1.Text);
            //}

            textBox1.Text = samling.Encrypt(textBox1.Text);
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = true;
        }

        /// <summary>
        /// knappen för att decrypta min input i textbox1.
        /// om decrypt knappen har tryckts på engång, då funkar den inte förs en encrypt har tryckts på. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //foreach (Chiper item in listBox2Chosen.Items)
            //{
            //    textBox1.Text = item.Decrypt(textBox1.Text);
            //}

            textBox1.Text = samling.Decrypt(textBox1.Text);
            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = false;

        }

        /// <summary>
        /// metoden som visar alla mina chipers i listBox1Display.
        /// </summary>
        private void PopulateCipherBox()
        {
            listBox1Display.Items.Add(new ReversalChiper());
            listBox1Display.Items.Add(new CaesarChiper(3));
            listBox1Display.Items.Add(new CaesarChiper(5));
            listBox1Display.Items.Add(new OddAndEvenChipher());
            listBox1Display.Items.Add(new RövarSpråketChiper());
        }

        /// <summary>
        /// använder sig av dd metoden i salmligsklassen, för alla chiphers som används
        /// samt lägger till alla chipers i listBox2chosen så fort man trycker på btnAdd.
        /// try-catch för Add-knappen för att undvika att programmet krachar när man trycker på Add-knappen utan att lägga tilll ett chiper.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            samling.Add((Chiper)listBox1Display.SelectedItem);
            try
            {
                
                listBox2Chosen.Items.Add(listBox1Display.SelectedItem);
               
            }
            catch (Exception)
            {

                MessageBox.Show("Error, choose chipers!");
            }
            
        }

        /// <summary>
        /// samma som btn add fast när man tar bort en chiper från listBox2Chosen
        /// så decrypar den tilll den kvarstående chiphern eller orginal strängen,
        /// beroende på hur många chipers man använder.
        /// try-catch på Remove knappen för att undvika att programmet kraschar när man inte har något chiffer att lägga till.
        /// innuti try-catch finns en if-sats som säger att om det inte finns några valda chiffers att ta bort då kan man decrypta texten som finns i textbox1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != null)
                {
                    textBox1.Text = samling.Decrypt(textBox1.Text);
                }
                 
                
                
                samling.Remove((Chiper)listBox2Chosen.SelectedItem);
                listBox2Chosen.Items.Remove(listBox2Chosen.SelectedItem);
   
                textBox1.Text = samling.Encrypt(textBox1.Text);
              
            }
            catch (Exception)
            {

                MessageBox.Show("Error, choose chipers!");
            }
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
