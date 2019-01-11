-- Thông tin nhóm
-- 1. Bùi Phan Viết Cường – MSSV : 15110173
-- 2. Nguyễn Thị Trúc – MSSV : 15110349

-------------------------------------USER----------------------------------------
USE EEEnglish
GO
CREATE LOGIN LoginNhom14 WITH PASSWORD = '1234'
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'LoginNhom14')
BEGIN
    CREATE USER [LoginNhom14] FOR LOGIN [LoginNhom14]
    EXEC sp_addrolemember N'db_owner', N'LoginNhom14'
END
-------------------------------------USER-----------------------------------------