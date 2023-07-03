namespace _14.hafta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            textBox3.Text = Convert.ToString(sonuc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "cengo ya ";
            MessageBox.Show("3 sayfadaki yazý deðiþti");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add("tab3", "yeni sekme", 1);
            Button btn = new Button();
            btn.Text = "kod ile oluþuruldu";
            btn.Width = 250;

            tabControl1.TabPages["tab3"].Controls.Add(btn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /* textBox4.Visible = false;
             textBox5.Visible = false;
             textBox6.Visible = false;
             textBox7.Visible = false; */

            panel1.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                if (panel1.Controls[i] is TextBox)
                    panel1.Controls[i].Text = "";
            }
        }
    }
}