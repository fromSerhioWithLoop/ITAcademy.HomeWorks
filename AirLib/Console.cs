using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirMLib
{
    public class ConsoleBook
    {
        public void ClearPage(ref Graf graf)
        {
            graf.ThirdLine = "\n";
            graf.FourthLine  = "\n";
            graf.FifthLine  = "\n";
            graf.SixthLine = "\n";
            graf.SeventhLine = "\n";
            graf.EighthLine = "\n";
            graf.Ninthline = "\n";
            graf.TenthLine = "\n";
            graf.EleventhLine = "\n";
            graf.StatusLine = "\n";
        }

        public void StartPage(ref Graf graf)
        {
            graf.ThirdLine      = "\n\t";
            graf.FourthLine     = "\n\t\t\t\tIII\tTTTTTTTTTTT";
            graf.FifthLine      = "\n\t\t\t\tIII\t    TTT";
            graf.SixthLine      = "\n\t\t\t\t   \t    TTT";
            graf.SeventhLine    = "\n\t\t\t\tIII\t    TTT";
            graf.EighthLine     = "\n\t\t\t\tIII\t    TTT";
            graf.Ninthline      = "\n\t\t\t\tIII\t    TTT";
            graf.TenthLine      = "\n\t\t\t\tIII\t    TTT   ACADEMY BOT";
            graf.EleventhLine   = "\n\t\t\t  SerhioFromLoop development";
            graf.StatusLine = "\nPrompt:\t press Enter for continue.\n";
        }
        public void NamePage(ref Graf graf)
        {
            graf.ThirdLine = "\n\t\t You are welcome in our Airoport!!!";
            graf.FifthLine = "\n\t\t How can I call you, Sir?";
            graf.StatusLine = "\n Prompt:\tPlease enter your first and second name.\n";
        }

        public void CheckInPage(ref Graf graf,string name)
        {
            graf.ThirdLine = "\n\t\t You are welcome in our Airoport!!!";
            graf.FifthLine = "\n\t\t What can I help you, Mr."+name+"?";
            graf.SixthLine = "\n\t\t\t 1.I need buy a ticket";
            graf.SeventhLine = "\n\t\t\t 2.I need check in for a flight";
            graf.StatusLine = "\nPrompt:\tChoose your destiny!\n\t";

        }

        public void BarCodeCheckingPage(ref Graf graf, string barcode)
        {            
            graf.FourthLine = "\n\tPlease entering your personal 8-num BarCode with your Ticket.";
            graf.StatusLine = "\n Promt:\t Your Barcode (bought in internet) with your ticket:"+barcode+"\n";
        }

        public void ClientLoginPage(ref Graf graf)
        {
            graf.FourthLine = "\n\tPlease entering serial and number of your Pasport. ";
            graf.StatusLine = "\n Promt:\t MM 1234567 for example.\n";

        }


        public void DestinationPlaceChoosingPage(ref Graf graf,Airoports airoports)
        {
            
            
            graf.ThirdLine = "\n\t Please choose your destination place:";
            graf.FourthLine = "\n\t\t1."+airoports.City(AiroportsCount.Barcelona);
            graf.FifthLine = "\n\t\t2."+ airoports.City(AiroportsCount.Berlin);
            graf.SixthLine = "\n\t\t3." + airoports.City(AiroportsCount.Frankfurt);
            graf.SeventhLine = "\n\t\t4." + airoports.City(AiroportsCount.London);
            graf.EighthLine = "\n\t\t5." + airoports.City(AiroportsCount.Madrid);
            graf.Ninthline = "\n\t\t6." + airoports.City(AiroportsCount.Minsk);
            graf.TenthLine = "\n\t\t7." + airoports.City(AiroportsCount.Moscow);
            graf.EleventhLine = "\n\t\t8." + airoports.City(AiroportsCount.Paris);
        }

        public void BaggageControl(ref Graf graf)
        {
            graf.FourthLine = "\n\t Please put your baggage on the scales ";
            graf.FifthLine = "\n\t and enter the weight:";
            graf.StatusLine = "\n Promt:\tWeight is(kilo):";
        }

        public void BaggageOversizeCheck(ref Graf graf,string bagOverCost)
        {
            graf.FourthLine = "\n\tYou have oversize weight for 1pics baggage.";
            graf.FifthLine = "\n\tNow you need buy more pics of baggage";
            graf.SixthLine = "\n\tAdditional cost is: " + bagOverCost;//+baggage.AdditionalCost;
            graf.StatusLine = "\n\t Press Enter for continue.";
        }

        public void TicketOnDisplay(ref Graf graf, Ticket ticket)
        {
            graf.ThirdLine = "\n\t   Your ticket:";
            graf.FourthLine = "\n\tMr."+ticket.Name;
            graf.FifthLine = "\n\tBarCode: "+ticket.BarCode;
            graf.SixthLine = "\n\tPlace: "+ticket.Sity+"   "+ticket.Destination;
            graf.SeventhLine = "\n\tFlying time: "+ticket.FlyingTime()+" hours";
            graf.Ninthline = "\n\tTotal cost: "+ticket.Cost+ " euro";
            graf.StatusLine = "\n\tPress Enter.";
        }
        
        public void GoodLuck(ref Graf graf)
        {
            graf.FifthLine="\n\t\t\tWhat now?";
            graf.SeventhLine = "\n\t\tSecurity control is 50m ahead of you.";
            graf.EighthLine = "\n\tThank you for using the services of our airline";

        }

        

    }




    public class Graf
    {

        public string FirstLine { get; set; } = "\n\n\t\t Terminal №1 Airoport MyhosranskInternational";
        public string SecondLine { get; } = "\n**************************************************************************";
        public string ThirdLine { get; set; } = "\n";
        public string FourthLine { get; set; } = "\n";
        public string FifthLine { get; set; } = "\n";
        public string SixthLine { get; set; } = "\n";
        public string SeventhLine { get; set; } = "\n";
        public string EighthLine { get; set; } = "\n";
        public string Ninthline { get; set; } = "\n";
        public string TenthLine { get; set; } = "\n";
        public string EleventhLine { get; set; } = "\n";
        public string TwelfthLine { get; set; } = "\n**************************************************************************";
        public string ThirteenthLine { get; set; } = "\n";
        public string StatusLine { get; set; } = "\n";


        public string OutputGraf()
        {

            string stringToOut = FirstLine + SecondLine + ThirdLine + FourthLine +
                               FifthLine + SixthLine + SeventhLine + EighthLine +
                               Ninthline + TenthLine + EleventhLine + TwelfthLine
                               +ThirteenthLine+StatusLine;

            return stringToOut;
        }


    }
}
