using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_CodeFirst.Models.MetaDataTypes
{
    public class BookTypeMetaData
    {
        [Required(ErrorMessage = "Required Field")]
        public string Name { get; set; }
    }
}
