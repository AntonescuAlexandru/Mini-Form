using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            checkBox10.Visible = false;
           

            this.textBox1.Validating += new CancelEventHandler(this.txtCasetaGoala_Validare1);
            this.textBox2.Validating += new CancelEventHandler(this.txtCasetaGoala_Validare2);
            this.textBox3.Validating += new CancelEventHandler(this.txtCasetaGoala_Validare3);
            textBox4.KeyPress += new KeyPressEventHandler(textBox4_KeyPresss);
            textBox4.KeyPress += new KeyPressEventHandler(amount_PaidTextBox_KeyPress);
            textBox4.Validating += new CancelEventHandler(txtCasetaGoala_Validare4);
            this.groupBox1.Validating += new CancelEventHandler(this.Validare5);
            this.groupBox2.Validating += new CancelEventHandler(this.Validare6);

            
       
        }
        private void txtCasetaGoala_Validare1(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length < 4)
            {
               // MessageBox.Show("Your name must contain at least 4 letters");
                tb.Tag = false;
                checkBox5.Visible = false;
                checkBox5.Checked = false;
            }
            else
            {
                tb.Tag = true;
                checkBox5.Visible = true;
                checkBox5.Checked = true;
            }
        }
        private void txtCasetaGoala_Validare2(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender; 
            if (tb.Text.Length < 2)
            {
              //  MessageBox.Show("Your function must contain at least 2 letters");
                tb.Tag = false;
                checkBox6.Visible = false;
                checkBox6.Checked = false;
            }
            else
            {
                tb.Tag = true;
                checkBox6.Visible = true;
                checkBox6.Checked = true;
            }
        }
        private void txtCasetaGoala_Validare3(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length < 20)
            {
                //MessageBox.Show("Your name must contain at least 20 letters");
                tb.Tag = false;
                checkBox7.Visible = false;
                checkBox7.Checked = false;
            }
            else
            {
                tb.Tag = true;
                checkBox7.Visible = true;
                checkBox7.Checked = true;
            }
        }

        private void textBox4_KeyPresss(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            
           // if (textBox4.Text.Length>2)
            //{
               
                e.Handled = true;
           // }

        }
        private void amount_PaidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && (e.KeyChar != '\b');
        }
        
        private void txtCasetaGoala_Validare4(object sender, CancelEventArgs e)
        {
            
             if (textBox4.Text.Length == 0||textBox4.Text.Length>=3)
             {
                //MessageBox.Show("Your age must contain a number between 1-100");
                 textBox4.Tag = false;
                 checkBox8.Visible = false;
                 checkBox8.Checked = false;
             }
             else
             {
                 textBox4.Tag = true;
                 checkBox8.Visible = true;
                 checkBox8.Checked = true;
             }
        }
        private void Validare5(object sender, CancelEventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                checkBox9.Visible = true;
                checkBox9.Checked = true;
            }
            else
            {
                //MessageBox.Show("You must check your gender");
                checkBox9.Visible = false;
                checkBox9.Checked = false;
            }
        }
        private void Validare6(object sender, CancelEventArgs e)
        {

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
            {
                checkBox10.Visible = true;
                checkBox10.Checked = true;

            }
            else
            {
               //MessageBox.Show("You must check at least one option");
                checkBox10.Visible = false;
                checkBox10.Checked = false;
            }

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Start")
            {
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;
                checkBox8.Visible = false;
                checkBox9.Visible = false;
                checkBox10.Visible = false;
                this.button2.Enabled = true;
                this.textBox1.ReadOnly = false;
                this.textBox2.ReadOnly = false;
                this.textBox3.ReadOnly = false;
                this.textBox4.ReadOnly = false;
                this.groupBox1.Enabled = true;
                this.groupBox2.Enabled = true;
                this.button1.Text = "Stop";
                //button1.Image = Image.FromFile("C:/Users/ALex1/Desktop/altele/visual/Formular/1359303124_22947.ico");
              


                
            }
            else
            {
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;
                checkBox8.Visible = false;
                checkBox9.Visible = false;
                checkBox10.Visible = false;
                this.textBox1.Clear();
                this.textBox2.Clear();
                this.textBox3.Clear();
                this.textBox4.Clear();
                this.textBox5.Clear();
                this.checkBox1.Checked=false;
                this.checkBox2.Checked = false;
                this.checkBox3.Checked = false;
                this.checkBox4.Checked = false;
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;
                this.button2.Enabled = false;
                this.textBox1.ReadOnly = true;
                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox4.ReadOnly = true;
                this.groupBox1.Enabled = false;
                this.groupBox2.Enabled = false;
                this.button1.Text = "Start";
                //button1.Image = Image.FromFile("C:/Users/ALex1/Desktop/altele/visual/Formular/1359303060_82366.ico");
              
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true && checkBox9.Checked == true && checkBox8.Checked == true && checkBox7.Checked == true && checkBox6.Checked == true && checkBox5.Checked == true)
            {

                textBox5.Text += "Nume:" + textBox1.Text.ToString();
                textBox5.Text += "\r\n" + "Functie:" + textBox2.Text.ToString();
                textBox5.Text += "\r\n" + "Descriere:" + textBox3.Text.ToString();
                textBox5.Text += "\r\n" + "Varsta:" + textBox4.Text.ToString();
                if (radioButton1.Checked == true)
                    textBox5.Text +="\r\n"+ "Sex:" + radioButton1.Text;
                if (radioButton2.Checked == true)
                    textBox5.Text +="\r\n"+ "Sex:" + radioButton2.Text;
                textBox5.Text += "\r\n" + "Spor:";
                if (checkBox1.Checked == true)
                    textBox5.Text +="\r\n"+ checkBox1.Text.ToString()+" ";
                if (checkBox2.Checked == true)
                    textBox5.Text +="\r\n"+ checkBox2.Text.ToString()+" ";
                if (checkBox3.Checked == true)
                    textBox5.Text += "\r\n"+checkBox3.Text.ToString()+" ";
                if (checkBox4.Checked == true)
                    textBox5.Text +="\r\n"+ checkBox4.Text.ToString();
                this.button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apasati pe Start. Scrieti-va datele personale. Verificati daca in dreptul fiecarui camp de completat apare semnul de ok. Apasati pe Valideaza. Apasa trimite pentru a trimite datele. Sfarsit. ");
        }
    }
}
