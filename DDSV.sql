﻿use master
create database DDSV
use DDSV
go

----------------
CREATE TABLE QUYENTRUYCAP
(
MAPHANQUYEN VARCHAR(15),
TENPHANQUYEN NVARCHAR(30),
PRIMARY KEY(MAPHANQUYEN)
)
INSERT INTO QUYENTRUYCAP VALUES('QTV',N'QUẢN TRỊ VIÊN')
INSERT INTO QUYENTRUYCAP VALUES('GV',N'GIẢNG VIÊN')
-------------------------------------------------
-----------------------------------------------------
--------------------------KHOA
CREATE TABLE KHOA
(
	MAKHOA VARCHAR(10),
	TENKHOA NVARCHAR(50),
	PRIMARY KEY(MAKHOA)
)
INSERT INTO KHOA VALUES('CNTT',N'CÔNG NGHỆ THÔNG TIN')
iNSERT INTO KHOA VALUES('CNTP',N'CÔNG NGHỆ THỰC PHẨM')
Select*from KHOA
---------------------------MÔN HỌC
CREATE TABLE MONHOC
(
	MAMH VARCHAR(15),
	TENMH NVARCHAR(50),
	TONGSOTIET INT,
	SOTIETLT INT,
	SOTIETTH INT
	PRIMARY KEY(MAMH)
)
INSERT INTO MONHOC VALUES ('0101007881',N'CÔNG NGHỆ .NET',75,15,60)
--------------------------LỚP MÔN HỌC
SELECT*FROM MONHOC
CREATE TABLE LOPMONHOC
(
	MALOPMH VARCHAR(15),
	TENLOPMH NVARCHAR(50),
	MAKHOA VARCHAR(10),
	KHOA VARCHAR(10),
	PRIMARY KEY(MALOPMH)
)
--Bảng lớp môn học
ALTER TABLE LOPMONHOC ADD CONSTRAINT FK_MHK FOREIGN KEY (MAKHOA) REFERENCES KHOA (MAKHOA);
INSERT INTO LOPMONHOC VALUES('10DHTH1',N'ĐẠI HỌC TIN HỌC 1','CNTT','10')
INSERT INTO LOPMONHOC VALUES('10DHTH4',N'ĐẠI HỌC TIN HỌC 4','CNTT','10')
---------------------------PHÒNG HỌC
CREATE TABLE PHONGHOC
(
	MAPHONGHOC VARCHAR(15),
	TENPHONGHOC NVARCHAR(20),
	DIACHI NVARCHAR(50),
	PRIMARY KEY(MAPHONGHOC)
)
INSERT INTO PHONGHOC VALUES('A101','PHÒNG A.101',N'LÊ TRỌNG TẤN')
INSERT INTO PHONGHOC VALUES('A102','PHÒNG A.102',N'LÊ TRỌNG TẤN')
INSERT INTO PHONGHOC VALUES('B101','PHÒNG B.201',N'LÊ TRỌNG TẤN')
--------------------------CA HỌC
CREATE TABLE CAHOC
(
	MACAHOC VARCHAR(15),
	GIOBATDAU NVARCHAR(20),
	GIOKETTHUC NVARCHAR(20),
	BUOIHOC NVARCHAR(20),
	PRIMARY KEY(MACAHOC)
)
INSERT INTO CAHOC VALUES('C1','07:00','11:45',N'SÁNG')
INSERT INTO CAHOC VALUES('C2','07:00','09:30',N'SÁNG'),
('C3','09:00','11:45',N'SÁNG'),
('C4','12:30','14:45',N'CHIỀU'),
('C5','15:00','17:15',N'CHIỀU'),
('C6','12:30','16:30',N'CHIỀU'),
('C7','12:30','17:15',N'CHIỀU')
SELECT*FROM CAHOC
-------------------------------------------------------
CREATE TABLE TAIKHOAN
(
TENTAIKHOAN VARCHAR(20),
TENNGUOIDUNG VARCHAR(50),
MATKHAU VARCHAR(50),
MAPHANQUYEN VARCHAR(15),
PRIMARY KEY(TENTAIKHOAN)
)
--Bảng tài khoản
ALTER TABLE TAIKHOAN ADD CONSTRAINT FK_TAIKHOAN_QUYENTRUYCAP FOREIGN KEY(MAPHANQUYEN) REFERENCES QUYENTRUYCAP(MAPHANQUYEN)
Alter table TAIKHOAN ADD CONSTRAINT FK_GV_TK FOREIGN KEY (TENTAIKHOAN) REFERENCES GIANGVIEN(MAGIANGVIEN)
INSERT INTO TAIKHOAN VALUES('1971016001','VU ANH HUNG','123','GV')
INSERT INTO TAIKHOAN VALUES('ADMIN','ADMIN','123','QTV')
CREATE TABLE GIANGVIEN
(
	MAGIANGVIEN VARCHAR(20),
	HOTENGV NVARCHAR(50),
	GIOITINH NVARCHAR(10),
	NGAYSINH DATE,
	TRINHDO NVARCHAR(30),
	MAKHOA VARCHAR(10)
	PRIMARY KEY(MAGIANGVIEN)
)
SET DATEFORMAT DMY
INSERT INTO GIANGVIEN VALUES('ADMIN',N'NGÔ TRƯỜNG AN',N'NAM','1/8/1980',N'Thạc sĩ','CNTT')
INSERT INTO GIANGVIEN VALUES('1971016001',N'VŨ ANH HÙNG',N'NAM','8/8/1980',N'Thạc sĩ','CNTT')
INSERT INTO GIANGVIEN VALUES('1971016002',N'NGUYỄN VĂN BẢO',N'NAM','18/5/1982',N'Thạc sĩ','CNTT')
ALTER TABLE GIANGVIEN ADD CONSTRAINT FK_KHOA FOREIGN KEY (MAKHOA) REFERENCES KHOA (MAKHOA)
-----------------------PROC-----------------------------
CREATE PROC INSERT_GIANGVIEN @MAGIANGVIEN VARCHAR(20),@HOTENGV NVARCHAR(50),@GIOITINH NVARCHAR(10),@NGAYSINH DATE,@TRINHDO NVARCHAR(30),@MAKHOA VARCHAR(10)
AS
BEGIN
INSERT INTO GIANGVIEN VALUES(@MAGIANGVIEN,@HOTENGV,@GIOITINH,@NGAYSINH,@TRINHDO,@MAKHOA)
END
CREATE PROC UPDATE_GIANGVIEN @MAGIANGVIEN VARCHAR(20),@HOTENGV NVARCHAR(50),@GIOITINH NVARCHAR(10),@NGAYSINH DATE,@TRINHDO NVARCHAR(30),@MAKHOA VARCHAR(10)
AS
BEGIN
UPDATE GIANGVIEN
SET HOTENGV = @HOTENGV,GIOITINH = @GIOITINH,NGAYSINH = @NGAYSINH,TRINHDO = @TRINHDO,MAKHOA = @MAKHOA
WHERE MAGIANGVIEN = @MAGIANGVIEN
END
SELECT * FROM GIANGVIEN
------------------------------BẢNG SINH VIÊN

CREATE TABLE SINHVIEN
(
	MASV VARCHAR(15),
	HOTENSV NVARCHAR(50),
	GIOITINH NVARCHAR(10),
	NGAYSINH DATE,
	LOPNIENCHE VARCHAR(15),
	PRIMARY KEY(MASV)
)
SET DATEFORMAT DMY
INSERT INTO SINHVIEN VALUES ('2001190017',N'NGÔ TRƯỜNG AN',N'Nam','4/7/1999','10DHTH4')
INSERT INTO SINHVIEN VALUES ('2001190018',N'VÕ HOÀNG AN',N'Nam','25/7/1999','10DHTH1')
-------------------------------
CREATE PROC INSERT_SINHVIEN @MASV VARCHAR(15),@HOTENSV NVARCHAR(50),@GIOITINH NVARCHAR(10),@NGAYSINH DATE,@LOPNIENCHE NVARCHAR(30)
AS
BEGIN
INSERT INTO SINHVIEN VALUES(@MASV,@HOTENSV,@GIOITINH,@NGAYSINH,@LOPNIENCHE)
END
--------------------------------------------------
CREATE PROC UPDATE_SINHVIEN @MASV VARCHAR(15),@HOTENSV NVARCHAR(50),@GIOITINH NVARCHAR(10),@NGAYSINH DATE,@LOPNIENCHE NVARCHAR(30)
AS
BEGIN
UPDATE SINHVIEN
SET HOTENSV = @HOTENSV,GIOITINH = @GIOITINH,NGAYSINH = @NGAYSINH,LOPNIENCHE = @LOPNIENCHE
WHERE MASV = @MASV
END

-------------------------------------MÔN HỌC_LỚP MÔN HỌC
CREATE TABLE MONHOC_LOPMONHOC
(
	IDLOPMH INT,
	MALOPMH VARCHAR(15),
	MAMH VARCHAR(15),
	MAGIANGVIEN VARCHAR(20),
	HOCKY INT,
	NAMHOC VARCHAR(20),
	SOBUOIHOC INT,
	NGAYBATDAU DATE,
	NGAYKETTHUC DATE,
	SISO INT,
	MAPHONGHOC VARCHAR(15),
	MACAHOC VARCHAR(15),
	TRANGTHAI NVARCHAR(30),
	PRIMARY KEY(IDLOPMH)
)
--Bảng môn học lớp
ALTER TABLE MONHOC_LOPMONHOC ADD CONSTRAINT FK_MALMH FOREIGN KEY (MALOPMH) REFERENCES LOPMONHOC (MALOPMH);
ALTER TABLE MONHOC_LOPMONHOC ADD CONSTRAINT FK_MAGV FOREIGN KEY (MAGIANGVIEN) REFERENCES GIANGVIEN (MAGIANGVIEN);
ALTER TABLE MONHOC_LOPMONHOC ADD CONSTRAINT FK_MAPH FOREIGN KEY (MAPHONGHOC) REFERENCES PHONGHOC (MAPHONGHOC);
ALTER TABLE MONHOC_LOPMONHOC ADD CONSTRAINT FK_MACH FOREIGN KEY (MACAHOC) REFERENCES CAHOC (MACAHOC);
ALTER TABLE MONHOC_LOPMONHOC ADD CONSTRAINT FK_MAMH FOREIGN KEY (MAMH) REFERENCES MONHOC (MAMH);
SET DATEFORMAT DMY
INSERT INTO MONHOC_LOPMONHOC VALUES(1,'10DHTH4','0101007881','1971016001',1,'2021-2022',15,'4/5/2020','4/10/2020',45,'A101','C1',N'ĐÃ BẮT ĐẦU')
SELECT*FROM MONHOC_LOPMONHOC
--------------------
CREATE PROC HIENTHI_DSLOPMONHOC_MONHOC @MAMONHOC VARCHAR(20)
AS
BEGIN
SELECT ML.IDLOPMH,ML.MALOPMH,ML.MAMH,ML.MAGIANGVIEN,ML.HOCKY,ML.NAMHOC,ML.SOBUOIHOC,ML.NGAYBATDAU,ML.NGAYKETTHUC,ML.SISO,ML.MAPHONGHOC,ML.MACAHOC FROM MONHOC_LOPMONHOC ML, MONHOC M WHERE ML.MAMH=M.MAMH AND ML.MAMH = @MAMONHOC
END
EXEC dbo.HIENTHI_DSLOPMONHOC_MONHOC '0101007881'
--------------------
CREATE PROC TRUYCAP_IDLOPMHCUOICUNG @IDLOPMH INT OUTPUT
AS
BEGIN
--B1: KHAI BÁO
DECLARE cur_IDLOPMHCUOICUNG CURSOR SCROLL FOR SELECT IDLOPMH FROM MONHOC_LOPMONHOC
--B2: MỞ CURSOR
OPEN cur_IDLOPMHCUOICUNG
--B3: XỬ LÍ
DECLARE @SO INT
FETCH LAST FROM cur_IDLOPMHCUOICUNG INTO @SO
BEGIN
SET @IDLOPMH=@SO
--FETCH LAST FROM cur_HOADONCUOICUNG INTO @SO
END
--B4: ĐÓNG CURSOR
CLOSE cur_IDLOPMHCUOICUNG
--B5: HỦY CURSOR
DEALLOCATE cur_IDLOPMHCUOICUNG
END
GO
DECLARE @SO INT
EXEC TRUYCAP_IDLOPMHCUOICUNG @SO OUTPUT
SELECT @SO
--------------------INSERT_MOCHOC_LOPMONHOC_GV
CREATE PROC INSERT_MONCHOC_LOPMONHOC_GV @IDLOPMH INT, @MALOPMH VARCHAR(15),@MAMH VARCHAR(15),@MAGIANGVIEN VARCHAR(15),@HOCKY INT, @NAMHOC VARCHAR(20), @SOBUOIHOC INT, @NGAYBATDAU DATE, @NGAYKETTHUC DATE,@SISO INT,@MAPHONGHOC VARCHAR(15),@MACAHOC VARCHAR(15),@TRANGTHAI NVARCHAR(30)
AS
BEGIN
INSERT INTO MONHOC_LOPMONHOC
VALUES(@IDLOPMH,@MALOPMH,@MAMH,@MAGIANGVIEN,@HOCKY,@NAMHOC,@SOBUOIHOC,@NGAYBATDAU,@NGAYKETTHUC,@SISO,@MAPHONGHOC,@MACAHOC,@TRANGTHAI)
END
--INSERT INTO MONHOC_LOPMONHOC VALUES(4,'10DHTH4','0101003472','1971016001',1,'2021-2022',15,'4/5/2020','4/10/2020',45,'A102','C1',N'ĐÃ BẮT ĐẦU')
-----------------INSERT_MOCHOC_LOPMONHOC
CREATE PROC INSERT_MONHOC_LOPMONHOC @IDLOPMH INT, @MALOPMH VARCHAR(15),@MAMH VARCHAR(15),@HOCKY INT, @NAMHOC VARCHAR(20), @SOBUOIHOC INT, @NGAYBATDAU DATE, @NGAYKETTHUC DATE,@SISO INT,@MAPHONGHOC VARCHAR(15),@MACAHOC VARCHAR(15),@TRANGTHAI NVARCHAR(30)
AS
BEGIN
INSERT INTO MONHOC_LOPMONHOC(IDLOPMH,MALOPMH,MAMH,HOCKY,NAMHOC,SOBUOIHOC,NGAYBATDAU,NGAYKETTHUC,SISO,MAPHONGHOC,MACAHOC,TRANGTHAI)
VALUES(@IDLOPMH,@MALOPMH,@MAMH,@HOCKY,@NAMHOC,@SOBUOIHOC,@NGAYBATDAU,@NGAYKETTHUC,@SISO,@MAPHONGHOC,@MACAHOC,@TRANGTHAI)
END
--EXEC dbo.INSERT_MONHOC_LOPMONHOC 4,'10DHTH4','006618',1,'2020 - 2021',15,'4/5/2020','5/10/2020',60,'A101','C1',N'MỞ LỚP'
-------------------UPDATE_MOCHOC_LOPMONHOC
CREATE PROC UPDATE_MOCHOC_LOPMONHOC_GV @IDLOPMH INT, @MALOPMH VARCHAR(15),@MAMH VARCHAR(15),@MAGIANGVIEN VARCHAR(15),@HOCKY INT, @NAMHOC VARCHAR(20), @SOBUOIHOC INT, @NGAYBATDAU DATE, @NGAYKETTHUC DATE,@SISO INT,@MAPHONGHOC VARCHAR(15),@MACAHOC VARCHAR(15),@TRANGTHAI NVARCHAR(30)
AS
BEGIN
UPDATE MONHOC_LOPMONHOC
SET  MALOPMH=@MALOPMH,MAMH=@MAMH,MAGIANGVIEN=@MAGIANGVIEN,HOCKY=@HOCKY,NAMHOC=@NAMHOC,SOBUOIHOC=@SOBUOIHOC,NGAYBATDAU=@NGAYBATDAU,NGAYKETTHUC=@NGAYKETTHUC,SISO=@SISO,MAPHONGHOC=@MAPHONGHOC,MACAHOC=@MACAHOC,TRANGTHAI=@TRANGTHAI
WHERE IDLOPMH=@IDLOPMH
END
--EXEC DBO.UPDATE_MOCHOC_LOPMONHOC_GV 4,'10DHTH4','0101003472','1971016001',2,'2021-2022',15,'4/5/2020','4/10/2020',45,'A102','C1',N'ĐÃ BẮT ĐẦU'
-------------------
------------------------------SINHVIEN_HOC_LOPMONHOC
CREATE TABLE SINHVIEN_HOC_LOPMONHOC
(
	IDLOPMH INT,
	MASV VARCHAR(15),
	NGAYDANGKY DATE,
	PRIMARY KEY(IDLOPMH,MASV)
)
--Bảng SINHVIEN_HOC_LOPMONHOC
ALTER TABLE SINHVIEN_HOC_LOPMONHOC ADD CONSTRAINT FK_ID FOREIGN KEY (IDLOPMH) REFERENCES MONHOC_LOPMONHOC(IDLOPMH);
ALTER TABLE SINHVIEN_HOC_LOPMONHOC ADD CONSTRAINT FK_MASV FOREIGN KEY (MASV) REFERENCES SINHVIEN (MASV);
SET DATEFORMAT DMY
INSERT INTO SINHVIEN_HOC_LOPMONHOC VALUES(1,'2001190017','4/5/2020')
INSERT INTO SINHVIEN_HOC_LOPMONHOC VALUES(1,'2001190018','4/5/2020')
-----------------------------------
CREATE PROC HIENTHI_DSLOPMONHOCTHEOMON @MAMH VARCHAR(20)
AS
BEGIN
SELECT * FROM  MONHOC_LOPMONHOC ML WHERE ML.MAMH = @MAMH
END
EXEC dbo.HIENTHI_DSLOPMONHOCTHEOMON '0101007881'
----------------------------------PHIẾU ĐIỂM DANH
CREATE TABLE PHIEUDIEMDANH
(
	MAPDD INT,
	IDLOPMH INT,
	TUANTHU INT,
	NGAYDIEMDANH DATE,
	SOSINHVIENVANG INT,
	PRIMARY KEY (MAPDD)
)
--Bảng Phiếu điểm danh
INSERT INTO PHIEUDIEMDANH VALUES (1,1,1,'05/04/2020',1)
INSERT INTO PHIEUDIEMDANH VALUES (2,2,1,'05/04/2020',1)
INSERT INTO PHIEUDIEMDANH VALUES (3,1,2,'12/04/2020',0)
CREATE PROC KIEMTRA_LICHSUDIEMDANH @ID INT, @TUAN INT
AS
BEGIN
SELECT * FROM PHIEUDIEMDANH WHERE IDLOPMH = @ID AND TUANTHU = @TUAN
END
--EXEC KIEMTRA_LICHSUDIEMDANH 2,1
SELECT*FROM PHIEUDIEMDANH
--Bảng Phiếu điểm danh
ALTER TABLE PHIEUDIEMDANH ADD CONSTRAINT FK_DD FOREIGN KEY (IDLOPMH) REFERENCES MONHOC_LOPMONHOC (IDLOPMH);
----------------------------------LỊCH SỬ VẮNG
CREATE TABLE LICHSUVANG
(
	MAPDD INT,
	ID INT,
	MASV VARCHAR(15),
	HOTENSV NVARCHAR(50),
	GIOITINH NVARCHAR(10),
	NGAYSINH DATETIME,
	LOPNIENCHE VARCHAR(15),
	LYDOVANG NVARCHAR(50)
	PRIMARY KEY(MAPDD,ID)
)
--Bảng lịch sử vắng
ALTER TABLE LICHSUVANG ADD CONSTRAINT FK_VSV FOREIGN KEY (MASV) REFERENCES SINHVIEN (MASV);
ALTER TABLE LICHSUVANG ADD CONSTRAINT FK_PDD FOREIGN KEY (MAPDD) REFERENCES PHIEUDIEMDANH (MAPDD);
--------------------------------------
--------------------------------------
CREATE PROC LAYDSLOP_GV @MAGV VARCHAR(15)
AS
BEGIN
SELECT ML.IDLOPMH,ML.MAMH,M.TENMH,ML.MALOPMH,ML.MACAHOC,ML.MAPHONGHOC,ML.NGAYBATDAU,ML.NGAYKETTHUC,ML.TRANGTHAI 
FROM MONHOC_LOPMONHOC ML,MONHOC M, GIANGVIEN G 
WHERE ML.MAGIANGVIEN = G.MAGIANGVIEN AND ML.MAMH = M.MAMH AND ML.MAGIANGVIEN = @MAGV AND ML.TRANGTHAI = N'ĐÃ BẮT ĐẦU'
END

EXEC dbo.LAYDSLOP_GV '1971016001'
CREATE PROC LAYDSLOPDIEMDANH_GV @MAGV VARCHAR(15), @TENMONHOC NVARCHAR(50)
AS
BEGIN
SELECT ML.IDLOPMH,ML.MAMH,M.TENMH,ML.MALOPMH,ML.MACAHOC,ML.MAPHONGHOC,ML.SOBUOIHOC, ML.NGAYBATDAU
FROM MONHOC_LOPMONHOC ML,MONHOC M, GIANGVIEN G 
WHERE ML.MAGIANGVIEN = G.MAGIANGVIEN AND ML.MAMH = M.MAMH AND ML.MAGIANGVIEN = @MAGV AND M.TENMH = @TENMONHOC AND ML.TRANGTHAI = N'ĐÃ BẮT ĐẦU'
END

EXEC dbo.LAYDSLOPDIEMDANH_GV '1971016001',N'CÔNG NGHỆ .NET'
--------------------------------------------
CREATE PROC LAYDSCBMONHOC_GV @MAGV VARCHAR(15)
AS
BEGIN
SELECT DISTINCT M.TENMH
FROM MONHOC_LOPMONHOC ML,MONHOC M, GIANGVIEN G 
WHERE ML.MAGIANGVIEN = G.MAGIANGVIEN AND ML.MAMH = M.MAMH AND ML.MAGIANGVIEN = @MAGV AND ML.TRANGTHAI = N'ĐÃ BẮT ĐẦU'
END

EXEC LAYDSCBMONHOC_GV '1971016001'
------------------------------------------DANH SÁCH LỊCH SỬ ĐIỂM DANH LỚP --------------------------------
CREATE PROC LAY_LICHSUDD_IDLOPMH @IDLOPMH INT
AS
BEGIN
SELECT P.MAPDD,P.IDLOPMH,P.TUANTHU,P.NGAYDIEMDANH,P.SOSINHVIENVANG, (L.[SISO]-P.SOSINHVIENVANG)AS N'COMAT' FROM PHIEUDIEMDANH P,(SELECT COUNT(MASV) AS 'SISO' FROM SINHVIEN_HOC_LOPMONHOC WHERE IDLOPMH = @IDLOPMH) AS L WHERE IDLOPMH = @IDLOPMH
END
--EXEC dbo.LAY_LICHSUDD_IDLOPMH 2

SELECT*FROM LICHSUVANG WHERE MAPDD = 1
SELECT*FROM MONHOC_LOPMONHOC WHERE IDLOPMH = 1


----SĨ SỐ LỚP----
CREATE FUNCTION LAYSISOLOP(@IDLOPMH INT)
RETURNS INT
AS 
BEGIN
DECLARE @SOSV INT
SET @SOSV = 0
SET @SOSV = (SELECT COUNT(MASV) FROM SINHVIEN_HOC_LOPMONHOC WHERE IDLOPMH = @IDLOPMH)
RETURN @SOSV
END

SELECT dbo.LAYSISOLOP(1)
--------------------------------------DANH SÁCH SV VẮNG LỚP - TUẦN---------------------------------------
CREATE PROC TONGKETVANG_LOPMONHOC @IDLOPMH INT
AS
BEGIN
SELECT L.MASV,L.HOTENSV,L.GIOITINH,L.LOPNIENCHE, COUNT(MASV) AS N'SOBUOIVANG' FROM PHIEUDIEMDANH P, MONHOC_LOPMONHOC ML, LICHSUVANG L WHERE P.IDLOPMH = ML.IDLOPMH AND ML.IDLOPMH = @IDLOPMH AND P.MAPDD = L.MAPDD GROUP BY L.MASV,L.HOTENSV,L.GIOITINH,L.LOPNIENCHE
END
EXEC dbo.TONGKETVANG_LOPMONHOC 1
---------------------------------------DANH SÁCH ĐIỂM DANH SINH VIÊN

CREATE PROC LAY_DSSINHVIEN_LOPMONHOC @IDLOPMH INT
AS
BEGIN
SELECT H.MASV,S.HOTENSV,S.GIOITINH,S.NGAYSINH,S.LOPNIENCHE 
FROM MONHOC_LOPMONHOC M,SINHVIEN_HOC_LOPMONHOC H, SINHVIEN S 
WHERE M.IDLOPMH=H.IDLOPMH AND H.MASV=S.MASV AND M.IDLOPMH=@IDLOPMH
END
EXEC dbo.LAY_DSSINHVIEN_LOPMONHOC 1
------------------------------------------------------------------
CREATE PROC TRUYCAP_MAPDDCUOICUNG @MAPDD INT OUTPUT
AS
BEGIN
--B1: KHAI BÁO
DECLARE cur_PHIEUDIEMDANHCUOICUNG CURSOR SCROLL FOR SELECT MAPDD FROM PHIEUDIEMDANH
--B2: MỞ CURSOR
OPEN cur_PHIEUDIEMDANHCUOICUNG
--B3: XỬ LÍ
DECLARE @SO INT
SET @SO = 0
FETCH LAST FROM cur_PHIEUDIEMDANHCUOICUNG INTO @SO
BEGIN
SET @MAPDD=@SO
--FETCH LAST FROM cur_HOADONCUOICUNG INTO @SO
END
--B4: ĐÓNG CURSOR
CLOSE cur_PHIEUDIEMDANHCUOICUNG
--B5: HỦY CURSOR
DEALLOCATE cur_PHIEUDIEMDANHCUOICUNG
END
GO

DECLARE @SO INT
EXEC TRUYCAP_MAPDDCUOICUNG @SO OUTPUT
SELECT @SO
GO
--------------------------------------PROC TẠO PHIẾU ĐIỂM DANH-----------------------------
CREATE PROC INSERT_PHIEUDIEMDANH @MAPDD INT,@IDLOPMH INT,@TUANTHU INT,@NGAYDIEMDANH DATE, @SOSINHVIENVANG INT
AS
BEGIN
INSERT INTO PHIEUDIEMDANH VALUES(@MAPDD,@IDLOPMH,@TUANTHU,@NGAYDIEMDANH,@SOSINHVIENVANG)
END
-------------------------------------TRUY CẬP VÀ LẤY THỨ TỰ TUẦN HỌC TRƯỚC ĐÓ--------------------
CREATE PROC TRUYCAP_TUANHOCCUOICUNG @IDLOPMH INT, @TUAN INT OUTPUT
AS
BEGIN
--B1: KHAI BÁO
DECLARE cur_TUANHOCCUOICUNG CURSOR SCROLL FOR (SELECT L.TUANTHU FROM (SELECT*FROM PHIEUDIEMDANH WHERE IDLOPMH = @IDLOPMH) AS L)
--B2: MỞ CURSOR
OPEN cur_TUANHOCCUOICUNG
--B3: XỬ LÍ
DECLARE @SO INT
SET @SO = 0
FETCH LAST FROM cur_TUANHOCCUOICUNG INTO @SO
BEGIN
SET @TUAN=@SO
--FETCH LAST FROM cur_HOADONCUOICUNG INTO @SO
END
--B4: ĐÓNG CURSOR
CLOSE cur_TUANHOCCUOICUNG
--B5: HỦY CURSOR
DEALLOCATE cur_TUANHOCCUOICUNG
END
GO
DECLARE @SO INT
EXEC TRUYCAP_TUANHOCCUOICUNG 3, @SO OUTPUT
SELECT @SO
GO
SELECT*FROM LICHSUVANG
INSERT INTO LICHSUVANG VALUES( 5 , 1 , '2001190017' , N'NGÔ TRƯỜNG AN' , N'NAM', '4/7/1999' , '10DHTH4' , N'KHÔNG RÕ' )
 ALTER TABLE LICHSUVANG  ALTER COLUMN  NGAYSINH  DATETIME
 CREATE PROC INSERT_LSV @MAPDD INT, @ID INT, @MASV VARCHAR(15),@HOTENSV NVARCHAR(50),@GIOITINH NVARCHAR(10),@NGAYSINH DATETIME,@LOPNIENCHE VARCHAR(15),@LYDOVANG NVARCHAR(50)
 AS
 BEGIN
 INSERT INTO LICHSUVANG VALUES(@MAPDD,@ID,@MASV,@HOTENSV,@GIOITINH,@NGAYSINH,@LOPNIENCHE,@LYDOVANG)
 END
 EXEC INSERT_LSV 1,1,'2001190017',N'NGÔ TRƯỜNG AN' , N'NAM', '4/7/1999' , '10DHTH4' , N'KHÔNG RÕ' 