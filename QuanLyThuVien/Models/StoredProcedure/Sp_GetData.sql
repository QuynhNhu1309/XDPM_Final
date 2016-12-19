

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
	SELECT id FROM doc_gia WHERE ma_the_thu_vien = @ma_the_thu_vien;
 END

  EXEC Data_DG_ID_Dua_Vao_MaTV 'TV001'
