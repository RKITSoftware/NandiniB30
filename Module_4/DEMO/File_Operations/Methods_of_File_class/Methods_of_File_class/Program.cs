using System;
using System.IO;

namespace Methods_of_File_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_path = @"E:\\RKIT_Training\\Module_4\\Demo\\File_Operations\\Demo_file.txt";
            string new_file = @"E:\\RKIT_Training\Module_4\\Demo\\File_Operations\\Demo_newFile.txt";
            
            //Check whether file is exists or not
            if (File.Exists(file_path))
            {
                Console.WriteLine("File exists");

                //Get when the file was accessed last time 
                DateTime lastAccessTime = File.GetLastAccessTime(file_path);
                Console.WriteLine("Last time Demo_file was accessed was {0}", lastAccessTime);

                //get when the file was written last time
                DateTime lastWriteTime = File.GetLastWriteTime(file_path);
                Console.WriteLine("Last time Demo_file was written in was {0}",lastWriteTime);

                //To copy one file into another
                File.Copy(file_path, new_file);
                Console.WriteLine("Demo_file copied to Demo_newFile");

                // Move new file to new location
                File.Move(new_file, @"D:\\Demo_newFile.txt");
                Console.WriteLine("Demo_newFile is moved to new location:D:\\Demo_newFile.txt.");

                //Read all the lines one by one in a file
                String[] lines;
                lines = File.ReadAllLines(file_path);
                Console.WriteLine("Read lines one by one:");
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);

                //Read all the lines in a file at once
                String lines_at_once;
                lines_at_once = File.ReadAllText(file_path);
                Console.WriteLine("Read all lines at once:");
                Console.WriteLine(lines_at_once);

                //To append text in the file we use StreamWriter object with AppendText method
                using (StreamWriter objWriter = File.AppendText(file_path))
                {
                    objWriter.WriteLine();
                    objWriter.WriteLine("New entry:Appended text");
                }
                Console.WriteLine("Text has been appended to Demo_file.");

                //Write texts to the file;will not append text but overwrite existing texts
                File.WriteAllText(new_file, "This text is for demo.");
                Console.WriteLine("Demo_newFile is overwritten.");

                //Delete file
                File.Delete(new_file);
                Console.WriteLine("Demo_newFile is deleted.");
                Console.ReadLine();
            }
            else
            {
                File.Create(file_path);
                //File 'Demo_file' is created if file was not created.
                Console.WriteLine("File 'Demo_file' is created");
                Console.ReadLine();
            }

            //output:-
            //File exists
            //Last time Demo_file was accessed was 14 - 11 - 2021 08:30:33 PM
            //Last time Demo_file was written in was 14 - 11 - 2021 08:30:33 PM
            //Demo_file copied to Demo_newFile
            //Demo_newFile is moved to new location:D:\Demo_newFile.txt.
            //Read lines one by one:
            //I am Nandini.
            //I am making a demo file.
            //Read all lines at once:
            //I am Nandini.
            //I am making a demo file.
            //First entry: File operations
            //
            //Text has been appended to Demo_file.
            //Demo_newFile is overwritten.
            //Demo_newFile is deleted.
        }
    }
}
