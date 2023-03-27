using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Collections;

namespace FirmTranspLAB2
{
    // �����
    public partial class Form1  : Form
    {
       
        Firm firm = new Firm("Tesla");
        Firm firm2 = new Firm("Skoda", 15000);
        Firm firm1 = new Firm(14000, 2000, "TOYOTAAA", 5000, 15000, "Skoda", 3650);
        Firm firm3 = new Firm();
        public Form1()
        {
            InitializeComponent();
            Text = "FirmTransportation";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("���� ����������");
            comboBox1.Items.Add("����� ����������");
            comboBox1.Items.Add("�������� �����");
            comboBox1.Items.Add("���������� �����������");
            comboBox1.Items.Add("���������� ����������");
            comboBox1.Items.Add("����� �����������");
            comboBox1.Items.Add("���������� ��������������");

            comboBox2.Items.Add("���� ����������");
            comboBox2.Items.Add("����� ����������");
            comboBox2.Items.Add("�������� �����");
            comboBox2.Items.Add("���������� �����������");
            comboBox2.Items.Add("���������� ����������");
            comboBox2.Items.Add("����� �����������");
            comboBox2.Items.Add("���������� ��������������");

            comboBox3.Items.Add("���� ����������");
            comboBox3.Items.Add("����� ����������");
            comboBox3.Items.Add("���������� �����������");
            comboBox3.Items.Add("���������� ����������");
            comboBox3.Items.Add("���������� ��������������");

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string writeRealize = firm1.writeFunc(comboBox2.Text);
            MessageBox.Show($"����� �������� ����: \n\n{writeRealize}", "����� ����� �����", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string hex = firm1.hexNumber(comboBox3.Text, textBox5.Text);

            MessageBox.Show($"����������������� �������������: \n\n{hex}", "����������������� ������������� ����", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"��������������� ����� ToString():\n\n{firm1.ToString()}", "����� ToString()", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"����� ������������ � ����������� ����������, ������ ���������� �����:\n\n{firm1}", "����������� � max" +
                " �����������", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"����� ������������ � ����� �����������: \n\n{firm2}", "����������� � ����� �����������",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"����� ������������ � ����� ����������: \n\n{firm}", "����������� � ����� ����������", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"����� ������������ ��� ����������: \n\n{firm3}", "����������� ��� ����������", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string changeF = firm1.ChangeField(comboBox1.Text, textBox4.Text);
            MessageBox.Show($"��������� �����: \n\n{changeF}\n\n{firm1}", "��������������� ����� ������", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string countObj = Firm.countObjects.ToString();
            MessageBox.Show($"���������� ��������� ��������: \n\n{countObj}", "���������� ��������", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Money - ���� ����������\nMas - ����� ����������\nFirmName - �������� �����\nCountCar - ���������� " +
                "�����������\nCountWorker - ���������� ����������\n" +
                "CarBrand - ����� ����������\nCountTransp - ���������� �������������� � ���", "�������� ����� ������",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Firm firmIE = new Firm();
            while (true)
            {
                if (textBox6.Text.Length == 0)
                {
                    MessageBox.Show("������� ���������� �����������!", "������", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                }
                if (firmIE.CheckOnInt(textBox6.Text))
                {
                    int value = Convert.ToInt32(textBox6.Text);
                    try
                    {
                        Firm firmEx = new Firm("Tesla", value);
                        MessageBox.Show($"������ ������� ������: {firmEx}\n����������� ���������� �����������: 50", "�����", 
                            MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        break;
                    }
                    catch (NewException ex)
                    {
                        Win32.MessageBox(0, $"����������: {ex.Message}\n����������:{ex.Value}\n����������� ����������: 50",
                            "��������� ����������", 0);
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("������� ���������� ���������� �����������!", "������", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    break;
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string t7 = textBox7.Text;
            void Ex(string s) {
                while (true)
                {
                    if (s.Length == 0)
                    {
                        MessageBox.Show("������� ��������!", "������", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        break;
                    }
                    if (firm.CheckOnInt(s))
                    {
                        int val = Convert.ToInt32(s);
                        MessageBox.Show($"���������� '{val}' � Int32 ������� �����������!", 
                            "�����", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        break;
                    }
                    else
                    {
                        throw new InvalidCastException("InvalidCastException Op.2", s);
                    }
                }
            }
            try
            {
                Ex(t7);
            }
            catch (InvalidCastException ex)
            {
                Win32.MessageBox(0, $"����������: {ex.Message}.\n\nC����� '{ex.Value}' �� ����� ���� ��������� � Int32 ",
                    "��������������� ����������", 0);

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
           

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox3.SelectedItem.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
                NewCollection collection = new NewCollection();
                CollectionListeners listener = new CollectionListeners(collection);
                string k1 = collection.PushCollect(textBox1.Text);
                string k2 = collection.Push();
                string k3 = collection.Pop().ToString();
                MessageBox.Show(k1);
                MessageBox.Show(k2);
                MessageBox.Show(k3);


            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_4(object sender, EventArgs e)
        {

        }
    }
}