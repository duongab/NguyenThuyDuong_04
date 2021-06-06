namespace NguyenThuyDuong_1721050422_LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_NhanVien : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TinhThanhs", "NhanVien_MaNhanVien", "dbo.NhanViens");
            DropIndex("dbo.TinhThanhs", new[] { "NhanVien_MaNhanVien" });
            CreateIndex("dbo.NhanViens", "MaTinhThanh");
            AddForeignKey("dbo.NhanViens", "MaTinhThanh", "dbo.TinhThanhs", "MaTinhThanh", cascadeDelete: true);
            DropColumn("dbo.TinhThanhs", "NhanVien_MaNhanVien");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TinhThanhs", "NhanVien_MaNhanVien", c => c.String(maxLength: 128));
            DropForeignKey("dbo.NhanViens", "MaTinhThanh", "dbo.TinhThanhs");
            DropIndex("dbo.NhanViens", new[] { "MaTinhThanh" });
            CreateIndex("dbo.TinhThanhs", "NhanVien_MaNhanVien");
            AddForeignKey("dbo.TinhThanhs", "NhanVien_MaNhanVien", "dbo.NhanViens", "MaNhanVien");
        }
    }
}
