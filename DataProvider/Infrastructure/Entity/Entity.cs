using System;

namespace DataProvider.Infrastructure.Entity
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
