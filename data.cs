using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Data
    {
        private static Data[] list= new Data[1000];
        public static int k = 0;
        private string name;
        private string school;
        private string interest;
        private static bool flag = true;

        public void Datasave(string name,string school,string interest)
        {
            this.name = name;
            this.school = school;
            this.interest = interest;
        }
        public static void Datainsert(Data data)
        {
            list[k] = data;
            k++;
        }
        public static bool Schoolsearch(string search)
        {
            for (int i = 0; i < k; i++)
            {
                if (list[i].school == search)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Interestsearch(string search)
        {
            for (int i = 0; i < k; i++)
            {
                if (list[i].interest == search)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Datasearch(string search)
        {
            for(int i = 0; i < k; i++)
            {
                if (list[i].name== search)
                {
                    Console.WriteLine("姓名：" + list[i].name);
                    Console.WriteLine("就讀學校：" + list[i].school);
                    Console.WriteLine("興趣：" + list[i].interest);
                    flag= false;
                }
            }
            if(Schoolsearch(search))
            {
                Console.WriteLine("就讀"+search+"的有");
                for(int i = 0; i < k; i++)
                {
                    if (list[i].school == search)
                    {
                        Console.WriteLine(list[i].name+" ");
                    }
                }
            }
            else if(Interestsearch(search))
            {
                Console.WriteLine("興趣是" + search + "的有");
                for (int i = 0; i < k; i++)
                {
                    if (list[i].interest == search)
                    {
                        Console.WriteLine(list[i].name + " ");
                    }
                }
            }
            else
            {
                if(flag)
                {
                    Console.WriteLine("查無此關鍵字");
                }
            }
        }

    }
}
