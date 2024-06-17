class Program
{

    static void Main()
    {
        
        double[] grades = new double[10];

        FilloGrades(grades);

        CalculateAverageAndCountAbove(grades);  
    
    }

    static void FilloGrades (double[] grades)
    {
       Random random = new Random();
    for (int i = 0; i < grades.Length; i++)
    {
        // For user input, uncomment the next line and comment the random line
        // Console.Write($"Enter grade for student {i + 1}: ");
        // grades[i] = double.Parse(Console.ReadLine());

        // Using random grades for simplicity
        grades[i] = random.Next(10); // Random grades between 50 and 100
        Console.WriteLine($"Grade for student {i + 1}: {grades[i]}");
    }
    }
    static void CalculateAverageAndCountAbove(double[] grades)
{
    double sum = 0;
    for (int i = 0; i < grades.Length; i++)
    {
        sum += grades[i];
    }

    double average = sum / 10;
    int countAbove = 0;

    for (int i = 0; i < grades.Length; i++)
    {
        if (grades[i] > average)
        {
            countAbove++;
        }
    }

    Console.WriteLine($"The average grade is: {average}");
    Console.WriteLine($"Number of students who scored above the average: {countAbove}");
}




    
}
