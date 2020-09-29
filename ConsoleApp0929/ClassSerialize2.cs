using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0929
{
    class ClassSerialize2
    {
        static void Main()
        {
            BinaryFormatter serializer = new BinaryFormatter();
            //--------------------------------------
            //파일을 읽어서 배열에 저장
            PersonS[] arr = new PersonS[1];
            if (File.Exists("b.dat"))
            {
                FileStream rs = new FileStream("b.dat", FileMode.Open);
                arr = (PersonS[])serializer.Deserialize(rs);
                Console.WriteLine("객체 역직렬화 성공");
                foreach(PersonS item in arr)
                {
                    Console.WriteLine(item.Name);
                }
                rs.Close();
            }
            int readCnt = arr.Length;
            //-------------------------------
            PersonS[] new_arr = new PersonS[100];
            Array.Copy(arr, new_arr, readCnt);

            while (true)
            {
                string name = Console.ReadLine();
                string phone = Console.ReadLine();
                if (name.Equals("q")||phone.Equals("q")){ break; }
                
                int age = int.Parse(Console.ReadLine());
                new_arr[readCnt] = new PersonS(name, phone, age);
                readCnt++;
            }
            //--------------------------------
            FileStream fs = new FileStream("b.dat", FileMode.Create);
            serializer.Serialize(fs, new_arr);
            fs.Close();
            Console.WriteLine("객체 직렬화 성공");
        }
    }
}
