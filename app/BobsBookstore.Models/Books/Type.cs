﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BobsBookstore.Models.Books
{
    public class Type
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Type_Id { get; set; }

        public string TypeName { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
