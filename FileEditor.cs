namespace TextEditor
{
    public class Class
    {
        public async static void FileWrite()
        {
            string[]? texts =
            {
                null
            };
            string? input = null;
            string? file_Name = null;
            file_Name = Console.ReadLine();
            if(file_Name == "")
            {
                file_Name = null;
                Console.WriteLine("{0}", file_Name != null ? "Error while processing the file's name" : "File name is empty");
                Environment.Exit(0x2);
            }
            string directory = @$"C:\Users\{Environment.UserName}\OneDrive\Desktop\" + file_Name + ".txt";

            switch (file_Name)
            {
                case var value when value == file_Name != null:
                    if (!File.Exists(directory))
                    {
                        var file = File.Create(directory);
                        file.Close();
                        for (int i = 0; i < 10; i++)
                        {
                            input = Console.ReadLine();
                            texts = texts.Append(input).ToArray();
                        }
                        await File.WriteAllLinesAsync(directory, texts);
                    }
                    else
                    {
                        string? choice;
                        string N = "N";
                        string Y = "Y";
                       Console.WriteLine("File already exists under this name. Do you want to delete it? (Y/N)");
                       choice = Console.ReadLine();

                        if (choice == Y)
                        {
                            File.Delete(directory);
                            FileWrite();
                        }


                        else if (choice == N)
                        {
                            Environment.Exit(0x3);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option");
                            Environment.Exit(0x4);
                        }
                        }
                    break;
                default:
                    Environment.Exit(0x1);
                    break;
                    }
            }

        public static void Main()
        {
            FileWrite();
        }
    }
}
