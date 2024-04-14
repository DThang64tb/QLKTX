CREATE TRIGGER DeleteSL
ON DangKyThue
FOR DELETE
AS
BEGIN
    DECLARE @soLuong INT;

    SELECT @soLuong = dbo.Phong.SoNguoiHienTai
    FROM Phong
    INNER JOIN deleted ON deleted.MaPhong = Phong.MaPhong;

    IF @soLuong < 0
    BEGIN
        RAISERROR(N'số lượng người nhỏ hơn 0', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        UPDATE Phong
        SET SoNguoiHienTai = SoNguoiHienTai - 1
        FROM Phong
        INNER JOIN deleted ON deleted.MaPhong = Phong.MaPhong;
    END
END
