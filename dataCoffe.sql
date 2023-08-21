create database qlcf
use qlcf
/*bang ban*/
create table ban
(
banid nvarchar(10) primary key,
tenban nvarchar(10) not null
)
/*bang thuc don*/
create table thucdon
(
douongid nvarchar(10) primary key,
tendouong nvarchar(50),
dongia float
)
/*bang goi mon*/
create table goimon
(
goiid nvarchar(10) primary key,
douongid nvarchar(10),
banid nvarchar(10),
soluong int
)
/*du lieu demo bang thuc don*/
insert into thucdon 
values('CF001',N'Cà phê đen','10000'),
      ('CF002',N'Cà Phê sữa','15000'),
	  ('CF003',N'Cà phê đá','12000');
                  
--bảng bàn
insert into ban
values('B01',N'Bàn 1'),
      ('B02',N'Bàn 2'),
	  ('B03',N'Bàn 3'),
	  ('B04',N'Bàn 4'),
	  ('B05',N'Bàn 5'),
	  ('B06',N'Bàn 6');
--bảng gọi món
insert into goimon(goiid,douongid,banid,soluong)
values('G001','CF001','B01','3'),
      ('G002','CF002','B02','2');