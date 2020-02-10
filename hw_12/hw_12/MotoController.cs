using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using BaseLib;

namespace hw_12
{
    public class MotoController
    {
        public Motocycle GetMotorcycleByID(string answer)
        {
            List<Motocycle> motoBase = GetMotorcycles();
            foreach (var item in motoBase)
            {
                if (item.ID == answer)
                {
                    //controller.DeleteMotorcycle(item);
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Get undefined object[] returned from base and cutting as List of Motorcycles 
        /// </summary>
        /// <returns></returns>
        public List<Motocycle> GetMotorcycles()
        {
            CRUD crud = new CRUD();
            List<Motocycle> motoList = new List<Motocycle>();
            object[] obj = crud.GetAll();
            if (obj == null) return null;
            IEnumerator num = obj.GetEnumerator(); //set IEnumerator for obj,
                                                    //now I can devide my object on list of Motorcycles
            while (num.MoveNext())
            {
                object item = num.Current;
                Motocycle motocycle = item as Motocycle;
               motoList.Add(item as Motocycle);
            }
            num.Reset();
            return motoList;
        }
        public void CreatMotorcycle(object moto)
        {
            CRUD crud = new CRUD();
            crud.Add(moto);
        }
        public bool UpdateMotorcycle(Motocycle oldMoto, Motocycle newMoto)
        {
            CRUD crud = new CRUD();
            return crud.Update(oldMoto,newMoto);
        }
        public bool DeleteMotorcycle(Motocycle moto)
        {
            CRUD crud = new CRUD();
            return crud.Delete(moto);
        }
    }
}
