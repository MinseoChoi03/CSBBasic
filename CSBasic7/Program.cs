using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Products
    {
        private List<string> list = new List<string>();
        public Products()
        {
            list.Add("탕수육");
            list.Add("차돌 짬뽕");
            list.Add("볶음 짬뽕");
            list.Add("깐쇼새우");
            list.Add("양장피");
            list.Add("간짜장");
        }
        public string this[int i]
        {
            get { return list[i]; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }
    class Program
    {
        struct Point
        {
            public int x;
            public int y;
        }
        static void NextPosition(int x, int y, int vx, int vy,
            out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        class Wanted<T>
            //where T : Student
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }
        class Student
        {
            public override string ToString()
            {
                return "학생";
            }
        }
        static void Main(string[] args)
        {
            Point point;
            point.x = 10;
            point.y = 10;

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재 좌표 : " + x + "," + y);
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표 : " + x + "," + y);

            Console.Write("숫자 입력 : ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("변환 성공 : " + output);
            }
            else
            {
                Console.WriteLine("변환 실패 : " + output);
            }

            Products ps = new Products();
            Random rs = new Random();
            int i = rs.Next(0, 6);
            Console.WriteLine(ps[i]);

            Wanted<string> ws = new Wanted<string>("string");
            Wanted<int> wi = new Wanted<int>(10);
            Wanted<Student> wstu = new Wanted<Student>(new Student());
            Console.WriteLine(ws);
            Console.WriteLine(wi);
            Console.WriteLine(wstu);

        }
    }
}
