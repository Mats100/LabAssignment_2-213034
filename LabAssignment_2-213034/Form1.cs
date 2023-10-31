namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome, " + textBox1.Text, "Greetings", MessageBoxButtons.OK);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string items = String.Empty;

            if (checkBox1.Checked)
                items += "\n Pencil";
            if (checkBox2.Checked)
                items += "\n Sharpener";
            if (checkBox3.Checked)
                items += "\n Pen";

            MessageBox.Show("You have bought: " + items);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string Gender;

            if (radioButton1.Checked)
                Gender = "Male";
            else
                Gender = "Female";

            MessageBox.Show(Gender.ToString());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            decimal price = numericUpDown1.Value;
            int quantity = (int)numericUpDown2.Value;
            decimal total;

            total = price * quantity;

            MessageBox.Show(String.Format("The total price is {0:C}", total));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] country = { "Pakistan", "United States" };

            foreach (string name in country)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Pakistan")
            {
                comboBox2.Items.Add("Skardu");
                comboBox2.Items.Add("Multan");
                comboBox2.Items.Add("Vehari");
                comboBox2.Items.Add("Hunza");
                comboBox2.Items.Add("Lahore");
                comboBox2.Items.Add("Islamabad");
                comboBox2.Items.Add("Murree");
            }
            if (comboBox1.SelectedItem.ToString() == "United States")
            {
                comboBox2.Items.Add("New York");
                comboBox2.Items.Add("Washington");
                comboBox2.Items.Add("Ohio");
                comboBox2.Items.Add("Denmark");
                comboBox2.Items.Add("Las Vegas");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = "DateTimePicker Date: " + dateTimePicker1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label10.Text = "MonthCalender Date: " + monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                this.ForeColor = color.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                this.BackColor = color.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
                this.Font = font.Font;
        }
    }
}