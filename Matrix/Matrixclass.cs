
namespace Matrixclass
{
    class Matrix
    {
        private readonly int n, m;
        private int[,] matrix;


        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            matrix = new int[n, m];
        }

        public void FillSnake()
        {
            int counter = 1;
            for (int i = 0; i < m; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                        matrix[j, i] = counter++;
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                        matrix[j, i] = counter++;
                }
            }
        }

       public  enum DirectionDiagonal {right, down }
        public void FillDiagonalSnake(DirectionDiagonal Direction)
        {
            if (n != m) { Console.WriteLine("Matrix is not square!"); }
            int counter1 = 1;
            int counter2 = n * n;

            for (int i = 0; i < n; i++)
            {

                if (Direction == DirectionDiagonal.down)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        matrix[i - j, j] = counter1++;
                        matrix[n - (i - j + 1), n - j - 1] = counter2--;
                        if (counter1 > counter2)
                        {
                            break;
                        }

                    }
                    Direction = DirectionDiagonal.right;
                    continue;
                }
                if (Direction == DirectionDiagonal.right)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        matrix[j, i - j] = counter1++;
                        matrix[n - (j + 1), n - (i - j + 1)] = counter2--;
                        if (counter1 > counter2)
                        {
                            break;
                        }
                    }
                    Direction = DirectionDiagonal.down;
                    continue;
                }
            }



        }

        enum Directions { up, down, left, right }
        public void FillCircleSnake()
        {
            Directions direction = Directions.down;
            int rx = n - 1; // right X
            
            int lx = 0; // left X
            int dy = m - 1; // down Y
            int uy = 0; // upper y
            int counter = 1;
            while (counter <= n * n)
            {
                switch (direction)
                {
                    case Directions.left:
                        for (int i = rx; i >= lx; i--)
                        {
                            matrix[uy, i] = counter++;
                        }
                        uy++;
                        direction = Directions.down;
                        break;

                    case Directions.right:
                        for (int i = lx; i <= rx; i++)
                        {
                            matrix[dy, i] = counter++;
                        }
                        dy--;
                        direction = Directions.up;
                        break;

                    case Directions.up:
                        for (int i = dy; i >= uy; i--)
                        {
                            matrix[i, rx] = counter++;
                        }
                        rx--;
                        direction = Directions.left;
                        break;

                    case Directions.down:
                        for (int i = uy; i <= dy; i++)
                        {
                            matrix[i, lx] = counter++;
                        }
                        lx++;
                        direction = Directions.right;
                        break;

                }
            }
        }

    
        public void ReadMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
