-- Thông tin nhóm
-- 1. Bùi Phan Viết Cường – MSSV : 15110173
-- 2. Nguyễn Thị Trúc – MSSV : 15110349

CREATE DATABASE EEEnglish
GO
USE EEEnglish
GO
-- bảng loại lớp
CREATE TABLE CLASSTYPE(
	ID_ClassType CHAR(10) PRIMARY KEY,
	ClassType_Name NVARCHAR(30) NOT NULL
)
-- bảng cấp độ lớp
CREATE TABLE CLASSLEVEL(
	ID_CLassLevel CHAR(10) PRIMARY KEY,
	ClassLevel_Name NVARCHAR(30) NOT NULL,
	Class_Level INT NOT NULL CHECK(Class_Level >= 1 AND Class_Level <= 3)
)
-- bảng lớp học
CREATE TABLE CLASS(
	ID_Class CHAR(10) PRIMARY KEY,
	Class_Name NVARCHAR(30) NOT NULL,
	Total INT,
	Studying_Time TIME(7) NOT NULL,
	Date_of_Week_1 NVARCHAR(20) NOT NULL,
	Date_of_Week_2 NVARCHAR(20) NOT NULL,
	SYear INT NOT NULL,
	Semester INT NOT NULL,
	ID_ClassType CHAR(10) REFERENCES dbo.CLASSTYPE(ID_ClassType) NOT NULL,
	ID_ClassLevel CHAR(10) REFERENCES dbo.CLASSLEVEL(ID_CLassLevel) NOT NULL
)
-- bảng học sinh
CREATE TABLE STUDENT(
	ID_Student CHAR(10) PRIMARY KEY,
	Name NVARCHAR(60) NOT NULL,
	Gender NVARCHAR(10) NOT NULL,
	Birthday DATE NOT NULL CHECK(Birthday < GETDATE()),
	PhoneNumber CHAR(12),
	SAddress NVARCHAR(50) NOT NULL
)

-- bảng đăng ký
CREATE TABLE REGISTER(
	ID_Register INT IDENTITY PRIMARY KEY,
	Studying_Time TIME(7) NOT NULL,
	Date_of_Week_1 NVARCHAR(20) NOT NULL,
	Date_of_Week_2 NVARCHAR(20) NOT NULL,
	Input_Exam_Date DATE NOT NULL,
	ID_Student CHAR(10) REFERENCES dbo.STUDENT(ID_Student) NOT NULL,
	ID_ClassType CHAR(10) REFERENCES dbo.CLASSTYPE(ID_ClassType) NOT NULL,
	Fee NUMERIC(18,0) NOT NULL CHECK(Fee > 0)
)

-- bảng kì thi đầu vào
CREATE TABLE INPUT_EXAM(
	Point INT NOT NULL CHECK(Point >= 0 AND Point <= 1000), 
	ID_Student CHAR(10) REFERENCES dbo.STUDENT(ID_Student) PRIMARY KEY
)
-- bảng lớp học - học sinh
CREATE TABLE STUDYING(
	ID_Student CHAR(10) REFERENCES dbo.STUDENT(ID_Student),
	ID_Class CHAR(10) REFERENCES dbo.CLASS(ID_Class),
	SStatus NVARCHAR(20),
	Date_Receive DATETIME,
	PRIMARY KEY(ID_Student,ID_Class)
)
GO
-- bảng quá trình học
CREATE TABLE STUDYING_PROCESS(
	ID_Student CHAR(10) REFERENCES dbo.STUDENT(ID_Student),
	ID_Class CHAR(10) REFERENCES dbo.CLASS(ID_Class),
	Hard_Point INT CHECK (Hard_Point >= 0 AND Hard_Point <= 30),
	Listening INT CHECK (Listening>= 0 AND Listening <= 250),
	Reading INT CHECK (Reading >= 0 AND Reading <= 250),
	Writing INT CHECK (Writing >= 0 AND Writing <= 250),
	Speaking INT CHECK (Speaking >= 0 AND Speaking <= 250),
	SMonth INT CHECK(SMonth >= 1 AND SMonth <= 3),
	PRIMARY KEY (ID_Student, ID_Class,SMonth)	
)
-- bảng kỳ thi đầu ra
CREATE TABLE OUTPUT_EXAM(
	ID_Student CHAR(10) REFERENCES dbo.STUDENT(ID_Student),
	ID_Class CHAR(10) REFERENCES dbo.CLASS(ID_Class),
	Point INT NOT NULL CHECK (Point >= 0 AND Point <= 1000),
	Graduation NVARCHAR(20) NOT NULL,
	PRIMARY KEY (ID_Student, ID_Class)
)
-- bảng danh sách hạn chế vì bỏ thi, cấm thi
CREATE TABLE BLACKLIST(
	ID_BlackList INT IDENTITY PRIMARY KEY,
	ID_Student CHAR(10) REFERENCES dbo.STUDENT(ID_Student),
	Reason NVARCHAR(50),
	ID_Class CHAR(10) REFERENCES dbo.CLASS(ID_Class)
)
-- bảng tài khoản
CREATE TABLE ACCOUNT(
	UserName CHAR(8) PRIMARY KEY,
	SPassword CHAR(8) NOT NULL,
	Permission INT NOT NULL
	)

GO -- đưa dữ liệu vào database
INSERT dbo.CLASSTYPE( ID_ClassType, ClassType_Name )
VALUES  ( N'ct1',  N'Anh văn giao tiếp')
INSERT dbo.CLASSTYPE( ID_ClassType, ClassType_Name )
VALUES  ( N'ct2',  N'Anh văn Phản xạ')
INSERT dbo.CLASSTYPE( ID_ClassType, ClassType_Name )
VALUES  ( N'ct3', N'Anh văn Toeic')
INSERT dbo.CLASSTYPE( ID_ClassType, ClassType_Name )
VALUES  ( N'ct4',  N'Anh văn Ielts' )

GO
INSERT dbo.CLASSLEVEL( ID_CLassLevel, ClassLevel_Name,Class_Level )
VALUES  ( N'cl1', N'Cơ bản', 1)
INSERT dbo.CLASSLEVEL( ID_CLassLevel, ClassLevel_Name,Class_Level )
VALUES  ( N'cl2', N'Trung bình', 2)
INSERT dbo.CLASSLEVEL( ID_CLassLevel, ClassLevel_Name,Class_Level )
VALUES  ( N'cl3', N'Nâng cao', 3)

GO
INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear ,Semester ,ID_ClassType ,ID_ClassLevel)
VALUES  ( N'c1' , N'Anh văn giao tiếp Cơ bản 1' , 10 , '18:00',N'Thứ 3',N'Thứ 5',2017 ,1 , N'ct1' , N'cl1')

INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear ,Semester ,ID_ClassType ,ID_ClassLevel)
VALUES  ( N'c2' , N'Anh văn giao tiếp Cơ bản 2' , 0 , '19:00',N'Thứ 4',N'Thứ 6',2017 ,1 , N'ct1' , N'cl1')

INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear ,Semester ,ID_ClassType ,ID_ClassLevel)
VALUES  ( N'c3' , N'Anh văn Phản xạ Cơ bản 1' , 0 , '19:00',N'Thứ 2',N'Thứ 4',2017 ,1 , N'ct2' , N'cl1')

INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear ,Semester ,ID_ClassType ,ID_ClassLevel)
VALUES  ( N'c4' , N'Anh văn Toeic Cơ bản 1' , 10 , '19:30',N'Thứ 5',N'Thứ 7',2017 ,1 , N'ct3' , N'cl1')

INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear ,Semester ,ID_ClassType ,ID_ClassLevel)
VALUES  ( N'c5' , N'Anh văn Toeic Nâng cao 1' , 0 , '19:30',N'Thứ 6',N'Chủ Nhật',2017 ,1 , N'ct3' , N'cl3')

INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear ,Semester ,ID_ClassType ,ID_ClassLevel)
VALUES  ( N'c6' , N'Anh văn giao tiếp Nâng cao 1' , 0 , '20:00',N'Thứ 3',N'Thứ 5',2017 ,1 , N'ct1' , N'cl3')

INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear ,Semester ,ID_ClassType ,ID_ClassLevel)
VALUES  ( N'c7' , N'Anh văn Ielts Trung bình 1' , 0 , '18:30',N'Thứ 2',N'Thứ 6',2017 ,1 , N'ct4' , N'cl2')

GO
INSERT dbo.ACCOUNT ( UserName, SPassword, Permission )
VALUES  ( 'admin','admin', 1 )

GO
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv1' , N'Lê Quang Anh' , N'Nam' , '1997-06-03' , '0987665787' , N'Thủ Đức')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv2' , N'Nguyễn Xuân Nhã' , N'Nam' , '1998-07-13' , '0908767800' , N'Quận 1')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv3' , N'Vũ Thu Phương' , N'Nữ' , '1990-10-05' , '0979565421' , N'Quận 12')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv4' , N'Nguyễn Minh' , N'Nam' , '1997-05-16' , '01689090876' , N'Thủ Đức')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv5' , N'Trương Thị Kim Chi' , N'Nữ' , '1995-07-03' , '0988127892' , N'Quận 1')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv6' , N'Mạc Linh Ngọc' , N'Nữ' , '1999-06-15' , '01977656765' , N'Tân Bình')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv7' , N'Châu Ngọc Quang' , N'Nam' , '1990-08-19' , '0977556545' , N'Phú Nhuận')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv8' , N'Trương Vô Kị' , N'Nam' , '1997-12-12' , '0986123432' , N'Thủ Đức')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv9' , N'Cao Toàn Mỹ' , N'Nam' , '1995-05-19' , '01982453241' , N'Quận 12')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv10' , N'Hoàng Ngọc Thảo' , N'Nữ' , '1997-02-22' , '0987668900' , N'Quận 2')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv11' , N'Lê Quốc Bửu' , N'Nam' , '1996-10-03' , '0986675717' , N'Tân Bình')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv12' , N'Tạ Quốc' , N'Nam' , '1998-06-23' , '0998789210' , N'Hiệp Bình Chánh')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv13' , N'Lê Diệu Linh' , N'Nữ' , '1994-05-05' , '0977567321' , N'Quận 12')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv14' , N'Nguyễn Minh Toàn' , N'Nam' , '2000-09-16' , '01689090980' , N'Thủ Đức')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv15' , N'Trịnh Kim Hồng' , N'Nữ' , '1997-08-24' , '0989098780' , N'Quận 3')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv16' , N'Hoàng Minh Hữu' , N'Nam' , '1996-06-15' , '01909876590' , N'Tân Bình')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv17' , N'Nguyễn Quang Minh' , N'Nam' , '1994-11-20' , '0977980878' , N'Phú Nhuận')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv18' , N'Bách Thiệu Quế' , N'Nữ' , '1997-01-10' , '0986133423' , N'Quận 10')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv19' , N'Linh Ngọc Đàm' , N'Nữ' , '1996-05-19' , '0198233909' , N'Quận 12')
INSERT dbo.STUDENT( ID_Student , Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
VALUES  ( 'hv20' , N'Thái Minh Tuấn' , N'Nam' , '1993-12-01' , '0987687921' , N'Quận 3')

GO
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv1' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv2' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv3' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv4' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv5' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv6' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv7' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv8' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv9' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '18:00' , N'Thứ 3' , N'Thứ 5' , '2017-11-30' , 'hv10' , 'ct1' , 1500000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv11' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv12' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv13' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv14' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv15' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv16' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv17' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv18' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv19' , 'ct3' , 3000000 )
INSERT dbo.REGISTER( Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType ,Fee)
VALUES  ( '19:30' , N'Thứ 5' , N'Thứ 7' , '2017-12-05' , 'hv20' , 'ct3' , 3000000 )

GO
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 190, 'hv1')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 150, 'hv2')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 200, 'hv3')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 130, 'hv4')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 100, 'hv5')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 80, 'hv6')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 230, 'hv7')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 110, 'hv8')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 200, 'hv9')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 160, 'hv10')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 100, 'hv11')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 240, 'hv12')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 200, 'hv13')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 170, 'hv14')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 180, 'hv15')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 100, 'hv16')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 90, 'hv17')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 60, 'hv18')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 140, 'hv19')
INSERT dbo.INPUT_EXAM( Point, ID_Student )
VALUES  ( 130, 'hv20')

GO
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv1' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv2' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv3' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv4' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv5' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv6' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv7' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv8' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv9' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv10' , 'c1' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv11' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv12' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv13' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv14' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv15' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv16' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv17' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv18' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv19' , 'c4' , N'Thi đạt' , GETDATE())
INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
VALUES  ( 'hv20' , 'c4' , N'Thi đạt' , GETDATE())

GO
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv1' , 'c1' , 10 , 170 , 180 , 190 , 200 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv1' , 'c1' , 20 , 150 , 170 , 200 , 210 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv1' , 'c1' , 20 , 190 , 160 , 170 , 190 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv2' , 'c1' , 30 , 150 , 160 , 130 , 150 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv2' , 'c1' , 30 , 120 , 150 , 180 , 170 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv2' , 'c1' , 20 , 160 , 170 , 180 , 180 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv3' , 'c1' , 30 , 150 , 130 , 130 , 140 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv3' , 'c1' , 10 , 100 , 90 , 190 , 170 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv3' , 'c1' , 0 , 180 , 130 , 120 , 150 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv4' , 'c1' , 20 , 90 , 120 , 130 , 110 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv4' , 'c1' , 10 , 100 , 110 , 130 , 100 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv4' , 'c1' , 10 , 110 , 140 , 120 , 90 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv5' , 'c1' , 30 , 200 , 190 , 180 , 100 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv5' , 'c1' , 30 , 190 , 190 , 180 , 110 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv5' , 'c1' , 30 , 170 , 180 , 180 , 130 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv6' , 'c1' , 20 , 180 , 170 , 150 , 140 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv6' , 'c1' , 10 , 150 , 170 , 150 , 150 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv6' , 'c1' , 0 , 130 , 180 , 170 , 170 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv7' , 'c1' , 20 , 170 , 170 , 160 , 190 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv7' , 'c1' , 10 , 160 , 170 , 180 , 150 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv7' , 'c1' , 30 , 150 , 160 , 180 , 190 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv8' , 'c1' , 20 , 180 , 170 , 150 , 170 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv8' , 'c1' , 20 , 150 , 170 , 160 , 160 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv8' , 'c1' , 20 , 170 , 190 , 170 , 140 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv9' , 'c1' , 10 , 170 , 140 , 150 , 140 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv9' , 'c1' , 20 , 150 , 150 , 130 , 150 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv9' , 'c1' , 30 , 130 , 150 , 140 , 170 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv10' , 'c1' , 20 , 180 , 160 , 150 , 140 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv10' , 'c1' , 10 , 160 , 170 , 190 , 150 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv10' , 'c1' , 30 , 180 , 180 , 170 , 170 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv11' , 'c4' , 30 , 160 , 200 , 190 , 180 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv11' , 'c4' , 30 , 150 , 160 , 190 , 200 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv11' , 'c4' , 10 , 170 , 160 , 180 , 190 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv12' , 'c4' , 20 , 120 , 130 , 150 , 120 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv12' , 'c4' , 20 , 140 , 150 , 150 , 140 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv12' , 'c4' , 10 , 160 , 170 , 140 , 160 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv13' , 'c4' , 30 , 150 , 150 , 170 , 180 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv13' , 'c4' , 20 , 150 , 190 , 170 , 170 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv13' , 'c4' , 20 , 180 , 180 , 180 , 200 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv14' , 'c4' , 20 , 90 , 100 , 100 , 110 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv14' , 'c4' , 10 , 120 , 110 , 100 , 100 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv14' , 'c4' , 10 , 110 , 140 , 120 , 130 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv15' , 'c4' , 20 , 200 , 190 , 180 , 100 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv15' , 'c4' , 30 , 190 , 190 , 180 , 110 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv15' , 'c4' , 10 , 170 , 180 , 180 , 130 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv16' , 'c4' , 20 , 150 , 170 , 170 , 140 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv16' , 'c4' , 10 , 150 , 180 , 160 , 180 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv16' , 'c4' , 10 , 160 , 180 , 170 , 190 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv17' , 'c4' , 20 , 170 , 170 , 160 , 190 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv17' , 'c4' , 10 , 160 , 170 , 180 , 150 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv17' , 'c4' , 30 , 150 , 160 , 180 , 190 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv18' , 'c4' , 20 , 180 , 170 , 150 , 170 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv18' , 'c4' , 20 , 150 , 170 , 160 , 160 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv18' , 'c4' , 20 , 170 , 190 , 170 , 140 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv19' , 'c4' , 10 , 170 , 140 , 150 , 140 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv19' , 'c4' , 20 , 150 , 150 , 130 , 150 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv19' , 'c4' , 30 , 130 , 150 , 140 , 170 , 3 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv20' , 'c4' , 20 , 160 , 170 , 200 , 180 , 1 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv20' , 'c4' , 10 , 170 , 170 , 180 , 190 , 2 )
INSERT dbo.STUDYING_PROCESS( ID_Student ,ID_Class ,Hard_Point ,Listening ,Reading ,Writing ,Speaking ,SMonth)
VALUES  ( 'hv20' , 'c4' , 30 , 170 , 180 , 170 , 170 , 3 )

GO
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv1' , 'c1' , 700 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv2' , 'c1' , 800 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv3' , 'c1' , 750 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv4' , 'c1' , 680 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv5' , 'c1' , 900 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv6' , 'c1' , 690 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv7' , 'c1' , 740 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv8' , 'c1' , 730 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv9' , 'c1' , 680 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv10' , 'c1' , 890 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv11' , 'c4' , 750 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv12' , 'c4' , 830 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv13' , 'c4' , 700 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv14' , 'c4' , 810 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv15' , 'c4' , 690 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv16' , 'c4' , 600 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv17' , 'c4' , 580 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv18' , 'c4' , 700 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv19' , 'c4' , 690 , N'Đạt')
INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
VALUES  ( 'hv20' , 'c4' , 760 , N'Đạt')

GO
------------------------- các hàm thực thi ---------------------------
CREATE FUNCTION checkLogin (@username CHAR(8), @password CHAR(8)) -- hàm kiểm tra đăng nhập
RETURNS INT 
AS
BEGIN
	DECLARE @permission INT
	SELECT @permission = Permission FROM dbo.ACCOUNT
	WHERE UserName = @username AND SPassword = @password
	IF @permission IS NULL
		RETURN 0
	RETURN @permission
END 

GO
CREATE FUNCTION countStudentTotal(@classid CHAR(10)) -- hàm đếm số lượng sinh viên 1 lớp
RETURNS INT
AS
BEGIN
	DECLARE @total INT
	SELECT @total = Total FROM dbo.CLASS WHERE ID_Class = @classid
	RETURN @total
END

GO
CREATE FUNCTION countClassinClassType(@classtypeid CHAR(10)) -- hàm đếm số lượng lớp trong 1 class type
RETURNS INT
AS
BEGIN
	DECLARE @total INT
	SELECT @total = COUNT(ID_Class) FROM dbo.CLASS WHERE ID_ClassType = @classtypeid
	RETURN @total
END

GO
CREATE FUNCTION getClassTypeName(@idclasstype NCHAR(10)) -- hàm lấy tên lớp theo mã lớp
RETURNS NVARCHAR(30)
AS
BEGIN
	DECLARE @name NVARCHAR(30)
	SELECT @name = ClassType_Name FROM dbo.CLASSTYPE WHERE ID_ClassType = ID_ClassType
	RETURN @name
END

GO
CREATE FUNCTION GetSemester(@m INT) -- hàm chọn kỳ học 
RETURNS INT
AS
BEGIN
	DECLARE @sem INT
	IF(@m >= 1 AND @m <= 3)
		SET @sem = 1
	ELSE IF (@m >=4 AND @m <= 6)
		SET @sem = 2
	ELSE IF (@m >= 7 AND @m <= 9)
		SET @sem = 3
	ELSE IF (@m >= 10 AND @m <= 12)
		SET @sem = 4
	RETURN @sem
END

GO
CREATE FUNCTION SetLevelByPoint(@point INT) -- chọn level theo điểm
RETURNS INT
AS
BEGIN
	IF @point >= 0 AND @point <= 250
		RETURN 1
	ELSE IF @point >250 AND @point <= 500
		RETURN 2
	ELSE IF @point > 500 AND @point <= 1000
		RETURN 3
	RETURN 0
END

GO
CREATE FUNCTION GetClassLevelID(@point INT) -- lấy ra level lớp theo điểm thi đầu vào 
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @level INT, @classlevelid CHAR(10)
	SET @level = dbo.SetLevelByPoint(@point)
	SET @classlevelid = (SELECT ID_CLassLevel FROM dbo.CLASSLEVEL WHERE Class_Level = @level)
	RETURN @classlevelid
END

GO
CREATE FUNCTION CheckProcessPoint(@studentid CHAR(10), @classid CHAR(10)) -- hàm tính điểm quá trình
RETURNS INT
AS
BEGIN
	DECLARE @total INT, @hardpoint INT, @listening INT, @reading INT , @writing INT, @speaking INT
	SET @hardpoint = (SELECT SUM(Hard_Point) FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid)
	SET @listening = (SELECT SUM(Listening) FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid)
	SET @reading = (SELECT SUM(Reading) FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid)
	SET @writing = (SELECT SUM(Writing) FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid)
	SET @speaking = (SELECT SUM(Speaking) FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid)
	SET @total = (@listening + @reading + @writing + @speaking)/3 + @hardpoint/3
	IF(@total > 1000)
		SET @total = 1000
	RETURN @total
END

GO
CREATE FUNCTION CheckProcessPointEqualZero(@studentid CHAR(10), @classid CHAR(10)) -- hàm kiểm tra điểm quá trình nhập đủ chưa
RETURNS INT
AS
BEGIN
	DECLARE @total INT, @month1 INT, @month2 INT , @month3 INT
	SET @month1 = (SELECT SUM(Listening) + SUM(Reading) + SUM(Writing) + SUM(Speaking) 
	FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid AND SMonth = 1)
	SET @month2 = (SELECT SUM(Listening) + SUM(Reading) + SUM(Writing) + SUM(Speaking) 
	FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid AND SMonth = 2)
	SET @month3 = (SELECT SUM(Listening) + SUM(Reading) + SUM(Writing) + SUM(Speaking) 
	FROM dbo.STUDYING_PROCESS WHERE ID_Student = @studentid AND ID_Class = @classid AND SMonth = 3)
	SET @total = @month1 + @month2 + @month3
	IF @month1 = 0 OR @month2 = 0 OR @month3 = 0 OR @total = 0
		RETURN 0
	RETURN 1
END

GO
CREATE FUNCTION CheckGraduationForNewRegister(@studentid CHAR(10),@classid CHAR(10)) -- kiểm tra học viên tốt nghiệp 1 lớp hay chưa 
RETURNS INT
AS
BEGIN
	DECLARE @status NVARCHAR(20)
	SET @status = (SELECT Graduation FROM dbo.OUTPUT_EXAM WHERE ID_Student = @studentid AND ID_Class = @classid)
	IF @status = N'Không đạt' OR @status = N'Đạt' OR @status = N'Bỏ thi'
		RETURN 1 -- có thi tốt nghiệp
	RETURN 0 -- chưa thi tốt nghiệp
END

GO
CREATE FUNCTION CountStudentInClass(@classid CHAR(10)) -- đếm số lượng sinh viên 1 lớp đủ 10 người chưa 
RETURNS INT
AS
BEGIN
	DECLARE @total INT
	SET @total = (SELECT Total FROM dbo.CLASS WHERE ID_Class = @classid)
	RETURN @total
END

GO
CREATE FUNCTION countRegisterNumber(@studentID CHAR(10))
RETURNS INT
AS
BEGIN
	DECLARE @total INT
	SET @total = (SELECT COUNT(ID_Register) FROM dbo.REGISTER WHERE ID_Student = @studentID)
	RETURN @total
END
GO
CREATE FUNCTION CountStudentInBlackList(@studentID CHAR(10), @classID CHAR(10))
RETURNS INT
AS
BEGIN
	DECLARE @total INT
	SET @total = (SELECT COUNT(ID_BlackList) FROM dbo.BLACKLIST 
	WHERE ID_Student = @studentID AND ID_Class = @classID)
	IF @total >= 1
		RETURN 1
	RETURN 0
END
--------------------------- các hàm thực thi -------------------------------


GO
---------------------------- các trigger thực thi ---------------------------
CREATE TRIGGER trgDeleteClassType -- trigger xóa 1 loại lớp khi chưa mở lớp nào
ON dbo.CLASSTYPE 
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @id NCHAR(10), @num int
	SELECT @id = Deleted.ID_ClassType FROM Deleted
	SELECT @num = dbo.countClassinClassType(@id)
	IF(@num = 0)
		DELETE dbo.CLASSTYPE WHERE ID_ClassType = @id
	ELSE
		BEGIN
			RAISERROR('Không thể xóa loại lớp đang có lớp giảng dạy',16,1)
			ROLLBACK TRAN
		END
END

GO
CREATE TRIGGER trgDeleteClass -- trigger xóa 1 lớp học khi chưa có học viên đăng ký
ON dbo.CLASS
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @id NCHAR(10), @num int
	SELECT @id = Deleted.ID_Class FROM Deleted
	SELECT @num = dbo.countStudentTotal(@id)
	IF(@num = 0)
		DELETE dbo.CLASS WHERE ID_Class = @id
	ELSE
		BEGIN
			RAISERROR('Không thể huỷ lớp đang đã có sinh viên đăng ký',16,1)
			ROLLBACK TRAN
		END
END

GO
CREATE TRIGGER trgPickClassForStudentByRegister -- trigger tăng sĩ số lớp học khi chọn lớp 
ON dbo.STUDYING
FOR INSERT
AS
BEGIN
	DECLARE @total INT, @id CHAR(10)
	SET @id = (SELECT Inserted.ID_Class FROM Inserted)
	SET @total = (SELECT Total FROM dbo.CLASS WHERE ID_Class = @id)
	IF @total < 10
		UPDATE dbo.CLASS SET Total = Total + 1 WHERE ID_Class = @id
	ELSE
		ROLLBACK TRAN
END

GO
CREATE TRIGGER trgCreateProcess -- trigger tạo quá trình học 
ON dbo.STUDYING
FOR INSERT
AS
BEGIN
	DECLARE @studentid CHAR(10), @classid CHAR(10)
	SET @studentid = (SELECT Inserted.ID_Student FROM Inserted)
	SET @classid = (SELECT Inserted.ID_Class FROM Inserted)

	INSERT dbo.STUDYING_PROCESS
	VALUES  ( @studentid , @classid , 0 ,0 ,0 , 0 , 0 , 1)
	INSERT dbo.STUDYING_PROCESS
	VALUES  ( @studentid , @classid , 0 ,0 ,0 , 0 , 0 , 2)
	INSERT dbo.STUDYING_PROCESS
	VALUES  ( @studentid , @classid , 0 ,0 ,0 , 0 , 0 , 3)
	INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
	VALUES  ( @studentid , @classid , 0 , N'Chưa thi')
END

GO
CREATE TRIGGER trgUpdateOutputPoint  -- trigger cập nhật điểm + kết quả thi 
ON dbo.OUTPUT_EXAM
INSTEAD OF UPDATE
AS
BEGIN
	-- làm việc với điểm cuối khóa
	DECLARE @classid CHAR(10), @studentid CHAR(10), @point INT
	SET @point = (SELECT Inserted.Point FROM Inserted)
	SET @classid = (SELECT Deleted.ID_Class FROM Deleted)
	SET @studentid = (SELECT Deleted.ID_Student FROM Deleted)

	-- làm việc với điểm quá trình
	DECLARE @hpoint INT
	SET @hpoint = dbo.CheckProcessPoint(@studentid,@classid)

	-- tính toán
	DECLARE @final INT
	SET @final = (@point + @hpoint)/2

	IF @final >= 0 AND @final < 500
		BEGIN
		UPDATE dbo.OUTPUT_EXAM SET Point = @point, Graduation = N'Không đạt'
		WHERE ID_Student = @studentid AND ID_Class = @classid
		UPDATE dbo.STUDYING SET SStatus = N'Thi không đạt'
		WHERE ID_Student = @studentid AND ID_Class = @classid
		END
	ELSE IF @final >= 500 AND @final <= 1000
		BEGIN
		UPDATE dbo.OUTPUT_EXAM SET Point = @point, Graduation = N'Đạt'
		WHERE ID_Student = @studentid AND ID_Class = @classid
		UPDATE dbo.STUDYING SET SStatus = N'Thi đạt'
		WHERE ID_Student = @studentid AND ID_Class = @classid
		END
	ELSE
		RAISERROR('Cập nhật điểm thi thất bại!',16,1)
		ROLLBACK TRAN
END

GO
CREATE TRIGGER trgCheckNumber -- trigger kiểm tra số điện thoại trùng
ON dbo.STUDENT
FOR INSERT
AS
BEGIN
	DECLARE @phone CHAR(12), @studentid CHAR(10), @count INT
	SET @studentid = (SELECT Inserted.ID_Student FROM Inserted)
	SET @phone = (SELECT Inserted.PhoneNumber FROM Inserted)
	SET @count = (SELECT COUNT(PhoneNumber) FROM STUDENT WHERE PhoneNumber = @phone)
	IF @count >= 2
		UPDATE dbo.STUDENT SET PhoneNumber = NULL WHERE dbo.STUDENT.ID_Student = @studentid
END

GO
CREATE TRIGGER trgUpdateStudentQuitExam -- trigger update trạng thái và điểm của sinh viên
ON dbo.BLACKLIST
AFTER INSERT
AS
BEGIN
	DECLARE @studentID CHAR(10), @classID CHAR(10)
	SET @studentID = (SELECT Inserted.ID_Student FROM Inserted)
	SET @classID = (SELECT Inserted.ID_Class FROM Inserted)
	DELETE dbo.OUTPUT_EXAM WHERE ID_Student = @studentID AND ID_Class = @classID
	INSERT dbo.OUTPUT_EXAM( ID_Student ,ID_Class ,Point ,Graduation)
	VALUES  ( @studentID , @classID , 0 , N'Bỏ thi')
	UPDATE dbo.STUDYING SET SStatus = N'Bỏ thi'
	WHERE ID_Student = @studentID AND ID_Class = @classID
	--UPDATE dbo.OUTPUT_EXAM SET Point = 0, Graduation = N'Bỏ thi' WHERE ID_Student = @studentID AND ID_Class = @classID	
END

------------------------------- các trigger thực thi --------------------------

GO
------------------------------ các stored procedure thực thi --------------------
CREATE PROCEDURE spResetPassword(@username CHAR(8))  -- reset password 
AS
BEGIN
	UPDATE dbo.ACCOUNT SET SPassword = '123' WHERE UserName = @username
END

GO
CREATE PROCEDURE spGetListClassLevel -- lấy danh sách cấp lớp
AS
BEGIN
	SELECT ID_CLassLevel,ClassLevel_Name,Class_Level FROM dbo.CLASSLEVEL
END

GO
CREATE PROCEDURE spGetListClassType -- lấy danh sách loại lớp 
AS
BEGIN
	SELECT ID_ClassType,ClassType_Name FROM dbo.CLASSTYPE
END

GO
CREATE PROCEDURE spAddClassType -- thêm loại lớp học 
@idClassType NCHAR(10), @classTypeName NVARCHAR(30)
AS
BEGIN
	INSERT dbo.CLASSTYPE VALUES ( @idClassType,@classTypeName)
END

GO
CREATE PROCEDURE spEditClassType -- chỉnh sửa loại lớp
@idClassType NCHAR(10),@classTypeName NCHAR(30)
AS
BEGIN
	UPDATE dbo.CLASSTYPE SET ClassType_Name = @classTypeName WHERE ID_ClassType = @idClassType
END

GO
CREATE PROCEDURE spGetListClass(@classtypeid CHAR(10)) -- lấy list lớp học
AS
BEGIN
	SELECT ID_Class,Class_Name,Total,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear,Semester,
	CLASS.ID_ClassType,ClassType_Name,CLASS.ID_ClassLevel,ClassLevel_Name,Class_Level 
	FROM dbo.CLASS,dbo.CLASSTYPE,dbo.CLASSLEVEL 
	WHERE CLASS.ID_ClassType = @classtypeid 
	AND CLASS.ID_ClassType = CLASSTYPE.ID_ClassType
	AND CLASS.ID_ClassLevel = CLASSLEVEL.ID_CLassLevel
END

GO
CREATE PROCEDURE spAddClass -- thêm lớp học 
@idclass CHAR(10),
@className NVARCHAR(30),
@studyingTime TIME(7),
@date1 NVARCHAR(20),
@date2 NVARCHAR(20),
@idclasstype NCHAR(10),
@idclasslevel NCHAR(10)
AS
BEGIN
	INSERT dbo.CLASS( ID_Class ,Class_Name ,Total ,Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,SYear ,
	Semester ,ID_ClassType ,ID_ClassLevel)
	VALUES  ( @idclass ,  @className ,0 ,@studyingTime , @date1 , @date2 ,YEAR(GETDATE()) , 
	dbo.GetSemester(MONTH(GETDATE())) , @idclasstype ,  @idclasslevel )
END

GO
CREATE PROCEDURE spEditClass -- chỉnh sửa thông tin lớp học (đối với lớp chưa có học viên)
@idclass CHAR(10),
@className NVARCHAR(30),
@studyingTime TIME(7),
@date1 NVARCHAR(20),
@date2 NVARCHAR(20),
@idclasstype CHAR(10),
@idclasslevel CHAR(10)
AS
BEGIN
	DECLARE @total INT
	SELECT @total = Total FROM dbo.CLASS WHERE ID_Class = @idclass
	IF(@total = 0)
	   UPDATE dbo.CLASS SET Class_Name = @className, Studying_Time = @studyingTime, Date_of_Week_1 = @date1,
	   Date_of_Week_2 = @date2, ID_ClassType = @idclasstype, ID_ClassLevel = @idclasslevel
	   WHERE ID_Class = @idclass
END

GO
CREATE PROCEDURE spAddNewStudent
@studentid CHAR(10),@studentname NVARCHAR(60),@gender NVARCHAR(10),@birthday DATE,@phone NCHAR(12),@address NVARCHAR(50),
@studyingtime TIME(7),@date1 NVARCHAR(20), @date2 NVARCHAR(20),@inputdate DATE,@classtypeid CHAR(10),
@fee NUMERIC(18,0)
AS
BEGIN
	INSERT dbo.STUDENT( ID_Student ,Name ,Gender ,Birthday ,PhoneNumber ,SAddress)
	VALUES  ( @studentid , @studentname , @gender , @birthday , @phone , @address)

	INSERT dbo.REGISTER(Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType,Fee)
	VALUES  ( @studyingtime ,  @date1 , @date2 , @inputdate , @studentid , @classtypeid, @fee )
END

GO
CREATE PROCEDURE spGetListStudent -- lấy danh sách học viên
AS
BEGIN
	SELECT ID_Student,Name,Gender,Birthday,PhoneNumber,SAddress FROM dbo.STUDENT
	ORDER BY ID_Student
END

GO
CREATE PROCEDURE spEditStudent -- chỉnh sửa thông tin học viên
@id CHAR(10),
@name NVARCHAR(60),
@gender NVARCHAR(10),
@birthday DATE,
@phone NCHAR(12),
@address NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.STUDENT SET Name = @name, Gender = @gender, Birthday = @birthday, PhoneNumber = @phone, SAddress = @address
	WHERE ID_Student = @id
END

GO
CREATE PROCEDURE spAddInputPoint -- nhập điểm thi đầu vào cho học viên, mỗi hv có 1 lần thi đầu vào
@studentid CHAR(10),
@point INT
AS
BEGIN
	DECLARE @p INT
	SELECT @p = Point FROM dbo.INPUT_EXAM WHERE ID_Student = @studentid
	IF @p IS NULL
		BEGIN
		INSERT dbo.INPUT_EXAM( Point, ID_Student )
		VALUES  ( @point, @studentid)
		END
     ELSE
		BEGIN
		UPDATE dbo.INPUT_EXAM SET Point = @point WHERE ID_Student = @studentid
		END  
END

GO
CREATE PROCEDURE spGetPointStudent -- lấy điểm học viên để kiểm tra nhập điểm hay chưa
@studentid CHAR(10)
AS
BEGIN
	SELECT Point,ID_Student FROM dbo.INPUT_EXAM WHERE ID_Student = @studentid
END

GO
CREATE PROCEDURE spPickClass -- chọn lớp cho học sinh
@studentid CHAR(10),
@classid CHAR(10)
AS
BEGIN
	DECLARE @status NVARCHAR(20), @count INT
	SET @count = (SELECT COUNT(ID_Student) FROM dbo.REGISTER where ID_Student= @studentid )
	IF @count > 1
		SET @status = N'Đăng ký cũ'
	ELSE 
		SET @status = N'Đăng ký mới' 
	INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
	VALUES  ( @studentid , @classid , @status , GETDATE())
END

GO
CREATE PROCEDURE spGetClassByStudent -- lấy danh sách lớp theo học viên
@studentid CHAR(10)
AS
BEGIN
	SELECT TOP 1 STUDYING.ID_Class,Class_Name,SStatus,Date_Receive FROM dbo.STUDYING,dbo.CLASS 
	WHERE ID_Student = @studentid
	AND CLASS.ID_Class = STUDYING.ID_Class
	ORDER BY Date_Receive DESC
END

GO
CREATE PROCEDURE spGetListClassInProcess -- lấy danh sách lớp học để load lên combobox
AS
BEGIN
	SELECT ID_Class,Class_Name,Total,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear,Semester,CLASS.ID_ClassType,
	ClassType_Name,CLASS.ID_ClassLevel,ClassLevel_Name,Class_Level 
	FROM dbo.CLASS,dbo.CLASSTYPE,dbo.CLASSLEVEL
	WHERE CLASS.ID_ClassType = CLASSTYPE.ID_ClassType
	AND CLASS.ID_ClassLevel = CLASSLEVEL.ID_CLassLevel
END

GO
CREATE PROCEDURE spGetListStudyingProcess -- lấy danh sách quá trình học
@classid CHAR(10),
@smonth INT
AS
BEGIN
	SELECT STUDENT.ID_Student,Name,Hard_Point,Listening,Reading,Writing,Speaking,SMonth FROM dbo.STUDYING_PROCESS,dbo.STUDENT 
	WHERE dbo.STUDYING_PROCESS.ID_Class = @classid 
	AND SMonth = @smonth
	AND STUDYING_PROCESS.ID_Student = STUDENT.ID_Student
END

GO
CREATE PROCEDURE spUpdateHardPoint -- cập nhật điểm chuyên cần
@classid CHAR(10),
@studentid CHAR(10),
@smonth INT,
@hardpoint float
AS
BEGIN
	UPDATE dbo.STUDYING_PROCESS SET Hard_Point = @hardpoint
	WHERE ID_Student = @studentid
	AND ID_Class = @classid
	AND SMonth = @smonth
END

GO
CREATE PROCEDURE spUpdateSkillPoint -- cập nhật điểm quá trình học viên
@classid CHAR(10),
@studentid CHAR(10),
@smonth INT,
@listening INT,
@reading INT,
@writing INT,
@speaking INT
AS
BEGIN
	UPDATE dbo.STUDYING_PROCESS SET Listening = @listening, Reading = @reading, Writing = @writing, Speaking = @speaking
	WHERE ID_Student = @studentid
	AND ID_Class = @classid
	AND SMonth = @smonth
END

GO
CREATE PROCEDURE spGetListOutputExamByClass -- lấy danh sách lớp theo bảng đầu ra
@classid CHAR(10)
AS
BEGIN
	SELECT ID_Class,OUTPUT_EXAM.ID_Student,Name,Point,Graduation FROM dbo.OUTPUT_EXAM,dbo.STUDENT
	WHERE dbo.OUTPUT_EXAM.ID_Class = @classid
	AND OUTPUT_EXAM.ID_Student = STUDENT.ID_Student
END

GO
CREATE PROCEDURE spGetListClassByRegister -- lấy danh sách lớp theo phiếu đăng ký
@studentid CHAR(10),@point INT
AS
BEGIN
	DECLARE @registerid CHAR(10)
	SET @registerid = (SELECT TOP 1 ID_Register FROM dbo.REGISTER WHERE ID_Student = @studentid -- lấy mã đăng ký mới nhất của học viên
	ORDER BY ID_Register DESC)
	SELECT ID_Class,Class_Name,CLASS.ID_ClassLevel,ClassLevel_Name,CLASS.Studying_Time,CLASS.Date_of_Week_1,CLASS.Date_of_Week_2 
	FROM dbo.CLASS,dbo.REGISTER,dbo.STUDENT,dbo.CLASSLEVEL
	WHERE ID_Register = @registerid
	AND REGISTER.ID_Student = @studentid
	AND REGISTER.ID_Student = STUDENT.ID_Student
	AND REGISTER.ID_ClassType = CLASS.ID_ClassType
	AND CLASS.Studying_Time = REGISTER.Studying_Time
	AND CLASS.Date_of_Week_1 = REGISTER.Date_of_Week_1
	AND CLASS.Date_of_Week_2 = REGISTER.Date_of_Week_2
	AND CLASS.ID_ClassLevel = dbo.GetClassLevelID(@point)
	AND CLASS.ID_ClassLevel = CLASSLEVEL.ID_CLassLevel
END

GO
CREATE PROCEDURE spGetInfoStudent  -- lấy thông tin học sinh hiển thị ra form đăng ký cũ
@studentid CHAR(10), @classid CHAR(10)
AS
BEGIN
	DECLARE @studentName NVARCHAR(60), @className NVARCHAR(30), @classtypeid CHAR(10), @classTypeName NVARCHAR(30), 
	@classlevelid CHAR(10), @classLevelName NVARCHAR(30), @countStudied INT
	SELECT @className = Class_Name FROM dbo.CLASS
	WHERE ID_Class = @classid
	SELECT @classtypeid = CLASS.ID_ClassType, @classTypeName = ClassType_Name FROM dbo.CLASS,dbo.CLASSTYPE
	WHERE ID_Class = @classid AND CLASS.ID_ClassType = CLASSTYPE.ID_ClassType
	SELECT @classlevelid = CLASS.ID_ClassLevel, @classLevelName = ClassLevel_Name FROM dbo.CLASS, dbo.CLASSLEVEL
	WHERE ID_Class = @classid AND CLASS.ID_ClassLevel = CLASSLEVEL.ID_CLassLevel
	SELECT @studentName = Name FROM dbo.STUDENT WHERE ID_Student = @studentid
	SET @countStudied = (SELECT COUNT(ID_Class) FROM dbo.STUDYING WHERE ID_Student = @studentid)
	SELECT @studentid AS ID_Student, @studentName AS Name, @classid AS ID_Class, @className AS Class_Name,
	@classtypeid AS ID_ClassType, @classTypeName AS ClassType_Name, @classlevelid AS ID_ClassLevel, 
	@classLevelName AS ClassLevel_Name, @countStudied AS CountStudied
END

GO
CREATE PROCEDURE spGetListForReRegister -- lấy danh sách lớp đăng ký hiển thị ra cho sinh viên cũ chọn lớp
@studentid CHAR(10),
@classtypeid CHAR(10),
@classlevelid CHAR(10),
@studyingtime TIME(7),
@date1 NVARCHAR(20),
@date2 NVARCHAR(20)
AS
BEGIN
	SELECT ID_Class,Class_Name,Total,Studying_Time,Date_of_Week_1,Date_of_Week_2,SYear,Semester,
	CLASS.ID_ClassType,ClassType_Name,CLASS.ID_ClassLevel,ClassLevel_Name,Class_Level 
	FROM dbo.CLASS,dbo.CLASSTYPE,dbo.CLASSLEVEL
	WHERE CLASS.ID_ClassType = @classtypeid
	AND CLASS.ID_ClassLevel = @classlevelid
	AND Studying_Time = @studyingtime
	AND Date_of_Week_1 = @date1
	AND Date_of_Week_2 = @date2
	AND CLASS.ID_ClassLevel = CLASSLEVEL.ID_CLassLevel
	AND CLASS.ID_ClassType = CLASSTYPE.ID_ClassType
	AND ID_Class NOT IN (SELECT ID_Class FROM dbo.STUDYING WHERE ID_Student = @studentid)
END

GO
CREATE PROCEDURE spRegisterForOldStudent -- đăng ký cho học viên cũ
@studentid CHAR(10), @classid CHAR(10),
@studyingtime TIME(7),@date1 NVARCHAR(20), @date2 NVARCHAR(20),@classtypeid CHAR(10),@fee NUMERIC(18,0)
AS
BEGIN
	INSERT dbo.REGISTER(Studying_Time ,Date_of_Week_1 ,Date_of_Week_2 ,Input_Exam_Date ,ID_Student ,ID_ClassType,Fee)
	VALUES  (@studyingtime ,  @date1 , @date2 , GETDATE() , @studentid , @classtypeid, @fee )

	INSERT dbo.STUDYING( ID_Student ,ID_Class ,SStatus ,Date_Receive)
	VALUES  ( @studentid , @classid , N'Đăng ký cũ' , GETDATE())
END

GO
CREATE PROCEDURE spSearchListStudent -- tìm kiếm học viên theo kí tự nhập vào
@text NVARCHAR(50)
AS
BEGIN
	SELECT ID_Student,Name,Gender,Birthday,PhoneNumber,SAddress FROM dbo.STUDENT
	WHERE ID_Student LIKE '%'+@text+'%' 
	OR Name LIKE '%'+@text+'%' 
	OR PhoneNumber LIKE '%'+@text+'%' 
	OR SAddress LIKE '%'+@text+'%'
END

GO
CREATE PROCEDURE spCheckHistoryRegisterByStudent -- lấy danh sách đăng ký của học viên
@studentID CHAR(10)
AS
BEGIN
	SELECT ID_Register,CLASSTYPE.ID_ClassType,ClassType_Name,
	Studying_Time,Date_of_Week_1,Date_of_Week_2,Input_Exam_Date,Fee
	FROM dbo.REGISTER,dbo.STUDENT,dbo.CLASSTYPE
	WHERE REGISTER.ID_Student = @studentID
	AND REGISTER.ID_Student = STUDENT.ID_Student
	AND REGISTER.ID_ClassType = CLASSTYPE.ID_ClassType
END

GO
CREATE PROCEDURE spCheckHistoryClassByStudent -- lấy danh sách lịch sử lớp học và kết quả
@studentID CHAR(10)
AS
BEGIN
	SELECT CLASS.ID_Class,Class_Name,SStatus, Date_Receive, Studying_Time,Point,Graduation 
	FROM dbo.STUDYING INNER JOIN dbo.STUDENT ON STUDENT.ID_Student = STUDYING.ID_Student
	INNER JOIN dbo.CLASS ON CLASS.ID_Class = STUDYING.ID_Class
	INNER JOIN dbo.OUTPUT_EXAM ON OUTPUT_EXAM.ID_Class = STUDYING.ID_Class AND OUTPUT_EXAM.ID_Student = STUDYING.ID_Student
	AND OUTPUT_EXAM.ID_Student = STUDENT.ID_Student AND OUTPUT_EXAM.ID_Class = CLASS.ID_Class
	WHERE STUDYING.ID_Student = @studentID
	ORDER BY Date_Receive
END

GO
CREATE PROCEDURE spSetBlackList -- thêm học viên bỏ thi vào danh sách hạn chế
@studentID CHAR(10),
@classID CHAR(10),
@reason NVARCHAR(50)
AS
BEGIN
	INSERT dbo.BLACKLIST(ID_Student ,Reason ,ID_Class)
	VALUES  ( @studentID ,  @reason , @classID)
END


GO
CREATE PROCEDURE spGetBlackList -- lấy danh sách hạn chế ra màn hình
AS
BEGIN
	SELECT ID_BlackList,BLACKLIST.ID_Student,Name,BLACKLIST.ID_Class, Class_Name, Reason 
	FROM dbo.BLACKLIST,dbo.CLASS,dbo.STUDENT
	WHERE BLACKLIST.ID_Student = STUDENT.ID_Student
	AND BLACKLIST.ID_Class = CLASS.ID_Class
END

GO
CREATE PROCEDURE spCheckExistsInBlackList
@studentID CHAR(10)
AS
BEGIN
	DECLARE @result INT
	SET @result = 0
	IF @studentID IN (SELECT ID_Student FROM dbo.BLACKLIST)
		SET @result = 1
	SELECT @result
END

---------------------------- các stored procedure thực thi -------------------------------
