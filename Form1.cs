using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace FirmTranspLAB2
{
    // �����
    public partial class Form1 : Form
    {

        Firm firm = new Firm("Tesla");
        Firm firm2 = new Firm("Skoda", 15000);
        Firm firm1 = new Firm(14000, 2000, "TOYOTAAA", 5000, 15000, "Skoda", 3650);
        Firm firm3 = new Firm();
        static NewCollection collection = new NewCollection();
        CollectionListeners listener = new CollectionListeners(collection);


        public Form1()
        {
            InitializeComponent();
            Text = "FirmTransportation";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            collection.MyCollection();
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

            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("������� Array", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("������� Stack", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("�������� �������", 160, HorizontalAlignment.Center);


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
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            void Ex(string s)
            {
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

            collection.PushCollect(textBox1.Text);
            string result = "";
            foreach (var item2 in collection.stack)
            {
                result += $"Elem in stack: {item2}\n";
            }
            MessageBox.Show(result, "���������� ��������� � ����", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_4(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {


            MessageBox.Show(collection.Pop().ToString(), "�������� ��������� �����", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {



            ListViewItem item = new ListViewItem(collection.PushArrayTest());
            item.SubItems.Add(collection.PushStackTest());
            item.SubItems.Add(collection.RandomSelectTest());


            // ���������� �������� � ListView
            listView1.Items.Add(item);

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

            // �������� ��������� �������� CollectionType<Firm>
            CollectionType<Firm> collection = new CollectionType<Firm>();

            // ���������� �������� � ���������
            collection.AddItem(new Firm { Money = 10000, Mas = 2000, FirmName = "Firm1", CountCar = 50, CountWorker = 100, CarBrand = "Brand1", CountTransp = 500 });
            collection.AddItem(new Firm { Money = 20000, Mas = 2500, FirmName = "Firm2", CountCar = 70, CountWorker = 120, CarBrand = "Brand2", CountTransp = 600 });
            collection.AddItem(new Firm { Money = 15000, Mas = 2200, FirmName = "Firm3", CountCar = 60, CountWorker = 90, CarBrand = "Brand3", CountTransp = 550 });


            // LINQ-�������
            int n = 60; // ������ ��������� ��� ������
            var collectionSizeN = collection.Where(firm => firm.CountCar == n).ToList();

            var maxCollection = collection.Max();
            var minCollection = collection.Min();


            MessageBox.Show($"������������ ��������� �� ���������� �����������: {maxCollection.FirmName}\n " +
                $"����������� ��������� �� ���������� �����������: {minCollection.FirmName}", "LINQ", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Car prototype = new Car(10000, 1200, "Toyota", 100, 50, "Toyota Camry", 200);


            // ������������ ���������
            Car clone1 = (Car)prototype.Clone();
            clone1.Money = 15000;
            clone1.CarBrand = "Toyota Corolla";
            clone1.CountCar = 120;

            Car clone2 = (Car)prototype.Clone();
            clone2.FirmName = "Ford";
            clone2.CountWorker = 70;



            MessageBox.Show($"��������: {prototype}\n\n" +
                $"���� 1: {clone1}\n\n " +
                $"���� 2: {clone2}", "��������", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
        }

        private void button18_Click(object sender, EventArgs e)
        {


            ICarManufacturer manufacturerA = new ManufacturerA();
            ICarManufacturer manufacturerB = new ManufacturerB();

            Car1 carA = new CarA(manufacturerA);
            Car1 carB = new CarB(manufacturerB);

            
            

            MessageBox.Show($"�arA: {carA.ShowDetails()} \n " +
                $"�arB: {carB.ShowDetails()}", "����", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);


        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
CarContext context = new CarContext();

            ICarCalculationStrategy strategy1 = new PriceAndMassCalculationStrategy();
            ICarCalculationStrategy strategy2 = new CountCarAndWorkerCalculationStrategy();

            context.SetStrategy(strategy1);
            context.CalculateAndDisplay(25000, 1500, 100, 50, "Firm A", "Brand A", 200);
            MessageBox.Show($"{context.CalculateAndDisplay(25000, 1500, 100, 50, "Firm A", "Brand A", 200)}\n " 
                , "���������", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);


            context.SetStrategy(strategy2);
            MessageBox.Show($"{context.CalculateAndDisplay(25000, 1500, 100, 50, "Firm A", "Brand A", 200)}", "���������", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
        }
    }
}