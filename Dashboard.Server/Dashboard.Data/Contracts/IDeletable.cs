using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Data.Contracts
{
    internal interface IDeletable
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.mm.yyyy}", ApplyFormatInEditMode = true)]
        DateTime? DeletedOn { get; set; }

        bool IsDeleted { get; set; }
    }
}
