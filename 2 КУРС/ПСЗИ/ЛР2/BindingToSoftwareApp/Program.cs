using System.Security.Cryptography;
using System.Text;
using System.Management;

namespace BindingToSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем данные о жестком диске и хэшируем их
            string serialNumber = GetHardDriveSerialNumber();
            byte[] hashedKey = GetHashedKey(serialNumber);

            // Получаем ключевую информацию с сервера, хэшируем её
            string key = GetKeyFromServer(serialNumber);
            byte[] hashedKeyFromServer = GetHashedKey(key);

            // Сравниваем полученные хэш-суммы
            if (IsSerialNumberHashCorrect(hashedKey, hashedKeyFromServer))
            {
                Console.WriteLine("Correct hard drive serial number. Program was started successfully!");
            }
            else
            {
                Console.WriteLine("Wrong hard drive serial number. Program is not allow to start!");
                return;
            }
        }

        static bool IsSerialNumberHashCorrect(byte[] hashedKey, byte[] hashedKeyFromServer)
        {
            bool flag = true;
            for (int i = 0; i < 16; i++)
            {
                flag = hashedKey[i] == hashedKeyFromServer[i];
            }
            return flag;
        }
        static byte[] GetHashedKey(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                return data;
            }
        }

        static string GetHardDriveSerialNumber()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject drive in searcher.Get())
            {
                string serialNumber = drive["SerialNumber"].ToString();
                Console.WriteLine($"Current Hard Drive serial number is: {serialNumber}");
                return serialNumber;
            }
            return null;
        }

        static string GetKeyFromServer(string data)
        {
            /*
            При использовании реального сервера:
            string url = "http://example.com/get_key.php?data=" + data;
            WebClient client = new WebClient();
            string key = client.DownloadString(url);
            */
            string key = File.ReadAllText($"D:\\WORK\\2 КУРС\\ПСЗИ\\ЛР2\\BindingToSoftwareApp\\server.txt");
            return key;
        }

    }
}
