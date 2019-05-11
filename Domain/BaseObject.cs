using System;

namespace Domain
{
    public class BaseObject
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }

}
