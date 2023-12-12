using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.Models
{
    [Table("books")]
    public partial class Book
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("page_count")]
        public int PageCount { get; set; }

        [Column("created_at", ignoreOnInsert: true)]
        public DateTime CreatedAt { get; set; }

        public Book(int id, string name, string author, int pageCount)
        {
            Id = id;
            Name = name;
            Author = author;
            PageCount = pageCount;
        }

        public Book() { }
    }
}
