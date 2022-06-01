create database QLBH;
create table HANG(
	[Mã hàng] char(10) not NULL Primary Key,
	[Tên hàng] nvarchar(70),
	[Đơn giá] int,
);
delete from hang;
select * from hang;