using System;
using Expert.Domain.Entities.Interfaces;

namespace Expert.Domain.Entities;

public abstract class AuditedEntityBase<TKey> : BaseEntity<TKey>, IAuditedEntityBase
{
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime LastModifiedDate { get; set; }
}
