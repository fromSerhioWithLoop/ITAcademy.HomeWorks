using System;
using System.Collections.Generic;
using System.Text;

namespace BaseLib
{
    /// <summary>
    /// FIRST VALUE IN recieved object MUST BE --- string iD !!!!
    /// GetAll(object[]) return ALL BASE in Arr as object[]
    /// Add(object) add object in BASE 
    /// Update(object)return bool(false if not founded),DELETE object by ID and ADD recieved object
    /// Delete(object) return bool(false if not founded),DELETE object by ID
    /// DeleteBase() DELETE  BASE (debug only!)
    /// </summary>
    public class CRUD
    {
        public object[] GetAll()
        {
            return Bases.MotoBase;
        }

        public void Add(object obj)
        {
            List<object> list = new List<object>
            {
                obj
            };
            if (Bases.MotoBase != null) { list.AddRange(Bases.MotoBase); }
            object[] arr = list.ToArray();
            Bases.MotoBase = arr;
        }
        //
        public bool Update(object oldObj, object newObj)
        {
            if (Delete(oldObj)) { Add(newObj); return true; }
            return false;
        }
        //
        public bool Delete(object obj)
        {
            if (Bases.MotoBase == null) return false;
            List<object> list = new List<object>();
            list.AddRange(Bases.MotoBase);
            foreach (var item in list)
            {
                if (item == obj)
                {
                    list.Remove(item);
                    object[] arr = list.ToArray();
                    Bases.MotoBase = arr;
                    return true;
                }
            }
            Console.WriteLine("Object Not Found. Press any key.");
            Console.ReadKey();
            return false;
        }
        public void DeleteBase() { Bases.MotoBase = null; }
    }
}
