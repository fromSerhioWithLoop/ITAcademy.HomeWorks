using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirMLib
{


    

    public class Baggage
    {
        public ushort TaxPer100Km { get; private set; } = 5;
        public ushort BaggageAllowance {get; set;} = 8;
        public ushort OversizeTax{ get; private set; } = 10;
        public ushort MaxBaggageWeight { get; private set; } = 20;
        public int Weight { get;  set; } = 20;
        public ushort Pics=0;
        public double Cost { get; set; } = 0;
        public double AdditionalCost { get; set; } = 0;


        public double BaggageCost(int weight,double distance)
        {
            if (weight < BaggageAllowance) return 0;
            else if (weight < 20) Pics = 1;
            else {
                    Weight = weight;
                    Pics = (ushort)(Weight / MaxBaggageWeight+1);
                 } 
            
            double price=distance/100*Pics;
            Cost = price;
            AdditionalCost = price-distance/100;
            return price;
        }
    }



    public class Person
    {
        public string Name { get; set; }
        public string Pasport { get; set; }
        public string PersonID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Sitizen { get; set; }

    }

    public class Ticket : Person
    {
        public string Sity { get; set; } = "Moscow";
        public double Cost { get; set; } = 200;
        public string BarCode { get; set; }
        public string Destination { get; set; } = "Russia";
        public int Range { get; set; } = 700;
        private ushort BaseCostPer100km { get; set; } = 10;

        public Ticket():base()
        {
        }

        
        public double TicketCost(double baggageCost)
        {
            double totalcost=Range/BaseCostPer100km+baggageCost;
            
            return totalcost;
        }

        public int FlyingTime()
        {
            int airplaneSpeed = 700;
            int time=Range/airplaneSpeed;
            return time;
        }
              
    }




    public class BarCodes
    {
        public string Barcode { get; set; }

        public string GetBarCode()
        {

            Random getBarCode = new Random();

            Barcode = getBarCode.Next(11111111, 99999998).ToString();
            return Barcode;
        }

      
        public string CheckBarCode(int barcode, string firstname,string secondname)
        {
            string str;
            if (barcode < 11111110 & barcode > 99999999) str = secondname + " " + firstname;
            else str = "Err1";
            return str;
        }

    }

    public enum AiroportsCount : byte
    {
        Minsk,
        Moscow,
        Berlin,
        Frankfurt,
        Paris ,
        London,
        Madrid,
        Barcelona
    }

    public class Airoports
    {

        const ushort minsk = 350;
        const ushort moscow = 700;
        const ushort berlin = 1000;
        const ushort frankfurt = 1400;
        const ushort paris = 1900;
        const ushort london = 1900;
        const ushort madrid = 2800;
        const ushort barcelona = 2400;


        public string City(AiroportsCount airoport)
        {
            switch (airoport)
            {
                case AiroportsCount.Minsk: return "Minsk";
                case AiroportsCount.Moscow: return "Moscow";
                case AiroportsCount.Berlin: return "Berlin";
                case AiroportsCount.Frankfurt: return "Francfurt";
                case AiroportsCount.Paris: return "Paris";
                case AiroportsCount.London: return "London";
                case AiroportsCount.Madrid: return "Madrid";
                case AiroportsCount.Barcelona: return "Barcelona";
                default: return "-";
            }
        }

        public string Country(AiroportsCount airoport)
        {
            switch (airoport)
            {
                case AiroportsCount.Minsk: return "Belarus";
                case AiroportsCount.Moscow: return "Russia";
                case AiroportsCount.Berlin: return "Germany";
                case AiroportsCount.Frankfurt: return "Germany";
                case AiroportsCount.Paris: return "France";
                case AiroportsCount.London: return "England";
                case AiroportsCount.Madrid: return "Spain";
                case AiroportsCount.Barcelona: return "Spain";
                default: return "-";
            }

        }


        public ushort Distance(AiroportsCount airoport)
        {
            switch (airoport)
            {
                case AiroportsCount.Minsk: return minsk;
                case AiroportsCount.Moscow: return moscow;
                case AiroportsCount.Berlin: return berlin;
                case AiroportsCount.Frankfurt: return frankfurt;
                case AiroportsCount.Paris: return paris;
                case AiroportsCount.London: return london;
                case AiroportsCount.Madrid: return madrid;
                case AiroportsCount.Barcelona: return barcelona;
                default: return 0;
            }

        }


    }


}
