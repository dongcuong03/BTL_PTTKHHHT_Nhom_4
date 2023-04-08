
create database BTL_nhom4
use BTL_nhom4

drop table TaiKhoan 
create table TaiKhoan(
TenDangNhap nvarchar(50) primary key,
MatKhau nchar(10),
VaiTro nvarchar(50),
SoDienThoai nchar(10))

insert into TaiKhoan
values('lvq','123','1','0397099702')
insert into TaiKhoan
values('lvs','1234','2','0397099702')
insert into phong
values('P101')

select TenDangNhap as "Tên đăng nhập", MatKhau as "Mật Khẩu", VaiTro as "Vai trò", SoDienThoai as "Số điện thoại" from TaiKhoan
create table phong(
maphong nvarchar(30) primary key)

create table sinhhoatphi(
maphong nvarchar(30) foreign key references phong(maphong),
thang int,
tiendien int,
tiennuoc int,
tienwifi int,
tienphong int,
tongtien int)

create table themsinhvien(
msv char(20),
maphong nvarchar(30) foreign key references phong(maphong),
hoten nvarchar(50),
ngaysinh date,
gioitinh nvarchar(20),
cccd char(20),
quequan nvarchar(50),
lop char(20))

create table csvc (
maphong nvarchar(30) foreign key references phong(maphong),
cua smallint,
den smallint,
tbvs smallint,
giuong smallint,
tu smallint,
dieuhoa smallint,
wifi smallint)

drop table csvc
drop table themsinhvien
drop table sinhhoatphi
drop table phong
insert into phong
values('P101'),('P102'),('P103'),('P104'),('P105'),
('P201'),('P202'),('P203'),('P204'),('P205'),
('P301'),('302'),('P303'),('P304'),('P305'),
('P401'),('P402'),('P403'),('P404'),('P405')
delete from phong where maphong ='302'
insert into phong
values('P302')

insert into themsinhvien
values ('2151470','P103','LVA','2002/1/5','Nam','5558','TH','63fdf')