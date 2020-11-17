using System;
using System.Collections.Generic;
using System.Text;
using AirPortDataLayer.Data;
using System.Linq;

namespace AirPortDataLayer.Crud
{
    public class Category
    {
        public readonly AppDatabaseContext _db;
        public Category(AppDatabaseContext db)
        {
            _db = db;
        }
        public string Insert(AirPortModel.Models.Category obj)
        {
            try
            {
                _db.categories.Add(obj);
                _db.SaveChanges();
                return "Successful";
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }
}
//Insert Complete baghiash moonde bargashtam mizanam :D
