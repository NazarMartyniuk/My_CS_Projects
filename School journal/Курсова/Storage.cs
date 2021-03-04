using System;
using System.Collections.Generic;

namespace Курсова
{
    public class Storage
    {
        private List<Goods> storage = new List<Goods>();
        public List<Goods> GetStorage { get => storage; }
        public void AddItem(Goods obj)
        {
            storage.Add(obj);
        }
        public void DeleteItem(Goods obj)
        {
            storage.Remove(obj);
        }
        public List<Goods> FindUniqGoods(Goods obj)
        {
            List<Goods> res = new List<Goods>();
            if(obj is Groceries)
            {
                Groceries newObj = obj as Groceries;
                foreach (Goods item in storage)
                {
                    Groceries tmp = item as Groceries;
                    if (tmp != newObj)
                        res.Add(tmp);
                }
            }
            else
            {
                NonGroceries newObj = obj as NonGroceries;
                foreach (Goods item in storage)
                {
                    NonGroceries tmp = item as NonGroceries;
                    if (tmp != newObj)
                        res.Add(tmp);
                }
            }
            return res;
        }
    }
}
