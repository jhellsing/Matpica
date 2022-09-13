using Matpica;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matpica
{
    internal class Matrix
    {
        private int a;
        private int b;
        private int[,] matrica;
        private static Random rand = new Random();

        public Matrix(int a, int b)
        {
            this.a = a;
            this.b = b;
            this.matrica = new int[a, b];
            for (int a1 = 0; a1 < a; a1++)
            {
                for (int b1 = 0; b1 < b; b1++)
                {
                    this.matrica[a1, b1] = rand.Next(12); 
                }
            }
        }
       
        public void Sum(Matrix matrix)
        {
           for (int a1 = 0; a1 < this.a; a1++)
           {
              for (int b1 = 0; b1 < this.b; b1++)
              {
                  this.matrica[a1, b1] = this.matrica[a1, b1] + matrix.matrica[a1, b1];
              }
           }
        }
      
        public void PrintMatrix()
        {
            for (int a1 = 0; a1 < this.a; a1++)
            {
                for (int b1 = 0; b1 < this.b; b1++)
                {
                    Console.Write(this.matrica[a1, b1] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
      
        public void MultiplyOnNumber(int num)
        {
            for (int a1 = 0; a1 < this.a; a1++)
            {
                for (int b1 = 0; b1 < this.b; b1++)
                {
                    this.matrica[a1, b1] = this.matrica[a1, b1] * num;
                }
            }
        }
        
        public void MultiplyOnMatrix(Matrix matrix)
        {
          int[,] result = new int[this.a, matrix.b];
          for (int a1 = 0; a1 < this.a; a1++)
          {
              for (int b1 = 0; b1 < matrix.b; b1++)
              {
                   result[a1, b1] = 0;
                   for (int c1 = 0; c1 < matrix.a; c1++)
                   {
                       result[a1, b1] = result[a1, b1] + this.matrica[a1, c1] * matrix.matrica[c1, b1];
                   }
              }
          }
          this.matrica = result;
          this.a = result.GetLength(0);
          this.b = result.GetLength(1);
        }
    }
}