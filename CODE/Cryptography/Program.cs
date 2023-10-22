using Cryptography;
using System.IO;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
/* Вариант 2
Разработайте программу шифрования/расшифрования файлов следующим
методом «сдвиг+гаммирование». На первом этапе шифрования каждый байт
сообщения подвергается циклическому сдвигу на 5 бит влево. На втором
этапе на каждые 4 байта сообщения, прошедшего первый этап шифрования,
накладывается 4-байтовая гамма. Гамма вводится с клавиатуры
 */

using System;
using System.IO;

// Вариант 2
// 1 байт = 8 бит

class Program
{
    static void Main(string[] args)
    {
        // Шифрование
        string path = @"C:\Users\Вика\Desktop\test2.txt";
        string outPath = @"C:\Users\Вика\Desktop\test3.txt";

        Console.WriteLine("Write the gamma (4 bytes)");
        string gamma = Console.ReadLine();

        EncryptFile(path, outPath, Encoding.UTF8.GetBytes(gamma));

        DecryptFile(path, outPath, Encoding.UTF8.GetBytes(gamma));

    }



    static void EncryptFile(string inputFilePath, string encryptedFilePath, byte[] gamma)
    {
        int gammaIndex = 0;
        using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open))
        using (FileStream encryptedFileStream = new FileStream(encryptedFilePath, FileMode.Create))
        {
            int bytesRead;
            byte[] buffer = new byte[4];

            // Пока не конец файла, считываем по 4 байта
            while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                // Циклический сдвиг на 5 бит влево
                for (int i = 0; i < bytesRead; i++)
                {
                    buffer[i] = (byte)(buffer[i] << 5 | buffer[i] >> 3);
                }

                // Гаммирование
                for (int i = 0; i < bytesRead; i++)
                {
                    buffer[i] ^= gamma[gammaIndex];
                    gammaIndex++;
                    // Если ключ закончился, обнуляем его индекс
                    if ((gammaIndex + 1) == gamma.Length)
                        gammaIndex = 0;
                }

                encryptedFileStream.Write(buffer, 0, bytesRead);
            }
        }

    }
    static void DecryptFile(string encryptedFilePath, string decryptedFilePath, byte[] gamma)
    {

        using (FileStream encryptedFileStream = new FileStream(encryptedFilePath, FileMode.Open))
        using (FileStream decryptedFileStream = new FileStream(decryptedFilePath, FileMode.Create))
        {
            int bytesRead;
            byte[] buffer = new byte[4];
            int gammaIndex = 0;

            while ((bytesRead = encryptedFileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                // Гаммирование
                for (int i = 0; i < bytesRead; i++)
                {
                    buffer[i] ^= gamma[gammaIndex];
                    gammaIndex++;
                    // Если ключ закончился, обнуляем его индекс
                    if ((gammaIndex + 1) == gamma.Length)
                        gammaIndex = 0;
                }

                // Циклический сдвиг на 5 бит вправо
                for (int i = 0; i < bytesRead; i++)
                {
                    buffer[i] = (byte)(buffer[i] >> 5 | buffer[i] << 3);
                }

                decryptedFileStream.Write(buffer, 0, bytesRead);
            }
        }

    }

    static uint CircularShift(uint number, int count, bool isShiftLeft)
    {
        // Проверка на то, что count находится в uint, т.е в диапазоне [0, 31]
        if (count < 0 || count > 31)
        {
            return 0;
        }

        if (isShiftLeft)
        {
            return (number << count) | (number >> (32 - count));
        }
        else
        {
            return (number >> count) | (number << (32 - count));
        }
    }

}