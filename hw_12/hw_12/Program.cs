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
            
            //Motocycle motoBase;
            string answer = "";
            engine.BookSetter(InterfaceEngine.PageList.startPage);
            Motocycle[] motocycleBase = null;
            while (true)//menu loop
            {
                
                motocycleBase =  controller.GetMotorcycles(motocycleBase);
                answer =engine.BookSetter(InterfaceEngine.PageList.menuPage,motocycleBase);
                while (true)//loop
                {
                    if (answer == "1")
                    {
                        answer = engine.BookSetter(InterfaceEngine.PageList.addMotoPage, motocycleBase);
                        Motocycle motocycle = new Motocycle();
                        // motocycle= answer.Split() as Motocycle;

                        string[] temp = new string[5];
                        string[] words = answer.Split();
                        answer = null;
                        int i;
                        
                        //catch { }
                        for (i = 0; i < 5; i++)
                        {
                            try{temp[i] = words[i];}
                            catch { temp[i] = "-";}
                        }
                        motocycle.ID = temp[0];
                        motocycle.Name = temp[1];
                        motocycle.Model = temp[2];
                        motocycle.Year = temp[3];
                        motocycle.Odometr = temp[4];



                        //ArrayList list = new ArrayList(5);
                        //list.AddRange(words);

                        //motocycle=list.ToArray() as Motocycle;
                        //Object obj = word as Object;
                        //Console.WriteLine(obj);
                        //Console.ReadKey();
                        //motocycle = obj as Motocycle;
                        
                        Console.WriteLine(motocycle.ID+motocycle.Odometr);
                        Console.ReadKey();
                        controller.CreatMotorcycle(motocycle);
                        motocycleBase = controller.GetMotorcycles(motocycleBase);
                        break;
                        //if(word[0]!=null)motocycle.ID =
                        //motocycle=word as Motocycle();
                        //Console.WriteLine(word[0]);
                        //Console.ReadKey();
                        ////string[] words = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        // if (words[0] != null) motocycle.ID = words[0];

                        //List<Motocycle> list = words as Motocycle;

                    }
                    else if (answer == "2")
                    {
                        answer = engine.BookSetter(InterfaceEngine.PageList.updateMotoPage);
                    }
                    else if (answer == "3")
                    {
                        answer = engine.BookSetter(InterfaceEngine.PageList.deleteMotoPage);
                    }
                    else break;
                    
                }
                //Console.ReadKey();
            }
        }
    }
}
