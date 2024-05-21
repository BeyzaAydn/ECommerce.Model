using Microsoft.AspNetCore.Identity;

namespace ECommerce.Model.Entities
{
    public class AppUserRole:IdentityRole<Guid>
    {
        public string Description {  get; set; }
    }
}
