namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sua_maphieumuon : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.phieu_muon", "ma_phieu_muon", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.phieu_muon", "ma_phieu_muon", c => c.Int(nullable: false));
        }
    }
}
