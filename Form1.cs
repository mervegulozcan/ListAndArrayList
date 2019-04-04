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

namespace ArrayList_ve_List
{
    public partial class Form1 : Form
    {   Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDizi_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            int[] dizi = new int[5];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(1, 25);
                lstData.Items.Add(dizi[i]);
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            ArrayList list = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{

            //    list.Add(rnd.Next(1, 25));
            //}
            list.Add(1);
            list.Add(1.05);
            list.Add("Ali");
            list.Add(200);
            list.Add("Fil");

            foreach (var item in list)
            {
                lstData.Items.Add(item);
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(rnd.Next(1, 25));
            }
            foreach (int item in list)
            {
                lstData.Items.Add(item);
            }
            

        }

        private List<Button> dugmeler = new List<Button>();
        private void btnList2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            dugmeler.Clear();
            for (int i = 0; i < 7; i++)
            {
                Button btn = new Button();
                btn.Text = ("Görev " + i).ToString();
                btn.Name = "btn" + i;
                btn.Tag = i+1;
                btn.Click += new EventHandler(btnListi_Click);

                dugmeler.Add(btn);
                flowLayoutPanel1.Controls.Add(dugmeler[i]);
            }
            MessageBox.Show(dugmeler.Count + " yeni buton eklendi.");
            btnRenklendir.Show();
        }

        private void btnListi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btn0")
            {
                MessageBox.Show("1. butona tıklandı");
            }
            else
            {
                
                MessageBox.Show(String.Format(@"{0}. butona tıklandı" , btn.Tag));
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Color> cr = new List<Color>();
            cr.Add(Color.Black);
            cr.Add(Color.Red);
            cr.Add(Color.Blue);
            foreach (Color item2 in cr)
            {
                foreach (Button item in dugmeler) 
                { 
                    item.BackColor = item2;
                } 
                
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
