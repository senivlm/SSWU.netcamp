using Matrixclass;

class Program
{
	static void Main(string[] args)
	{
		Matrix matr = new(5, 5);
		matr.ReadMat();
		Console.WriteLine();
		matr.FillDiagonalSnake(true);	
		matr.ReadMat();

	}
}