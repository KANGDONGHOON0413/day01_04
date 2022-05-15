using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01_04
{
    //this를 활용한 코딩
    class book01
    {
        string Title;
        decimal money;
        string author;

        public book01(): this(string.Empty, 0, string.Empty) { }
        public book01(string Title): this(Title, 0, string.Empty) { }
        public book01(string Title, decimal money) : this(Title, money, string.Empty) { }
        public book01(string Title, decimal money, string author)
        {
            this.Title = Title;
            this.money = money;
            this.author = author;
        }
        public void getdata()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("money: " + money);
            Console.WriteLine("author: " + author);
            Console.WriteLine("");
        }

        public void Setdata(){ Setdata(string.Empty, 0, string.Empty); }
        public void Setdata(string Title) { Setdata(Title, 0, string.Empty); }
        public void Setdata(string Title, decimal money) { Setdata(string.Empty, money, string.Empty); }
        public void Setdata(string Title, decimal money, string author)
        {
            this.Title = Title;
            this.money = money;
            this.author = author;
        }
        
    }

    class book2 : book01
    {
        string Title = "잡지";
        decimal money = 5000;
        string author = "제이케이롤링";

        //base는 java의 super 와 비슷하다.
        public book2() : base() { }
        public book2(string Title) : base(Title) { }
        public book2(string Title, decimal money) : base(Title, money) { }
        public book2(string Title, decimal money, string author) : base(Title, money, author) { }

        public void setdefault()
        {
            base.Setdata(Title, money, author);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book01 Book01 = new book01();
            book01 Book02 = new book01("명상");
            book01 Book03 = new book01("명상", 10000);
            book01 Book04 = new book01("명상", 10000, "강동훈");

            Console.WriteLine("Book01 INFO:");
            Book01.getdata();
            Console.WriteLine("Book02 INFO:");
            Book02.getdata();
            Console.WriteLine("Book03 INFO:");
            Book03.getdata();
            Console.WriteLine("Book04 INFO:");
            Book04.getdata();

            Book01.Setdata("c#9.0프로그래밍", 21000, "정성태 위키북스");
            Book01.getdata();

            book2 Book05 = new book2("영국", 1000, "연방");
            Console.WriteLine("Book05_1 INFO: (default data)");
            Book05.getdata();
            Book05.setdefault();
            Console.WriteLine("Book05_2 INFO: (set default data)");
            Book05.getdata();
            Book05.Setdata("프랑스", 2000, "라팔");
            Console.WriteLine("Book05_3 INFO: (setted data)");
            Book05.getdata();

        }
    }
}
