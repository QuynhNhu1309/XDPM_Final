namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cuon_sach",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_cuon_sach = c.String(),
                        id_dau_sach = c.Int(nullable: false),
                        id_tinh_trang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.dau_sach", t => t.id_dau_sach, cascadeDelete: true)
                .ForeignKey("dbo.trang_thai", t => t.id_tinh_trang, cascadeDelete: false)
                .Index(t => t.id_dau_sach)
                .Index(t => t.id_tinh_trang);
            
            CreateTable(
                "dbo.dau_sach",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_dau_sach = c.String(),
                        ten_dau_sach = c.String(nullable: false, maxLength: 255),
                        id_loai_sach = c.Int(nullable: false),
                        tom_tat = c.String(nullable: false),
                        id_nxb = c.Int(nullable: false),
                        so_luong_cuon_sach = c.Int(nullable: false),
                        nam_xuat_ban = c.Int(nullable: false),
                        id_tac_gia = c.Int(nullable: false),
                        id_tinh_trang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.loai_sach", t => t.id_loai_sach, cascadeDelete: true)
                .ForeignKey("dbo.nha_xuat_ban", t => t.id_nxb, cascadeDelete: true)
                .ForeignKey("dbo.tac_gia", t => t.id_tac_gia, cascadeDelete: true)
                .ForeignKey("dbo.trang_thai", t => t.id_tinh_trang, cascadeDelete: false)
                .Index(t => t.id_loai_sach)
                .Index(t => t.id_nxb)
                .Index(t => t.id_tac_gia)
                .Index(t => t.id_tinh_trang);
            
            CreateTable(
                "dbo.loai_sach",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_loai_sach = c.String(maxLength: 100),
                        ten_loai = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.nha_xuat_ban",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_nxb = c.String(maxLength: 100),
                        ten_nxb = c.String(nullable: false, maxLength: 200),
                        so_dien_thoai = c.String(maxLength: 50),
                        dia_chi = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tac_gia",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_tac_gia = c.String(maxLength: 100),
                        ho_ten = c.String(nullable: false, maxLength: 255),
                        noi_cong_tac = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.trang_thai",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ten_trang_thai = c.String(),
                        ten_bang = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.doc_gia",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_doc_gia = c.String(maxLength: 100),
                        ho_ten = c.String(nullable: false, maxLength: 250),
                        dia_chi = c.String(nullable: false, maxLength: 200),
                        dien_thoai = c.String(nullable: false, maxLength: 50),
                        ngay_cap_the = c.DateTime(nullable: false),
                        ngay_het_han = c.DateTime(nullable: false),
                        nam_tot_nghiep = c.DateTime(nullable: false),
                        so_sach_muon_toi_da = c.Int(nullable: false),
                        thoi_gian_muon_toi_da = c.Int(nullable: false),
                        cmnd = c.String(),
                        nghe_nghiep = c.String(),
                        id_tinh_trang = c.Int(nullable: false),
                        ma_the_thu_vien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.trang_thai", t => t.id_tinh_trang, cascadeDelete: true)
                .Index(t => t.id_tinh_trang);
            
            CreateTable(
                "dbo.phieu_muon",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_phieu_muon = c.Int(nullable: false),
                        id_doc_gia = c.Int(nullable: false),
                        ngay_muon = c.DateTime(nullable: false),
                        tong_so_luong_muon = c.Int(nullable: false),
                        id_nv = c.Int(nullable: false),
                        id_tinh_trang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.doc_gia", t => t.id_doc_gia, cascadeDelete: true)
                .ForeignKey("dbo.nhan_vien", t => t.id_nv, cascadeDelete: true)
                .ForeignKey("dbo.trang_thai", t => t.id_tinh_trang, cascadeDelete: false)
                .Index(t => t.id_doc_gia)
                .Index(t => t.id_nv)
                .Index(t => t.id_tinh_trang);
            
            CreateTable(
                "dbo.nhan_vien",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_nhan_vien = c.String(maxLength: 100),
                        ho_ten = c.String(nullable: false, maxLength: 250),
                        dia_chi = c.String(nullable: false, maxLength: 200),
                        dien_thoai = c.String(nullable: false, maxLength: 50),
                        cmnd = c.String(),
                        chuc_vu = c.String(),
                        id_tinh_trang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.trang_thai", t => t.id_tinh_trang, cascadeDelete: false)
                .Index(t => t.id_tinh_trang);
            
            CreateTable(
                "dbo.phieu_tra",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_phieu_tra = c.String(),
                        id_phieu_muon = c.Int(nullable: false),
                        id_nv = c.Int(nullable: false),
                        ngay_tra = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.nhan_vien", t => t.id_nv, cascadeDelete: true)
                .ForeignKey("dbo.phieu_muon", t => t.id_phieu_muon, cascadeDelete: false)
                .Index(t => t.id_phieu_muon)
                .Index(t => t.id_nv);
            
            CreateTable(
                "dbo.phieu_tra_chi_tiet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_phieu_tra_chi_tiet = c.String(),
                        id_phieu_tra = c.Int(nullable: false),
                        id_cuon_sach = c.Int(nullable: false),
                        so_luong = c.Int(nullable: false),
                        so_ngay_qua_han = c.Int(nullable: false),
                        id_tinh_trang = c.Int(nullable: false),
                        tien_phat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cuon_sach", t => t.id_cuon_sach, cascadeDelete: true)
                .ForeignKey("dbo.phieu_tra", t => t.id_phieu_tra, cascadeDelete: true)
                .ForeignKey("dbo.trang_thai", t => t.id_tinh_trang, cascadeDelete: false)
                .Index(t => t.id_phieu_tra)
                .Index(t => t.id_cuon_sach)
                .Index(t => t.id_tinh_trang);
            
            CreateTable(
                "dbo.phieu_muon_chi_tiet",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ma_phieu_muon_chi_tiet = c.String(),
                        id_phieu_muon = c.Int(nullable: false),
                        id_cuon_sach = c.Int(nullable: false),
                        ngay_tra = c.DateTime(nullable: false),
                        id_tinh_trang = c.Int(nullable: false),
                        so_luong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cuon_sach", t => t.id_cuon_sach, cascadeDelete: true)
                .ForeignKey("dbo.phieu_muon", t => t.id_phieu_muon, cascadeDelete: true)
                .ForeignKey("dbo.trang_thai", t => t.id_tinh_trang, cascadeDelete: false)
                .Index(t => t.id_phieu_muon)
                .Index(t => t.id_cuon_sach)
                .Index(t => t.id_tinh_trang);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.doc_gia", "id_tinh_trang", "dbo.trang_thai");
            DropForeignKey("dbo.phieu_muon", "id_tinh_trang", "dbo.trang_thai");
            DropForeignKey("dbo.phieu_muon_chi_tiet", "id_tinh_trang", "dbo.trang_thai");
            DropForeignKey("dbo.phieu_muon_chi_tiet", "id_phieu_muon", "dbo.phieu_muon");
            DropForeignKey("dbo.phieu_muon_chi_tiet", "id_cuon_sach", "dbo.cuon_sach");
            DropForeignKey("dbo.nhan_vien", "id_tinh_trang", "dbo.trang_thai");
            DropForeignKey("dbo.phieu_tra_chi_tiet", "id_tinh_trang", "dbo.trang_thai");
            DropForeignKey("dbo.phieu_tra_chi_tiet", "id_phieu_tra", "dbo.phieu_tra");
            DropForeignKey("dbo.phieu_tra_chi_tiet", "id_cuon_sach", "dbo.cuon_sach");
            DropForeignKey("dbo.phieu_tra", "id_phieu_muon", "dbo.phieu_muon");
            DropForeignKey("dbo.phieu_tra", "id_nv", "dbo.nhan_vien");
            DropForeignKey("dbo.phieu_muon", "id_nv", "dbo.nhan_vien");
            DropForeignKey("dbo.phieu_muon", "id_doc_gia", "dbo.doc_gia");
            DropForeignKey("dbo.dau_sach", "id_tinh_trang", "dbo.trang_thai");
            DropForeignKey("dbo.cuon_sach", "id_tinh_trang", "dbo.trang_thai");
            DropForeignKey("dbo.dau_sach", "id_tac_gia", "dbo.tac_gia");
            DropForeignKey("dbo.dau_sach", "id_nxb", "dbo.nha_xuat_ban");
            DropForeignKey("dbo.dau_sach", "id_loai_sach", "dbo.loai_sach");
            DropForeignKey("dbo.cuon_sach", "id_dau_sach", "dbo.dau_sach");
            DropIndex("dbo.phieu_muon_chi_tiet", new[] { "id_tinh_trang" });
            DropIndex("dbo.phieu_muon_chi_tiet", new[] { "id_cuon_sach" });
            DropIndex("dbo.phieu_muon_chi_tiet", new[] { "id_phieu_muon" });
            DropIndex("dbo.phieu_tra_chi_tiet", new[] { "id_tinh_trang" });
            DropIndex("dbo.phieu_tra_chi_tiet", new[] { "id_cuon_sach" });
            DropIndex("dbo.phieu_tra_chi_tiet", new[] { "id_phieu_tra" });
            DropIndex("dbo.phieu_tra", new[] { "id_nv" });
            DropIndex("dbo.phieu_tra", new[] { "id_phieu_muon" });
            DropIndex("dbo.nhan_vien", new[] { "id_tinh_trang" });
            DropIndex("dbo.phieu_muon", new[] { "id_tinh_trang" });
            DropIndex("dbo.phieu_muon", new[] { "id_nv" });
            DropIndex("dbo.phieu_muon", new[] { "id_doc_gia" });
            DropIndex("dbo.doc_gia", new[] { "id_tinh_trang" });
            DropIndex("dbo.dau_sach", new[] { "id_tinh_trang" });
            DropIndex("dbo.dau_sach", new[] { "id_tac_gia" });
            DropIndex("dbo.dau_sach", new[] { "id_nxb" });
            DropIndex("dbo.dau_sach", new[] { "id_loai_sach" });
            DropIndex("dbo.cuon_sach", new[] { "id_tinh_trang" });
            DropIndex("dbo.cuon_sach", new[] { "id_dau_sach" });
            DropTable("dbo.phieu_muon_chi_tiet");
            DropTable("dbo.phieu_tra_chi_tiet");
            DropTable("dbo.phieu_tra");
            DropTable("dbo.nhan_vien");
            DropTable("dbo.phieu_muon");
            DropTable("dbo.doc_gia");
            DropTable("dbo.trang_thai");
            DropTable("dbo.tac_gia");
            DropTable("dbo.nha_xuat_ban");
            DropTable("dbo.loai_sach");
            DropTable("dbo.dau_sach");
            DropTable("dbo.cuon_sach");
        }
    }
}
