using System.ComponentModel.DataAnnotations.Schema;

namespace GGlease.Model.DB.Generic
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}