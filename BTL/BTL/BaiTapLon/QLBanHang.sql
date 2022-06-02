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
	[Chức vụ] nvarchar,
	[Số giờ làm] int,
	[Tiền lương] int,
);
select *from NhanVien;
create table ChucVu (
	[Mã chức vụ] varchar(8) primary key,
	[Tên chức vụ] nvarchar(100),
	[Lương giờ] int
);
select *from ChucVu;
insert into ChucVu values ('CV1', N'Quản lý', 22000);
insert into ChucVu values ('CV2', N'Phục vụ', 18000);
insert into ChucVu values ('CV3', N'Bảo vệ', 15000);
insert into ChucVu values ('CV4', N'Lao công', 15000);

drop table TaiKhoan;
drop table KhoHang;
drop table SanPham;
drop table SanPhamTrongKho;
drop table NhanVien;