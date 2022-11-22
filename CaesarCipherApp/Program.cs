using System.Text;
using CaesarCipher;

namespace CaesarCipherApp;
internal class Program
{
    public delegate string CipherOperation(string inputText, int key);
    static void Main()
    {
        string inputPath = "input.txt";
        string outputPath = "output.txt";
        CipherOperation? Operate = null;        
        string? order = "";
        do
        {    
            WriteInstructions();
            order = Console.ReadLine();
            Console.Clear();
            if (order.ToLower() == "кодировать")
            {
                Operate = CaesarCipher.Coder.Encode;
            }
            else if (order.ToLower() == "декодировать")
            {
                Operate = CaesarCipher.Coder.Decode;
            }
            else if (order.ToLower() == "выход")
            {
                continue;
            }    
            else
            {
                Console.WriteLine("Неизвестная операция");
                continue;
            }
            Console.WriteLine("Введите ключ");
            int key;
            while (int.TryParse(Console.ReadLine(), out key) == false)
                Console.WriteLine("Введите целое число");

            string inputText = "";
            try
            {
                using (StreamReader reader = new StreamReader(inputPath))
                {
                    inputText = reader.ReadToEnd();
                }
            }
            catch
            {
                Console.WriteLine("Неверный путь к файлу");
                continue;
            }

            if (inputText == "")
                throw new Exception("В файле нет содержимого");

            string processedText = Operate(inputText, key);

            using (StreamWriter writer = new StreamWriter(outputPath, false))
            {
                writer.WriteLine(processedText);
            }
            Console.WriteLine($"Операция завершена успешно. Обработанный файл записан в {outputPath}");            

        } while (order.ToLower() != "выход");
    }
    static void WriteInstructions()
    {
        Console.WriteLine("Введите одну из следующих команд: кодировать, декодировать, выход");
    }
}