create database QuanLyBanHang;
create table TaiKhoan (
	[Tên người dùng] varchar(50) primary key,
	[Tên tài khoản] varchar(50),
	[Mật khẩu] varchar(50)
);

insert into TaiKhoan values ('admin','admin', 'admin');

select *from TaiKhoan;

create table KhoHang (
	[Mã kho] varchar(10) primary key,
	[Tên kho] nvarchar(100),
	[Ghi chú] nvarchar(150)
);

select *from KhoHang;
create table SanPham (
	[Mã sản phẩm] varchar(10) primary key,
	[Tên sản phẩm] nvarchar(100)
);

select *from SanPham;
create table SanPhamTrongKho(
	[Mã kho] varchar(10),
	[Mã sản phẩm] varchar(10),
	[Tên sản phẩm] nvarchar(100),
	[Số lượng] int,
	[Ghi chú] nvarchar(150),
	foreign key ([Mã Kho]) references KhoHang([Mã kho]),
	foreign key ([Mã sản phẩm]) references SanPham([Mã sản phẩm])
);
select *from SanPhamTrongKho;
create table NhanVien (
	[Mã nhân viên] varchar(8) primary key,
	[Tên nhân viên] nvarchar(100),
	[Số điện thoại] varchar(10),
	[Địa chỉ] nvarchar(100),
	[Ca làm] varchar,
	[Số giờ làm] int,
	[Tiền lương] int,
);
select *from NhanVien;

drop table TaiKhoan;
drop table KhoHang;
drop table SanPham;
drop table SanPhamTrongKho;
drop table NhanVien;