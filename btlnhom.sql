create table  banbomon   (
 tenban nvarchar( 50) ,  
 truongban char(10), 
 primary key ( tenban) ,
 sogvdg int 
  )
  create table admin(
  matkhau int ,
  tendangnhap nvarchar(50) references banbomon (tenban)
  )
   create table ngoaingu
(
	mann int identity ,
	tennn nvarchar(50) not null   primary key
)
 create table giaovien (
 magv char(10) primary key, 
 tengv  nvarchar(50)  ,
 ngaysinh   datetime  ,
 gioitinh  nvarchar(20)   ,
  dantoc nvarchar(50)  ,
 tongiao nvarchar(50)  , 
 quequan  nvarchar(50)  , 
 trinhdo nvarchar(50)  ,
 ngayvaolam  datetime  ,
 ngoaingu nvarchar(50)  references ngoaingu (tennn) ,
 ghichu nvarchar(50) ,
 tenban nvarchar(50) references banbomon (tenban)  
   )
alter table giaovien add   STT int identity
alter table cacmonhoc add STT int identity
 CREATE TABLE phanconggiangday
(
	magv char(10) not null, 
	tengv nvarchar(50)  ,
	tungay datetime  ,
	denngay datetime ,
	congtac nvarchar(50) ,
	ghichu nvarchar(50),
	constraint k_phanconggiangday foreign key (magv) references giaovien(magv),
	constraint pk_phanconggiangday primary key (magv )
)
  
 create table lichgiangday (
  magv char(10) primary key ,
  tengv nvarchar(50 ),
  chuyenmon  nvarchar(50),
  buoi nvarchar(50),
  gioitinh char(10) ,
  ngaysinh datetime ,
  thu char(10), 
  tiet char(10),   
  malop char(10),
  tuan char(10),
  constraint k_lichgiangday foreign key (magv) references giaovien(magv) 
  ) 
   alter table lichgiangday drop column gioitinh
  alter table lichgiangday drop column ngaysinh 
create table lichdaythay 
(
thutu  int,
tuan int ,
buoi nvarchar(50) ,
tiet char(10),
lop char(10),
magiaoviennghi char(10) references giaovien(magv) ,
magiaoviendaythay char(10) references  giaovien(magv)
)
ALTER table lichdaythay drop column thutu
ALTER table lichdaythay add  thutu int identity
ALTER table lichdaythay add  thu int
  
 create table lophoc( 
 malh char(10) primary key,
 magvcn char(10) references  giaovien(magv), 
 siso int ,
 namnhaphoc date,
 namketthuc date,
 tenban  nvarchar(50) references banbomon( tenban)  
 ) 
 create table hocsinh  (
 mahs char(10) primary key,
 malh char(10) references lophoc(malh),
 tenhs nvarchar(50),
 diachi nvarchar(50) ,
 dantoc char(10), 
 ngaysinh datetime,  
 gioitinh  nvarchar(50),
 ghichu nvarchar(50) ,
 ngaynhaptruong  date ,
 ngayratruong date ,
 suckhoe nvarchar(50) 
 ) 
    
 CREATE TABLE thannhan
(
	 
	mahs char(10) references hocsinh(mahs) ,
	hotenbo  nvarchar(50),
	ngaysinh  datetime, 
	diachi nvarchar(50),
	nghenghiep nvarchar(50),
	sodienthoai int,
	hotenme  nvarchar(50),
	ngaysinhme  datetime, 
	diachime  nvarchar(50),
	nghenghiepme nvarchar(50),
	sodienthoaime int,
 constraint fk_THANNHAN foreign key (mahs) references hocsinh(mahs) 
 )
 create table  bangdiem(
  mabd char(10) primary key ,
  mahs char(10) references hocsinh  (mahs) , 
  diemtb float , 
  diemtoan  float,
  diemvan  float,
  diemanh  float,
  diemhoa float,
  diemly float,
  diemsinh float,
  diemsu float,
  diemdia float,
  giaovienquanly char(10) references giaovien(magv)
 )
 create table cacmonhoc (
 mamh char(10) primary  key ,  
 tenmonhoc  nvarchar (50)
 )  
 create table chitietbangdiem(
 mactd char(10) primary key ,
 mahs char(10)references hocsinh(mahs), 
 mamh char(10) references cacmonhoc (mamh),
 diemmieng float,
 diem15p1 float,
 diem15p2 float,
 diem45p1 float,
 diem45p2 float,
 diemhocky float,
 diemtbmon float
 ) 
 CREATE TABLE kyluat
(

	makl int identity,  
	mahs char(10) references hocsinh(mahs),
	hinhthuc nvarchar(50) not null,
	lydo nvarchar(50) not null, 
	ngaykyluat datetime
)
alter table kyluat add ghichu nvarchar(50)
create table khenthuong 
(
    makt int identity,  
	mahs char(10) references hocsinh(mahs),
	hinhthuc nvarchar(50) not null,
	lydo nvarchar(50) not null, 
	ngaykhenthuong datetime
)
 create  table hocba(
 mahb char(10) ,
 mahs char(10) references hocsinh(mahs),
 magv char(10) references giaovien(magv),
 diemtb char(10),
 hocluc nvarchar(50),
 hanhkiem nvarchar(50), 
 kyluat nvarchar(50),
 khenthuong nvarchar(50),
 danhgiagv nvarchar(50),
 xeploai nvarchar(50),
 ghichu nvarchar(50) ,
 hocky char(50)
 )
 create table hesoluong(
 STT int identity, 
 hesoluong float)
  alter table lichgiangday drop column gioitinh
  alter table lichgiangday drop column ngaysinh 
  

 CREATE TABLE bangluong
( 
	stt int identity,	
	magv char(10)references giaovien(magv), 
	luongcoban float , 
	hesoluong float, 
	luongphucap float , 
	BaoHiemYTe float, 
	TongLuong float
	)
	ALTER table hocsinh add stt int identity