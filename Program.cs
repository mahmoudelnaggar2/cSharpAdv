PrintDirectoryFileSystemEntries(@"D:\Training\Mahdy\AdvancedC#\Recursion", 1);


static void PrintDirectoryFileSystemEntries(string dirPath, int level)
{

    foreach (var file in Directory.GetFiles(dirPath))
    {
        Console.WriteLine($"{new string('-', level)}  (File) - {new FileInfo(file).Name}");
    }

    foreach (var folder in Directory.GetDirectories(dirPath))
    {
        Console.WriteLine($"{new string('-', level)}  (Folder) - {new DirectoryInfo(folder).Name}");

        PrintDirectoryFileSystemEntries(folder, level + 1);
    }
}

/*
Console.WriteLine(CalculateFactorial(5));


static int CalculateFactorial(int number)
{
    if (number <= 1) return number;

    return number * CalculateFactorial(number - 1);
}
*/
