USE QuanLyBanHangNhom1;
GO

--INSERT INTO tblChatLieu (MaChatLieu, TenChatLieu)
--VALUES

---- Dòng 1
--('CL01', N'Nước'),

---- Dòng 2
--('CL02', N'Sữa bò'),

---- Dòng 3
--('CL03', N'Bột mì'),

---- Dòng 4
--('CL04', N'Lúa gạo'),

---- Dòng 5
--('CL05', N'Thịt heo'),

---- Dòng 6
--('CL06', N'Cá basa'),

---- Dòng 7
--('CL07', N'Trái cây tươi'),

---- Dòng 8
--('CL08', N'Rau củ quả tươi'),

---- Dòng 9
--('CL09', N'Gia vị nấu ăn'),

---- Dòng 10
--('CL10', N'Đồ hộp');
--GO

--INSERT INTO tblKhach (MaKhach, TenKhach, DiaChi, DienThoai)
--VALUES

---- Dòng 1
--('KH01', N'Nguyễn Văn A', N'123 Nguyễn Trãi, Hà Nội', '0123456789'),

---- Dòng 2
--('KH02', N'Trần Thị B', N'456 Hai Bà Trưng, Hà Nội', '0987654321'),

---- Dòng 3
--('KH03', N'Lê Văn C', N'789 Lý Thái Tổ, Hà Nội', '0123987654'),

---- Dòng 4
--('KH04', N'Phạm Thị D', N'1011 Bà Triệu, Hà Nội', '0912345678'),

---- Dòng 5
--('KH05', N'Đinh Văn E', N'2022 Trần Hưng Đạo, Hà Nội', '0898765432'),

---- Dòng 6
--('KH06', N'Vũ Thị F', N'3033 Kim Mã, Hà Nội', '0789123456'),

---- Dòng 7
--('KH07', N'Trương Văn G', N'4044 Láng Hạ, Hà Nội', '0678901234'),

---- Dòng 8
--('KH08', N'Bùi Thị H', N'5055 Nguyễn Chí Thanh, Hà Nội', '0567890123'),

---- Dòng 9
--('KH09', N'Đỗ Văn I', N'6066 Tôn Đức Thắng, Hà Nội', '0456789012'),

---- Dòng 10
--('KH10', N'Nguyễn Thị K', N'7077 Phạm Văn Đồng, Hà Nội', '0345678901');
--GO

--INSERT INTO tblHang (MaHang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh)
--VALUES

---- Dòng 1
--('H001', N'Nước ngọt Coca-Cola', 'CL01', 10, 10000, 15000, 'cocacola.jpg'),

---- Dòng 2
--('H002', N'Sữa tươi TH True Milk', 'CL02', 20, 15000, 20000, 'thtruemilk.jpg'),

---- Dòng 3
--('H003', N'Bánh mì sandwich', 'CL03', 50, 5000, 10000, 'banhmisandwich.jpg'),

---- Dòng 4
--('H004', N'Mì gói Hảo Hảo', 'CL03', 30, 3000, 5000, 'mihaohhao.jpg'),

---- Dòng 5
--('H005', N'Gạo Nàng Hương', 'CL04', 100, 20000, 30000, 'gaonang huong.jpg'),

---- Dòng 6
--('H006', N'Thịt ba chỉ', 'CL05', 50, 50000, 70000, 'thitbachi.jpg'),

---- Dòng 7
--('H007', N'Cá basa fillet', 'CL06', 20, 40000, 60000, 'cabasafillet.jpg'),

---- Dòng 8
--('H008', N'Táo', 'CL07', 50, 20000, 30000, 'tao.jpg'),

---- Dòng 9
--('H009', N'Cà rốt', 'CL08', 30, 10000, 15000, 'carot.jpg'),

---- Dòng 10
--('H010', N'Muối', 'CL09', 100, 5000, 8000, 'muoi.jpg');
--GO

--INSERT INTO tblNhanVien (MaNhanVien, TenNhanVien, GioiTinh, DiaChi, DienThoai, NgaySinh)
--VALUES

---- Dòng 1
--('NV01', N'Nguyễn Văn A', N'Nam', N'123 Nguyễn Trãi, Hà Nội', '0123456789', '1990-01-01'),

---- Dòng 2
--('NV02', N'Trần Thị B', N'Nữ', '456 Hai Bà Trưng, Hà Nội', '0987654321', '1991-02-02'),

---- Dòng 3
--('NV03', N'Lê Văn C', N'Nam', N'789 Lý Thái Tổ, Hà Nội', '0123987654', '1992-03-03'),

---- Dòng 4
--('NV04', N'Phạm Thị D', N'Nữ', N'1011 Bà Triệu, Hà Nội', '0912345678', '1993-04-04'),

---- Dòng 5
--('NV05', N'Đinh Văn E', N'Nam', N'2022 Trần Hưng Đạo, Hà Nội', '0898765432', '1994-05-05'),

---- Dòng 6
--('NV06', N'Vũ Thị F', N'Nữ', N'3033 Kim Mã, Hà Nội', '0789123456', '1995-06-06'),

---- Dòng 7
--('NV07', N'Trương Văn G', N'Nam', N'4044 Láng Hạ, Hà Nội', '0678901234', '1996-07-07'),

---- Dòng 8
--('NV08', N'Bùi Thị H', N'Nữ', N'5055 Nguyễn Chí Thanh, Hà Nội', '0567890123', '1997-08-08'),

---- Dòng 9
--('NV09', N'Đỗ Văn I', N'Nam', N'6066 Tôn Đức Thắng, Hà Nội', '0456789012', '1998-09-09'),

---- Dòng 10
--('NV10', N'Nguyễn Thị K', N'Nữ', N'7077 Phạm Văn Đồng, Hà Nội', '0345678901', '1999-10-10');
--GO

--INSERT INTO tblHDBan(MaHDBan, NgayBan, MaNhanVien, MaKhach, TongTien)
--VALUES

---- Dòng 1
--('HD001', '2024-04-09', 'NV01', 'KH01', 100000),

---- Dòng 2
--('HD002', '2024-04-08', 'NV02', 'KH02', 200000),

---- Dòng 3
--('HD003', '2024-04-07', 'NV03', 'KH03', 300000),

---- Dòng 4
--('HD004', '2024-04-06', 'NV01', 'KH02', 400000),

---- Dòng 5
--('HD005', '2024-04-05', 'NV02', 'KH01', 500000),

---- Dòng 6
--('HD006', '2024-04-04', 'NV03', 'KH03', 600000),

---- Dòng 7
--('HD007', '2024-04-03', 'NV01', 'KH02', 700000),

---- Dòng 8
--('HD008', '2024-04-02', 'NV02', 'KH01', 800000),

---- Dòng 9
--('HD009', '2024-04-01', 'NV03', 'KH03', 900000),

---- Dòng 10
--('HD010', '2024-03-31', 'NV01', 'KH02', 1000000);
--GO

--INSERT INTO tblChiTietHDBan(MaHDBan, MaHang, SoLuong, DonGia, GiamGia, ThanhTien)
--VALUES

---- Dòng 1
--('HD001', 'H001', 2, 15000, 1000, 30000),

---- Dòng 2
--('HD002', 'H002', 1, 20000,1000, 20000),

---- Dòng 3
--('HD003', 'H003', 3, 5000, 1000, 15000),

---- Dòng 4
--('HD004', 'H004', 2, 3000, 1000, 6000),

---- Dòng 5
--('HD005', 'H005', 10, 30000, 1000, 300000),

---- Dòng 6
--('HD006', 'H006', 5, 70000, 1000, 350000),

---- Dòng 7
--('HD007', 'H007', 2, 60000, 1000, 120000),

---- Dòng 8
--('HD008', 'H008', 3, 30000, 1000, 90000),

---- Dòng 9
--('HD009', 'H009', 5, 15000, 1000, 75000),

---- Dòng 10
--('HD010', 'H010', 10, 8000, 1000, 80000);
--GO