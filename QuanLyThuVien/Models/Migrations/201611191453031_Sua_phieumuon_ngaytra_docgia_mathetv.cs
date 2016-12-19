namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sua_phieumuon_ngaytra_docgia_mathetv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.phieu_muon", "ngay_tra", c => c.DateTime(nullable: false));
            AlterColumn("dbo.doc_gia", "ma_the_thu_vien", c => c.String());
            DropColumn("dbo.phieu_muon_chi_tiet", "ngay_tra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.phieu_muon_chi_tiet", "ngay_tra", c => c.DateTime(nullable: false));
            AlterColumn("dbo.doc_gia", "ma_the_thu_vien", c => c.Int(nullable: false));
            DropColumn("dbo.phieu_muon", "ngay_tra");
        }
    }
}
