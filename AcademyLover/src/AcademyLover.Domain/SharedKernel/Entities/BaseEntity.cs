using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLover.Domain.SharedKernel.Entities
{
    public class BaseEntity<T>
    {
        public int Id { get; set; }
    }
}
