using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace hw_12
{
    /// <summary>
    /// When add 1 more page:
    /// 1.add name of page in pagelist
    /// 2.creat grafPage in Console.cs ConsoleBook
    /// 3.add this grafPage in BookDialog()
    /// </summary>
    public class InterfaceEngine
    {
        private string Answer { get; set; }

        public enum PageList //when add page -- creat grafPage in Console.cs and add this grafPage in BookDialog() 
        {
            startPage,
            menuPage,
            addMotoPage,
            updateMotoPage,
            deleteMotoPage
        }
        public string BookSetter(PageList pagelist)//used for overload input parametrs for BookSetPage 
        {
            Motocycle moto = null;
            Motocycle[] motoBase = null;
            return BookDialog(pagelist,moto,motoBase);
        }
        public string BookSetter(PageList pagelist, Motocycle[] motoBase)//overload 2
        {
            Motocycle moto = null;
            return BookDialog(pagelist,moto, motoBase);
        }
        public string BookSetter(PageList pagelist, Motocycle moto)//overload 3
        {
            Motocycle[] motoBase = null;
            return BookDialog(pagelist,moto, motoBase);
        }
        public string BookDialog(PageList pageList,Motocycle moto,Motocycle[] motoBase) //output graf and RETURN answer from console!!!
        {
            ConsoleBook book = new ConsoleBook();
            Graf graf = new Graf();
            string answer;
            switch (pageList)
            {
                case PageList.startPage:
                    book.StartPage(ref graf); break;
                case PageList.menuPage:
                    book.MenuPage(ref graf); break;
                case PageList.addMotoPage:
                    book.AddMotoPage(ref graf); break;
                default: break;
            }
            answer = OutputFunc(graf,motoBase);
            return answer;
        }
        public string OutputFunc(Graf graf,Motocycle[] motoBase)
        {
            Console.Clear();
            string PrintConsole = graf.OutputGraf();
            foreach (char i in PrintConsole) Console.Write(i);
            Console.WriteLine();
            var count = 1;
            if(motoBase!=null)
            {
                foreach (var moto in motoBase)
                {
                    //Motocycle m = new Motocycle();
                    //List<string> m = new List<string>(item as string);
                    Console.WriteLine($"\t{count}. ID: {moto.ID}\t Brand: {moto.Name}\t Model: {moto.Name}" +
                                        $"\t Year: {moto.Year}\t Mileage: {moto.Odometr}");
                    count++;
                }
            }
            string answer = Console.ReadLine();
            return answer;
        }

    }
}
