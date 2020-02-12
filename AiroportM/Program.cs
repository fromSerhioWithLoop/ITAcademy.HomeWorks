using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirMEngine;
using AirMLib;


/// <summary>
/// TerminalEngine.cs contains functions for correct working main programm
/// Console.cs contains contains blocks for quick and easy console settings
/// AiroportM.cs contains classes that affects only airoporsts settings
/// </summary>

namespace AiroportM
{
    class Program
    {
        static void Main(string[] args)
        {

            

            while (true) //main loop
            {
                Person person = new Person();
                Ticket ticket = new Ticket();
                Baggage baggage = new Baggage();
                TerminalEngine engine = new TerminalEngine();

                string answer="";

                engine.BookSetter(TerminalEngine.PageList.waiting);
                person.Name=engine.BookSetter(TerminalEngine.PageList.welcome);
                ticket.Name = person.Name;

                while (true) //checkIn loop
                {
                    answer = engine.BookSetter(TerminalEngine.PageList.ticketCheking,ticket.Name);
                    if (answer == "1") // i need a ticket
                    {
                        person.Pasport = engine.BookSetter(TerminalEngine.PageList.passportSetting);

                        while (true) //regisration loop
                        {
                            answer = engine.BookSetter(TerminalEngine.PageList.airoportChoosing);
                            if (engine.AiroportChoosing(ref ticket, answer) == true) break;
                        }

                        while (true) //baggage loop
                        {
                            answer = engine.BookSetter(TerminalEngine.PageList.baggageScalling);
                            if (!int.TryParse(answer, out int bagWeight)) Console.WriteLine("\n\tЭто не цифра!");
                            else { Console.WriteLine(bagWeight); baggage.Weight = bagWeight; break; }
                        }
                        baggage.BaggageCost(baggage.Weight, ticket.Range);
                        BarCodes barCodes = new BarCodes();
                        ticket.BarCode = barCodes.GetBarCode();

                        engine.BookSetter(TerminalEngine.PageList.baggageOvCheck, baggage.AdditionalCost.ToString());
                        break;
                    }

                    if (answer == "2") //i have the ticket!
                    {
                        BarCodes barCodes = new BarCodes();
                        ticket.BarCode = barCodes.GetBarCode();
                        do 
                        {
                        } while (engine.BookSetter(TerminalEngine.PageList.barCodeChecking,ticket.BarCode)!= ticket.BarCode);
                        break;
                    }
                }

                ticket.Cost = ticket.TicketCost(baggage.Cost);
                engine.BookSetter(TerminalEngine.PageList.ticketTyping,ticket);
                engine.BookSetter(TerminalEngine.PageList.GoodLuckPage);
            }
        }
    }

}


