
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
		
