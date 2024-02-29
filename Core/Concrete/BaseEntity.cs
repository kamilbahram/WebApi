using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreatedData { get; set; }
        public DateTime UpdatedData { get; set; }
        public DateTime DeletedData { get; set; }
    }
}
