create database THQLBanHang;
create table Donhang( 
	MaHang varchar(10) not null primary key,
	TenHang nvarchar(100),
	DonGia int
);

drop table Donhang;
create table ThanhToan(
	STT varchar(1000),
	TenHang nvarchar(100),
	SoLuong int,
	DonGia int,
	ThanhTien int,
);
drop table ThanhToan;
insert into Donhang values ('MH1', N'Trà sữa chân trâu đường đen', 25000);
insert into Donhang values ('MH2', N'Hồng trà sữa', 30000);
insert into Donhang values ('MH3', N'Trà xanh', 100000);
Select DonGia from Donhang where TenHang = N'Trà xanh';
select *from Donhang;
select *from ThanhToan;