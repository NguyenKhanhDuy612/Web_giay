using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyClassLibrary.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]

        public int Id { get; set; }
        public int CatId { get; set; }

        //public int SupplierId { get; set; }
        //[Required(ErrorMessage ="Ten san pham khong duoc de trong!")]
        //public int SanPham { get; set; }

    }
}
