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
        private int[,] mat=new int[15, 15];
        int n, m;

        public Matrice(TextBox[,] other, int nsize, int msize)
        {
            this.n = nsize;
            this.m = msize;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    this.mat[i, j] = int.Parse(other[i, j].Text);
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
            for (int i = 1; i <= a.n; i++)
                for (int j = 1; j <= b.m; j++)
                    for (int k = 1; k <= a.m; k++)
                            rez.mat[i, j] += a.mat[i, k] * b.mat[k, j];
            return new Matrice(rez);
        }

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
            while(put != 0)
            {
                if(put % 2 != 0)
                {
                    put--;
                    rez = rez * a;
                }
                put /= 2;
                a = a * a;
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
        public int factorComunMatrice(Matrice a)
        {
            int factor = a.mat[0, 0];

            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.m; j++)
                    factor = cmmdc(factor, a.mat[i, j]);

            return factor;
        }

        public int det(int dim, int[,] a)
        {
            int d = 0;
            int k, i, j, subi, subj;
            int[,] subMat = new int[dim, dim];
            if (dim == 2)
                return (a[0, 0] * a[1, 1]) - (a[1, 0] * a[0, 1]);
            else
            {
                for(k=0; k<dim; k++)
                {
                    subi = 0;
                    for(i=1; i<dim; i++)
                    {
                        subj = 0;
                        for(j=0; j<dim; j++)
                        {
                            if (j == k)
                                continue;
                            subMat[subi, subj] = a[i, j];
                            subj++;
                        }
                        subi++;
                    }
                    int put = (int)Math.Pow(-1, k);
                    d += put * mat[0, k] * det(dim - 1, subMat);
                }
            }
            return d;
        }

        //determinant

        public int determinant(Matrice a)
        {
            return det(a.n, a.mat);               
        }

        //factor comun din determinant

        public int factorComunDeterminantLinie(Matrice a, int lin)
        {
            int factor = a.mat[lin, 0];

            for (int i = 1; i < a.n; i++)
                factor = cmmdc(factor, a.mat[lin, i]);

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
        
        public int urmaMatrice(Matrice a)
        {
            int s = 0;
            for (int i = 0; i < a.n; i++)
                s += a.mat[i, i];
            return s;
        }

        //transpusa

        public Matrice transpusa(Matrice a)
        {
            Matrice at = new Matrice(a.m, a.n);
            for (int i = 0; i < at.n; i++)
                for (int j = 0; j < at.m; j++)
                    at.mat[i, j] = a.mat[j, i];
            return new Matrice(at);
        }        

        //rangul

        public int rangulMatricei(Matrice a)
        {
            int rang = a.m;

            for(int i=0; i<rang; i++)
            {
                if(a.mat[i, i]!=0)
                {
                    for(int j=0; j<a.n; j++)
                    {
                        if(j!=i)
                        {
                            int mult = a.mat[j, i] / a.mat[i, i];
                            for (int k = 0; k < rang; k++)
                                a.mat[j, k] -= mult * a.mat[i, k];
                        }
                    }
                }
                else
                {
                    bool reduce = true;
                    for(int j=i+1; j<a.n; j++)
                    {
                        if(a.mat[j, i]!=0)
                        {
                            for(int k=0; k<rang; k++)
                            {
                                int aux = a.mat[i, k];
                                a.mat[i, k] = a.mat[j, k];
                                a.mat[j, k] = aux;
                            }
                            reduce = false;
                            break;
                        }
                    }
                    if(reduce)
                    {
                        rang--;
                        for (int j = 0; j < a.n; j++)
                            mat[j, i] = mat[j, rang];
                    }
                    i--;
                }
            }

            return rang;
        }

        //fibonacci

    }
}
