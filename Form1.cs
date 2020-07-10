using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        
        int cLeft = 4;
        int dLeft = 1;
        int bLeft = 4;
        int Cen = 1;
        int x = 3;
        int y = 0;
        int[] A = new int[10000];
        Pen blackpen = new Pen(Color.Black, 2);
        float x1, x2, y1, y2;
        string a;
        private PictureBox pictureBox1 = new PictureBox();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < A.Length; i++)
                A[i] = 1; 
        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            e.Graphics.DrawLine(blackpen, x1, y1, x2, y2);
            this.blackpen.Dispose();

        }
            private void button1_Click(object sender, EventArgs e)
        {

            AddNewTextBox();
        }
        public System.Windows.Forms.PictureBox AddNewTextBox()
        {
            x = x + 1;
            x1 = 350;
            y1 = 170;
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox(); //Khởi tạo đối tượng Textbox có tên là txt
            this.Controls.Add(txt);  //Thêm đối tượng txt vào Form
            txt.Top = cLeft * 25; //Thiết lập thuộc tính Top
            txt.Left = 200; //Thiết lập thuộc tính Left
            txt.Text = "Main Topic " + this.cLeft.ToString(); //Thiết lập thuộc tính Text cho Textbox
            txt.Name = this.x.ToString();
            x2 = 300;
            y2 = cLeft * 25 - 10;
            cLeft = cLeft + 1;
            txt.Click += mybutton_click;
            this.Controls.Add(pictureBox1);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            return pictureBox1; 

            
        }
        private void mybutton_click(object sender, EventArgs e)
        {
            Cen = 0;
            TextBox txt1 = sender as TextBox;
            a = txt1.Name;
            
        }
        public System.Windows.Forms.TextBox AddNewTextBox1()
        {
            y = y + 1;
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox(); //Khởi tạo đối tượng Textbox có tên là txt
            this.Controls.Add(txt);  //Thêm đối tượng txt vào Form
            txt.Top = int.Parse(a) * 25; //Thiết lập thuộc tính Top
            if (A[int.Parse(a)] == 1)
            {
                txt.Left = 85 ; //Thiết lập thuộc tính Left
            }
            else
            {
                txt.Left = 85 - (A[int.Parse(a)] - 1) * 110;
            }
            txt.Text = "Sub Topic " + this.A[int.Parse(a)].ToString(); //Thiết lập thuộc tính Text cho Textbox
            txt.Name = this.y.ToString();
            A[int.Parse(a)] = A[int.Parse(a)] + 1;
            dLeft += 1;
            txt.Click += mybutton_click;
            return txt; //Trả lại đối tượng txt với các thuộc tính kèm theo
        }

        public System.Windows.Forms.TextBox AddNewTextBox2()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox(); //Khởi tạo đối tượng Textbox có tên là txt
            this.Controls.Add(txt);  //Thêm đối tượng txt vào Form
            txt.Top = int.Parse(a) * 80; //Thiết lập thuộc tính Top
            
            if (A[int.Parse(a)] == 1)
            {
                txt.Left = 620; //Thiết lập thuộc tính Left
            }
            else
            {
                txt.Left = 620 + (A[int.Parse(a)]-1) * 110;
            }
            txt.Text = "Sub Topic " + this.A[int.Parse(a)].ToString(); //Thiết lập thuộc tính Text cho Textbox
            A[int.Parse(a)] = A[int.Parse(a)] + 1;
            dLeft = dLeft + 1;
            bLeft = bLeft + 1;

            return txt; //Trả lại đối tượng txt với các thuộc tính kèm theo
        }



            private void button2_Click(object sender, EventArgs e)
            {
                if (Cen == 1)
                {
                    AddNewTextBox();

                }
                else if (Cen == 2)
                {
                    AddNewTextBox2();
                }
                else { AddNewTextBox1(); };


            }

            private void textBox1_Click(object sender, EventArgs e)
            {
                Cen = 1;
            }

            private void textBox2_Click(object sender, EventArgs e)
            {
                Cen = 2;
                a = "1";
                
            }

            private void textBox3_Click(object sender, EventArgs e)
            {
                 Cen = 2;
                 a = "2";
                 
            }

        private void textBox4_Click(object sender, EventArgs e)
        {
            Cen = 2;
            a = "3";
            
        }
    }
}

