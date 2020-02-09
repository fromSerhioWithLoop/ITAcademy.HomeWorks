using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace hw_12
{
    class IDGetter
    {
        internal string ID { get; set; }
    }
    /// <summary>
    /// FIRST VALUE IN recieved Object MUST BE --- string iD !!!!
    /// GetAll(Object[]) return ALL BASE in Arr as object[]
    /// GetByID(Object) return object finded by ID
    /// Add(Object) add Object in BASE 
    /// Update(Object)return bool(false if not founded),DELETE object by ID and ADD recieved object
    /// Delete(Object) return bool(false if not founded),DELETE object by ID
    /// DeleteBase() DELETE  BASE (debug only!)
    /// </summary>
    public class CRUD
    {
        public Object[] GetAll(Object[] obj)
        {
            obj = Bases.MotoBase;
            return obj;
        }
        public Object GetByID(Object obj)
        {
            IDGetter objID = obj as IDGetter;
            List<Object> list = new List<Object>();
            list.AddRange(Bases.MotoBase);
            foreach (var item in list)
            {
                IDGetter id = item as IDGetter;
                if (id.ID == objID.ID) return item;
            }
            return null;
        }
        public void Add(Object obj)
        {
            ArrayList list = new ArrayList();
            if(Bases.MotoBase!=null)list.AddRange(Bases.MotoBase);
            list.Add(obj);
            list.Sort();
            Bases.MotoBase= list.ToArray();
        }
        public bool Update(Object obj)
        {
            IDGetter objID = obj as IDGetter;
            List<Object> list = new List<Object>();
            list.AddRange(Bases.MotoBase);
            foreach (var item in list)
            {
                IDGetter id = item as IDGetter;
                if (id.ID == objID.ID)
                {
                    list.Remove(item);
                    list.Add(obj);
                    list.Sort();
                    Bases.MotoBase = list.ToArray();
                    return true;
                }
            }
            return false;
        }

        public bool Delete(Object obj)
        {
            IDGetter objID = obj as IDGetter;
            List<Object> list = new List<Object>();
            list.AddRange(Bases.MotoBase);
            foreach (var item in list)
            {
                IDGetter id = item as IDGetter;
                if (id.ID == objID.ID)
                {
                    list.Remove(item);
                    list.Sort();
                    Bases.MotoBase = list.ToArray();
                    return true;
                }
            }
            return false;
        }
        public void DeleteBase() { Bases.MotoBase = null; }
    }
}
