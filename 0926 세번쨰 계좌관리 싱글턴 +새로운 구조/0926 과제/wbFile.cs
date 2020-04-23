using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _0926_과제
{
    class wbFile
    {
        public static void filesersave(List<Account> arr, int size)
        {
            Stream ws = new FileStream("mlist.txt", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            int max = arr.Count;
            serializer.Serialize(ws, max);
            serializer.Serialize(ws, size);

            for (int i = 0; i < size; i++)
            {
                Account mem = arr[i];
                serializer.Serialize(ws, mem);
            }
            ws.Close();
        }
        public static List<Account> fileserload(out int max)
        {
            Stream rs = new FileStream("mlist.txt", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            max = (int)deserializer.Deserialize(rs);
            int size = (int)deserializer.Deserialize(rs);
            Console.WriteLine("불러온 최대저장개수 : {0}개", max);
            Console.WriteLine("불러온 개수 : {0}개", size);

            Account[] memlist = new Account[size];
            for (int i = 0; i < size; i++)
            {
                memlist[i] = (Account)deserializer.Deserialize(rs);
            }
            rs.Close();
            List<Account> arr = new List<Account>();
            arr.CopyTo(memlist);

            return arr;
        }
    }
}
