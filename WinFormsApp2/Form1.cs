using System.Collections.Specialized;
using System.Xaml.Permissions;
using System.Drawing;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] arr = new int[26];
            int min = 100;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(-100, 100);
                textBox1.Text += arr[i].ToString() + ' ';
            }

            if (arr[0] >= 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    arr[i] = arr[i] * (min * min);
                    textBox2.Text += arr[i].ToString() + ' ';
                }

            }
            if (arr[0] < 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    arr[i] = arr[i] * (max * max);
                    textBox2.Text += arr[i].ToString() + ' ';
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[25];
            int[] arr2 = new int[25];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new Random().Next(-100, 100);
                arr2[i] = new Random().Next(-100, 100);
                if (arr1[i] <= 0)
                {
                    arr2[i] = arr2[i] * 10;
                }
                else
                {
                    arr2[i] = 0;
                }
                textBox3.Text += arr1[i].ToString() + ' ';
                textBox4.Text += arr2[i].ToString() + ' ';
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            double x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 10);
                x += Math.Pow(arr[i], i + 1);
                textBox5.Text += arr[i].ToString() + ' ';
            }
            textBox6.Text = x.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool is_negative = false;
            string str = "";
            int x = int.Parse(textBox7.Text);
            int[] arr1 = new int[x];
            int[,] arr = new int[x, x];
            dataGridView1.RowCount = x;
            dataGridView1.ColumnCount = x;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    arr[i, j] = new Random().Next(-10, 10);
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        is_negative = true;
                    }
                }
                if (is_negative == true)
                {
                    str += "1";
                }
                else if (is_negative == false)
                {
                    str += "0";
                }
            }
            textBox8.Text = str;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int summ = 0;
            int diagonal_summ = 0;
            int second_diagonal_summ = 0;
            int max_frst = -100;
            int max_lst = -100;              
            int x = int.Parse(textBox9.Text);
            int[,] arr = new int[x, x];
            dataGridView2.RowCount = x;
            dataGridView2.ColumnCount = x;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    arr[i, j] = new Random().Next(-10,10);
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }
            for (int j = 0; j < x; j++)
            {
                summ += arr[0, j];
            }
            for (int i = 0; i < x; i++)
            {
                diagonal_summ += arr[i, i];
            }
            for (int i = 0; i < x; i++)
            {
                second_diagonal_summ += arr[i, x - i - 1];
            }
            for (int j = 0; j < x; j++)
            {
                if (arr[0, j] > max_frst)
                {
                    max_frst = arr[0, j];
                }
            }
            for (int j = 0; j < x; j++)
            {
                if (arr[x-1, j] > max_lst)
                {
                    max_lst = arr[x - 1, j];
                }
            }
            textBox10.Text = summ.ToString();
            textBox11.Text = diagonal_summ.ToString();
            textBox12.Text = second_diagonal_summ.ToString();
            textBox13.Text = max_frst.ToString();
            textBox14.Text = max_lst.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox15.Text);
            int n = int.Parse(textBox16.Text);
            int[,] arr1 = new int[m, n];
            int[,] arr2 = new int[m, n];
            int[,] arr3 = new int[m, n];
            dataGridView3.RowCount = m;
            dataGridView3.ColumnCount = n;
            dataGridView4.RowCount = m;
            dataGridView4.ColumnCount = n;
            dataGridView5.RowCount = m;
            dataGridView5.ColumnCount = n;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = new Random().Next(-10, 10);
                    arr2[i, j] = new Random().Next(-10, 10);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = arr2[i, j].ToString();
                }
            }
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView5.Rows[i].Cells[j].Value = arr3[i, j].ToString();
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox15.Text);
            int n = int.Parse(textBox16.Text);
            int[,] arr1 = new int[m, n];
            int[,] arr2 = new int[m, n];
            int[,] arr3 = new int[m, n];
            dataGridView3.RowCount = m;
            dataGridView3.ColumnCount = n;
            dataGridView4.RowCount = m;
            dataGridView4.ColumnCount = n;
            dataGridView5.RowCount = m;
            dataGridView5.ColumnCount = n;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = new Random().Next(-10, 10);
                    arr2[i, j] = new Random().Next(-10, 10);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = arr2[i, j].ToString();
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView5.Rows[i].Cells[j].Value = arr3[i, j].ToString();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox15.Text);
            int n = int.Parse(textBox16.Text);
            int x = int.Parse(textBox17.Text);
            int y = int.Parse(textBox18.Text);
            int[,] arr1 = new int[m, n];
            int[,] arr2 = new int[x, y];
            int[,] arr3 = new int[m, y];
            dataGridView3.RowCount = m;
            dataGridView3.ColumnCount = n;
            dataGridView4.RowCount = x;
            dataGridView4.ColumnCount = y;
            

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = new Random().Next(-10, 10);
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr2[i, j] = new Random().Next(-10, 10);
                }
            }
            if (m == y)
            {
                for (int i = 0; i < arr1.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2.GetLength(1); j++)
                    {
                        for(int k = 0; k < x; k++)
                        {
                            arr3[i, j] += arr1[i, k] * arr2[k, j];
                        }
                    }
                }
            }
            else if (m != y)
            {
                errorProvider1.SetError(textBox16, "ошибка в размерности");
            }
                
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                }
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    dataGridView4.Rows[i].Cells[j].Value = arr2[i, j].ToString();
                }
            }
            dataGridView5.RowCount = arr3.GetLength(0);
            dataGridView5.ColumnCount = arr3.GetLength(1);
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    dataGridView5.Rows[i].Cells[j].Value = arr3[i, j].ToString();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox19.Text);
            int b = int.Parse(textBox20.Text);
            int c = int.Parse(textBox21.Text);
            int d = int.Parse(textBox22.Text);

            if (a > b && b > c &&  c > d)
            {
                textBox23.Text = "success";
            }
            else
            {
                a = a * a;
                b = b * b;
                c = c * c;
                d = d * d;
                textBox19.Text = a.ToString();
                textBox20.Text = b.ToString();
                textBox21.Text = c.ToString();
                textBox22.Text = d.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int h = int.Parse(textBox24.Text);
            double y = (Math.Abs(Math.Sin(8 * h) / Math.Pow(1 - Math.Sin(4 * h) * Math.Cos(Math.Pow(h,2)) + 18 ,2)));
            double a = Math.Pow(y, 0.5);
            double b = 1 - Math.Pow(3 / 3 + Math.Abs(Math.Tan(a*Math.Pow(h,2)) - Math.Sin(a * h)), 0.5);
            double c = a * Math.Pow(h, 2) * Math.Sin(b * h) + b * Math.Pow(h, 3) * Math.Cos(a * h);
            double dis = Math.Pow(b, 2) - 4 * a * c;
            if (dis >= 0)
            {
                textBox24.Text = "Success";
                double frst = (Math.Pow(dis, 0.5) - b) / 2;
                double scnd = (-b - Math.Pow(dis, 0.5) / 2);
                textBox25.Text = frst.ToString();
                textBox26.Text = scnd.ToString();
            }
            else if (dis < 0)
            {
                textBox24.Text = "error dis < 0";
                textBox25.Text = "";
                textBox25.Text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox27.Text);
            int b = int.Parse(textBox28.Text);
            int c = int.Parse(textBox29.Text);
            int x = int.Parse(textBox30.Text);
            int y = int.Parse(textBox31.Text);

            if (a <= x && b <= y || c <= x && b <= y || b <= x && a <= y || c <= y && a <= x || c <= y && b <= x)
            {
                textBox32.Text = "success";
            }
            else
            {
                textBox32.Text = "error";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double x = int.Parse(textBox33.Text);
            double y = int.Parse(textBox34.Text);
            double x1 = Math.Pow(x, Math.Pow(y, 2)) / Math.Pow(2, y);
            double x2 = Math.Pow(x, Math.Pow(y, 3)) / Math.Pow(3, y);

            textBox35.Text = x1.ToString();
            textBox36.Text = x2.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a = int.Parse(textBox37.Text);
            double x = 0;
            double xnext = 0;
            double xprev = 0;
            double x0 = 0;
            double answ = 0;
            

            if (a <= 1)
            {
                x0 = Math.Min(2 * a, 0.95);
            }
            if (a > 1 && a <= 25)
            {
                x0 = a / 5;
            }
            else
            {
                x0 = a / 25;
            }
            xprev = a / 5 * x0 + 4 / 5 * Math.Pow(x0, 4);
            while (5/4 * a * Math.Abs(xnext - x) < Math.Pow(10, -6))
            {
            
                x = a / 5 * xprev + 4 / 5 * Math.Pow(xprev, 4);
                xnext = a / 5 * x + 4 / 5 * Math.Pow(x, 4);
                
            }
            answ = a - Math.Pow(xnext, 5);
            textBox38.Text = answ.ToString();

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f, l;
            decimal h, g;
            a = 0; b = 0; c = 0; f = 1; g = 1; h = 1; d = 1; l = 1;
            for (int k = 1; k <= 100; k++)
            {
                a += Math.Pow(k, 2);
            }
            for (int k = 1; k <= 50; k++)
            {
                b += 1 / Math.Pow(k, 3);
            }
            double resfact = 1;
            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= k; j++)
                {
                    resfact *= j;
                    
                }
                c += 1 / resfact;
            }
            for (int k = 1; k <= 128; k++)
            {
                d += 1 / Math.Pow(2 * k, 2);
            }
            for (int k = 1; k <= 52; k++)
            {
                f *= Math.Pow(k, 2) / (Math.Pow(k, 2) + 2 * k + 3);
            }
            g = 1;
            decimal g1, g2, g3;
            for (int k = 2; k <= 100; k++)
            {
                g1 = k + 1;
                g2 = k + 2;
                g3 = g1 / g2;
                g *= g3;
            }
            decimal resfact2 = 1;
            for (int k = 1; k <= 10; k++)
            {
                for(int j = 1; j<= k; j++)
                {
                    resfact2 = resfact2 * j;
                    
                }
                h *= 2 + (1 / resfact2);
            }
            double resfact3 = 1;
            for (int k = 2; k <=10; k++)
            {
                for (int j = 1; j <= k; j++)
                {
                    resfact3 = resfact3 * j;
                    
                }
                l *= Math.Pow(1 - (1 / resfact3), 2);
            }
            textBox40.Text = a.ToString();
            textBox41.Text = b.ToString();
            textBox42.Text = c.ToString();
            textBox43.Text = d.ToString();
            textBox44.Text = f.ToString();
            textBox45.Text = g.ToString();
            textBox46.Text = h.ToString();
            textBox47.Text = l.ToString();



        }

        private void button15_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[5];
            Random rnd = new Random();
            int summ1 = 0;
            int summ2 = 0;
            int summ3 = 0;

            for (int i = 0; i < 5; i++)
            {
                arr1[i] = rnd.Next(-10, 10);
                if (arr1[i] % 5 == 0)
                {
                    summ1 += arr1[i];
                }
                if (arr1[i] % 2 != 0 && arr1[i] < 0)
                {
                    summ2 += arr1[i];
                }
                if (Math.Abs(arr1[i] + 1) < Math.Pow(i + 1, 2))
                {
                    summ3 += arr1[i];
                }
                label2.Text += arr1[i].ToString() + " ";
            }
            textBox39.Text = summ1.ToString();
            textBox48.Text = summ2.ToString();
            textBox49.Text = summ3.ToString();
            

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[45];
            Random rnd = new Random();
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < 15; i++)
            {
                arr1[i] = rnd.Next(-10, 10);
                if (arr1[i] == 0)
                {
                    cnt2++;
                }
            }
            for (int i = 0; i < 15; i++)
            {
                if (arr1[i] < 0)
                {
                    cnt1++;
                }
            }
            label1.Text = "";
            for (int i = 0; i < 15; i++)
            {
                label1.Text += arr1[i].ToString() + " ";
            }
            textBox50.Text = cnt1.ToString();
            textBox51.Text = cnt2.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double[] arr1 = new double[30];
            double[] arr2 = new double[30];
            double summ = 0;
            for (int i = 0; i < 30; i++)
            {
                if((i + 1) % 2 != 0)
                {
                    arr1[i] = i + 1;
                }
                else
                {
                    arr1[i] = (i + 1) / 2;
                }
                label3.Text += arr1[i].ToString() + " ";
            }
            for(int i = 0; i < 30; i++)
            {
                if((i + 1) % 2 != 0)
                {
                    arr2[i] = Math.Pow(i + 1, 2);
                }
                else
                {
                    arr2[i] = Math.Pow(i + 1, 3);
                }
                label4.Text += arr2[i].ToString() + " ";
            }
            for(int i = 0; i < 30; i++)
            {
                summ += Math.Pow(arr1[i] - arr2[i], 2);
            }
            summ++;
            textBox52.Text = summ.ToString();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            double[,] arr1 = new double[8, 8];
            double [,] arr2 = new double[8, 8];
            double[] arr3 = new double[8];
            dataGridView6.RowCount = 8;
            dataGridView6.ColumnCount = 8;
            dataGridView7.RowCount = 8;
            dataGridView7.ColumnCount = 8;
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                arr3[i] = rnd.Next(-10, 10);
                label5.Text += arr3[i].ToString() + " ";
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    arr1[i, j] = Math.Pow(arr3[i], i + 1);
                    arr2[i, j] = Math.Pow(arr3[i], i);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    dataGridView6.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    dataGridView7.Rows[i].Cells[j].Value = arr2[i, j].ToString();
                }
            }


        }

        private void button19_Click(object sender, EventArgs e)
        {
            double[,] arr1 = new double[2, 2];
            double[] arra = new double[2];
            double[] arrb = new double[2];
            double[] arrc = new double[2];
            double[] arrd = new double[2];
            double[] arre = new double[2];
            dataGridView8.RowCount = 2;
            dataGridView8.ColumnCount = 2;
            Random rnd = new Random();
            double[] min = new double[2];
            double[] max = new double[2];

            for (int i = 0; i < 2; i++)
            {
                min[i] = 10000;
                max[i] = 0;
                arrb[i] = 1;
                for(int j = 0; j < 2; j++)
                {
                    arr1[i, j] = rnd.Next(-10, 10);
                    dataGridView8.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                    arra[i] += arr1[i, j];
                    arrb[i] *= arr1[i, j];
                    if (arr1[i,j] < min[i])
                    {
                        arrc[i] = arr1[i, j];
                        min[i] = arr1[i, j];
                    }
                    arrd[i] = arra[i] / 2;
                    if (arr1[i,j] > max[i])
                    {
                        max[i] = arr1[i, j];

                    }
                    arre[i] = max[i] - min[i];                                            
                }
                label6.Text += arra[i].ToString() + ' ';
                label7.Text += arrb[i].ToString() + ' ';
                label8.Text += min[i].ToString() + ' ';
                label9.Text += arrd[i].ToString() + ' ';
                label10.Text += arre[i].ToString() + ' ';

            }
            for(int i = 0; i < 8; i++)
            {

            }
            
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            dataGridView9.RowCount = 2;
            dataGridView9.ColumnCount = 2;
            Random rnd = new Random();
            double[,] arr1 = new double[2, 2];
            double[] min = new double[2];
            double max = 0;
            double max1 = 0;
            for (int i = 0; i < 2; i++)
            {
                min[i] = 10000;
                max = 0;
                
                for(int j = 0; j < 2; j++)
                {
                    arr1[i, j] = rnd.Next(-100, 100);
                    dataGridView9.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                    if (arr1[i,j] < min[i])
                    {
                        min[i] = arr1[i, j];
                        label12.Text = i.ToString() + ' ';
                    }
                    for(int k = 0; k < min.Length; k++)
                    {
                        if (max > min[k])
                        {
                            max = min[k];
                            label13.Text = k.ToString();
                        }
                    }
                    
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        PaintEventArgs Pnt()
        {
            Graphics g = this.pictureBox1.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            PaintEventArgs pnt = new PaintEventArgs(g, rect);

            return pnt;
        }
        void Rct(int x_pos, int y_pos, int width, int height)
        {
            Pen wPen = new Pen(Color.Black, 1);


            Pnt().Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(x_pos, y_pos, width, height));
            Pnt().Graphics.DrawRectangle(wPen, new Rectangle(x_pos, y_pos, width, height));
        }
        void Elps(double x_pos, double y_pos, int width, int height)
        {

            Pen wPen = new Pen(Color.Black, 1);


            Pnt().Graphics.FillEllipse(new SolidBrush(Color.White), new Rectangle((int)Math.Round(x_pos), (int)Math.Round(y_pos), width, height));
            Pnt().Graphics.DrawEllipse(wPen, new Rectangle((int)Math.Round(x_pos), (int)Math.Round(y_pos), width, height));
        }

        void Liner(int x1_pos, int y1_pos, int x2_pos, int y2_pos)
        {
            Pen bPen = new Pen(Color.Black);
            Pnt().Graphics.DrawLine(bPen, x1_pos, y1_pos, x2_pos, y2_pos);
        }

        void Trgl(int x1_pos, int y1_pos, int x2_pos, int y2_pos, int x3_pos, int y3_pos)
        {
            Pen bPen = new Pen(Color.Black);
            Pnt().Graphics.DrawLine(bPen, x1_pos, y1_pos, x2_pos, y2_pos);
            Pnt().Graphics.DrawLine(bPen, x2_pos, y2_pos, x3_pos, y3_pos);
            Pnt().Graphics.DrawLine(bPen, x3_pos, y3_pos, x1_pos, y1_pos);

        }

        void Arc(int x1_pos, int y1_pos, int width, int height, int s_agl, int sw_agl)
        {
            Pen bPen = new Pen(Color.Black);
            Pnt().Graphics.DrawArc(bPen, x1_pos, y1_pos, width, height, s_agl, sw_agl);

        }

        void Str(string txt, int x_pos, int y_pos, int size)
        {
            Pnt().Graphics.DrawString(txt, new Font("Arial", size), new SolidBrush(Color.Black), x_pos, y_pos);
        }

        void Pxl(int x, int y)
        {
            Pnt().Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(x * 10, y * 10, 10, 10));
        }

        void Cleaner()
        {
            Pnt().Graphics.Clear(Color.White);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Cleaner();

            Elps(100, 100, 200, 100);
            Elps(75, 75, 55, 55);

            Liner(190, 200, 165, 230);
            Liner(210, 200, 235, 230);

            Trgl(80, 100, 80, 115, 50, 115);

            Trgl(250, 120, 250, 160, 320, 120);
            Trgl(200, 170, 245, 170, 245, 220);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Cleaner();

            Rct(100, 200, 200, 250);
            Rct(230, 270, 60, 180);
            Rct(140, 250, 70, 70);

            Trgl(100, 200, 300, 200, 200, 100);

            Liner(250, 150, 250, 70);
            Liner(250, 70, 280, 70);
            Liner(280, 70, 280, 180);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Cleaner();

            Rct(100, 100, 60, 150);
            Rct(115, 115, 30, 30);

            Rct(160, 170, 250, 80);

            Elps(150, 250, 40, 40);
            Elps(300, 250, 40, 40);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Cleaner();

            Rct(200, 400, 20, 40);

            Trgl(160, 400, 260, 400, 210, 330);
            Trgl(160, 330, 260, 330, 210, 260);
            Trgl(160, 260, 260, 260, 210, 190);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Cleaner();

            Liner(10, 10, 10, 220);
            Liner(10, 220, 60, 220);
            Liner(60, 10, 10, 10);

            Arc(35, 10, 50, 210, 90, 180);

            Elps(45, 85, 60, 60);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Cleaner();

            Trgl(10, 10, 110, 10, 60, 40);

            Liner(10, 50, 10, 110);
            Liner(10, 110, 110, 110);
            Liner(110, 110, 110, 50);
            Liner(110, 50, 60, 80);
            Liner(60, 80, 10, 50);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Cleaner();

            Elps(10, 10, 100, 100);

            Elps(30, 40, 20, 20);
            Elps(70, 40, 20, 20);

            Trgl(60, 50, 55, 75, 65, 75);

            Trgl(45, 85, 75, 85, 60, 100);

            Liner(60, 10, 60, 25);
            Liner(50, 11, 45, 25);
            Liner(40, 14, 35, 25);
            Liner(70, 11, 75, 25);
            Liner(80, 14, 85, 25);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Cleaner();

            Elps(100, 100, 200, 80);
            Elps(100, 120, 35, 40);
            Elps(110, 130, 9, 9);
            Liner(110, 147, 125, 147);

            Liner(150, 175, 160, 200);
            Liner(160, 200, 260, 200);
            Liner(260, 200, 230, 178);

            Liner(150, 105, 165, 60);
            Liner(165, 60, 280, 60);
            Liner(280, 60, 265, 110);

            Liner(295, 130, 330, 90);
            Liner(330, 90, 370, 90);
            Liner(370, 90, 335, 130);
            Liner(335, 130, 370, 160);
            Liner(370, 160, 330, 170);
            Liner(330, 170, 270, 170);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Cleaner();

            Rct(100, 100, 100, 50);

            Arc(30, 150, 50, 50, 90, 180);
            Arc(210, 150, 50, 50, -90, 180);

            Liner(55, 150, 235, 150);
            Liner(55, 200, 235, 200);

            for (int i = 0; i < 5; i++)
            {
                Elps(45 + i * 45, 165, 20, 20);
            }

            Liner(130, 100, 130, 40);
            Liner(130, 40, 180, 40);
            Liner(180, 40, 180, 60);
            Liner(180, 60, 150, 60);
            Liner(150, 60, 150, 100);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Cleaner();

            Elps(100, 100, 100, 100);
            Elps(120, 140, 20, 20);
            Elps(160, 140, 20, 20);

            Liner(150, 150, 130, 80);
            Liner(130, 80, 110, 80);
            Liner(150, 150, 180, 80);
            Liner(180, 80, 200, 80);

            Arc(100, 200, 100, 100, 180, 180);
            Liner(100, 250, 100, 350);
            Liner(200, 250, 200, 350);
            Arc(100, 300, 100, 100, 0, 180);

            Trgl(120, 260, 120, 310, 60, 250);
            Trgl(180, 260, 180, 310, 240, 250);

            Liner(115, 385, 115, 450);
            Liner(115, 450, 95, 450);

            Liner(185, 385, 185, 450);
            Liner(185, 450, 205, 450);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Cleaner();

            Elps(140, 75, 20, 20);

            Arc(100, 100, 100, 50, 210, 120);
            Arc(100, 110, 100, 50, 210, 120);

            Liner(116, 107, 116, 117);
            Liner(184, 107, 184, 117);

            Elps(50, 115, 200, 200);

            Str("12", 140, 125, 12);
            Str("6", 140, 285, 12);
            Str("9", 65, 215, 12);
            Str("3", 225, 215, 12);

            Liner(150, 220, 150, 165);
            Liner(150, 220, 210, 220);

            Liner(120, 310, 110, 330);
            Liner(180, 310, 190, 330);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Cleaner();

            Rct(100, 100, 40, 10);

            Liner(120, 110, 130, 130);

            Arc(45, 155, 90, 90, 180, 180);
            Elps(50, 160, 80, 80);
            Elps(80, 190, 20, 20);

            Arc(255, 155, 90, 90, 180, 90);
            Elps(260, 160, 80, 80);
            Elps(290, 190, 20, 20);

            Elps(150, 180, 40, 40);
            Elps(165, 195, 10, 10);

            Trgl(130, 130, 90, 200, 170, 200);
            Trgl(90, 200, 50, 140, 125, 140);
            Liner(130, 130, 280, 130);
            Liner(270, 100, 300, 200);
            Liner(170, 200, 284, 145);
            Liner(90, 200, 50, 190);
            Liner(300, 200, 255, 200);
            Liner(180, 170, 190, 170);
            Liner(180, 170, 160, 230);
            Liner(160, 230, 150, 230);

            Liner(270, 100, 240, 125);
            Liner(240, 125, 230, 125);
            Liner(270, 100, 280, 65);
            Liner(280, 65, 270, 65);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Cleaner();

            Elps(100, 100, 200, 200);
            Elps(130, 130, 140, 140);
            Elps(175, 175, 50, 50);

            Elps(185, 100, 30, 30);
            Elps(250, 130, 30, 30);
            Elps(120, 130, 30, 30);
            Elps(270, 185, 30, 30);
            Elps(100, 185, 30, 30);
            Elps(250, 240, 30, 30);
            Elps(120, 240, 30, 30);

            Trgl(200, 200, 110, 350, 160, 350);
            Trgl(200, 200, 290, 350, 240, 350);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Cleaner();

            Elps(100, 100, 200, 200);
            Elps(180, 180, 40, 40);

            Elps(260, 180, 40, 40);
            Str("1", 275, 195, 10);
            Elps(250, 140, 40, 40);
            Str("2", 265, 155, 10);
            Elps(220, 110, 40, 40);
            Str("3", 235, 125, 10);
            Elps(180, 100, 40, 40);
            Str("4", 195, 115, 10);
            Elps(140, 110, 40, 40);
            Str("5", 155, 125, 10);
            Elps(110, 140, 40, 40);
            Str("6", 125, 155, 10);
            Elps(100, 180, 40, 40);
            Str("7", 115, 195, 10);
            Elps(110, 220, 40, 40);
            Str("8", 125, 235, 10);
            Elps(140, 250, 40, 40);
            Str("9", 155, 265, 10);
            Elps(180, 260, 40, 40);
            Str("0", 195, 275, 10);

            Trgl(200, 250, 270, 300, 290, 260);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> row = new List<int>()
            {
                3, 4, 8, 9, 14, 15,
                3, 4, 8, 9, 14, 15,
                5, 6, 8, 9, 12, 13,
                1, 5, 6, 8, 9, 12, 13,
                2, 3, 7, 8, 9, 10, 11,
                4, 6, 7, 8, 9, 10, 11, 12, //8
                5, 6, 7, 8, 9, 10, 11, 12, 12, //9
                5, 6, 7, 8, 9, 10, 11, 12, 12, //9
                4, 6, 7, 8, 9, 10, 11, 12, //8
                2, 3, 7, 8, 9, 10, 11, //7
                1, 5, 6, 8, 9, 12, 13, // 7
                5, 6, 8, 9, 12, 13, //6
                3, 4, 8, 9, 14, 15, // 6
                3, 4, 8, 9, 14, 15, // 6
            };
            List<int> count = new List<int>() { 6, 6, 6, 7, 7, 8, 9, 9, 8, 7, 7, 6, 6, 6 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> row = new List<int>()
            {
                2, 3, //2
                1, 2, 3, 4, // 4
                1, 2, 3, 4, 11, // 5
                2, 3, 5, 6, 12, //5
                7, 8, 13, 14, // 4
                4, 5, 9, 10, 15, // 5
                3, 4, 5, 6, 11, 12, 16, // 7
                3, 4, 5, 6, 9, 10, 13, 14, 15, 16, // 10
                4, 5, 7, 8, 15, 13, // 6
                15, 11, 12, // 3
                3, 4, 9, 10, 14, // 5
                2, 3, 4, 5, 7, 8, 12, 13, // 8
                1, 2, 3, 4, 5, 6,// 6
                1, 2, 3 ,4, 5, 6, //6
                2, 3, 4, 5, // 4
                3, 4 // 2                                       
            };
            List<int> count = new List<int>() { 2, 4, 5, 5, 4, 5, 7, 10, 6, 3, 5, 8, 6, 6, 4, 2 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> row = new List<int>()
            {
                         8,
                      6,7,
                     5,6,
                2,3, 5,6,7,8,9,10,11,12,13,14,15,16,
                2,3,4,5,6,7,8,9,10,11,
                2,3, 5,6,7,8,9,10,11,12,13,14,15,16,
                     5,6,
                      6,7,
                         8

            };
            List<int> count = new List<int>() { 1, 2, 2, 14, 10, 14, 2, 2, 1 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> row = new List<int>()
            {
                2,
                1,2,3,
                2,3,
                2,4,5,
                2,6,7,
                2,7,8,16,
                2, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, // 13
                2, 4, 5, 6,7,8,9,10,11, //9
                2, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, // 13
                2,7,8,16,
                2,6,7,
                2,4,5,
                2,3,
                1,2,3,
                2
            };
            List<int> count = new List<int>() { 1, 3, 2, 3, 3, 4, 13, 9, 13, 4, 3, 3, 2, 3, 1 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> row = new List<int>()
            {
                6,7,8,9,10, //5
                6, 7,
                6, 7,8,9,10,11,12,16, // 8
                1,2,3,4,6,7,8,9,10,11,12,13,14,15,16, // 15
                1,2,3,4,5,6,7,8,9,10,11,12, 16,//13
                1,2,3,4,5,6,7,8,9,10,11,12, 16,//13
                1,2,3,4,6,7,8,9,10,11,12,13,14,15,16, // 15
                6, 7,8,9,10,11,12,16, // 8
                6, 7,
                6,7,8,9,10, //5
            };
            List<int> count = new List<int>() { 5, 2, 8, 15, 13, 13, 15, 8, 2, 5 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> row = new List<int>()
            {
                8,
                7, 8, 9,
                7,8,9,
                7,8,9,
                7,8,9,
                6,7,8,9,10, //5
                5,6,7,8,9,10,11, //7
                5,6,7,8,9,10,11, //7
                4,5,6,7,8,9,10,11,12, //9
                4,5,6,7,8,9,10,11,12, //9
                3,4,5,6,7,8,9,10,11,12,13, //11
                2,3,4,5,6,7,8,9,10,11,12,13,14, //13
                7,8,9,
                7,8,9,
                6,7,8,
                3,4,5,6,7,8
            };
            List<int> count = new List<int>() { 1, 3, 3, 3, 3, 5, 7, 7, 9, 9, 11, 13, 3, 3, 3, 6 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> row = new List<int>()
            {
                16,
                16,
                16,
                16,
                6,7,8,9,10,11,12,13,14,16, //10
                6,7,8,9,10,11,12,13,14, 15, 16, //11
                3,5,6,7,8,9,10,11,12,13,14,15, 16, //13
                1,2,4,6,7,8,9,10,11,12,13,14,15,16, //14
                6,7,8,9,10,11,12,13,14, 15, 16, //11
                3,5,6,7,8,9,10,11,12,13,14,15, 16, //13
                1,2,4,6,7,8,9,10,11,12,13,14,15,16, //14
                6,7,8,9,10,11,12,13,14,16, //10
                7,13,16,
                7,8,9,10,11,12,16, // 7
                16
            };
            List<int> count = new List<int>() { 1, 1, 1, 1, 10, 11, 13, 14, 11, 13, 14, 10, 3, 7, 1 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> row = new List<int>()
            {
                10,
                9,11,
                8,10,12,
                8,11,13,
                6,7,8,10,
                5,6,7,8,11,13, //6
                5,6,7,8,10, // 5
                5,6,7,8,11,13, //6
                5,6,7,8,10, // 5
                6,8,11,13,
                6,8,10,
                6,8,11,13,
                6,8,10,12,
                6,8,11,
                6,9,
                6
            };
            List<int> count = new List<int>() { 1, 2, 3, 3, 4, 6, 5, 6, 5, 4, 3, 4, 4, 3, 2, 1 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<int> row = new List<int>()
            {
                8,9,10,11,//4
                7,12,
                6,8,12,15,//4
                5,7,9,10,13,16, //6
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16, // 16
                1,4,7,9,10,13, //6
                2,3,7,8,12, //5
                8,12,
                9,10,11
            };
            List<int> count = new List<int>() { 4, 2, 4, 6, 16, 6, 5, 2, 3 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> row = new List<int>()
            {
                4,5,6,7,8,9,10,11,12,13,14,15,16, //13
                4,5,6,7,16, //5
                6, 16,
                4,5,6,10,11,12,13,16,//8
                6,9,10,11,12,13,14,16, //8
                3,4,5,6,9,10,11,12,13,14,16, //11
                3,4,5,6,7,8,9,10,11,12,13,14,15,16, //14
                3,4,5,6,7,8,9,10,11,12,13,14,15,16, //14
                3,4,5,6,7,8,9,10,11,12,13,14,15,16, //14
                3,4,5,6,9,10,11,12,13,14,16, //11
                6,9,10,11,12,13,14,16, //8
                6,10,11,12,13,16,//6
                3,4,5,6,16, //5
                6,7,16,
                6,7,8,16, // 4
                6,7,8,9,10,11,12,13,14,15,16, //11

                
            };
            List<int> count = new List<int>() { 13, 5, 2, 8, 8, 11, 14, 14, 14, 11, 8, 6, 5, 3, 4, 11 };

            int state = 0;
            int st_r = 0;
            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15 };
            List<int> row = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11, //12
                3,4,6,7,8,9,12,//7
                3,4,6,7,8,9,10,13,//8
                3,4,5,9,10,13,//6
                3,4,6,7,8,9,10,13,//8
                3,4,6,7,8,9,12,//7
                1,2,3,4,5,6,7,8,9,10,11, //12

                3,4,5,6,7,8,9,10,11,12,13, //11
                5,7,8,9,10,11,12,14,//8
                5,7,8,9,10,11,14,15,//8
                5,6,10,11,13,14,15,//7
                5,7,8,9,10,11,14,15,//8
                5,7,8,9,10,11,12,14,//8
                3,4,5,6,7,8,9,10,11,12,13 //11

                
            };
            List<int> count = new List<int>() { 11, 7, 8, 6, 8, 7, 11, 11, 8, 8, 7, 8, 8, 11 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> row = new List<int>()
            {
                14,
                12,14,15,
                12,13,14,15,//4
                9,10,11,12,14,15,//6
                12,13,14,15,//4
                9,10,11,12,14,15,//6
                9,10,11,12,13,14,15,//7
                12,14,15,
                14,15,
                14,15,
                13,14,15,
                13,14,15,
                13,14,15,
                13,14,15,
                13,14,
                13



            };
            List<int> count = new List<int>() { 1, 3, 4, 6, 4, 6, 7, 3, 2, 2, 3, 3, 3, 3, 2, 1 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<int> row = new List<int>()
            {
                8,
                7,
                6,7,
                4,5,6,7,
                4,5,6,7,8,//5
                3,4,5,6,7,//5
                3,4,5,6,7,//5
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,
                3,4,5,6,7,16,//6
                3,4,5,6,7,14,15,16,//8
                4,5,6,7,8,//5
                4,5,6,7,
                6,7,
                7,
                8
            };
            List<int> count = new List<int>() { 1, 1, 2, 4, 5, 5, 5, 16, 6, 8, 5, 4, 2, 1, 1 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void tabPage19_Click(object sender, EventArgs e)
        {

        }

        private void button48_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            List<int> row = new List<int>()
            {
                11,12,13,
                8,10,11,12,13,//5
                6,7,10,11,12,13,//6
                5,6,7,9,10,11,12,13,//8
                2,3,5,6,7,8,9,10,11,12,13,14,15,16,//14
                2,3,4,5,6,7,8,9,10,11,12,//11
                2,3,5,6,7,8,9,10,11,12,13,14,15,16,//14
                5,6,7,9,10,11,12,13,//8
                6,7,10,11,12,13,//6
                8,10,11,12,13,//4
                11,12,13

            };
            List<int> count = new List<int>() { 3, 5, 6, 8, 14, 11, 14, 8, 6, 5, 3 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> row = new List<int>()
            {
                1,2,3,4,5,6,7,8,
                1,8,9,11,12,13,14,15,//8
                6,7,8,9,10,11,12,16,//8
                5,6,7,8,9,10,//6
                3,4,5,6,7,8,9,10,11,12,13,14,15,//13
                2,3,4,5,6,7,8,9,10,11,12,16,//12
                1,2,3,4,5,6,
                2,3,4,5,6,7,8,9,10,//9
                3,4,5,6,7,8,9,10,11,12,//10
                5,6,7,8,9,10, 13,14,15, //9
                5,10,11,16,//4
                1,3,4,5,6,12,13,14, //8
                2,3,5,6,7,15,16, //7
                3,4,5,7,8,//5
                2,3,5,6,7,//5
                1,3,4,5,6//5


            };
            List<int> count = new List<int>() { 8, 8, 8, 6, 13, 12, 6, 9, 10, 9, 4, 8, 7, 5, 5, 5 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Cleaner();
            // 
            List<int> col = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> row = new List<int>()
            {
                7,8,
                7,8,16,
                6,7,8,15,//4
                3,4,5,7,8,14,//6
                3,4,5,6,7,8,9,10,11,12,13,16,//12
                3,4,5,6,7,8,9,10,11,12,15,//11
                3,5,6,7,8,9,10,11,12,14,//10
                3,8,9,10,11,12,13,//7
                8,9,10,11,12,//5
                8,9,10,11,12,//5
                8,9,10,11,12,//5
                8,9,10,11,12,13,//6
                8,9,10,11,12,13,14,//7
                4,8,12,15,16, //5
                5,7,13,
                6,14,15
            };
            List<int> count = new List<int>() { 2, 3, 4, 6, 12, 11, 10, 7, 5, 5, 5, 6, 7, 5, 3, 3 };

            int state = 0;
            int st_r = 0;

            for (int i = 0; i < col.Count; i++)
            {
                for (int j = state; j < state + count[i]; j++)
                {
                    Pxl(col[i], row[j]);
                    st_r++;
                }

                state = st_r;
            }
        }
    }

}
