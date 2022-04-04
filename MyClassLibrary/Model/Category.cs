using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Model
{
    [Table("Categorys")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ten loai san pham khong de trong")]
        //bắt buộc nhập
        [StringLength(200)]
        public string Name { get; set; }
        public string Slug { get; set; }
        //cho phép null
        public int? ParentId { get; set; }
        //ko ?( bắt buộc null)
        public int? Orders { get; set; }

        [Required]
        public string MetaDesc { get; set; }

        [Required]
        public string MetaKey { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateAt { get; set; }
        public int? UpdatedBy { get; set; }
        // cho phep null
        public DateTime? UpdateAt { get; set; }
        public int? Startus { get; set; }








    }
}
