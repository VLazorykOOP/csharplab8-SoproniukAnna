using Lab8CSharp;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lab#8 ");
        //Console.WriteLine("Task1");
        //Task1 task1 = new Task1("Task1.txt", "Task1Res.txt");
        //task1.ProcessText();

        //Console.WriteLine("Task2");
        //int wordLength = 3 ; 
        //Task2 task2 = new Task2("Task2.txt", "Task2Res.txt");
        //task2.FilterWordsByLength(wordLength);

        //Console.WriteLine("Task3");
        //Task3 task3 = new Task3("Task3.txt", "Task3Res.txt");
        //task3.RemoveWordsWithOddLength();

        /*Console.WriteLine("Task4");
        string[] words = { "apple", "banana", "orange", "grape", "kiwi", "melon", "peach" };
        string filePath = "words.bin";

        Task4 task4 = new Task4(filePath);
        task4.WriteWordsToFile(words);

        Console.Write("Enter the length of the words to display: ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine($"Words with length {length}:");
        task4.ReadWordsByLength(length);

        Console.ReadKey();*/


        Console.WriteLine("Task5");
        // Крок 1: Створення папок
        string folder1Path = @"d:\temp1\Soproniuk_Anna1";
        string folder2Path = @"d:\temp1\Soproniuk_Anna2";

        Directory.CreateDirectory(folder1Path);
        Directory.CreateDirectory(folder2Path);

        // Крок 2: Створення файлів та запис тексту
        string t1Path = Path.Combine(folder1Path, "t1.txt");
        string t2Path = Path.Combine(folder1Path, "t2.txt");

        using (StreamWriter sw = File.CreateText(t1Path))
        {
            sw.WriteLine("<Шевченко Степан Іванович, 2001> року народження, місце проживання <м.Суми>");
        }

        using (StreamWriter sw = File.CreateText(t2Path))
        {
            sw.WriteLine("<Комар Сергій Федорович, 2000 > року народження, місце проживання <м. Київ>");
        }

        // Крок 3: Зчитування та запис тексту з файлів t1.txt та t2.txt у файл t3.txt
        string t3Path = Path.Combine(folder2Path, "t3.txt");

        File.Copy(t1Path, t3Path, true);

        using (StreamWriter sw = File.AppendText(t3Path))
        {
            sw.WriteLine();
            sw.WriteLine(File.ReadAllText(t2Path));
        }

        // Крок 4: Виведення інформації про створені файли
        Console.WriteLine($"Створені файли:");
        Console.WriteLine($"t1.txt: {new FileInfo(t1Path).Length} байт");
        Console.WriteLine($"t2.txt: {new FileInfo(t2Path).Length} байт");
        Console.WriteLine($"t3.txt: {new FileInfo(t3Path).Length} байт");

        // Крок 5: Переміщення файлу t2.txt у папку Soproniuk_Anna2
        string t2NewPath = Path.Combine(folder2Path, "t2.txt");
        File.Move(t2Path, t2NewPath);

        // Крок 6: Копіювання файлу t1.txt у папку Soproniuk_Anna2
        string t1NewPath = Path.Combine(folder2Path, "t1.txt");
        File.Copy(t1Path, t1NewPath);

        // Крок 7: Перейменування папки K2 в ALL та видалення папки Soproniuk_Anna1
        string folderAllPath = @"d:\temp1\ALL";
        Directory.Move(folder2Path, folderAllPath);
        Directory.Delete(folder1Path, true);
        //Directory.Delete(folder1Path);


        // Крок 8: Виведення повної інформації про файли папки All
        Console.WriteLine($"Файли в папці ALL:");
        string[] allFiles = Directory.GetFiles(folderAllPath);
        foreach (string file in allFiles)
        {
            Console.WriteLine($"{Path.GetFileName(file)}: {new FileInfo(file).Length} байт");
        }

        Console.ReadKey();
    }
}