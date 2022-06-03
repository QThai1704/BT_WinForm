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
	[Tên kho] nvarchar(100)
);
select *from KhoHang;

insert into KhoHang values ('MK2', N'admin');
delete from KhoHang where [Mã kho] = 'MK01';
create table SanPham (
	[Mã sản phẩm] varchar(10) primary key,
	[Tên sản phẩm] nvarchar(100),
	[Đơn giá] bigint
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
select *from SanPhamTrongKho where [Tên sản phẩm] = N'Giày Puma';



create table KhachHang (
	[Mã khách hàng] varchar(10) primary key,
	[Tên khách hàng] nvarchar(100),
	[Số điện thoại] varchar(10),
	[Địa chỉ] nvarchar(100)
);
select *from KhachHang;

create table HoaDon (
	[Mã hóa đơn] varchar(10) primary key,
	[Mã khách hàng] varchar(10),
	[Tên khách hàng] nvarchar(100),
	[Ngày tạo hóa đơn] date,
	foreign key ([Mã khách hàng]) references KhachHang([Mã khách hàng])
);
select *from HoaDon;

create table CTHoaDon (
	[Mã hóa đơn] varchar(10),
	[Tên sản phẩm] nvarchar(100),
	[Số lượng] int,
	[Ngày mua] date,
	[Giá bán] bigint,
	[Thành tiền] bigint,
	foreign key ([Mã hóa đơn]) references HoaDon([Mã hóa đơn])
);
select *from CTHoaDon;

drop table TaiKhoan;
drop table KhoHang;
drop table SanPham;
drop table SanPhamTrongKho;
drop table KhachHang;
drop table HoaDon;
drop table CTHoaDon;