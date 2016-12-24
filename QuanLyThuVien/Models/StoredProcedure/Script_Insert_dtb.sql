							---INSERT DATA--


--- BẢNG TÌNH TRẠNG --

INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Null', N'All');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Còn sách', N'dau_sach');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Hết sách', N'dau_sach');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Hoạt động', N'nhan_vien');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Không hoạt động', N'nhan_vien');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Hoạt động', N'doc_gia');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Không hoạt động', N'doc_gia');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Hư', N'cuon_sach');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Sẵn sàng phục vụ', N'cuon_sach');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Đang được mượn', N'cuon_sach');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Chưa trả', N'phieu_muon');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Đã trả', N'phieu_muon');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Chưa trả', N'phieu_tra');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Đã trả', N'phieu_tra');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Chưa trả', N'phieu_muon_chi_tiet');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Đã trả', N'phieu_muon_chi_tiet');
INSERT INTO trang_thai(ten_trang_thai, ten_bang) VALUES(N'Đã in phiếu mượn', N'phieu_muon');


--- BẢNG TÁC GIẢ ---

INSERT INTO tac_gia(ma_tac_gia, ho_ten, noi_cong_tac) VALUES('TG001', N'Phạm Lê Quỳnh Như',N'Trường Đại Học Sài Gòn');
INSERT INTO tac_gia(ma_tac_gia, ho_ten, noi_cong_tac) VALUES('TG002', N'Phạm Gia Bảo',N'Trường Đại Học Sài Gòn');

--- BẢNG NHÀ XUẤT BẢN ---


INSERT INTO nha_xuat_ban(ma_nxb, ten_nxb, so_dien_thoai,dia_chi) VALUES('NXB001',N'Giáo dục',N'976345345',N'An Dương Vương, Quận 5');
INSERT INTO nha_xuat_ban(ma_nxb, ten_nxb, so_dien_thoai,dia_chi) VALUES('NXB002',N'Kim Đồng',N'465465464',N'Address');
INSERT INTO nha_xuat_ban(ma_nxb, ten_nxb, so_dien_thoai,dia_chi) VALUES('NXB003',N'Văn Hóa',N'4949946113',N'Address');
INSERT INTO nha_xuat_ban(ma_nxb, ten_nxb, so_dien_thoai,dia_chi) VALUES('NXB004',N'Tri Thức',N'646131676',N'Address');

-- BẢNG LOẠI SÁCH

INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L01', N'Sách Văn');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L02', N'Sách Toán');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L03', N'Sách Lý');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L04', N'Sách Hóa');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L05', N'Sách Ngoại Ngữ');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L06', N'Sách Khoa Học');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L07', N'Sách Sinh học');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L08', N'Sách Lịch Sử');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L09', N'Sách Triết Học');
INSERT INTO loai_sach(ma_loai_sach, ten_loai) VALUES('L10', N'Sách Kinh Doanh');

--- BẢNG ĐẦU SÁCH ---

INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS001',N'Toán 9',2,N'Sách Toán lớp 9',1,20,1990,1,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS002',N'Toán 10',2,N'Sách Toán lớp 10',1,50,1990,1,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS003',N'Văn 10',1,N'Sách Văn 10',1,20,1990,1,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS004',N'Lý 11',3,N'Sách Lý 11',1,20,1990,1,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS005',N'Lý 10',3,N'Sách Lý 10',1,20,1990,1,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS006',N'Anh Văn 8',5,N'Sách Ngoại Ngữ 8',1,10,1990,2,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS007',N'Hóa 12',4,N'Hóa 12',2,10,1990,2,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS008',N'Sinh học 12',7,N'Sinh học 12',2,10,1990,2,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS009',N'Sinh học 11',7,N'Sinh học 11',2,10,1990,1,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS010',N'Kinh Doanh làm giàu',10,N'Kinh Doanh làm giàu',2,10,1990,1,2);
INSERT INTO dau_sach(ma_dau_sach, ten_dau_sach, id_loai_sach, tom_tat, id_nxb, so_luong_cuon_sach, nam_xuat_ban, id_tac_gia, id_tinh_trang) VALUES('DS011',N'Khoa học tiềm thức',6,N'Khoa học tiềm thức',2,10,1990,1,2);

-- BẢNG CUỐN SÁCH ---

INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS001',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS002',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS003',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS004',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS005',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS006',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS007',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS008',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS009',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS010',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS011',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS012',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS013',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS014',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS015',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS016',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS017',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS018',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS019',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS020',1,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS021',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS022',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS023',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS024',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS025',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS026',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS027',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS028',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS029',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS030',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS031',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS032',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS033',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS034',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS035',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS036',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS037',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS038',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS039',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS040',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS041',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS042',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS043',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS044',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS045',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS046',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS047',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS048',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS049',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS050',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS051',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS052',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS053',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS054',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS055',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS056',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS057',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS058',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS059',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS060',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS061',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS062',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS063',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS064',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS065',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS066',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS067',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS068',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS069',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS070',2,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS071',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS072',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS073',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS074',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS075',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS076',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS077',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS078',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS079',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS080',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS081',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS082',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS083',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS084',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS085',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS086',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS087',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS088',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS089',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS090',3,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS091',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS092',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS093',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS094',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS095',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS096',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS097',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS098',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS099',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS100',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS101',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS102',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS103',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS104',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS105',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS106',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS107',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS108',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS109',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS110',4,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS111',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS112',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS113',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS114',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS115',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS116',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS117',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS118',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS119',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS120',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS121',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS122',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS123',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS124',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS125',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS126',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS127',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS128',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS129',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS130',5,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS131',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS132',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS133',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS134',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS135',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS136',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS137',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS138',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS139',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS140',6,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS141',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS142',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS143',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS144',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS145',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS146',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS147',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS148',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS149',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS150',7,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS151',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS152',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS153',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS154',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS155',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS156',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS157',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS158',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS159',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS160',8,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS161',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS162',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS163',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS164',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS165',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS166',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS167',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS168',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS169',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS170',9,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS171',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS172',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS173',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS174',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS175',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS176',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS177',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS178',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS179',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS180',10,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS181',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS182',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS183',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS184',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS185',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS186',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS187',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS188',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS189',11,9);
INSERT INTO cuon_sach(ma_cuon_sach, id_dau_sach, id_tinh_trang) VALUES('CS190',11,9);

--- BẢNG NHÂN VIÊN ---

INSERT INTO nhan_vien(ma_nhan_vien, ho_ten, dia_chi, dien_thoai, cmnd, chuc_vu, id_tinh_trang) VALUES('NV001', N'Nguyễn Văn A',N'Address', '989098231','289789345','thu_thu',4);
INSERT INTO nhan_vien(ma_nhan_vien, ho_ten, dia_chi, dien_thoai, cmnd, chuc_vu, id_tinh_trang) VALUES('NV002', N'Nguyễn Văn B',N'Address', '989093242','289789345','thu_thu',4);
INSERT INTO nhan_vien(ma_nhan_vien, ho_ten, dia_chi, dien_thoai, cmnd, chuc_vu, id_tinh_trang) VALUES('NV003', N'Nguyễn Văn C',N'Address', '989023245','289789345','thu_thu',4);
INSERT INTO nhan_vien(ma_nhan_vien, ho_ten, dia_chi, dien_thoai, cmnd, chuc_vu, id_tinh_trang) VALUES('NV004', N'Nguyễn Văn D',N'Address', '989093241','289789345','thu_thu',4);
INSERT INTO nhan_vien(ma_nhan_vien, ho_ten, dia_chi, dien_thoai, cmnd, chuc_vu, id_tinh_trang) VALUES('NV005', N'Nguyễn Văn G',N'Address', '989893245','289789345','admin',4);
INSERT INTO nhan_vien(ma_nhan_vien, ho_ten, dia_chi, dien_thoai, cmnd, chuc_vu, id_tinh_trang) VALUES('NV006', N'Nguyễn Văn I',N'Address', '989593245','289789345','thu_thu',4);
INSERT INTO nhan_vien(ma_nhan_vien, ho_ten, dia_chi, dien_thoai, cmnd, chuc_vu, id_tinh_trang) VALUES('NV007', N'Nguyễn Văn O',N'Address', '989013245','289789345','thu_thu',4);

--- BẢNG PHIẾU NHẬP ---
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN001', 42588,2000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN002', 42594,4000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN003', 42710,1800000, 1,2);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN004', 42711,1800000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN005', 42712,2000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN006', 42713,1000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN007', 42714,1000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN008', 42715,1000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN009', 42716,1000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN010', 42717,1000000, 1,1);
INSERT INTO phieu_nhap(ma_phieu_nhap, ngay_nhap, tongtien, id_tinh_trang, id_nhan_vien) VALUES('PN011', 42718,1000000, 1,1);

INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT001',1,1,100000,20,2000000,1);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT002',1,2,80000,50,4000000,2);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT003',1,3,90000,20,1800000,3);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT004',1,4,90000,20,1800000,4);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT005',1,5,100000,20,2000000,5);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT006',1,6,100000,10,1000000,6);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT007',1,7,100000,10,1000000,7);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT008',1,8,100000,10,1000000,8);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT009',1,9,100000,10,1000000,9);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT010',1,10,100000,10,1000000,10);
INSERT INTO phieu_nhap_chi_tiet(ma_phieu_nhap_chi_tiet, id_nha_xuat_ban, id_dau_sach, gia_nhap, so_luong_nhap, thanh_tien, id_phieu_nhap) VALUES(N'PNCT011',1,11,100000,10,1000000,11);

--- BẢNG ĐỘC GIẢ ----

INSERT INTO doc_gia(ma_doc_gia, ho_ten, dia_chi, dien_thoai, ngay_cap_the, ngay_het_han, nam_tot_nghiep, so_sach_muon_toi_da, thoi_gian_muon_toi_da, cmnd, nghe_nghiep, id_tinh_trang, ma_the_thu_vien) VALUES('DG001',N'Nguyễn Văn A',N'Address',1472184024,42370,42736,2018,0,20,123456789,N'Sinh viên',6,'TV001');
INSERT INTO doc_gia(ma_doc_gia, ho_ten, dia_chi, dien_thoai, ngay_cap_the, ngay_het_han, nam_tot_nghiep, so_sach_muon_toi_da, thoi_gian_muon_toi_da, cmnd, nghe_nghiep, id_tinh_trang, ma_the_thu_vien) VALUES('DG002',N'Nguyễn Văn B',N'Address',1234214083,42371,42737,2018,0,20,627836476,N'Sinh viên',6,'TV002');
INSERT INTO doc_gia(ma_doc_gia, ho_ten, dia_chi, dien_thoai, ngay_cap_the, ngay_het_han, nam_tot_nghiep, so_sach_muon_toi_da, thoi_gian_muon_toi_da, cmnd, nghe_nghiep, id_tinh_trang, ma_the_thu_vien) VALUES('DG003',N'Nguyễn Văn C',N'Address',2374723740,42372,42738,2018,0,20,234174214,N'Sinh viên',6,'TV003');
INSERT INTO doc_gia(ma_doc_gia, ho_ten, dia_chi, dien_thoai, ngay_cap_the, ngay_het_han, nam_tot_nghiep, so_sach_muon_toi_da, thoi_gian_muon_toi_da, cmnd, nghe_nghiep, id_tinh_trang, ma_the_thu_vien) VALUES('DG004',N'Nguyễn Văn D',N'Address',8348594355,42373,42739,2018,0,20,237495735,N'Sinh viên',6,'TV004');
INSERT INTO doc_gia(ma_doc_gia, ho_ten, dia_chi, dien_thoai, ngay_cap_the, ngay_het_han, nam_tot_nghiep, so_sach_muon_toi_da, thoi_gian_muon_toi_da, cmnd, nghe_nghiep, id_tinh_trang, ma_the_thu_vien) VALUES('DG005',N'Nguyễn Văn E',N'Address',7564750324,42374,42740,2018,0,20,909879974,N'Sinh viên',6,'TV005');

--- BẢNG PHIẾU MƯỢN -----


INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon,tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra) VALUES('PM001',1,42680,3,1,12,42680);
INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon,tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra) VALUES('PM002',2,42681,2,2,11,42684);
INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon,tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra) VALUES('PM003',3,42682,4,2,11,42693);
INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon,tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra) VALUES('PM004',4,42683,1,3,11,42694);
INSERT INTO phieu_muon(ma_phieu_muon, id_doc_gia, ngay_muon,tong_so_luong_muon, id_nv, id_tinh_trang, ngay_tra) VALUES('PM005',5,42684,1,1,11,42695);


--- BẢNG PHIẾU MƯỢN CHI TIẾT ----

INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_dau_sach,id_tinh_trang, so_luong) VALUES('PMCT001',1,1,12,1);
INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_dau_sach,id_tinh_trang, so_luong) VALUES('PMCT002',1,2,12,2);
INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_dau_sach,id_tinh_trang, so_luong) VALUES('PMCT003',2,2,11,2);
INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_dau_sach,id_tinh_trang, so_luong) VALUES('PMCT004',3,1,11,2);
INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_dau_sach,id_tinh_trang, so_luong) VALUES('PMCT005',3,1,11,2);
INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_dau_sach,id_tinh_trang, so_luong) VALUES('PMCT006',4,1,12,1);
INSERT INTO phieu_muon_chi_tiet(ma_phieu_muon_chi_tiet, id_phieu_muon, id_dau_sach,id_tinh_trang, so_luong) VALUES('PMCT007',5,3,11,1);


--- BẢNG PHIẾU TRẢ

INSERT INTO phieu_tra(ma_phieu_tra, id_phieu_muon, id_nv,ngay_tra) VALUES('PT001',1,1,42684);
INSERT INTO phieu_tra(ma_phieu_tra, id_phieu_muon, id_nv,ngay_tra) VALUES('PT002',4,2,42693);


--- BẢNG PHIẾU TRẢ CHI TIẾT

INSERT INTO phieu_tra_chi_tiet(ma_phieu_tra_chi_tiet, id_phieu_tra, id_dau_sach,so_luong, so_ngay_qua_han, id_tinh_trang,tien_phat) VALUES('PTCT001',1,1,1,0,14,0);
INSERT INTO phieu_tra_chi_tiet(ma_phieu_tra_chi_tiet, id_phieu_tra, id_dau_sach,so_luong, so_ngay_qua_han, id_tinh_trang,tien_phat) VALUES('PTCT002',1,2,2,0,14,0);
INSERT INTO phieu_tra_chi_tiet(ma_phieu_tra_chi_tiet, id_phieu_tra, id_dau_sach,so_luong, so_ngay_qua_han, id_tinh_trang,tien_phat) VALUES('PTCT003',2,1,1,0,14,0);

