using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CREATE_QUIZ
{

    public partial class Form1 : Form
    {



        List<string[]> arrayList = new List<string[]>();  // the 5 options and the correct answers
        int grade = 0;
        int numofq = 0;  // num of questions
        int indexofcurq = 0; // index of current question
        List<string> question = new List<string>();   // array of questions

        public Form1()
        {
            InitializeComponent();

        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e) //  new question button
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked) //
            {
                question.Add(textBox1.Text);
                string x = GetTrueans(radioButton1, radioButton2, radioButton3, radioButton4, radioButton5);
                arrayList.Add(GetStringArrayFromTextBoxes(textBox2, textBox3, textBox4, textBox5, textBox6, x));
                numofq++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;

            }
            else
            {
                MessageBox.Show("choose ans");
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            if (comboBox1.Text == "2")
            {
                textBox2.Visible = true;
                radioButton1.Visible = true;
                textBox3.Visible = true;
                radioButton2.Visible = true;
            }
            if (comboBox1.Text == "3")
            {
                textBox2.Visible = true;
                radioButton1.Visible = true;
                textBox3.Visible = true;
                radioButton2.Visible = true;
                textBox4.Visible = true;
                radioButton3.Visible = true;
            }
            if (comboBox1.Text == "4")
            {
                textBox2.Visible = true;
                radioButton1.Visible = true;
                textBox3.Visible = true;
                radioButton2.Visible = true;
                textBox4.Visible = true;
                radioButton3.Visible = true;
                textBox5.Visible = true;
                radioButton4.Visible = true;
            }
            if (comboBox1.Text == "5")
            {
                textBox2.Visible = true;
                radioButton1.Visible = true;
                textBox3.Visible = true;
                radioButton2.Visible = true;
                textBox4.Visible = true;
                radioButton3.Visible = true;
                textBox5.Visible = true;
                radioButton4.Visible = true;
                textBox6.Visible = true;
                radioButton5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (indexofcurq < numofq)
            {
                label6.Text = question[indexofcurq];


                if (comboBox1.Text == "2")
                {
                    radioButton6.Text = arrayList[indexofcurq][0];
                    radioButton7.Text = arrayList[indexofcurq][1];
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;

                }
                else if (comboBox1.Text == "3")
                {
                    radioButton6.Text = arrayList[indexofcurq][0];
                    radioButton7.Text = arrayList[indexofcurq][1];
                    radioButton8.Text = arrayList[indexofcurq][2];
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;

                }
                else if (comboBox1.Text == "4")
                {
                    radioButton6.Text = arrayList[indexofcurq][0];
                    radioButton7.Text = arrayList[indexofcurq][1];
                    radioButton8.Text = arrayList[indexofcurq][2];
                    radioButton9.Text = arrayList[indexofcurq][3];
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    radioButton9.Visible = true;

                }
                else if (comboBox1.Text == "5")
                {
                    radioButton6.Text = arrayList[indexofcurq][0];
                    radioButton7.Text = arrayList[indexofcurq][1];
                    radioButton8.Text = arrayList[indexofcurq][2];
                    radioButton9.Text = arrayList[indexofcurq][3];
                    radioButton10.Text = arrayList[indexofcurq][4];
                    radioButton6.Visible = true;
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    radioButton9.Visible = true;
                    radioButton10.Visible = true;
                }


                label6.Visible = true;
                button3.Visible = false;
                button4.Visible = true;
            }
            else
            {
                this.Hide();
                Grade g = new Grade();
                g.SetData(grade.ToString(), numofq.ToString());
                g.Show();

            }


        }


        /*   
        private int qsize()
        {
            return Convert.ToInt32(numericUpDown1.Value);
        }

        */

        public string GetTrueans(RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r4, RadioButton r5)
        {
            if (r1.Checked)
            {
                return textBox2.Text;
            }
            else if (r2.Checked)
            {
                return textBox3.Text;
            }
            else if (r3.Checked)
            {
                return textBox4.Text;
            }
            else if (r4.Checked)
            {
                return textBox5.Text;
            }
            else if (r5.Checked)
            {
                return textBox6.Text;
            }
            return "NoAnS";

        }

        static string[] GetStringArrayFromTextBoxes(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, string Trueans)  // prepare the equivelant array to be added
        {
            string[] intArray = new string[6];

            // Assuming TextBox.Text contains integer values
            // if this true     do this        else do this
            intArray[0] = textBox1.Text != "" ? textBox1.Text : "def";
            intArray[1] = textBox2.Text != "" ? textBox2.Text : "def";
            intArray[2] = textBox3.Text != "" ? textBox3.Text : "def";
            intArray[3] = textBox4.Text != "" ? textBox4.Text : "def";
            intArray[4] = textBox5.Text != "" ? textBox5.Text : "def";
            intArray[5] = Trueans;





            return intArray;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (radioButton6.Checked && radioButton6.Text == arrayList[indexofcurq][5])
            {
                grade++;
            }
            else if (radioButton7.Checked && radioButton7.Text == arrayList[indexofcurq][5])
            {
                grade++;
            }
            else if (radioButton8.Checked && radioButton8.Text == arrayList[indexofcurq][5])
            {
                grade++;
            }
            else if (radioButton9.Checked && radioButton9.Text == arrayList[indexofcurq][5])
            {
                grade++;
            }
            else if (radioButton10.Checked && radioButton10.Text == arrayList[indexofcurq][5])
            {
                grade++;
            }

            radioButton6.Checked = radioButton7.Checked = radioButton8.Checked = radioButton9.Checked = radioButton10.Checked = false;
            indexofcurq++;
            button3_Click(sender, e);


        }


    }
}