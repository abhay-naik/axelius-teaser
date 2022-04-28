using Axelius.Storages.SqlDb.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewApi.Commands.Models
{
    [Table("feedbacks",Schema = "core")]
    public class Feedback : SqlEntity
    {
        [Column("id", TypeName="bigint")]
        public long Id { get; set; }

        [Column("name",TypeName ="varchar(200)")]
        public string Name { get; set; }

        [Column("content", TypeName = "varchar(2000)")]
        public string Content { get; set; }
    }
}
