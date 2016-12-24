

---- LẤY MÃ PHIẾU MƯỢN VỪA TẠO -----


IF OBJECT_ID('Data_PM_ID_Latest') IS NOT NULL
DROP PROCEDURE Data_PM_ID_Latest;
GO
 CREATE PROCEDURE Data_PM_ID_Latest
	@id_doc_gia int
 AS
 BEGIN
	--SELECT pmct.id FROM phieu_muon_chi_tiet pmct, phieu_muon pm WHERE pmct.id_tinh_trang = 12 and pm.id_tinh_trang = 10
	--and id_doc_gia = @id_doc_gia ORDER BY pmct.id ASC;

	SELECT TOP 1 id FROM phieu_muon pm WHERE pm.id_tinh_trang = 10
	and id_doc_gia = @id_doc_gia ORDER BY pm.id DESC;
 END

 EXEC Data_PM_ID_Latest 1



 --- LẤY ID ĐỘC GIẢ DỰA VÀO MÃ ĐỘC GIẢ--- 

IF OBJECT_ID('Data_DG_ID_Dua_Vao_MaTV') IS NOT NULL
DROP PROCEDURE Data_DG_ID_Dua_Vao_MaTV;
GO
 CREATE PROCEDURE Data_DG_ID_Dua_Vao_MaTV
	@ma_the_thu_vien varchar(100)
 AS
 BEGIN
	SELECT * FROM doc_gia WHERE ma_the_thu_vien = @ma_the_thu_vien;
 END

  EXEC Data_DG_ID_Dua_Vao_MaTV 'TV001'


  ------ LẤY VÀ TẠO RA MÃ ĐỘC GIẢ VÀ MÃ THẺ THƯ VIỆN VỪA TẠO  ----


  IF OBJECT_ID('Get_ID_Ma_DocGia') IS NOT NULL
DROP PROCEDURE Get_ID_Ma_DocGia;
GO
 CREATE PROCEDURE Get_ID_Ma_DocGia
 AS
 BEGIN
 DECLARE @id_dg int;
 DECLARE @ma_doc_gia varchar(100);
	if(not exists(select * from doc_gia))
		begin
		set @id_dg = 1;
		set @ma_doc_gia = 'DG00' + CAST(@id_dg as varchar(100));
		select @ma_doc_gia as ma_doc_gia;
		end
	else
		begin
		set @ma_doc_gia = (select MAX(ma_doc_gia) from doc_gia)
		set @id_dg = cast(SUBSTRING(@ma_doc_gia, 3 ,4) as int)
		set @id_dg = @id_dg + 1;
		
			if(@id_dg < 10)
				begin 
				set @ma_doc_gia = 'DG00' + CAST(@id_dg as varchar(100))
				select @ma_doc_gia as ma_doc_gia;
				end
			else if(@id_dg < 100 and @id_dg >=  10)
				begin 
				set @ma_doc_gia = 'DG0' + CAST(@id_dg as varchar(100));
				select @ma_doc_gia as ma_doc_gia;
				end

			else if(@id_dg < 1000 and @id_dg >=  100)
				begin 
				set @ma_doc_gia = 'DG' + CAST(@id_dg as varchar(100));
				select @ma_doc_gia as ma_doc_gia;
				end
	end


 END

  EXEC Get_ID_Ma_DocGia




  IF OBJECT_ID('Get_MaTheThuVien') IS NOT NULL
DROP PROCEDURE Get_MaTheThuVien;
GO
 CREATE PROCEDURE Get_MaTheThuVien
 AS
 BEGIN
 DECLARE @id_dg int;
 DECLARE @ma_doc_gia varchar(100);
	if(not exists(select * from doc_gia))
		begin
		set @id_dg = 1;
		set @ma_doc_gia = 'TV00' + CAST(@id_dg as varchar(100));
		select @ma_doc_gia as ma_doc_gia;
		end
	else
		begin
		set @ma_doc_gia = (select MAX(ma_the_thu_vien) from doc_gia)
		set @id_dg = cast(SUBSTRING(@ma_doc_gia, 3 ,4) as int)
		set @id_dg = @id_dg + 1;
		
			if(@id_dg < 10)
				begin 
				set @ma_doc_gia = 'TV00' + CAST(@id_dg as varchar(100))
				select @ma_doc_gia as ma_doc_gia;
				end
			else if(@id_dg < 100 and @id_dg >=  10)
				begin 
				set @ma_doc_gia = 'TV0' + CAST(@id_dg as varchar(100));
				select @ma_doc_gia as ma_doc_gia;
				end

			else if(@id_dg < 1000 and @id_dg >=  100)
				begin 
				set @ma_doc_gia = 'TV' + CAST(@id_dg as varchar(100));
				select @ma_doc_gia as ma_doc_gia;
				end
	end


 END

  EXEC Get_MaTheThuVien




   ----- TẠO MÃ ĐẦU SÁCH -----
    IF OBJECT_ID('Get_MaDauSach') IS NOT NULL
DROP PROCEDURE Get_MaDauSach;
GO
 CREATE PROCEDURE Get_MaDauSach
 AS
 BEGIN
 DECLARE @id_dg int;
 DECLARE @ma_doc_gia varchar(100);
	if(not exists(select * from dau_sach))
		begin
		set @id_dg = 1;
		set @ma_doc_gia = 'DS00' + CAST(@id_dg as varchar(100));
		select @ma_doc_gia as ma_doc_gia;
		end
	else
		begin
		set @ma_doc_gia = (select MAX(ma_dau_sach) from dau_sach)
		set @id_dg = cast(SUBSTRING(@ma_doc_gia, 3 ,4) as int)
		set @id_dg = @id_dg + 1;
		
			if(@id_dg < 10)
				begin 
				set @ma_doc_gia = 'DS00' + CAST(@id_dg as varchar(100))
				select @ma_doc_gia as ma_doc_gia;
				end
			else if(@id_dg < 100 and @id_dg >=  10)
				begin 
				set @ma_doc_gia = 'DS0' + CAST(@id_dg as varchar(100));
				select @ma_doc_gia as ma_doc_gia;
				end

			else if(@id_dg < 1000 and @id_dg >=  100)
				begin 
				set @ma_doc_gia = 'DS' + CAST(@id_dg as varchar(100));
				select @ma_doc_gia as ma_doc_gia;
				end
	end


 END

  EXEC Get_MaDauSach



  ---- THỐNG KÊ ----

   --- LẤY ID ĐỘC GIẢ DỰA VÀO MÃ ĐỘC GIẢ--- 

IF OBJECT_ID('Data_DG_ID_Dua_Vao_MaTV') IS NOT NULL
DROP PROCEDURE Data_DG_ID_Dua_Vao_MaTV;
GO
 CREATE PROCEDURE Data_DG_ID_Dua_Vao_MaTV
	@ma_the_thu_vien varchar(100)
 AS
 BEGIN
	SELECT * FROM doc_gia dg, phieu_muon pm, phieu_muon_chi_tiet pmct
	 WHERE ma_the_thu_vien = @ma_the_thu_vien and dg.id = pm.id_doc_gia and pmct.id_phieu_muon = pm.id;
 END

 EXEC Data_DG_ID_Dua_Vao_MaTV 'TV004'



