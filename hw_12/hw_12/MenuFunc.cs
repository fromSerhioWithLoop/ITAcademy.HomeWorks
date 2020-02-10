using System;
using System.Collections.Generic;
using System.Text;

namespace hw_12
{
    public static class MenuFunc
    {
        public static Motocycle AddMoto(string answ)
        {
            Motocycle motocycle = new Motocycle();
            string[] temp = new string[5];
            string[] words = answ.Split();
            for (int i = 0; i < 5; i++)
            {
                try { temp[i] = words[i]; }
                catch { temp[i] = "-"; }
            }
            motocycle.ID = temp[0];
            motocycle.Name = temp[1];
            motocycle.Model = temp[2];
            motocycle.Year = temp[3];
            motocycle.Odometr = temp[4];
            return motocycle;
        }
    }
}
