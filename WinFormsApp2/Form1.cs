using System.Collections.Specialized;
using System.Xaml.Permissions;

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
            dataGridView9.RowCount = 8;
            dataGridView9.ColumnCount = 10;
            Random rnd = new Random();
            double[,] arr1 = new double[8, 10];
            double[] min = new double[8];
            double[] max = new double[8];
            double max1 = 0;
            for (int i = 0; i < 8; i++)
            {
                min[i] = 10000;
                max[i] = 0;
                
                for(int j = 0; j < 10; j++)
                {
                    arr1[i, j] = rnd.Next(-10, 10);
                    dataGridView9.Rows[i].Cells[j].Value = arr1[i, j].ToString();
                    if (arr1[i,j] < min[i])
                    {
                        min[i] = arr1[i, j];
                    }
                    if (min[i] > max[i])
                    {
                        max[i] = min[i];
                    }
                    
                }
            }
        }
    }

}
