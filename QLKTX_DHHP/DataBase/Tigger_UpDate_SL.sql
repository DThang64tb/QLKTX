CREATE TRIGGER InsertSL
ON DangKyThue For INSERT
AS
BEGIN
	DECLARE @soLuong int;
	SELECT @soLuong = dbo.Phong.SoNguoiHienTai From Phong, Inserted WHERE Inserted.MaPhong = Phong.MaPhong;

	BEGIN
		UPDATE Phong Set SoNguoiHienTai = SoNguoiHienTai + 1 FROM Inserted WHERE Inserted.MaPhong = Phong.MaPhong;
	END
END