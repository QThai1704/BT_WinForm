create database THQLBanHang;
create table Hang( 
	[Mã hàng] varchar(10) not null primary key,
	[Tên hàng] nvarchar(100),
	[Đơn giá] bigint
);
drop table Hang;

insert into Hang values ('MH1', N'Trà sữa đường đen', 46000);
insert into Hang values ('MH2', N'Hồng trà', 32000);
insert into Hang values ('MH3', N'Trà xanh vải', 39000);
insert into Hang values ('MH4', N'Cafe hạt dẻ', 46000);
insert into Hang values ('MH5', N'Sữa chua uống vị nho', 46000);


Select [Đơn giá] from Hang where [Tên hàng] = N'Trà sữa đường đen';
select *from Hang;