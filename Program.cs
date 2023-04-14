using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請依序輸入姓名、就讀學校、興趣");
            Console.WriteLine("如要結束請輸入"+"\"END\"");
            while(true)
            {
                string name, school, interest;
                name= Console.ReadLine();
                if (name == "END") break;
                school= Console.ReadLine();
                interest= Console.ReadLine();
                Data data= new Data();
                data.Datasave(name, school, interest);
                Data.Datainsert(data);
            }
            Console.WriteLine("\n"+"如要查詢資料請輸入人名或輸入關鍵字");
            Console.WriteLine("如要結束使用請輸入"+"\"STOP\"");
            while(true)
            {
                string search;
                search = Console.ReadLine();
                if (search == "STOP")
                {
                    Console.WriteLine("感謝使用");
                    break;
                }
                Data.Datasearch(search);
            }
        }
    }
}
