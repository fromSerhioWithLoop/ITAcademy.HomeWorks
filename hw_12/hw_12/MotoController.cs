using System;
using System.Collections.Generic;
using System.Text;

namespace hw_12
{
    public class MotoController
    {
        public Motocycle GetMotorcycleByID(Motocycle moto)
        {
            CRUD crud = new CRUD();
            return moto = crud.GetByID(moto) as Motocycle;
        }
        public Motocycle[] GetMotorcycles(Object[] moto)
        {
            CRUD crud = new CRUD();
            moto = crud.GetAll(moto);
            Motocycle[] M = (Motocycle[])moto; //as Motocycle[];
            return M; 
        }
        public void CreatMotorcycle(Object moto)
        {
            CRUD crud = new CRUD();
            crud.Add(moto);
        }
        public bool UpdateMotorcycle(Motocycle moto)
        {
            CRUD crud = new CRUD();
            return crud.Update(moto);
        }
        public bool DeleteMotorcycle(Motocycle moto)
        {
            CRUD crud = new CRUD();
            return crud.Delete(moto);
        }
    }
}
