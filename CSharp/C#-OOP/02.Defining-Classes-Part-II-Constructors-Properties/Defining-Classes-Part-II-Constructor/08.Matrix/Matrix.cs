using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _08.Matrix
{
    class Matrix<T> where T:  new()
    {
       private T[,] matrx;
       public int rows;
       public int cols;

       public T this[int row, int col]
       {
           get
           {
               return matrx[row, col];
           }
           set
           {
               if (row < 0 || col < 0 || row >= rows || col >= cols)
               {
                   throw new IndexOutOfRangeException();
               }
               matrx[row, col] = value; 
           }
       }
       public static  Matrix<T> operator +(Matrix<T> left,Matrix<T> right) 
       {
           if ((left.rows != right.rows) || (left.cols != right.cols))
           {
               throw new InvalidOperationException();
           }
           Matrix<T> result = new Matrix<T>(left.rows, left.cols);
           for (int i = 0; i < left.rows; i++)
           {
               for (int j = 0; j < left.cols; j++)
               {
                   result[i, j] =(dynamic) left[i, j] +(dynamic) right[i, j];
               }
           }

           return result;
       }
       public static Matrix<T> operator -(Matrix<T> left, Matrix<T> right)
       {
           if ((left.rows != right.rows )||(left.cols != right.cols))
           {
               throw new InvalidOperationException();
           }
           Matrix<T> result = new Matrix<T>(left.rows, left.cols);
           for (int i = 0; i < left.rows; i++)
           {
               for (int j = 0; j < left.cols; j++)
               {
                   result[i, j] = (dynamic)left[i, j] - (dynamic)right[i, j];
               }
           }
           return result;
       }
       public static Matrix<T> operator *(Matrix<T> left, Matrix<T> right)
       {
           Matrix<T> result ;
           if ((left.rows != right.rows) || (left.cols != right.cols))
           {
               if (left.cols != right.rows)
               {
                   throw new InvalidOperationException();
               }
               result = new Matrix<T>(left.rows, right.cols);
               for (int i = 0; i < left.rows; i++)
               {
                   for (int j = 0; j < right.cols; j++)
                   {
                       for (int row = 0; row < left.cols; row++)
                       {
                           result[i, j] += (dynamic)left[i, row] * (dynamic)right[row, j];
                       }
                   }
               }
               
           }
           else
           {
               result = new Matrix<T>(left.rows, left.cols);
               for (int i = 0; i < left.rows; i++)
               {
                   for (int j = 0; j < left.cols; j++)
                   {

                       for (int row = 0; row < left.rows; row++)
                       {
                           result[i, j] += (dynamic)left[i, row] * (dynamic)right[row, j];
                       }
                   }
               }
           }
           return result;
       }
       public static bool operator true(Matrix<T> P)
        {
            for (int i = 0; i < P.rows; i++)
            {
                for (int j = 0; j < P.cols; j++)
                {
                    if ((dynamic)P.matrx[i,j] != 0)
                    {
                        return true;
                    }
                }
            }
           return false;
        }
       public static bool operator false(Matrix<T> P)
       {
           for (int i = 0; i < P.rows; i++)
           {
               for (int j = 0; j < P.cols; j++)
               {
                   if ((dynamic)P.matrx[i, j] != 0)
                   {
                       return false;
                   }
               }
           }
           return true;
       }


       public Matrix(int rows, int cols,T[,] arr = null)
       {
           if (rows < 0 || cols < 0 )
           {
               throw new IndexOutOfRangeException();
           }
           if (arr != null)
           {
               matrx = arr;
           }
           else
           {
               matrx = new T[rows, cols];
           }
           this.rows = rows;
           this.cols = cols;
       }
    }
}
