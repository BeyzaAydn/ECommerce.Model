using ECommerce.Model.Enums;
using ECommerce.Model.Interfaces;

namespace ECommerce.Model.Base
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {

            Status = DataStatus.INSERTED;

            CreatedDate = DateTime.Now;
            CreatedComputerName = System.Environment.MachineName; // Bilgisayarın adını verir.System kütüphanesi içinden environment ile bilgisayar adını alırız
            CreatedIpAddress = ""; //todo: IPadressi alınacak.
            MasterId = Guid.NewGuid();
            IsActive = true;
        }



        public int ID { get; set; }
        public Guid MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string ?UpdatedComputerName { get; set; }
        public string ?UpdatedIpAddress { get; set; }
        public bool IsActive { get; set; }
        public DataStatus Status { get ; set ; }
    }
}
