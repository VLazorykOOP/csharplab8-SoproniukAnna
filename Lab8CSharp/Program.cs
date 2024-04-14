using Lab8CSharp;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lab#8 ");
        //Task1 task1 = new Task1("Task1.txt", "Task1Res.txt");
        //task1.ProcessText();

        //int wordLength = 3 ; 
        //Task2 task2 = new Task2("Task2.txt", "Task2Res.txt");
        //task2.FilterWordsByLength(wordLength);

        Task3 task3 = new Task3("Task3.txt", "Task3Res.txt");
        task3.RemoveWordsWithOddLength();
    }
}