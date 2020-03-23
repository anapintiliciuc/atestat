using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectOOp
{
    class Matrice
    {
        public int[,] mat=new int[15, 15];
        public int n, m;

        public Matrice(TextBox[,] other, int nsize, int msize)
        {
            this.n = nsize;
            this.m = msize;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    try
                    {
                        this.mat[i, j] = int.Parse(other[i, j].Text);
                    }
                    catch
                    {
                        MessageBox.Show("Introduceti elemente valide in matrice, va rog frumos!");
                        return;
                    }
                }
                    //this.mat[i, j] = int.Parse(other[i, j].Text);
        }

        public Matrice(Matrice other)
        {
            this.n = other.n;
            this.m = other.m;
            for (int i = 0; i < this.n; i++)
                for (int j = 0; j < this.m; j++)
                    this.mat[i, j] = other.mat[i, j];
        }

        public Matrice(int othern, int otherm)
        {
            this.n = othern;
            this.m = otherm;
            for (int i = 0; i < this.n; i++)
                for (int j = 0; j < this.m; j++)
                    this.mat[i, j] = 0;
        }

        public Matrice(int[,] a, int othern, int otherm)
        {
            this.n = othern;
            this.m = otherm;
            for (int i = 0; i < this.n; i++)
                for (int j = 0; j < this.m; j++)
                    this.mat[i, j] = a[i, j];
        }

        ///adunare

        public static Matrice operator+(Matrice a, Matrice b)
        {
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.m; j++)
                    a.mat[i, j] += b.mat[i, j];
            return new Matrice(a);
        }

        /// scadere
    
        public static Matrice operator-(Matrice a, Matrice b)
        {
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.m; j++)
                    a.mat[i, j] -= b.mat[i, j];
            return new Matrice(a);
        }

        public static Matrice operator*(Matrice a, Matrice b)
        {
            Matrice rez = new Matrice(a.n, b.m);
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < b.m; j++)
                    for (int k = 0; k < a.m; k++)
                            rez.mat[i, j] += a.mat[i, k] * b.mat[k, j];
            return new Matrice(rez);
        }

        //public static Matrice operator=(Matrice a, Matrice b)
        //{
        //    for (int i = 0; i < a.n; i++)
        //        for (int j = 0; j < a.m; j++)
        //            a.mat[i, j] = b.mat[i, j];
        //    return new Matrice(a);
        //}

        //inmultire

        public static Matrice operator*(int x, Matrice a)
        {
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.m; j++)
                    a.mat[i, j] *= x;
            return new Matrice(a);
        }

        public static Matrice operator*(Matrice a, int x)
        {
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.m; j++)
                    a.mat[i, j] *= x;
            return new Matrice(a);
        }

        //putere

        public static Matrice operator^(Matrice a, int put)
        {
            Matrice rez = new Matrice(a);
            put--;
            while(put != 0)
            {
                if(put % 2 != 0)
                {
                    put--;
                    rez = new Matrice(rez * a);
                }
                put /= 2;
                a = new Matrice( a * a );
            }
            return new Matrice(rez);
        }

        //factor comun matrice

        int cmmdc(int x, int y)
        {
            if (y == 0)
                return x;
            return cmmdc(y, x % y);
        }
        public int factorComunMatrice()
        {
            int factor = mat[0, 0];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    factor = cmmdc(factor, mat[i, j]);

            return factor;
        }

        private void getCofactor(int[,] a,  int[,] temp, int p, int q, int dim)
        {
            int i = 0, j = 0;

            for(int row=0; row<dim; row++)
            {
                for(int col=0; col<dim; col++)
                {
                    if(row!=p && col!=q)
                    {
                        temp[i, j++] = a[row, col];
                        if(j==dim-1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
        }

        private int det(int dim, int[,] a)
        {
            int d = 0;

            if (dim == 1)
                return a[0, 0];

            int[,] temp=new int[n, n];
            int semn = 1;
            for(int f=0; f<n; f++)
            {
                getCofactor(a, temp, 0, f, n);
                d += semn * a[0, f] * det(dim - 1, temp);
                semn = -semn;
            }
            
            return d;
        }

        //determinant

        public int determinant()
        {
            return det(n, mat);               
        }

        //factor comun din determinant

        public int factorComunDeterminantLinie(int lin)
        {
            int factor = mat[lin, 0];

            for (int i = 1; i < n; i++)
                factor = cmmdc(factor, mat[lin, i]);

            return factor;
        }

        public int factorComunDeterminantColoana(Matrice a, int col)
        {
            int factor = a.mat[0, col];

            for (int i = 1; i < a.n; i++)
                factor = cmmdc(factor, a.mat[i, col]);

            return factor;
        }

        //urma
        
        public int urmaMatrice()
        {
            int s = 0;
            for (int i = 0; i < n; i++)
                s += mat[i, i];
            return s;
        }

        //transpusa

        public Matrice transpusa()
        {
            Matrice at = new Matrice(m, n);
            for (int i = 0; i < at.n; i++)
                for (int j = 0; j < at.m; j++)
                    at.mat[i, j] = mat[j, i];
            return new Matrice(at);
        }        

        //rangul

        public int rangulMatricei()
        {
            int rang = m;

            for(int i=0; i<rang; i++)
            {
                if(mat[i, i]!=0)
                {
                    for(int j=0; j<n; j++)
                    {
                        if(j!=i)
                        {
                            int mult = mat[j, i] / mat[i, i];
                            for (int k = 0; k < rang; k++)
                                mat[j, k] -= mult * mat[i, k];
                        }
                    }
                }
                else
                {
                    bool reduce = true;
                    for(int j=i+1; j<n; j++)
                    {
                        if(mat[j, i]!=0)
                        {
                            for(int k=0; k<rang; k++)
                            {
                                int aux = mat[i, k];
                                mat[i, k] = mat[j, k];
                                mat[j, k] = aux;
                            }
                            reduce = false;
                            break;
                        }
                    }
                    if(reduce)
                    {
                        rang--;
                        for (int j = 0; j < n; j++)
                            mat[j, i] = mat[j, rang];
                    }
                    i--;
                }
            }

            return rang;
        }

        //fibonacci

        public int fibonacci(int put)
        {
            Matrice m = new Matrice(2, 2);
            m.mat[0, 0] = 1;
            m.mat[0, 1] = 1;
            m.mat[1, 0] = 1;
            m.mat[1, 1] = 0;
            m = new Matrice(m ^ put);
            return m.mat[0, 1];
        }

        //inversa

        public Matrice inversa()
        {
            Matrice rez = new Matrice(n, m);
            int d = 1;
            int i, j, l;
            for (i = 0; i < n; i++)
                for (j = n; j < 2 * n; j++)
                    if (i == (j - n))
                        mat[i, j] = 1;
                    else mat[i, j] = 0;
            for (i = 0; i < n && d != 0; i++)
            {
                for (j = i; j < n && mat[j, i] == 0; j++) ;

                if (j >= n)
                    d = 0;
                else if (j > i)
                    for (l = 0; l < 2 * n; l++)
                        mat[i, l] += mat[j, l];
                if (mat[i, i] != 1)
                    for (l = 2 * n - 1; l >= 0; l--)
                        mat[i, l] /= mat[i, i];

                for (j = 0; j < n; j++)
                    if (j != i)
                        for (l = 2 * n - 1; l >= i; l--)
                            mat[j, l] -= mat[j, i] * mat[i, l];
            }

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    rez.mat[i, j] = mat[i, n + j];

            return rez;
        }

    }
}
