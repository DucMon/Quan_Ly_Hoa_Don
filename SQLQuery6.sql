ALTER PROC USP_GetHDByDate
@FromDate DATE, @toDate DATE
AS
BEGIN
	SELECT SoHDBan AS 'Số Hóa Đơn',KyHieu AS 'Ký Hiệu',MDVMH AS 'Mã KH',TenDonViMuaHang AS ' Tên Đơn Vi Mua Hàng', NguoiMuaHang AS 'Người Mua Hàng', MaSoThueMua AS 'Mã Số Thuế',DiaChiMua AS 'Địa Chỉ', STKMua AS 'Số TK',NgayHD AS 'NgàyXuất',HinhThucThanhToan AS 'Hình Thức' FROM dbo.HoaDonBan
	WHERE NgayHD >= @FromDate AND NgayHD <= @toDate
END
GO

ALTER PROC USP_GetDSbyCustomer
 @NameCustomer NVARCHAR(50) = N''
 AS
 BEGIN
	SELECT SoHDBan AS 'Số Hóa Đơn',KyHieu AS 'Ký Hiệu',MDVMH AS 'Mã KH',TenDonViMuaHang AS ' Tên Đơn Vi Mua Hàng', NguoiMuaHang AS 'Người Mua Hàng', MaSoThueMua AS 'Mã Số Thuế',DiaChiMua AS 'Địa Chỉ', STKMua AS 'Số TK',NgayHD AS 'NgàyXuất',HinhThucThanhToan AS 'Hình Thức' FROM dbo.HoaDonBan
	WHERE NguoiMuaHang = @NameCustomer
END
GO

EXEC dbo.USP_GetDSbyCustomer @NameCustomer = N'Kim' -- nvarchar(50)

	
