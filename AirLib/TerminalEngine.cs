using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirMLib;

namespace AirMEngine
{



    public class TerminalEngine 
    {
        private string Answer{get;set;}



        public enum PageList
        {
            waiting,
            welcome,
            ticketCheking,
            passportSetting,
            airoportChoosing,
            baggageScalling,
            baggageOvCheck,
            barCodeChecking,
            ticketTyping,
            GoodLuckPage
        }
        //---------------------------------------------------------------------------


        public string OutputFunc(Graf graf) 
        {
            Console.Clear();
            string PrintConsole = graf.OutputGraf();
            foreach (char i in PrintConsole) Console.Write(i);
            string answer = Console.ReadLine();
            return answer;
        }



        /// <summary>
        /// function overload for any types input values
        /// </summary>
 
        public string BookSetter(PageList pagelist, Ticket ticket)
        {
            string str = "";
            return BookSetPage(pagelist, ticket, str);
        }

        public string BookSetter(PageList pagelist, string str)
        {
            Ticket ticket = new Ticket();
            return BookSetPage(pagelist, ticket, str);
        }

        public string BookSetter(PageList pagelist)
        {
            Ticket ticket = new Ticket();
            string str = "";
            return BookSetPage(pagelist, ticket, str);
        }
        //------------------------------------------------------------------------

        public string BookSetPage(PageList pageList,Ticket ticket, string str)
        {
            ConsoleBook book = new ConsoleBook();
            Graf graf = new Graf();
            string answer;

            switch (pageList)
            {
                case PageList.waiting:
                    book.StartPage(ref graf); break;
                case PageList.welcome:
                    book.NamePage(ref graf); break;
                case PageList.ticketCheking:
                    book.CheckInPage(ref graf,str); break;
                case PageList.passportSetting:
                    book.ClientLoginPage(ref graf); break;
                case PageList.airoportChoosing:
                    Airoports airoports = new Airoports();
                    book.DestinationPlaceChoosingPage(ref graf,airoports); break;
                case PageList.baggageScalling:
                    book.BaggageControl(ref graf); break;
                case PageList.baggageOvCheck:
                    book.BaggageOversizeCheck(ref graf,str); break;
                case PageList.barCodeChecking:
                    book.BarCodeCheckingPage(ref graf,str); break;
                case PageList.ticketTyping:
                    Ticket ticket1 = new Ticket();
                    book.TicketOnDisplay(ref graf,ticket); break;
                case PageList.GoodLuckPage:
                    book.GoodLuck(ref graf); break;
                default:break;
                
            }
            answer = OutputFunc(graf);
            return answer;
        }
//-----------------------------------------------------------------------------------------------
        public bool AiroportChoosing(ref Ticket ticket, string choose)
        {
           
            Airoports airoports = new Airoports();
            switch (choose)
            {
                case "1":
                    ticket.Sity = airoports.City(AiroportsCount.Barcelona);
                    ticket.Range = airoports.Distance(AiroportsCount.Barcelona);
                    ticket.Destination = airoports.Country(AiroportsCount.Barcelona);
                    break;
                case "2":
                    ticket.Sity = airoports.City(AiroportsCount.Berlin);
                    ticket.Range = airoports.Distance(AiroportsCount.Berlin);
                    ticket.Destination = airoports.Country(AiroportsCount.Berlin);
                    break;
                case "3":
                    ticket.Sity = airoports.City(AiroportsCount.Frankfurt);
                    ticket.Range = airoports.Distance(AiroportsCount.Frankfurt);
                    ticket.Destination = airoports.Country(AiroportsCount.Frankfurt);
                    break;
                case "4":
                    ticket.Sity = airoports.City(AiroportsCount.London);
                    ticket.Range = airoports.Distance(AiroportsCount.London);
                    ticket.Destination = airoports.Country(AiroportsCount.London);
                    break;
                case "5":
                    ticket.Sity = airoports.City(AiroportsCount.Madrid);
                    ticket.Range = airoports.Distance(AiroportsCount.Madrid);
                    ticket.Destination = airoports.Country(AiroportsCount.Madrid);
                    break;
                case "6":
                    ticket.Sity = airoports.City(AiroportsCount.Minsk);
                    ticket.Range = airoports.Distance(AiroportsCount.Minsk);
                    ticket.Destination = airoports.Country(AiroportsCount.Minsk);
                    break;
                case "7":
                    ticket.Sity = airoports.City(AiroportsCount.Moscow);
                    ticket.Range = airoports.Distance(AiroportsCount.Moscow);
                    ticket.Destination = airoports.Country(AiroportsCount.Moscow);
                    break;
                case "8":
                    ticket.Sity = airoports.City(AiroportsCount.Paris);
                    ticket.Range = airoports.Distance(AiroportsCount.Paris);
                    ticket.Destination = airoports.Country(AiroportsCount.Paris);
                    break;
                default: return false;

            }
            return true;

        }

    }

}
