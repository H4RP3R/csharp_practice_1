// Задача 62: Заполните спирально массив 4 на 4.

int GetUserInput(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    string divider = string.Empty;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        divider += "------";
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} |");
        }
        Console.WriteLine();
        Console.WriteLine(divider);
    }
}

int[,] MakeMatrix(int rows = 4, int cols = 4)
{
    return new int[rows, cols];
}

void NumbersSpiral(int[,] matrix)
{
    int number = 1;
    int wStart = 0, wStop = matrix.GetLength(1) - 1;
    int hStart = 0, hStop = matrix.GetLength(0) - 1;

    int i = hStart++, j = wStart;
    char direction = 'E';
    while (number <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = number++;

        switch (direction)
        {
            case 'E':
                if (j < wStop) j++;
                else { direction = 'S'; wStop--; i++; }
                break;

            case 'S':
                if (i < hStop) i++;
                else { direction = 'W'; hStop--; j--; }
                break;

            case 'W':
                if (j > wStart) j--;
                else { direction = 'N'; wStart++; i--; }
                break;

            case 'N':
                if (i > hStart) i--;
                else { direction = 'E'; hStart++; j++; }
                break;
        }
    }
}

int rowsNum = GetUserInput("Rows number");
int colsNum = GetUserInput("Columns number");
int[,] mtrx = MakeMatrix(rowsNum, colsNum);
NumbersSpiral(mtrx);
PrintMatrix(mtrx);
