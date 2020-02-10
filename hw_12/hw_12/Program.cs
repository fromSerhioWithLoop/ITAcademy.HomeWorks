using System;
using System.Collections;
using System.Collections.Generic;

namespace hw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceEngine engine = new InterfaceEngine();
            MotoController controller = new MotoController();
            string answer = "";
            engine.BookSetter(InterfaceEngine.PageList.startPage);
            List<Motocycle> motocycleBase = null;
            while (true)//menu loop
            {
                motocycleBase =  controller.GetMotorcycles();
                answer =engine.BookSetter(InterfaceEngine.PageList.menuPage,motocycleBase);
                while (true)//checking loop
                {
                    if (answer == "1")
                    {
                        answer = engine.BookSetter(InterfaceEngine.PageList.addMotoPage, motocycleBase);
                        controller.CreatMotorcycle(MenuFunc.AddMoto(answer));
                        answer = null;
                        break;
                    }
                    else if (answer == "2")
                    {
                        answer = engine.BookSetter(InterfaceEngine.PageList.updateMotoPage,motocycleBase);
                        Motocycle motocycle= controller.GetMotorcycleByID(answer);
                        if (motocycle != null) Console.WriteLine("Введите новые параметры мотоцикла:");
                        answer = Console.ReadLine();
                        controller.UpdateMotorcycle(motocycle,MenuFunc.AddMoto(answer));
                    }
                    else if (answer == "3")
                    {
                        answer = engine.BookSetter(InterfaceEngine.PageList.deleteMotoPage, motocycleBase);
                        controller.DeleteMotorcycle(controller.GetMotorcycleByID(answer));
                    }
                    else break;
                }
            }
        }
    }
}
