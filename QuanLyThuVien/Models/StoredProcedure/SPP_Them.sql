
DROP PROC Them_PM_PMCT

CREATE PROC Them_PM_PMCT
	@ngay_muon datetime,
	@id_doc_gia int,
	@so_luong_muon int,
	@id_nv int,
	@id_tinh_trang int,
	@ngay_tra datetime,
	@id_dau_sach int
AS
SET NOCOUNT ON;
SET NOCOUNT ON;

	declare @id_PM int;
	declare @ma_phieu_muon varchar(100);
	declare @id_PMCT int;
	declare @ma_phieu_muon_chi_tiet varchar(100);
	declare @id_phieu_muon_latest int;
	declare @so_luong_cuon_sach int;
	declare @id_cuon_sach int;
	if(not exists(select * from phieu_muon))
		begin
		set @id_PM = 1;
		set @ma_phieu_muon = 'PM00' + CAST(@id_PM as varchar(100));
		select @ma_phieu_muon as ma_pm;
		end
	else
		begin
		set @ma_phieu_muon = (select MAX(ma_phieu_muon) from phieu_muon)
		set @id_PM = cast(SUBSTRING(@ma_phieu_muon, 3 ,4) as int)
		set @id_PM = @id_PM + 1;
		
			if(@id_PM < 10)
				begin 
				set @ma_phieu_muon = 'PM00' + CAST(@id_PM as varchar(100))
				select @ma_phieu_muon as ma_pm;
				end
			else if(@id_PM < 100 and @id_PM >=  10)
				begin 
				set @ma_phieu_muon = 'PM0' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end

			else if(@id_PM < 1000 and @id_PM >=  100)
				begin 
				set @ma_phieu_muon = 'PM' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end
	end

INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon, tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra)
 VALUES(@ma_phieu_muon, @id_doc_gia, @ngay_muon, 0, @id_nv, @id_tinh_trang, @ngay_tra)

		SET @id_phieu_muon_latest = (select MAX(id) from phieu_muon)
		SET @so_luong_cuon_sach = @so_luong_muon;
		While(@so_luong_cuon_sach > 0)
		BEGIN

				if(not exists(select * from phieu_muon_chi_tiet))
				begin
				set @id_PMCT = 1;
				set @ma_phieu_muon_chi_tiet = 'PMCT00' + CAST(@id_PMCT as varchar(100));
				select @ma_phieu_muon_chi_tiet as ma_pmct;
				end
			else
				begin
				set @ma_phieu_muon_chi_tiet = (select MAX(ma_phieu_muon_chi_tiet) from phieu_muon_chi_tiet)
				set @id_PMCT = cast(SUBSTRING(@ma_phieu_muon_chi_tiet, 5 ,4) as int)
				set @id_PMCT = @id_PMCT + 1;
		
					if(@id_PMCT < 10)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT00' + CAST(@id_PMCT as varchar(100))
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end
					else if(@id_PMCT < 100 and @id_PMCT >=  10)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT0' + CAST(@id_PMCT as varchar(100));
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end

					else if(@id_PMCT < 1000 and @id_PMCT >=  100)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT' + CAST(@id_PMCT as varchar(100));
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end
			end
		
		SET @id_cuon_sach = (SELECT TOP(1) id from cuon_sach WHERE id_dau_sach = @id_dau_sach AND id_tinh_trang = 6 )
		INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_cuon_sach, so_luong, id_tinh_trang)
		VALUES(@ma_phieu_muon_chi_tiet, @id_phieu_muon_latest, @id_cuon_sach, 1, 12)
		UPDATE cuon_sach SET id_tinh_trang = 7 WHERE id = @id_cuon_sach
		SET @so_luong_cuon_sach = @so_luong_cuon_sach - 1;

		END


UPDATE phieu_muon SET tong_so_luong_muon = tong_so_luong_muon + @so_luong_muon


EXEC Them_PM_PMCT @ngay_muon = '2016-11-09', @id_doc_gia = 1,  @so_luong_muon = 2, @id_nv = 1,
 @id_tinh_trang = 10, @ngay_tra = '2016-11-29', @id_dau_sach = 1


 @ngay_muon datetime,
	@id_doc_gia int,
	@so_luong_muon int,
	@id_nv int,
	@id_tinh_trang int,
	@ngay_tra datetime,
	@id_dau_sach int



DROP PROC Them_PM
CREATE PROC Them_PM	
	@ma_phieu_muon varchar(100),
	@ngay_muon datetime,
	@id_doc_gia int,
	@tong_so_luong_muon int,
	@id_nv int,
	@id_tinh_trang int,
	@ngay_tra datetime	
AS
SET NOCOUNT ON;


INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon, tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra)
 VALUES(@ma_phieu_muon, @id_doc_gia, @ngay_muon, @tong_so_luong_muon, @id_nv, @id_tinh_trang, @ngay_tra)



	EXEC Them_PM_PMCT



	
DROP PROC Them_PM_PMCT_ver1

CREATE PROC Them_PM_PMCT_ver1
	@ngay_muon datetime,
	@id_doc_gia int,
	@so_luong_muon int,
	@id_nv int,
	@id_tinh_trang int,
	@ngay_tra datetime,
	@id_dau_sach int
AS
SET NOCOUNT ON;
SET NOCOUNT ON;

	declare @id_PM int;
	declare @ma_phieu_muon varchar(100);
	declare @id_PMCT int;
	declare @ma_phieu_muon_chi_tiet varchar(100);
	declare @id_phieu_muon_latest int;
	declare @so_luong_cuon_sach int;
	declare @id_cuon_sach int;
	if(not exists(select * from phieu_muon))
		begin
		set @id_PM = 1;
		set @ma_phieu_muon = 'PM00' + CAST(@id_PM as varchar(100));
		select @ma_phieu_muon as ma_pm;
		end
	else
		begin
		set @ma_phieu_muon = (select MAX(ma_phieu_muon) from phieu_muon)
		set @id_PM = cast(SUBSTRING(@ma_phieu_muon, 3 ,4) as int)
		set @id_PM = @id_PM + 1;
		
			if(@id_PM < 10)
				begin 
				set @ma_phieu_muon = 'PM00' + CAST(@id_PM as varchar(100))
				select @ma_phieu_muon as ma_pm;
				end
			else if(@id_PM < 100 and @id_PM >=  10)
				begin 
				set @ma_phieu_muon = 'PM0' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end

			else if(@id_PM < 1000 and @id_PM >=  100)
				begin 
				set @ma_phieu_muon = 'PM' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end
	end

INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon, tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra)
 VALUES(@ma_phieu_muon, @id_doc_gia, @ngay_muon, 0, @id_nv, @id_tinh_trang, @ngay_tra)

		SET @id_phieu_muon_latest = (select MAX(id) from phieu_muon)
		SET @so_luong_cuon_sach = @so_luong_muon;
		While(@so_luong_cuon_sach > 0)
		BEGIN

				if(not exists(select * from phieu_muon_chi_tiet))
				begin
				set @id_PMCT = 1;
				set @ma_phieu_muon_chi_tiet = 'PMCT00' + CAST(@id_PMCT as varchar(100));
				select @ma_phieu_muon_chi_tiet as ma_pmct;
				end
			else
				begin
				set @ma_phieu_muon_chi_tiet = (select MAX(ma_phieu_muon_chi_tiet) from phieu_muon_chi_tiet)
				set @id_PMCT = cast(SUBSTRING(@ma_phieu_muon_chi_tiet, 5 ,4) as int)
				set @id_PMCT = @id_PMCT + 1;
		
					if(@id_PMCT < 10)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT00' + CAST(@id_PMCT as varchar(100))
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end
					else if(@id_PMCT < 100 and @id_PMCT >=  10)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT0' + CAST(@id_PMCT as varchar(100));
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end

					else if(@id_PMCT < 1000 and @id_PMCT >=  100)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT' + CAST(@id_PMCT as varchar(100));
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end
			end
		
		SET @id_cuon_sach = (SELECT TOP(1) id from cuon_sach WHERE id_dau_sach = @id_dau_sach AND id_tinh_trang = 6 )
		INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_cuon_sach, so_luong, id_tinh_trang)
		VALUES(@ma_phieu_muon_chi_tiet, @id_phieu_muon_latest, @id_cuon_sach, 1, 12)
		UPDATE cuon_sach SET id_tinh_trang = 7 WHERE id = @id_cuon_sach
		SET @so_luong_cuon_sach = @so_luong_cuon_sach - 1;

		END


UPDATE phieu_muon SET tong_so_luong_muon = tong_so_luong_muon + @so_luong_muon




DROP PROC Them_PhieuMuon
CREATE PROC Them_PhieuMuon
	@ma_doc_gia varchar(100),
	@so_luong_muon int,
	@ngay_muon datetime,
	@ngay_tra datetime,
	@id_nv int,
	@id_tinh_trang int
AS
SET NOCOUNT ON;
SET NOCOUNT ON;

	declare @id_PM int;
	declare @id_doc_gia int;
	declare @ma_phieu_muon varchar(100);
	declare @so_luong_cuon_sach int;
	SET @id_doc_gia = (SELECT id FROM doc_gia WHERE ma_the_thu_vien = @ma_doc_gia)
	if(not exists(select * from phieu_muon))
		begin
		set @id_PM = 1;
		set @ma_phieu_muon = 'PM00' + CAST(@id_PM as varchar(100));
		select @ma_phieu_muon as ma_pm;
		end
	else
		begin
		set @ma_phieu_muon = (select MAX(ma_phieu_muon) from phieu_muon)
		set @id_PM = cast(SUBSTRING(@ma_phieu_muon, 3 ,4) as int)
		set @id_PM = @id_PM + 1;
		
			if(@id_PM < 10)
				begin 
				set @ma_phieu_muon = 'PM00' + CAST(@id_PM as varchar(100))
				select @ma_phieu_muon as ma_pm;
				end
			else if(@id_PM < 100 and @id_PM >=  10)
				begin 
				set @ma_phieu_muon = 'PM0' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end

			else if(@id_PM < 1000 and @id_PM >=  100)
				begin 
				set @ma_phieu_muon = 'PM' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end
	end

INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon, tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra)
 VALUES(@ma_phieu_muon, @id_doc_gia, @ngay_muon, @so_luong_muon, @id_nv, @id_tinh_trang, @ngay_tra)

 EXEC Them_PhieuMuon 'TV001',5, '2016-11-08 00:00:00.000', '2016-11-08 00:00:00.000', 1, 11



 DROP PROC Them_PhieuMuonChiTiet

CREATE PROC Them_PhieuMuonChiTiet
	@so_luong_muon int,
	@id_tinh_trang int,
	@id_dau_sach int
AS
SET NOCOUNT ON;
SET NOCOUNT ON;

	declare @id_PM int;
	declare @ma_phieu_muon varchar(100);
	declare @id_PMCT int;
	declare @ma_phieu_muon_chi_tiet varchar(100);
	declare @id_phieu_muon_latest int;
	declare @so_luong_cuon_sach int;
	declare @id_cuon_sach int;
	declare @soluong_dausach int;

		SET @id_phieu_muon_latest = (select MAX(id) from phieu_muon)
		SET @so_luong_cuon_sach = @so_luong_muon;
		
	

				if(not exists(select * from phieu_muon_chi_tiet))
				begin
				set @id_PMCT = 1;
				set @ma_phieu_muon_chi_tiet = 'PMCT00' + CAST(@id_PMCT as varchar(100));
				select @ma_phieu_muon_chi_tiet as ma_pmct;
				end
			else
				begin
				set @ma_phieu_muon_chi_tiet = (select MAX(ma_phieu_muon_chi_tiet) from phieu_muon_chi_tiet)
				set @id_PMCT = cast(SUBSTRING(@ma_phieu_muon_chi_tiet, 5 ,4) as int)
				set @id_PMCT = @id_PMCT + 1;
		
					if(@id_PMCT < 10)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT00' + CAST(@id_PMCT as varchar(100))
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end
					else if(@id_PMCT < 100 and @id_PMCT >=  10)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT0' + CAST(@id_PMCT as varchar(100));
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end

					else if(@id_PMCT < 1000 and @id_PMCT >=  100)
						begin 
						set @ma_phieu_muon_chi_tiet = 'PMCT' + CAST(@id_PMCT as varchar(100));
						select @ma_phieu_muon_chi_tiet as ma_pmct;
						end
			end
		
		
		INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon,id_dau_sach, so_luong, id_tinh_trang)
		VALUES(@ma_phieu_muon_chi_tiet, @id_phieu_muon_latest, @id_dau_sach, @so_luong_muon, @id_tinh_trang)


		--Trừ số lượng cuốn sách sẵn sàng phục vụ trong bảng đầu sách
		SET @soluong_dausach = (SELECT so_luong_cuon_sach FROM dau_sach WHERE id = @id_dau_sach)
		UPDATE dau_sach SET so_luong_cuon_sach = @soluong_dausach - @so_luong_cuon_sach WHERE id = @id_dau_sach;

		-- Update lại tình trạng cuốn sách
		While(@so_luong_cuon_sach > 0)
		BEGIN
		SET @id_cuon_sach = (SELECT TOP(1) id from cuon_sach WHERE id_dau_sach = @id_dau_sach AND id_tinh_trang = 9 )
		UPDATE cuon_sach SET id_tinh_trang = 10 WHERE id = @id_cuon_sach
		SET @so_luong_cuon_sach = @so_luong_cuon_sach - 1;
		END


		
		
EXEC Them_PhieuMuonChiTiet 2, 15, 4



------ THÊM PHIẾU NHẬP VÀ PHIẾU NHẬP CHI TIẾT KHI THÊM ĐẦU SÁCH ----
  IF OBJECT_ID('Them_PhieuNhap') IS NOT NULL
DROP PROCEDURE Them_PhieuNhap;
GO
CREATE PROC Them_PhieuNhap
	@thanhtien float,
	@id_nha_xuat_ban int,
	@gia_nhap float,
	@so_luong_nhap int

AS
SET NOCOUNT ON;
SET NOCOUNT ON;
	declare @id_PM int;
	declare @ma_phieu_muon varchar(100);
	declare @id_phieu_nhap int;
	declare @idpnct int;
	declare @ma_pnct varchar(100);
	declare @id_dau_sach int;
	declare @id_cs int;
	declare @ma_cuon_sach varchar(100);
	
	if(not exists(select * from phieu_nhap))
		begin
		set @id_PM = 1;
		set @ma_phieu_muon = 'PN00' + CAST(@id_PM as varchar(100));
		select @ma_phieu_muon as ma_pm;
		end
	else
		begin
		set @ma_phieu_muon = (select MAX(ma_phieu_nhap) from phieu_nhap)
		set @id_PM = cast(SUBSTRING(@ma_phieu_muon, 3 ,4) as int)
		set @id_PM = @id_PM + 1;
		
			if(@id_PM < 10)
				begin 
				set @ma_phieu_muon = 'PN00' + CAST(@id_PM as varchar(100))
				select @ma_phieu_muon as ma_pm;
				end
			else if(@id_PM < 100 and @id_PM >=  10)
				begin 
				set @ma_phieu_muon = 'PN0' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end

			else if(@id_PM < 1000 and @id_PM >=  100)
				begin 
				set @ma_phieu_muon = 'PN' + CAST(@id_PM as varchar(100));
				select @ma_phieu_muon as ma_pm;
				end
	end

INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien)
 VALUES(@ma_phieu_muon, getdate(), @thanhtien, 1, 1)


--- Tạo mã mới cho phiếu nhập chi tiết
 if(not exists(select * from phieu_nhap_chi_tiet))
		begin
		set @idpnct = 1;
		set @ma_pnct = 'PNCT00' + CAST(@idpnct as varchar(100));
		select @ma_pnct as ma_pm1;
		end
	else
		begin
		set @ma_pnct = (select MAX(ma_phieu_nhap_chi_tiet) from phieu_nhap_chi_tiet)
		set @idpnct = cast(SUBSTRING(@ma_pnct, 5 ,4) as int)
		set @idpnct = @idpnct + 1;
		
			if(@idpnct < 10)
				begin 
				set @ma_pnct = 'PNCT00' + CAST(@idpnct as varchar(100))
				select @ma_pnct as ma_pm2;
				end
			else if(@idpnct < 100 and @idpnct >=  10)
				begin 
				set @ma_pnct = 'PNCT0' + CAST(@idpnct as varchar(100));
				select @ma_pnct as ma_pm3;
				end

			else if(@idpnct < 1000 and @idpnct >=  100)
				begin 
				set @ma_pnct = 'PNCT' + CAST(@idpnct as varchar(100));
				select @ma_pnct as ma_pm4;
				end
	end

 SET @id_phieu_nhap = (SELECT TOP(1) id FROM phieu_nhap ORDER BY id DESC)

 -- Lấy id đầu sách mới được thêm
  SET @id_dau_sach = (SELECT TOP(1) id FROM dau_sach ORDER BY id DESC)

 INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, 
 so_luong_nhap, thanh_tien, id_phieu_nhap)
 VALUES(@ma_pnct, @id_nha_xuat_ban, @id_dau_sach, @gia_nhap, @so_luong_nhap, @thanhtien, @id_phieu_nhap)
 
 WHILE(@so_luong_nhap > 0)
 BEGIN

	if(not exists(select * from cuon_sach))
		begin
		set @id_cs = 1;
		set @ma_cuon_sach = 'CS00' + CAST(@id_cs as varchar(100));
		select @ma_cuon_sach as ma_pm1;
		end
	else
		begin
		set @ma_cuon_sach = (select MAX(ma_cuon_sach) from cuon_sach)
		set @id_cs = cast(SUBSTRING(@ma_cuon_sach, 3 ,4) as int)
		set @id_cs = @id_cs + 1;
		
			if(@id_cs < 10)
				begin 
				set @ma_cuon_sach = 'CS00' + CAST(@id_cs as varchar(100))
				select @ma_cuon_sach as ma_pm2;
				end
			else if(@id_cs < 100 and @id_cs >=  10)
				begin 
				set @ma_cuon_sach = 'CS0' + CAST(@id_cs as varchar(100));
				select @ma_cuon_sach as ma_pm3;
				end

			else if(@id_cs < 1000 and @id_cs >=  100)
				begin 
				set @ma_cuon_sach = 'CS' + CAST(@id_cs as varchar(100));
				select @ma_cuon_sach as ma_pm4;
				end
	end

	INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach,id_tinh_trang) VALUES(@ma_cuon_sach, @id_dau_sach, 9)
	SET @so_luong_nhap = @so_luong_nhap - 1;

 END


EXEC Them_PhieuNhap 20000, 1, 10000, 2



------ THÊM PHIẾU NHẬP CHI TIẾT KHI ĐÃ CÓ TỒN TẠI PHIẾU NHẬP TRƯỚC ĐÓ, KHI THÊM ĐẦU SÁCH ----
  IF OBJECT_ID('Them_PhieuNhap_Exist') IS NOT NULL
DROP PROCEDURE Them_PhieuNhap_Exist;
GO
CREATE PROC Them_PhieuNhap_Exist
	@thanhtien float,
	@id_nha_xuat_ban int,
	@gia_nhap float,
	@so_luong_nhap int

AS
SET NOCOUNT ON;
SET NOCOUNT ON;
	declare @tong_tien float;
	declare @id_phieu_nhap int;
	declare @idpnct int;
	declare @ma_pnct varchar(100);
	declare @id_dau_sach int;
	declare @id_cs int;
	declare @ma_cuon_sach varchar(100);
	

--- Tạo mã mới cho phiếu nhập chi tiết
 if(not exists(select * from phieu_nhap_chi_tiet))
		begin
		set @idpnct = 1;
		set @ma_pnct = 'PNCT00' + CAST(@idpnct as varchar(100));
		select @ma_pnct as ma_pm1;
		end
	else
		begin
		set @ma_pnct = (select MAX(ma_phieu_nhap_chi_tiet) from phieu_nhap_chi_tiet)
		set @idpnct = cast(SUBSTRING(@ma_pnct, 5 ,4) as int)
		set @idpnct = @idpnct + 1;
		
			if(@idpnct < 10)
				begin 
				set @ma_pnct = 'PNCT00' + CAST(@idpnct as varchar(100))
				select @ma_pnct as ma_pm2;
				end
			else if(@idpnct < 100 and @idpnct >=  10)
				begin 
				set @ma_pnct = 'PNCT0' + CAST(@idpnct as varchar(100));
				select @ma_pnct as ma_pm3;
				end

			else if(@idpnct < 1000 and @idpnct >=  100)
				begin 
				set @ma_pnct = 'PNCT' + CAST(@idpnct as varchar(100));
				select @ma_pnct as ma_pm4;
				end
	end

 SET @id_phieu_nhap = (SELECT TOP(1) id FROM phieu_nhap ORDER BY id DESC)
 SET @tong_tien = (SELECT tongtien FROM phieu_nhap WHERE id = @id_phieu_nhap);
 UPDATE phieu_nhap SET tongtien = @tong_tien + @thanhtien WHERE id = @id_phieu_nhap;
 -- Lấy id đầu sách mới được thêm
  SET @id_dau_sach = (SELECT TOP(1) id FROM dau_sach ORDER BY id DESC)

 INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, 
 so_luong_nhap, thanh_tien, id_phieu_nhap)
 VALUES(@ma_pnct, @id_nha_xuat_ban, @id_dau_sach, @gia_nhap, @so_luong_nhap, @thanhtien, @id_phieu_nhap)

 WHILE(@so_luong_nhap > 0)
 BEGIN

	if(not exists(select * from cuon_sach))
		begin
		set @id_cs = 1;
		set @ma_cuon_sach = 'CS00' + CAST(@id_cs as varchar(100));
		select @ma_cuon_sach as ma_pm1;
		end
	else
		begin
		set @ma_cuon_sach = (select MAX(ma_cuon_sach) from cuon_sach)
		set @id_cs = cast(SUBSTRING(@ma_cuon_sach, 3 ,4) as int)
		set @id_cs = @id_cs + 1;
		
			if(@id_cs < 10)
				begin 
				set @ma_cuon_sach = 'CS00' + CAST(@id_cs as varchar(100))
				select @ma_cuon_sach as ma_pm2;
				end
			else if(@id_cs < 100 and @id_cs >=  10)
				begin 
				set @ma_cuon_sach = 'CS0' + CAST(@id_cs as varchar(100));
				select @ma_cuon_sach as ma_pm3;
				end

			else if(@id_cs < 1000 and @id_cs >=  100)
				begin 
				set @ma_cuon_sach = 'CS' + CAST(@id_cs as varchar(100));
				select @ma_cuon_sach as ma_pm4;
				end
	end

	INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach,id_tinh_trang) VALUES(@ma_cuon_sach, @id_dau_sach, 9)
	SET @so_luong_nhap = @so_luong_nhap - 1;

 END


EXEC Them_PhieuNhap_Exist 100000, 1, 10000, 10


---- THÊM PHIẾU TRẢ MỚI,

---UPDATE TÌNH TRẠNG PHIẾU MƯỢN VÀ PHIẾU MƯỢN CHI TIẾT, SỐ LƯỢNG CUỐN SÁCH CỦA DẦU SÁCH --

IF OBJECT_ID('Tra_Sach') IS NOT NULL
DROP PROCEDURE Tra_Sach;
GO
CREATE PROC Tra_Sach
	@id_pmct int
AS
SET NOCOUNT ON;
SET NOCOUNT ON;
	declare @idpt int;
	declare @ma_phieu_tra varchar(100);
	declare @id_phieu_muon int;
	declare @id_dau_sach int;
	declare @so_luong int;
	declare @idpt_ct int;
	declare @ma_phieu_tra_ct varchar(100);
	declare @idpm_trong_phieu_tra int;
	declare @so_luong_cuon_sach int;
	DECLARE @count_cuon_sach int;
	declare @dem_pmct_da_tra int;
	declare @dem_pmct_chua_tra int;
	
	
SET @id_phieu_muon = (SELECT id_phieu_muon FROM phieu_muon_chi_tiet WHERE id = @id_pmct)
SET @idpm_trong_phieu_tra = (SELECT TOP(1)id_phieu_muon FROM phieu_tra ORDER BY id DESC)
SET @id_dau_sach =(SELECT id_dau_sach FROM phieu_muon_chi_tiet WHERE id = @id_pmct);
SET @so_luong =(SELECT so_luong FROM phieu_muon_chi_tiet WHERE id = @id_pmct);
SET @so_luong_cuon_sach = (SELECT so_luong_cuon_sach FROM dau_sach WHERE id = @id_dau_sach);
--SELECT @id_phieu_muon AS id_phieu_muon;
--SELECT @idpm_trong_phieu_tra AS idpm_trong_phieu_tra;

-- Tạo mã cho phiếu trả chi tiết
if(not exists(select * from phieu_tra_chi_tiet))
		begin
		set @idpt_ct = 1;
		set @ma_phieu_tra_ct = 'PTCT00' + CAST(@idpt_ct as varchar(100));
		select @ma_phieu_tra_ct as ma_pm1;
		end
	else
		begin
		set @ma_phieu_tra_ct = (select MAX(ma_phieu_tra_chi_tiet) from phieu_tra_chi_tiet)
		set @idpt_ct = cast(SUBSTRING(@ma_phieu_tra_ct, 5 ,4) as int)
		set @idpt_ct = @idpt_ct + 1;
		
			if(@idpt_ct < 10)
				begin 
				set @ma_phieu_tra_ct = 'PTCT00' + CAST(@idpt_ct as varchar(100))
				select @ma_phieu_tra_ct as ma_pm2;
				end
			else if(@idpt_ct < 100 and @idpt_ct >=  10)
				begin 
				set @ma_phieu_tra_ct = 'PTCT0' + CAST(@idpt_ct as varchar(100));
				select @ma_phieu_tra_ct as ma_pm3;
				end

			else if(@idpt_ct < 1000 and @idpt_ct >=  100)
				begin 
				set @ma_phieu_tra_ct = 'PTCT' + CAST(@idpt_ct as varchar(100));
				select @ma_phieu_tra_ct as ma_pm4;
				end
	end
	

IF(@id_phieu_muon != @idpm_trong_phieu_tra) OR (not exists(select * from phieu_tra))
BEGIN
--- Tạo mã mới cho phiếu nhập chi tiết
 if(not exists(select * from phieu_tra))
		begin
		set @idpt = 1;
		set @ma_phieu_tra = 'PT00' + CAST(@idpt as varchar(100));
		select @ma_phieu_tra as ma_pm1;
		end
	else
		begin
		set @ma_phieu_tra = (select MAX(ma_phieu_tra) from phieu_tra)
		set @idpt = cast(SUBSTRING(@ma_phieu_tra, 5 ,4) as int)
		set @idpt = @idpt + 1;
		
			if(@idpt < 10)
				begin 
				set @ma_phieu_tra = 'PT00' + CAST(@idpt as varchar(100))
				select @ma_phieu_tra as ma_pm2;
				end
			else if(@idpt < 100 and @idpt >=  10)
				begin 
				set @ma_phieu_tra = 'PT0' + CAST(@idpt as varchar(100));
				select @ma_phieu_tra as ma_pm3;
				end

			else if(@idpt < 1000 and @idpt >=  100)
				begin 
				set @ma_phieu_tra = 'PT' + CAST(@idpt as varchar(100));
				select @ma_phieu_tra as ma_pm4;
				end
	end
	INSERT INTO phieu_tra(ma_phieu_tra, id_phieu_muon, id_nv, ngay_tra)
VALUES(@ma_phieu_tra, @id_phieu_muon, 1, getdate());

END

SET @idpt = (SELECT TOP(1)id FROM phieu_tra ORDER BY id DESC)
INSERT INTO phieu_tra_chi_tiet(ma_phieu_tra_chi_tiet, id_phieu_tra, id_dau_sach, so_luong, so_ngay_qua_han, 
id_tinh_trang, tien_phat)
VALUES(@ma_phieu_tra_ct, @idpt, @id_dau_sach, @so_luong, 0, 14, 0);

UPDATE dau_sach SET so_luong_cuon_sach = @so_luong_cuon_sach + @so_luong WHERE id = @id_dau_sach;
UPDATE phieu_muon_chi_tiet SET id_tinh_trang = 16 WHERE id = @id_pmct;

WHILE(@so_luong > 0)
BEGIN
UPDATE TOP(1) cuon_sach SET id_tinh_trang = 9 WHERE id_tinh_trang = 10 AND id_dau_sach = @id_dau_sach
SET @so_luong = @so_luong - 1;
END

SET @dem_pmct_da_tra = (SELECT COUNT(*) FROM phieu_muon_chi_tiet WHERE id_phieu_muon = @id_phieu_muon and id_tinh_trang = 16)
SET @dem_pmct_chua_tra = (SELECT COUNT(*) FROM phieu_muon_chi_tiet WHERE id_phieu_muon = @id_phieu_muon)
IF(@dem_pmct_da_tra = @dem_pmct_chua_tra)
BEGIN
UPDATE phieu_muon SET id_tinh_trang = 12 WHERE id = @id_phieu_muon
END
 





EXEC Tra_Sach 4

		--- Thêm thông tin cho phiếu trả






 SET @id_phieu_nhap = (SELECT TOP(1) id FROM phieu_nhap ORDER BY id DESC)
 SET @tong_tien = (SELECT tongtien FROM phieu_nhap WHERE id = @id_phieu_nhap);
 UPDATE phieu_nhap SET tongtien = @tong_tien + @thanhtien WHERE id = @id_phieu_nhap;
 -- Lấy id đầu sách mới được thêm
  SET @id_dau_sach = (SELECT TOP(1) id FROM dau_sach ORDER BY id DESC)

 INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, 
 so_luong_nhap, thanh_tien, id_phieu_nhap)
 VALUES(@ma_pnct, @id_nha_xuat_ban, @id_dau_sach, @gia_nhap, @so_luong_nhap, @thanhtien, @id_phieu_nhap)
