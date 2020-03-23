using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectOOp
{
    public partial class FormMatrix : Form
    {
        public FormMatrix()
        {
            InitializeComponent();
        }

        private void FormMatrix_Load(object sender, EventArgs e)
        {

        }

        TextBox[,] box1, box2;
        Label[,] labelsRez;
        Label labelPtRez;
        private TextBox[,] gen_mat(int dim1, int dim2, int nrDeOrdine, Point unde)
        {
            TextBox[,] box = new TextBox[dim1+1, dim2+1];
            int loc1 = unde.X + 80;
            int loc2 = unde.Y;
            char lit = 'A';
            if (nrDeOrdine == 2)
                lit = 'B';

            for (int i = 0; i < dim1; i++)
            {
                loc1 = unde.X + 10;
                loc2 = loc2 + 30;

                for (int j = 0; j < dim2; j++)
                {
                    box[i, j] = new TextBox();
                    box[i, j].Name = lit + Convert.ToString(i*dim1+j);
                    //MessageBox.Show(loc1.ToString());
                    loc1 = loc1 + 35;
                    box[i, j].Width = 30;
                    box[i, j].Height = 30;
                    box[i, j].Location = new Point(loc1, loc2 + 30);
                    this.panel2.Controls.Add(box[i, j]);
                }
            }
            return box;
        }

        TextBox n_tb = new TextBox();
        TextBox m_tb = new TextBox();
        TextBox p_tb = new TextBox();
        Label n_text = new Label();
        Label m_text = new Label();
        Label p_text = new Label();
        Button btn = new Button();
        Button btnCalc = new Button();

        private void genButtonCalc()
        {
            //MessageBox.Show("Aici");
            btnCalc.Text = "Calculeaza";
            Point saPun = buttonCalculeaza.Location;
            btnCalc.Location = new Point(saPun.X, saPun.Y+7);
            this.panel3.Controls.Add(btnCalc);
            btnCalc.Click += new EventHandler(this.btnCalc_click);
        }
        private void gen_n()
        {
            n_text.Text = "n = ";
            n_text.AutoSize = true;
            n_text.Location = new Point(0, 5);
            n_tb.Location = new Point(30, 1);

            this.panel3.Controls.Add(n_text);
            this.panel3.Controls.Add(n_tb);

            btn.Text = "Genereaza";
            btn.Location = new Point(150, 0);
            this.panel3.Controls.Add(btn);
            btn.Click += new EventHandler(this.btn_click);
        }
        private void gen_k()
        {
            n_text.Text = "k = ";
            n_text.AutoSize = true;
            n_text.Location = new Point(0, 5);
            n_tb.Location = new Point(30, 1);

            this.panel3.Controls.Add(n_text);
            this.panel3.Controls.Add(n_tb);

            btn.Text = "Genereaza";
            btn.Location = new Point(150, 0);
            this.panel3.Controls.Add(btn);
            btn.Click += new EventHandler(this.btn_click);
        }
        private void gen_n_m()
        {
            n_text.Text = "n = ";
            n_text.AutoSize = true;
            m_text.Text = "m = ";
            m_text.AutoSize = true;
            n_text.Location = new Point(0, 4);
            n_tb.Location = new Point(30, 0);
            m_text.Location = new Point(0, 54);
            m_tb.Location = new Point(30, 50);

            this.panel3.Controls.Add(m_text);
            this.panel3.Controls.Add(n_text);
            this.panel3.Controls.Add(n_tb);
            this.panel3.Controls.Add(m_tb);

            btn.Text = "Genereaza";
            btn.Location = new Point(150, 25);
            this.panel3.Controls.Add(btn);
            btn.Click += new EventHandler(this.btn_click);
        }

        private void gen_n_m_p()
        {
            n_text.Text = "n = ";
            n_text.AutoSize = true;
            m_text.Text = "m = ";
            m_text.AutoSize = true;
            p_text.Text = "p = ";
            p_text.AutoSize = true;

            n_text.Location = new Point(0, 4);
            n_tb.Location = new Point(30, 0);
            m_text.Location = new Point(0, 34);
            m_tb.Location = new Point(30, 30);
            p_text.Location = new Point(0, 64);
            p_tb.Location = new Point(30, 60);

            this.panel3.Controls.Add(m_text);
            this.panel3.Controls.Add(n_text);
            this.panel3.Controls.Add(p_text);
            this.panel3.Controls.Add(n_tb);
            this.panel3.Controls.Add(m_tb);
            this.panel3.Controls.Add(p_tb);

            btn.Text = "Genereaza";
            btn.Location = new Point(150, 30);
            this.panel3.Controls.Add(btn);
            btn.Click += new EventHandler(this.btn_click);

        }
        private void gen_n_m_nr()
        {
            n_text.Text = "n = ";
            n_text.AutoSize = true;
            m_text.Text = "m = ";
            m_text.AutoSize = true;
            p_text.Text = "nr = ";
            p_text.AutoSize = true;

            n_text.Location = new Point(0, 4);
            n_tb.Location = new Point(30, 0);
            m_text.Location = new Point(0, 34);
            m_tb.Location = new Point(30, 30);
            p_text.Location = new Point(0, 64);
            p_tb.Location = new Point(30, 60);

            this.panel3.Controls.Add(m_text);
            this.panel3.Controls.Add(n_text);
            this.panel3.Controls.Add(p_text);
            this.panel3.Controls.Add(n_tb);
            this.panel3.Controls.Add(m_tb);
            this.panel3.Controls.Add(p_tb);

            btn.Text = "Genereaza";
            btn.Location = new Point(150, 30);
            this.panel3.Controls.Add(btn);
            btn.Click += new EventHandler(this.btn_click);

        }

        private void gen_n_putere()
        {
            n_text.Text = "n = ";
            n_text.AutoSize = true;
            m_text.Text = "putere = ";
            m_text.AutoSize = true;
            n_text.Location = new Point(0, 4);
            n_tb.Location = new Point(30, 0);
            m_text.Location = new Point(0, 54);
            m_tb.Location = new Point(50, 50);

            this.panel3.Controls.Add(m_text);
            this.panel3.Controls.Add(n_text);
            this.panel3.Controls.Add(n_tb);
            this.panel3.Controls.Add(m_tb);

            btn.Text = "Genereaza";
            btn.Location = new Point(150, 25);
            this.panel3.Controls.Add(btn);
            btn.Click += new EventHandler(this.btn_click);
        }

        int n, m, p, k, putere, nrDeInmultit;
        int butGenereaza;
        Point aici1, aici2, aici3;
        private void iaN(TextBox x)
        {
            try
            {

               n = int.Parse(x.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. n!");
                butGenereaza = 0;
                return;
            }
            if (n > 10 || n < 1)
            {
                MessageBox.Show("n nu respecta limitele");
                return;
            }

            box1=gen_mat(n, n, 1, aici1);

            genButtonCalc();
            //gen_mat(n, n, 2);
        }
        private void iaK(TextBox x)
        {
            try
            {

               k = int.Parse(x.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. k!");
                butGenereaza = 0;
                return;
            }
            if (k > 1000000000 || k < 0)
            {
                MessageBox.Show("k nu respecta limitele");
                return;
            }

            genButtonCalc();
            //gen_mat(n, n, 2);
        }
        private void iaNMNr(TextBox x, TextBox y, TextBox z)
        {
            try
            {

                n = int.Parse(x.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. n!");
                butGenereaza = 0;
                return;
            }

            if (n > 10 || n < 1)
            {
                MessageBox.Show("n nu respecta limitele");
                return;
            }

            try
            {

                m = int.Parse(y.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. m!");
                butGenereaza = 0;
                return;
            }

            if (m > 10 || m < 1)
            {
                MessageBox.Show("m nu respecta limitele");
                return;
            }

            try
            {
                nrDeInmultit = int.Parse(z.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. nr cu care doriti sa inmultiti!");
                butGenereaza = 0;
                return;
            }

            if (nrDeInmultit > 1000000000)
            {
                MessageBox.Show("Numarul este un pic prea mare, nu credeti?");
                return;
            }

            box1 = gen_mat(n, m, 1, aici1);

            genButtonCalc();
        }

        private void iaNMDar1Mat(TextBox x, TextBox y)
        {
            try
            {

               n = int.Parse(x.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. n!");
                butGenereaza = 0;
                return;
            }

            if (n > 10 || n < 1)
            {
                MessageBox.Show("n nu respecta limitele");
                return;
            }

            try
            {

               m = int.Parse(y.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. m!");
                butGenereaza = 0;
                return;
            }
            if (m > 10 || m < 1)
            {
                MessageBox.Show("m nu respecta limitele");
                return;
            }
            box1=gen_mat(n, m, 1, aici1);

            genButtonCalc();
        }
        private void iaNM(TextBox x, TextBox y)
        {
            try
            {

               n = int.Parse(x.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. n!");
                butGenereaza = 0;
                return;
            }

            if (n > 10 || n < 1)
            {
                MessageBox.Show("n nu respecta limitele");
                return;
            }

            try
            {

               m = int.Parse(y.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. m!");
                butGenereaza = 0;
                return;
            }
            if (m > 10 || m < 1)
            {
                MessageBox.Show("m nu respecta limitele");
                return;
            }
            box1=gen_mat(n, m, 1, aici1);
            box2=gen_mat(n, m, 2, aici2);

            genButtonCalc();
        }
        private void iaNPutere(TextBox x, TextBox y)
        {
            try
            {

               n = int.Parse(x.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. n!");
                butGenereaza = 0;
                return;
            }

            if (n > 10 || n < 1)
            {
                MessageBox.Show("n nu respecta limitele");
                return;
            }

            try
            {

               putere = int.Parse(y.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. putere!");
                butGenereaza = 0;
                return;
            }
            if (putere < 1 || putere > 100)
            {
                MessageBox.Show("puterea nu respecta limitele");
                return;
            }
            box1=gen_mat(n, n, 1, aici1);

            genButtonCalc();
        }
        private void iaNMP(TextBox x, TextBox y, TextBox z)
        {
            try
            {

               n = int.Parse(x.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. n!");
                butGenereaza = 0;
                return;
            }

            if (n > 10 || n < 1)
            {
                MessageBox.Show("n nu respecta limitele");
                return;
            }

            try
            {

               m = int.Parse(y.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. m!");
                butGenereaza = 0;
                return;
            }

            if (m > 10 || m < 1)
            {
                MessageBox.Show("m nu respecta limitele");
                return;
            }

            try
            {
               p = int.Parse(z.Text);
            }
            catch
            {
                MessageBox.Show("Dati o valoare valida pt. p!");
                butGenereaza = 0;
                return;
            }

            if (p > 10 || p < 1)
            {
                MessageBox.Show("p nu respecta limitele");
                return;
            }

            box1=gen_mat(n, m, 1, aici1);
            box2=gen_mat(m, p, 2, aici2);

            genButtonCalc();
        }
        /*private void iaDinMat(TextBox[,] boxybox, int dim1, int dim2, int[,] mat)
        {
            int x;
            for(int i=0; i<dim1; i++)
            {
                for(int j=0; j<dim2; j++)
                {
                    try{
                        x = int.Parse(boxybox[i, j].Text);
                    }
                    catch
                    {
                        MessageBox.Show("Introduceti elemente valide in matrice, va rog frumos!");
                        return;
                    }
                }
            }
        }*/

        /*private void afisezRez(int[,] mat, int dim1, int dim2)
        {
            for (int i = 0; i < dim1; i++)
                for (int j = 0; j < dim2; j++)
                {
                    labelsRez[i, j].Text = mat[i, j].ToString();

                }
        }*/

        private void gen_boxDeRez(int[,] mat, int dim1, int dim2, Point unde)
        {
            labelsRez = new Label[dim1 + 1, dim2 + 1];
            int loc1 = unde.X + 80;
            int loc2 = unde.Y;

            for (int i = 0; i < dim1; i++)
            {
                loc1 = unde.X + 10;
                loc2 = loc2 + 30;

                for (int j = 0; j < dim2; j++)
                {
                    labelsRez[i, j] = new Label();
                    labelsRez[i, j].Name = 'C' + Convert.ToString(i * dim1 + j);
                    loc1 = loc1 + 35;
                    labelsRez[i, j].Width = 30;
                    labelsRez[i, j].Height = 30;
                    labelsRez[i, j].Location = new Point(loc1, loc2 + 30);
                    labelsRez[i, j].Text = mat[i, j].ToString();
                    this.panel2.Controls.Add(labelsRez[i, j]);
                }
            }
        }

        private void gen_boxDeRez(int el, Point unde)
        {
            labelPtRez = new Label();
            int loc1 = unde.X + 80;
            int loc2 = unde.Y;
            labelPtRez.Name = 'C' + Convert.ToString(1);
            loc1 = loc1 + 35;
            /*labelPtRez.Width = 30;
            labelPtRez.Height = 30;*/
            labelPtRez.AutoSize = true;
            labelPtRez.Location = new Point(loc1, loc2 + 30);
            labelPtRez.Text = el.ToString();
            this.panel2.Controls.Add(labelPtRez);
        }
        Label rezultat;
        private void btnCalc_click(object sender, EventArgs e)
        {
            //Point puneAici = box1[n-1, 1].Location;
            //rezultat.Location = aici3;
            //rezultat.Text = "REZULTAT:";
            //this.panel2.Controls.Add(rezultat);
            if (comboBoxChoice.Text == "Adunare a 2 matrice")
            {
                //iaDinMat(box1, n, m, mat1);
                //iaDinMat(box2, n, m, mat2);
                Matrice a = new Matrice(box1, n, m);
                Matrice b = new Matrice(box2, n, m);
                Matrice rez = new Matrice(a + b);
                gen_boxDeRez(rez.mat, rez.n, rez.m, aici3);
                //iaDinMat(box, n, m, mat1);
            }

            if (comboBoxChoice.Text == "Scadere dintre 2 matrice")
            {
                Matrice a = new Matrice(box1, n, m);
                Matrice b = new Matrice(box2, n, m);
                Matrice rez = new Matrice(a - b);
                gen_boxDeRez(rez.mat, rez.n, rez.m, aici3);
                //afisezRez(rez.mat, rez.n, rez.m);
            }

            if (comboBoxChoice.Text == "Inmultirea a 2 matrice")
            {
                Matrice a = new Matrice(box1, n, m);
                Matrice b = new Matrice(box2, m, p);
                Matrice rez = new Matrice(a * b);
                gen_boxDeRez(rez.mat, rez.n, rez.m, aici3);
                //afisezRez(rez.mat, rez.n, rez.m);
            }

            if (comboBoxChoice.Text == "Ridicarea unei matrice la o putere")
            {
                Matrice a = new Matrice(box1, n, n);
                Matrice rez = new Matrice(a ^ putere);
                gen_boxDeRez(rez.mat, rez.n, rez.m, aici3);
                //afisezRez(rez.mat, rez.n, rez.m);
            }

            if (comboBoxChoice.Text == "Scoaterea unui factor comun dintr-o matrice")
            {
                Matrice a = new Matrice(box1, n, m);
                int factor = a.factorComunMatrice();
                gen_boxDeRez(factor, aici3);
            }
            
            if (comboBoxChoice.Text == "Inmultirea unei matrice cu un numar intreg")
            {/**
                Matrice a = new Matrice(box1, n, m);
                int factor = a.factorComunMatrice();
                gen_boxDeRez(factor, aici3);
                    vezi ce trebuie pus
                **/
            }

            if (comboBoxChoice.Text == "Determinantul unei matrice")
            {
                Matrice a = new Matrice(box1, n, n);
                int determinant = a.determinant();
                gen_boxDeRez(determinant, aici3);
            }

            if (comboBoxChoice.Text == "Urma unei matrice")
            {
                Matrice a = new Matrice(box1, n, n);
                int urma = a.urmaMatrice();
                gen_boxDeRez(urma, aici3);
            }

            if (comboBoxChoice.Text == "Transpusa unei matrice")
            {
                Matrice a = new Matrice(box1, n, m);
                Matrice rez = new Matrice(a.transpusa());
                gen_boxDeRez(rez.mat, rez.n, rez.m, aici3);
            }

            if (comboBoxChoice.Text == "Rangul unei matrice")
            {
                Matrice a = new Matrice(box1, n, m);
                int rang = a.rangulMatricei();
                gen_boxDeRez(rang, aici3);
            }
            
            if (comboBoxChoice.Text == "Al k-lea element Fibonacci")
            {
                Matrice a = new Matrice(2, 2);
                int element = a.fibonacci(k);
                gen_boxDeRez(element, aici3);
                //labelPtRez.Text = element.ToString();
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            //MessageBox.Show("hjhsf");
            if(butGenereaza != 0)
            {
                panel2.Controls.Clear();
            }
            if (comboBoxChoice.Text == "Adunare a 2 matrice")
            {
                    iaNM(n_tb, m_tb);
            }

            if (comboBoxChoice.Text == "Scadere dintre 2 matrice")
            {
                    iaNM(n_tb, m_tb);
            }

            if (comboBoxChoice.Text == "Inmultirea a 2 matrice")
            {
                    iaNMP(n_tb, m_tb, p_tb);

            }

            if (comboBoxChoice.Text == "Ridicarea unei matrice la o putere")
            {
                    iaNPutere(n_tb, m_tb);
            }

            if (comboBoxChoice.Text == "Scoaterea unui factor comun dintr-o matrice")
            {
                    iaNMDar1Mat(n_tb, m_tb);
            }
            if (comboBoxChoice.Text == "Inmultirea unei matrice cu un numar intreg")
            {
                    iaNMNr(n_tb, m_tb, p_tb);
            }

            if (comboBoxChoice.Text == "Determinantul unei matrice")
            {
                    iaN(n_tb);
            }
            
            if (comboBoxChoice.Text == "Urma unei matrice")
            {
                    iaN(n_tb);
            }
            
            if (comboBoxChoice.Text == "Transpusa unei matrice")
            {
                    iaNMDar1Mat(n_tb, m_tb);
            }
            
            if (comboBoxChoice.Text == "Rangul unei matrice")
            {
                    iaNMDar1Mat(n_tb, m_tb);
            }

            if (comboBoxChoice.Text == "Al k-lea element Fibonacci")
            {
                    iaK(n_tb);
            }
            butGenereaza = 1;
        }

        private void buttonCalculeaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxChoice.Text))
            {
                MessageBox.Show("Selecteaza o operatie!");
                return;
            }
            butGenereaza = 0;
            aici1 = this.label1.Location;
            aici2 = this.label2.Location;
            aici3 = this.label3.Location;
            if (comboBoxChoice.Text == "Adunare a 2 matrice")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_m();
                return;
            }

            if(comboBoxChoice.Text == "Scadere dintre 2 matrice")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_m();
                return;
            }

            if (comboBoxChoice.Text == "Inmultirea a 2 matrice")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                p_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_m_p();
                return;
            }

            if(comboBoxChoice.Text == "Ridicarea unei matrice la o putere")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_putere();
                return;
            }

            if(comboBoxChoice.Text == "Scoaterea unui factor comun dintr-o matrice")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_m();
                return;
            }

            if(comboBoxChoice.Text == "Inmultirea unei matrice cu un numar intreg")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_m_nr();
                return;
            }

            if(comboBoxChoice.Text == "Determinantul unei matrice")
            {
                n_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n();
                return;
            }
            
            if(comboBoxChoice.Text == "Urma unei matrice")
            {
                n_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n();
                return;
            }

            if(comboBoxChoice.Text == "Transpusa unei matrice")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_m();
                return;
            }

            if (comboBoxChoice.Text == "Rangul unei matrice")
            {
                n_tb.Text = "";
                m_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_n_m();
                return;
            }


            if (comboBoxChoice.Text == "Al k-lea element Fibonacci")
            {
                n_tb.Text = "";
                panel2.Controls.Clear();
                panel3.Controls.Clear();
                gen_k();
                return;
            }
            MessageBox.Show("Nu ati selectat nimic!");
        }

    }
}
