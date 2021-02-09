using System;

namespace Core.Entities
{
    public class User : BaseEntity
    {
        private string UserName { get; set; }
        public int Password { get; set; }
        public DateTime Date { get; set; }
        
    }
}
