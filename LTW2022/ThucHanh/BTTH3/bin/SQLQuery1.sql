create database THQLBanHang;
create table Hang( 
	MaHang varchar(10) not null primary key,
	TenHang nvarchar(100),
	DonGia int
);
drop table Hang;

create table DonHang(
	STT varchar(1000),
	TenHang nvarchar(100),
	SoLuong int,
	DonGia int,
	ThanhTien int,
);
drop table Donhang;
insert into Hang values ('MH1', N'Trà sữa đường đen', 46000);
insert into Hang values ('MH2', N'Hồng trà', 32000);
insert into Hang values ('MH3', N'Trà xanh vải', 39000);
insert into Hang values ('MH4', N'Cafe hạt dẻ', 46000);
insert into Hang values ('MH5', N'Sữa chua uống vị nho', 39000);


Select DonGia from Donhang where TenHang = N'Trà xanh';
select *from Hang;
select *from DonHang;