create database QLSinhVien;

create table Tinh 
(
	MaTinh nvarchar(2) not null primary key,
	TenTinh nvarchar(50)
);
insert into Tinh values('18', N'Bình Định');
select *from Tinh;

create table Khoa
(
	MaKhoa nvarchar(10) not null primary key,
	TenKhoa nvarchar(50)
);
select *from Khoa;
create table Lop
(
	MaLop nvarchar(10) not null primary key,
	TenLop nvarchar(50)
);

delete from Tinh where MaTinh = 34;
update Tinh set TenTinh = N'Quảng Nam' where MaTinh = 17;
