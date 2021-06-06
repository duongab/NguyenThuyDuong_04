using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThuyDuong_1721050422_LTQL.Models
{
    [Table("NhanViens ")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public int MaTinhThanh { get; set; }

        // public virtual ICollection<TinhThanh> TinhThanhs { get; set; }
        public virtual TinhThanh TinhThanh { get; set; }
    }
}