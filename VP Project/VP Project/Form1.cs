using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VP_Project
{

    public partial class Form1 : Form
    {
        private int autoID = 0;
        public Form1()
        {
            InitializeComponent();
        }
      
        public class Car
        {
            public int Id { get; set; }
            public string? Model { get; set; }
            public string? Year { get; set; }
            public string? GearBox { get; set; }
            public string? Color { get; set; }
            public string? MaxSpeed { get; set; }
        }

        BindingList<Car> carList = new BindingList<Car>();





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            autoID = 1;
            dataGridView1.DataSource = carList;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox6.Text = dataGridView1.SelectedCells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textBox5.Text = dataGridView1.SelectedCells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
                textBox3.Text = dataGridView1.SelectedCells[4].Value.ToString();
                textBox2.Text = dataGridView1.SelectedCells[5].Value.ToString();
            }

            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Car c = new Car();

            // Now, add the columns that are selected in the checkboxes
            if (checkBox1.Checked)
            {
                dataGridView1.Columns.Add("ID", null);
            }
            if (checkBox5.Checked)
            {
                dataGridView1.Columns.Add("Model", null);
            }
            if (checkBox4.Checked)
            {
                dataGridView1.Columns.Add("Year", null);
            }
            if (checkBox3.Checked)
            {
                dataGridView1.Columns.Add("GearBox", null);
            }
            if (checkBox2.Checked)
            {
                dataGridView1.Columns.Add("Color", null);
            }
            if (checkBox6.Checked)
            {
                dataGridView1.Columns.Add("Max_Speed", null);
            }
           

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox5.Text != "" && textBox4.Text != "" && textBox3.Text != "" && textBox2.Text != "")
            {
                for (int i = 0; i < carList.Count; i++)
                    if (textBox2.Text == carList[i].Model && textBox3.Text == carList[i].Year)
                    {
                        MessageBox.Show("Car Data already exists!");
                        return;
                    }



                carList.Add(new Car { Id = autoID, Model = textBox1.Text, Year = textBox5.Text, GearBox = textBox4.Text, Color = textBox3.Text, MaxSpeed = textBox2.Text });

                textBox6.Text = "";
                textBox1.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                autoID++;
            }
            else
                MessageBox.Show("PLease fill the boxes");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(dataGridView1.SelectedCells[0].ToString()) - 1;
                carList.RemoveAt(index);
                for (int i = index; i < carList.Count; i++)
                    carList[i].Id--;
                autoID--;
            }
            catch (Exception)
            {

            }




            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";




        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = 0;
            string fast = "";
            try
            {

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    if (max < int.Parse(dataGridView1.Rows[i].Cells[5].ToString()))

                    {
                        max = int.Parse(dataGridView1.Rows[i].Cells[5].ToString());
                        fast = dataGridView1.Rows[i].Cells[1].ToString();

                    }

                }
                MessageBox.Show("The fastest car is " + fast + " & the top speed is " + max);

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong value in the data");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Select Gear type");
            }





            if (radioButton1.Checked == true)
            {
                int count = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    string x = "Manual";
                    if ((dataGridView1.Rows[i].Cells[3].Value.ToString()) == x)
                    {
                        count++;

                    }



                }
                MessageBox.Show("Nummber of Manual cars :" + count);

            }
            else if (radioButton2.Checked == true)
            {
                int count = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    string x = "Automatic";
                    if ((dataGridView1.Rows[i].Cells[3].Value.ToString()) == x)
                    {
                        count++;

                    }



                }
                MessageBox.Show("Nummber of Automatic cars :" + count);

            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                System.Diagnostics.Process.Start("https://www.nissan-global.com/EN/");
            }


            else if (comboBox1.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("https://www.toyota.com/");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("https://www.bmw.com/en/index.html");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                System.Diagnostics.Process.Start("https://www.audi.com/en.html");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                System.Diagnostics.Process.Start("https://www.ford.com/");
            }

            else
            {
                MessageBox.Show("Nothing selected");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}