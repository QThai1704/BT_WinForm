create database QLS;

create table Sach (
	MaSach varchar(2) not null primary key,
	TenSach nvarchar(100)
);

create table Thongtin (
	STT varchar(1000),
	HoTenSinhVien nvarchar(50),
	TenSach nvarchar(100),
	NgayTra datetime,
	NgayMuon datetime,
	ThanhTien int
);
select *from Sach;
select *from Thongtin;
drop table Sach;
