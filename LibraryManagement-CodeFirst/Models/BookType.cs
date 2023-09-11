using LibraryManagement_CodeFirst.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_CodeFirst.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType : BaseEntity
    {
        public string Name { get; set; }

        //Relational Property

        public virtual List<Book> Books { get; set; }
    }
}
