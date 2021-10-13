using System;

namespace string_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Nandini";

            //Copy() is used to create string with the same value as a specified string
            string SecondName = string.Copy(FirstName);

            //Equals() is used to check the string value.
            Console.WriteLine("Does both String is Equals : " + SecondName.Equals(FirstName));

            //IndexOf() is used return the index of given char.
            Console.WriteLine("Get the Char Position : " + FirstName.IndexOf("d"));

            //IndexOf() is used return the index of given char.
            String insertString = FirstName.Insert(4, " - RKIT - ");
            Console.WriteLine("Insert the New String to Old : " + insertString);

            //Replace() is used replace the chars.
            String replaceString = FirstName.Replace('N', 'n');
            Console.WriteLine("Replace the char : " + replaceString);

            //Remove() is used remove the chars of given position.
            Console.WriteLine("Remove the char : " + replaceString.Remove(1));

            //Trim() is used to remove the space.
            string trimString = " Nandini ";
            Console.WriteLine("Trim the char :\n" + trimString.Trim());
            Console.WriteLine("Trim From Left of char :\n" + trimString.TrimStart());
            Console.WriteLine("Trim From Right of char :\n" + trimString.TrimEnd());

            //ToUpper() is use to convert the string in uppercase.
            Console.WriteLine("Uppercase : " + FirstName.ToUpper());

            //ToLower() is use to convert the string in lowercase.
            Console.WriteLine("Lowercase : " + FirstName.ToLower());

            //Substring() is used to create the substring from given position.
            Console.WriteLine("Create the SubString of Given Position : " + replaceString.Substring(4));
            Console.ReadLine();
        }
    }
}
