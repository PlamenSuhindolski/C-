using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    public class Matrix<T> where T: int, float, double, decimal
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int Row, int Col)
        {
            this.matrix = new T[Row,Col];
            this.rows = Row;
            this.cols = Col;
        }

        public T this[int indexRow, int indexCol]
        {
            get 
            {
                return this.matrix[indexRow, indexCol];
            }

            set
            {
                this.matrix[indexRow, indexCol] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrixOne.rows, matrixOne.cols);

            if (matrixOne.rows == matrixTwo.rows && matrixOne.cols == matrixTwo.cols)
            {
                for (int rows = 0; rows < matrixOne.rows; rows++)
                {
                    for (int cols = 0; cols < matrixOne.cols; cols++)
                    {
                        resultMatrix[rows, cols] = (dynamic)matrixOne[rows, cols] + matrixTwo[rows, cols];
                    }
                }
            }
            else
            {
                throw new ArgumentException("\nThe matrices have different sizes!\nThey must be equals.");
            }

            return resultMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrixOne.rows, matrixOne.cols);

            if (matrixOne.rows == matrixTwo.rows && matrixOne.cols == matrixTwo.cols)
            {
                for (int rows = 0; rows < matrixOne.rows; rows++)
                {
                    for (int cols = 0; cols < matrixOne.cols; cols++)
                    {
                        resultMatrix[rows, cols] = (dynamic)matrixOne[rows, cols] - matrixTwo[rows, cols];
                    }
                }
            }
            else
            {
                throw new ArgumentException("\nThe matrices have different sizes!\nThey must be equal.");
            }
            return resultMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrixOne.rows, matrixTwo.cols);

            if (matrixOne.cols != matrixTwo.rows)
            {
                throw new ArgumentException("Imposibble operation:\nThe colums of first matrice are not equal to rows of second matrice!");
            }

            else if (matrixOne.cols == matrixTwo.rows)
            {
                for (int rows = 0; rows < resultMatrix.rows; rows++)
                {
                    for (int cols = 0; cols < resultMatrix.cols; cols++)
                    {
                        for (int i = 0; i < matrixOne.cols; i++)
                        {
                            resultMatrix[rows, cols] += (dynamic)matrixOne[rows, i] * matrixTwo[i, cols];
                        }
                    }
                }
            }
            return resultMatrix;
        }
    }
}
