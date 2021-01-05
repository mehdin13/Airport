using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class ToDoViewModel
    {
        public string Title { get; set; }
        public int Flight { get; set; }
        public string Description { get; set; }

    }
    public class ToDoListViewModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int FlightId { get; set; }
        public string Description { get; set; }
        public bool IsDon { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime LastUpdate { get; set; }

    }
    public class ToDoModifyViewModel
    {
        public int id { get; set; }
        public bool isdone { get; set; }
    }
}