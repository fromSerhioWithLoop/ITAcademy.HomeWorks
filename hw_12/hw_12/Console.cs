using System;
using System.Collections.Generic;
using System.Text;

namespace hw_12
{
    /// <summary>
    /// there is place for all grafPages
    /// </summary>
    public class ConsoleBook
    {
        public void StartPage(ref Graf graf)
        {
            graf.ThirdLine = "\n\t";
            graf.FourthLine = "\n\t\t\t\tIII\tTTTTTTTTTTT";
            graf.FifthLine = "\n\t\t\t\tIII\t    TTT";
            graf.SixthLine = "\n\t\t\t\t   \t    TTT";
            graf.SeventhLine = "\n\t\t\t\tIII\t    TTT";
            graf.EighthLine = "\n\t\t\t\tIII\t    TTT";
            graf.Ninthline = "\n\t\t\t\tIII\t    TTT";
            graf.TenthLine = "\n\t\t\t\tIII\t    TTT   ACADEMY ";
            graf.EleventhLine = "\n\t\t\t  SerhioFromLoop development";
            graf.StatusLine = "\nPrompt:\t press Enter for continue.\n";
        }
        public void MenuPage(ref Graf graf)
        {
            graf.ThirdLine = "\n\t\t\t\t MENU";
            graf.FifthLine = "\n\t\t Please choose what doing now:";
            graf.SixthLine = "\n\t\t 1.Add motorcycle.";
            graf.SeventhLine = "\n\t\t 2.Change motorcycle";
            graf.EighthLine = "\n\t\t 3.Delete motorcycle";
            graf.StatusLine = "\n\tPlease choose any line and press Enter.\n";
        }
        public void AddMotoPage(ref Graf graf)
        {
            graf.ThirdLine = "\n\t\t\t CREATING MOTOCICKLE";
            graf.FourthLine = "\n\t Please enter the following values with a space and press Enter";
            graf.FifthLine = "\n\t\t  ID\tBrand\tModel\tYear\tOdometr";
            graf.SixthLine = "\n\t\t If you have no info obout any position enter \"-\" ";
        }
        public void DeleteMotoPage(ref Graf graf)
        {
            graf.ThirdLine = "\n\t\t\t DELETE MOTOCICKLE";
            graf.FourthLine = "\n\t Please enter the ID deleting motocycle";
        }

        public void UpdateMotoPage(ref Graf graf)
        {
            graf.ThirdLine = "\n\t\t\t CHANGE MOTOCICKLE";
            graf.FourthLine = "\n\t Please enter the ID Changing motocycle";
        }

    }
    /// <summary>
    /// Based graf for all pages
    /// </summary>
    public class Graf
    {
        public string FirstLine { get; set; } = "\n\n\t\t\t  Motorsycles base Admin's Room!!!";
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
        //
        public string OutputGraf()
        {
            string stringToOut = FirstLine + SecondLine + ThirdLine + FourthLine +
                               FifthLine + SixthLine + SeventhLine + EighthLine +
                               Ninthline + TenthLine + EleventhLine + TwelfthLine
                               + ThirteenthLine + StatusLine;
            return stringToOut;
        }
    }
}
