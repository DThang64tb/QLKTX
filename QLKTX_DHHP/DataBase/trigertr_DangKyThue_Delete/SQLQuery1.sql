-- Tạo trigger để xóa thông tin từ bảng HopDongThue khi có dòng bị xóa từ bảng DangKyThue
CREATE TRIGGER tr_DangKyThue_Delete
ON DangKyThue
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM HopDongThue
    WHERE MaSV IN (SELECT MaSV FROM DELETED);
END;
