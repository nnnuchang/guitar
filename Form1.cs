using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace guitar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[,] chord;
        Label[] x;
        bool T;
        bool B;
        int p;
        int btnrang;
        string filename;
        string[] mychord;
        int[] myc;
        int[] myx;
        Formstart fs;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            fs = new Formstart();
            fs.Show();
            timer1.Interval = 3500;
            chord= new PictureBox[,] { { pic100, pic101, pic102, pic103, pic104, pic105, pic106, pic107, pic108, pic109, pic110, pic111, pic112, pic113, pic114, pic115, pic116, pic117 }, { pic200, pic201, pic202, pic203, pic204, pic205, pic206, pic207, pic208, pic209, pic210, pic211, pic212, pic213, pic214, pic215, pic216, pic217 }, { pic300, pic301, pic302, pic303, pic304, pic305, pic306, pic307, pic308, pic309, pic310, pic311, pic312, pic313, pic314, pic315, pic316, pic317 }, { pic400, pic401, pic402, pic403, pic404, pic405, pic406, pic407, pic408, pic409, pic410, pic411, pic412, pic413, pic414, pic415, pic416, pic417 }, { pic500, pic501, pic502, pic503, pic504, pic505, pic506, pic507, pic508, pic509, pic510, pic511, pic512, pic513, pic514, pic515, pic516, pic517 }, { pic600, pic601, pic602, pic603, pic604, pic605, pic606, pic607, pic608, pic609, pic610, pic611, pic612, pic613, pic614, pic615, pic616, pic617 } };
            x = new Label[] { lbl1x, lbl2x, lbl3x, lbl4x, lbl5x, lbl6x };
            T = false;
            B = false;
            mychord = new string[0];
            myc = new int[0];
            myx = new int[0];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    chord[i, j].Image = imageList1.Images[0];
                    chord[i, j].Visible = false;
                }
            }
            timer1.Enabled = true;
            timer2.Interval = 1;
            timer2.Enabled = true;
        }

        private void check()
        {
            recheck:
            //string[] CtoB = new string[] { "C", "D", "E", "F", "G", "A" };
            //string[] m = new string[] { "major", "minor" };
            //string[] finger = new string[] { "開放", "E指型", "A指型", "F指型", "CAGED" };

            if (comboBox1.Text == "C")
            {
                comboBox2.Enabled = comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                int c = 0;
                if (comboBox4.Text == "#")
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                if (comboBox2.Text == "major")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Cmaj(0);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emaj(8 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amaj(3+c);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmaj(7 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                }
                else if (comboBox2.Text == "minor")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Cmin(0+c);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emin(8 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amin(3 + c);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmin(7 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        caged(0);
                    }
                }
            }

            else if (comboBox1.Text == "D")
            {
                comboBox2.Enabled = comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                int c = 0;
                if (comboBox4.Text == "#")
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                if (comboBox2.Text == "major")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Dmaj(0);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }

                    else if (comboBox3.Text == "E指型")
                    {
                        Emaj(10 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amaj(5 + c);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmaj(9 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                }
                else if (comboBox2.Text == "minor")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Dmin(0 + c);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emin(10 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amin(5 + c);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmin(9 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        caged(0);
                    }
                }
            }


            else if (comboBox1.Text == "E")
            {
                comboBox2.Enabled = comboBox3.Enabled = true;
                comboBox4.Enabled = false;
                int c = 0;
                if (comboBox4.Text == "#")
                {
                    c = 1;
                    comboBox4.Text = " ";
                    comboBox1.Text = "F";
                    goto recheck;
                }
                else
                {
                    c = 0;
                }
                if (comboBox2.Text == "major")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Emaj(0);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emaj(0 + c);
                        T = true;
                        Emaj(12 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amaj(7 + c);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmaj(11 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                }
                else if (comboBox2.Text == "minor")
                {
                    if (comboBox3.Text == "開放")
                    {
                        
                        Emin(0 + c);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emin(0 + c);
                        T = true;
                        Emin(12 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amin(7 + c);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmin(11 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        caged(0);
                    }
                }
            }


            else if (comboBox1.Text == "F")
            {
                comboBox2.Enabled = comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                int c = 0;
                if (comboBox4.Text == "#")
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                if (comboBox2.Text == "major")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Fmaj(0 + c);
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emaj(1 + c);
                        T = true;
                        Emaj(13 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amaj(8);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmaj(0 + c);
                        T = true;
                        Fmaj(12 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                }
                else if (comboBox2.Text == "minor")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Fmin(0 + c);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emin(1 + c);
                        T = true;
                        Emin(13 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amin(8);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmin(0 + c);
                        T = true;
                        Fmin(12 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        caged(0);
                    }
                }
            }

            else if (comboBox1.Text == "G")
            {
                comboBox2.Enabled = comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                int c = 0;
                if (comboBox4.Text == "#")
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                if (comboBox2.Text == "major")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Gmaj(0);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emaj(3 + c);
                        T = true;
                        Emaj(15 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amaj(10);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmaj(2 + c);
                        T = true;
                        Fmaj(14 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                }
                else if (comboBox2.Text == "minor")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Gmin(0 + c);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emin(3 + c);
                        T = true;
                        Emin(15 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amin(10);
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmin(2 + c);
                        T = true;
                        Fmin(14 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        caged(0);
                    }
                }
            }



            else if (comboBox1.Text == "A")
            {
                comboBox2.Enabled = comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                int c = 0;
                if (comboBox4.Text == "#")
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                if (comboBox2.Text == "major")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Amaj(0);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emaj(5 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amaj(0 + c);
                        T = true;
                        Amaj(12 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmaj(4+c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                }
                else if (comboBox2.Text == "minor")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Amin(0 + c);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emin(5 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amin(0 + c);
                        T = true;
                        Amin(12 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmin(4 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        caged(0);
                    }
                }
            }


            else if (comboBox1.Text == "B")
            {
                comboBox2.Enabled = comboBox3.Enabled = true;
                comboBox4.Enabled = false;
                int c = 0;
                if (comboBox4.Text == "#")
                {
                    c = 1;
                    comboBox4.Text = " ";
                    comboBox1.Text = "C";
                    goto recheck;
                }   
                else
                {
                    c = 0;
                }
                if (comboBox2.Text == "major")
                {
                    if (comboBox3.Text == "開放")
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 18; j++)
                            {
                                chord[i, j].Image = imageList1.Images[0];
                                chord[i, j].Visible = false;
                                x[i].Text = "";


                            }
                        }
                    }

                    else if (comboBox3.Text == "E指型")
                    {
                        Emaj(7 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amaj(2+c);
                        T = true;
                        Amaj(14 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmaj(6+c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                    
                }

                else if (comboBox2.Text == "minor")
                {
                    if (comboBox3.Text == "開放")
                    {
                        Bmin(0 + c);
                        if (c == 1)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                for (int j = 0; j < 18; j++)
                                {
                                    chord[i, j].Image = imageList1.Images[0];
                                    chord[i, j].Visible = false;
                                    x[i].Text = "";
                                }
                            }
                        }
                    }
                    else if (comboBox3.Text == "E指型")
                    {
                        Emin(7 + c);
                    }
                    else if (comboBox3.Text == "A指型")
                    {
                        Amin(2 + c);
                        T = true;
                        Amin(14 + c);
                        T = false;
                    }
                    else if (comboBox3.Text == "F指型")
                    {
                        Fmin(6 + c);
                    }
                    else if (comboBox3.Text == "CAGED")
                    {
                        CAGED(0);
                    }
                }
                
            }
            else
            {
                for (int i = 0; i < mychord.Length; i++)
                {

                    if (comboBox1.Text == mychord[i])
                    {
                        comboBox2.Text = comboBox3.Text = comboBox4.Text = "";
                        comboBox2.Enabled = comboBox3.Enabled =comboBox4.Enabled= false;
                        int[] a=new int[0];
                        int[] b=new int[0];
                        Label[] x = new Label[] { lbl1x, lbl2x, lbl3x, lbl4x, lbl5x, lbl6x};
                        int r=0;
                        for (int k = 0; k <6; k++)
                        {
                            int v=(i* 6)+k;
                            if (myc[v] != -1)
                            {
                                int bl = b.Length;
                                Array.Resize(ref b, bl+1);
                                int al = a.Length;
                                Array.Resize(ref a, al+1);
                                b[r] = myc[v];
                                a[r] = 5 - k;
                                r++;
                                //string x = "";
                                //foreach (int s in a)
                                //{
                                //    x += Convert.ToString(s) + ",";
                                //}

                                //MessageBox.Show(x);
                                //x = "";
                                //foreach (int s in b)
                                //{
                                //    x += Convert.ToString(s) + ",";
                                //}

                                //MessageBox.Show(x);
                            }
                            else
                            {
                                continue;
                            }
                            
                        }
                        if (b.Max() > 17)
                        {

                        }
                        else
                        {
                            chord_(a, b);
                            for (int j = 0; j < 6; j++)
                            {
                                int v = (i * 6) + j;
                                if (myx[v] == 1)
                                    x[5-j].Text = "X";
                                else
                                    x[5-j].Text = "";
                            }
                            //string x = "";
                            //foreach (int s in a)
                            //{
                            //    x += Convert.ToString(s) + ",";
                            //}

                            //MessageBox.Show(x);
                            //foreach (int s in b)
                            //{
                            //    x += Convert.ToString(s) + ",";
                            //}

                            //MessageBox.Show(x);
                        }
                        break;
                    }
                }
            }
        }
        

        private void chord_(int[]a,int[]b)
        {
            btnL.Enabled = false;
            btnR.Enabled = false;
            int col = 1;
            for (int i = 0; i < 6; i++)
            {
                x[i].Text = "";
                if (T == false)
                {
                    for (int j = 0; j < 18; j++)
                    {
                        chord[i, j].Image = imageList1.Images[0];
                        chord[i, j].Visible = false;
                    }
                }
                
            }
            if (B == true)
            {
                 col = 0;
            }
            else
            {
                col=1;
            }
            for (int i = 0; i < a.Length; i++)
            {
                chord[a[i], b[i]].Visible = true;
                chord[a[i], b[i]].Image = imageList1.Images[col];
                if (a[i] == a.Max() && B==false)
                {
                    chord[a[i], b[i]].Image = imageList1.Images[2];
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (a.Max() < i && B==false)
                {
                    x[i].Text = "X";
                }
                else
                {
                    x[i].Text = "";
                }
            }
        }


        private void Cmaj(int i)
        {
            int[] a = new int[] { 4, 3, 1 };
            int[] b = new int[] { 3, 2, 1 };
            int[] c = new int[b.Length];
            for (int j=0;j<c.Length;j++)
            {
                c[j] = b[j] + i; 
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
                if (i > 0 && B == false)
                {
                    int[] x = new int[] { 2, 1, 0 };
                    int[] y = new int[] { i ,i ,i};
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                } 
            }
        }

        private void Dmaj(int i)
        {
            int[] a = new int[] { 3, 2, 1, 0 };
            int[] b = new int[] { 0, 2, 3, 2 };
            int[] c = new int[b.Length];
           for (int j=0;j<c.Length;j++)
            {
                c[j] = b[j] + i; 
            }
           if (c.Max() > 17)
           {

           }
           else
           {
               chord_(a, c);
           }
        }

        private void Emaj(int i)
        {  
            int[] a = new int[] { 5, 4, 3, 2 };
            int[] b = new int[] { 0, 2, 2, 1 };
            int[] c = new int[b.Length];
            for (int j=0;j<c.Length;j++)
            {
                c[j] = b[j] + i; 
            }
            if (c.Max() > 17)
            {
                
            }
            else
            {
                chord_(a, c);
                if (i > 0&&B==false)
                {
                    int[] x = new int[] { 4, 3, 2, 1, 0 };
                    int[] y = new int[] { i, i, i, i, i };
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                } 
            }
        }

        private void Fmaj(int i)
        {
            int[] a = new int[] { 3, 2, 1, 0 };
            int[] b = new int[] { 3, 2, 1, 1 };
            int[] c = new int[b.Length];
            for (int j=0;j<c.Length;j++)
            {
                c[j] = b[j] + i; 
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
            }
        }

        private void Gmaj(int i)
        {
            int[] a = new int[] { 5, 4, 0 };
            int[] b = new int[] { 3, 2, 3 };
            int[] c = new int[b.Length];
           for (int j=0;j<c.Length;j++)
            {
                c[j] = b[j] + i; 
            }
           if (c.Max() > 17)
           {

           }
           else
           {
               chord_(a, c);
               if (i > 0 && B == false)
               {
                   int[] x = new int[] { 3, 2, 1, 0 };
                   int[] y = new int[] { i, i, i, i };
                   for (int z = 0; z < x.Length; z++)
                   {
                       chord[x[z], y[z]].Visible = true;
                       chord[x[z], y[z]].Image = imageList1.Images[3];
                   }
               } 
           }
        }

        private void Amaj(int i)
        {
            int[] a = new int[] { 4, 3, 2, 1};
            int[] b = new int[] { 0, 2, 2, 2};
            int[] c = new int[b.Length];
            for (int j=0;j<c.Length;j++)
            {
                c[j] = b[j] + i; 
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
                if (i > 0 && B == false)
                {
                    int[] x = new int[] {  3, 2, 1, 0 };
                    int[] y = new int[] {  i, i, i, i };
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                } 
            }
        }

        //private void Bmaj(int i)
        //{
        //    int[] a = new int[] { 4,3, 2, 1, 0 };
        //    int[] b = new int[] { 2,4, 4, 4, 2 };
        //    chord_(a, b);
        //}



        private void Cmin(int i)
        {
            int[] a = new int[] { 4, 3, 1 };
            int[] b = new int[] { 3, 1, 1 };
            int[] c = new int[b.Length];
            for (int j = 0; j < c.Length; j++)
            {
                c[j] = b[j] + i;
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
                if (i > 0 && B == false)
                {
                    int[] x = new int[] { 2, 1, 0 };
                    int[] y = new int[] { i, i, i };
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                }
            }
            lbl1x.Text = "X";
        }

        private void Dmin(int i)
        {
            int[] a = new int[] { 3, 2, 1, 0 };
            int[] b = new int[] { 0, 2, 3, 1 };
            int[] c = new int[b.Length];
            for (int j = 0; j < c.Length; j++)
            {
                c[j] = b[j] + i;
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
            }
        }

        private void Emin(int i)
        {
            int[] a = new int[] { 5, 4, 3 };
            int[] b = new int[] { 0, 2, 2 };
            int[] c = new int[b.Length];
            for (int j = 0; j < c.Length; j++)
            {
                c[j] = b[j] + i;
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
                if (i > 0 && B == false)
                {
                    int[] x = new int[] { 4, 3, 2, 1, 0 };
                    int[] y = new int[] { i, i, i, i, i };
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                }
            }
        }

        private void Fmin(int i)
        {
            int[] a = new int[] { 3, 2, 1, 0 };
            int[] b = new int[] { 3, 1, 1, 1 };
            int[] c = new int[b.Length];
            for (int j = 0; j < c.Length; j++)
            {
                c[j] = b[j] + i;
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
            }
        }

        private void Gmin(int i)
        {
            int[] a = new int[] { 5, 4,1, 0 };
            int[] b = new int[] { 3, 1, 3,3 };
            int[] c = new int[b.Length];
            for (int j = 0; j < c.Length; j++)
            {
                c[j] = b[j] + i;
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
                if (i > 0 && B == false)
                {
                    int[] x = new int[] { 3, 2, 1, 0 };
                    int[] y = new int[] { i, i, i, i };
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                }
            }
        }

        private void Amin(int i)
        {
            int[] a = new int[] { 4, 3, 2, 1 };
            int[] b = new int[] { 0, 2, 2, 1 };
            int[] c = new int[b.Length];
            for (int j = 0; j < c.Length; j++)
            {
                c[j] = b[j] + i;
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
                if (i > 0 && B == false)
                {
                    int[] x = new int[] { 3, 2, 1, 0 };
                    int[] y = new int[] { i, i, i, i };
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                }
            }
        }

        private void Bmin(int i)
        {
            int[] a = new int[] { 2, 1, 0 };
            int[] b = new int[] { 4, 3, 2 };
            int[] c = new int[b.Length];
            for (int j = 0; j < c.Length; j++)
            {
                c[j] = b[j] + i;
            }
            if (c.Max() > 17)
            {

            }
            else
            {
                chord_(a, c);
                if (i > 0 && B == false)
                {
                    int[] x = new int[] { 2, 1, 0 };
                    int[] y = new int[] { i, i, i };
                    for (int z = 0; z < x.Length; z++)
                    {
                        chord[x[z], y[z]].Visible = true;
                        chord[x[z], y[z]].Image = imageList1.Images[3];
                    }
                }
            }
        }


        private void CAGED(int c)
        {
            if (c == 0) { p = 0; }
            int[] sc = new int[] { 0, 3, 5, 8, 10, 12 ,15};
            int[] sa = new int[] { 0, 2, 5, 7, 9, 12 ,14};
            int[] sg = new int[] { 0, 3,5, 7,10 ,12,15};
            int[] se = new int[] { 0, 2, 4, 7, 9, 12 ,14};
            int[] sd = new int[] { 0, 2, 5, 7, 10, 12, 14};
            for (int i = 0; i < 6; i++)
            {
                x[i].Text = "";
                if (T == false)
                {
                    for (int j = 0; j < 18; j++)
                    {
                        chord[i, j].Image = imageList1.Images[0];
                        chord[i, j].Visible = false;
                    }
                }

            }

            B = true;
            switch (comboBox1.Text)
            {
                case "C":
                    run(0, sc, p);
                    //chordnum=0;
                    //btnrang = sc.Length;
                    //WhatChord(chordnum, 0);
                    //T = true;
                    //for (int i = 1; i < sc.Length; i++)
                    //{
                    //    WhatChord(i, sc[i]);
                    //}
                    
                    //B = false;
                    //WhatChord(p, sc[p]);
                    //T = false;
                    
                    break;
                case "A":
                    run(1, sa, p);
                    break;
            //Amaj(0);
            //T = true;
            //Gmaj(2);
            //Emaj(5);
            //Dmaj(7);
            //Cmaj(9);
            //Amaj(12);
            //Gmaj(14);
            //T = false;
            //B = false;
            //break;
                case "G":
                    run(2, sg, p);
                    break;
                case "E":
                    run(3, se, p);
                    break;
                case "D":
                    run(4, sd, p);
                    break;
                case "F":
                    run(3, se, p);
                    break;
                case "B":
                    run(1, sa, p);
                    break;


            }
            btnEnabled();
        }

        private void WhatChord(int i,int j)
        {
            switch (i)
            {
                case 0:
                    Cmaj(j);
                    break;
                case 1:
                    Amaj(j);
                    break;
                case 2:
                    Gmaj(j);
                    break;
                case 3:
                    Emaj(j);
                    break;
                case 4:
                    Dmaj(j);
                    break;
                case 5:
                    Cmaj(j);
                    break;
                case 6:
                    Amaj(j);
                    break;
                case 7:
                    Gmaj(j);
                    break;
                case 8:
                    Emaj(j);
                    break;
                case 9:
                    Dmaj(j);
                    break;

                case 10:
                    Cmaj(j);
                    break;
                case 11:
                    Amaj(j);
                    break;
                case 12:
                    Gmaj(j);
                    break;
                case 13:
                    Emaj(j);
                    break;
                case 14:
                    Dmaj(j);
                    break;
            }
        }


        private void caged(int c)
        {
            if (c == 0) { p = 0; }
            int[] sc = new int[] { 0, 3, 5, 8, 10, 12, 15 };
            int[] sa = new int[] { 0, 2, 5, 7, 9, 12, 14 };
            int[] sg = new int[] { 0, 3, 5, 7, 10, 12, 15 };
            int[] se = new int[] { 0, 2, 4, 7, 9, 12, 14 };
            int[] sd = new int[] { 0, 2, 5, 7, 10, 12, 14 };
            for (int i = 0; i < 6; i++)
            {
                x[i].Text = "";
                if (T == false)
                {
                    for (int j = 0; j < 18; j++)
                    {
                        chord[i, j].Image = imageList1.Images[0];
                        chord[i, j].Visible = false;
                    }
                }

            }

            B = true;
            switch (comboBox1.Text)
            {
                case "C":
                    runmin(0, sc, p);
                    break;
                case "A":
                    runmin(1, sa, p);
                    break;
                case "G":
                    runmin(2, sg, p);
                    break;
                case "E":
                    runmin(3, se, p);
                    break;
                case "D":
                    runmin(4, sd, p);
                    break;
                case "F":
                    runmin(3, se, p);
                    break;
                case "B":
                    runmin(1, sa, p);
                    break;
            }
            btnEnabled();
        }

        private void WhatChordmin(int i, int j)
        {
            switch (i)
            {
                case 0:
                    Cmin(j);
                    break;
                case 1:
                    Amin(j);
                    break;
                case 2:
                    Gmin(j);
                    break;
                case 3:
                    Emin(j);
                    break;
                case 4:
                    Dmin(j);
                    break;
                case 5:
                    Cmin(j);
                    break;
                case 6:
                    Amin(j);
                    break;
                case 7:
                    Gmin(j);
                    break;
                case 8:
                    Emin(j);
                    break;
                case 9:
                    Dmin(j);
                    break;
                case 10:
                    Cmin(j);
                    break;
                case 11:
                    Amin(j);
                    break;
                case 12:
                    Gmin(j);
                    break;
                case 13:
                    Emin(j);
                    break;
                case 14:
                    Dmin(j);
                    break;
            }
        }


        private void btnEnabled()
        {
            if (p < 1)
                btnL.Enabled = false;
            else
                btnL.Enabled = true;
            if (p < btnrang-1)
                btnR.Enabled = true;
            else
                btnR.Enabled = false;
        }


        private void run(int chordnum,int[] s,int p) 
        {
            int c=0;
            int f = 0;
            if (comboBox4.Text == "#")
            {
                c = 1;
                f = 1;
            }
            else
            {
                c=0;
            }
            if (comboBox1.Text == "F")
            {
                c += 1;
                f = 1;
            }
            else if (comboBox1.Text == "B")
            {
                c += 2;
                f=1;
            }
            btnrang = s.Length-f;
            WhatChord(chordnum, 0+c);
            T = true;
            for (int i = 1; i < s.Length; i++)
            {
                WhatChord(chordnum+i, s[i]+c);
            }
            if (comboBox4.Text == "#")
            {
                for (int d = 0; d < 6; d++)
                {
                    chord[d, 0 + c].Image = imageList1.Images[0];
                    chord[d, 0 + c].Visible = true;
                }
            }
            B = false;
            WhatChord(chordnum+p, s[p]+c);
            T = false;
        }

        private void runmin(int chordnum, int[] s, int p)
        {
            int c = 0;
            int f = 0;
            if (comboBox4.Text == "#")
            {
                c = 1;
                f = 1;
            }
            else
            {
                c = 0;
            }
            if (comboBox1.Text == "F")
            {
                c += 1;
                f = 1;
            }
            else if (comboBox1.Text == "B")
            {
                c += 2;
                f=1;
            }
            btnrang = s.Length-f;
            WhatChordmin(chordnum, 0 + c);
            T = true;
            for (int i = 1; i < s.Length; i++)
            {
                WhatChordmin(chordnum + i, s[i] + c);
            }
            if (comboBox4.Text == "#")
            {
                for (int d = 0; d < 6; d++)
                {
                    chord[d, 0 + c].Image = imageList1.Images[0];
                    chord[d, 0 + c].Visible = true;
                }
            }
            B = false;
            WhatChordmin(chordnum + p, s[p] + c);
            T = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            check();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            check();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            check();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            check();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            p--;
            btnEnabled();
            switch (comboBox2.Text)
            {
                case "major":
                    CAGED(1);
                    break;
                case "minor":
                    caged(1);
                    break;
            }
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            p++;
            btnEnabled();
            switch (comboBox2.Text)
            {
                case "major":
                    CAGED(1);
                    break;
                case "minor":
                    caged(1);
                    break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter="文書檔(*.txt)|*.txt";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.DefaultExt = ".txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnOpen.Enabled = false;
                filename = openFileDialog1.FileName;
                FileInfo f = new FileInfo(openFileDialog1.FileName);
                StreamReader sr = f.OpenText();
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    int l=mychord.Length+1;
                    int ml = myc.Length + 1;
                    int mx = myx.Length + 1;
                    string []putin;
                    string[] putinx;
                    string[]nl=line.Split(':');
                    try
                    {
                        Array.Resize(ref mychord, l);
                        
                        mychord[mychord.Length - 1] = nl[0];
                        putin=nl[1].Split(',');
                        for(int i=0;i<putin.Length;i++)
                        {
                            ml = myc.Length + 1;
                            Array.Resize(ref myc,ml);
                            myc[myc.Length - 1] = Convert.ToInt32(putin[i]);
                        } 
                        putinx = nl[2].Split('-');
                        for (int i = 0; i < putin.Length; i++)
                        {
                            mx = myx.Length + 1;
                            Array.Resize(ref myx, mx);
                            myx[myx.Length - 1] = Convert.ToInt32(putinx[i]);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("資料錯誤");
                    }
                    

                    
                    //string a = "";
                    //foreach (int s in myc)
                    //{
                    //    a += Convert.ToString(s) + ",";
                    //}

                    //MessageBox.Show(a);
                }
                foreach (string s in mychord)
                {
                    comboBox1.Items.Add(s);
                }
                sr.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            numericUpDown1.Enabled = numericUpDown2.Enabled = numericUpDown3.Enabled = numericUpDown4.Enabled = numericUpDown5.Enabled = numericUpDown6.Enabled =checkBox1.Enabled=checkBox2.Enabled=checkBox3.Enabled=checkBox4.Enabled=checkBox5.Enabled=checkBox6.Enabled =true;
            btnOk.Enabled = btnNo.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            numericUpDown1.Enabled = numericUpDown2.Enabled = numericUpDown3.Enabled = numericUpDown4.Enabled = numericUpDown5.Enabled = numericUpDown6.Enabled = checkBox1.Enabled = checkBox2.Enabled = checkBox3.Enabled = checkBox4.Enabled = checkBox5.Enabled = checkBox6.Enabled = false;
            textBox1.Text = "";
            numericUpDown1.Value = numericUpDown2.Value = numericUpDown3.Value = numericUpDown4.Value = numericUpDown5.Value = numericUpDown6.Value = 0;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = checkBox5.Checked = checkBox6.Checked = false;
            btnOk.Enabled = btnNo.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CheckBox[] achb = new CheckBox[] { checkBox6,checkBox5,checkBox4,checkBox3,checkBox2,checkBox1};
            string havex="";
            foreach (CheckBox Ch in achb)
            {
                if (Ch.Checked == true)
                    havex += "1-";
                else
                    havex += "0-";
            }
            string save=textBox1.Text+":"+Convert.ToString(numericUpDown6.Value)+","+Convert.ToString(numericUpDown5.Value)+","+Convert.ToString(numericUpDown4.Value)+","+Convert.ToString(numericUpDown3.Value)+","+Convert.ToString(numericUpDown2.Value)+","+Convert.ToString(numericUpDown1.Value)+":"+havex;
            try
            {
                FileInfo f = new FileInfo(filename);
                StreamWriter sw = f.AppendText();
                sw.Write("\r\n");
                sw.Write(save);
                int l = mychord.Length + 1;
                int ml = myc.Length + 1;
                int mx = myx.Length + 1;
                string[] putin;
                string[] putinx;
                string[] nl = save.Split(':');
                try
                {
                    Array.Resize(ref mychord, l);

                    mychord[mychord.Length - 1] = nl[0];
                    putin = nl[1].Split(',');
                    for (int i = 0; i < putin.Length; i++)
                    {
                        ml = myc.Length + 1;
                        Array.Resize(ref myc, ml);
                        myc[myc.Length - 1] = Convert.ToInt32(putin[i]);
                    }
                    putinx = nl[2].Split('-');
                    for (int i = 0; i < putin.Length; i++)
                    {
                        mx = myx.Length + 1;
                        Array.Resize(ref myx, mx);
                        myx[myx.Length - 1] = Convert.ToInt32(putinx[i]);
                    }
                }
                catch
                {
                    MessageBox.Show("資料錯誤");
                }
                comboBox1.Items.Add(textBox1.Text);
                sw.Flush();
                sw.Close();
                textBox1.Enabled = false;
                numericUpDown1.Enabled = numericUpDown2.Enabled = numericUpDown3.Enabled = numericUpDown4.Enabled = numericUpDown5.Enabled = numericUpDown6.Enabled = false;
                textBox1.Text = "";
                numericUpDown1.Value = numericUpDown2.Value = numericUpDown3.Value = numericUpDown4.Value = numericUpDown5.Value = numericUpDown6.Value = 0;
                btnOk.Enabled = btnNo.Enabled = false;
            }
            catch
            {
                MessageBox.Show("請選擇檔案");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fs.Dispose();
            timer1.Enabled=false;
            this.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timer2.Enabled = false;
        }

    }
}
