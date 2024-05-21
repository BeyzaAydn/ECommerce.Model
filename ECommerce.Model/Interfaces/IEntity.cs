using ECommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Interfaces
{
    public  interface IEntity<T>
    {
        public int ID { get; set; }
        public T MasterId { get; set; }

        //Ortak özellikler

        //Created
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }


        //Updated
        public DateTime UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIpAddress { get; set; }

        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }




    }
}
