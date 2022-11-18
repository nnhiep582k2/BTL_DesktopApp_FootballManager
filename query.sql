
select TranDau_CauThu.MaTD, TenDoi from TranDau_CauThu join TranDau on TranDau.MaTD = TranDau_CauThu.MaTD join DoiBong on DoiBong.MaDoi = TranDau.MaDoiKhach or DoiBong.MaDoi = TranDau.MaDoiNha where TranDau_CauThu.MaTD = 'TD01'

select TenDoi,TenCT,MaVitri,NgaySinh,SoAo,CauThu.SoBanThang,CauThu.SoTheVang,CauThu.SoTheDo,MaQuocTich,SoLanRaSan,Anh
from CauThu join DoiBong on DoiBong.MaDoi = CauThu.MaDoi
where TenDoi = 'Arsenal'

select TenCT,MaVitri,NgaySinh,SoAo,CauThu.SoBanThang,CauThu.SoTheVang,CauThu.SoTheDo,MaQuocTich,SoLanRaSan,Anh from CauThu join TranDau_BanThang on TranDau_BanThang.MaCT = CauThu.MaCT where TranDau_BanThang.MaTD = 'TD03'

select * from TranDau
select * from TranDau_CauThu
select * from DoiBong

select * from CauThu join DoiBong on DoiBong.MaDoi = CauThu.MaDoi where TenDoi = 'Arsenal'



select top(3) with ties MaCT,TenCT,MaViTri,NgaySinh,SoAo,CauThu.SoBanThang,SoTheVang,SoTheDo,MaQuocTich,SoLanRaSan,TenDoi,HLV from CauThu
join DoiBong on DoiBong.MaDoi = CauThu.MaDoi order by CauThu.SoBanThang desc






--câu 2: 
go
create or alter trigger DoiBong_SoLuongCauThu on CauThu for insert, update , delete
as
begin

	declare @MaDoi1 nvarchar(20), @in1 int ,  @MaDoi2 nvarchar(20), @de2 int
	select @MaDoi1 = inserted.MaDoi , @in1 = 1
	from inserted 

	select @MaDoi2 = deleted.MaDoi , @de2 = 1
	from deleted

	update DoiBong
	set SoLuongCT = ISNULL(SoLuongCT,0) + ISNULL(@in1,0) -  ISNULL(@de2,0)
	where MaDoi = ISNULL(@MaDoi1,@MaDoi2)
end

select * from CauThu
select * from DoiBong

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT12','DB09',N'Xavi','AM','1995-09-10','1','QT04',NULL)
INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT13','DB09',N'NNH','CB','1995-09-10','1','QT04',NULL)
delete from CauThu
where MaCT = 'CT13'


-- câu 3:
go
create trigger CauThu_TranDau on TranDau_CauThu for insert, update, delete
as
begin
	update CauThu
	set SoLanRaSan = isnull(SoLanRaSan, 0) + 1 
	from inserted
	where inserted.MaCT = CauThu.MaCT

	update CauThu
	set SoLanRaSan = isnull(SoLanRaSan, 0) - 1 
	from deleted
	where deleted.MaCT = CauThu.MaCT
end

insert into TranDau_CauThu values ('TD02', 'CT03')
select * from TranDau_CauThu
select * from CauThu

delete from TranDau_CauThu
where MaTD = 'TD02' and MaCT = 'CT03'

update TranDau_CauThu
set MaCT = 'CT04'
where MaTD = 'TD02' and MaCT = 'CT03'



--cau 4:

go
create or alter trigger DoiBong_Ban on TranDau_BanThang for insert, update, delete
as
begin
	declare @mact nvarchar(30), @sluong int, @madk nvarchar(30), @madn nvarchar(30), @madoi nvarchar(30), @sbthang int, @sbthua int
	declare @mact2 nvarchar(30), @sluong2 int, @madk2 nvarchar(30), @madn2 nvarchar(30), @madoi2 nvarchar(30), @sbthang2 int, @sbthua2 int
	
	select @mact = MaCT, @sluong = SoLuong from inserted
	select @mact2 = MaCT, @sluong2 = SoLuong from deleted

	select @madoi = madoi from CauThu where MaCT = @mact
	select @madoi2 = madoi from CauThu where MaCT = @mact2

	if not exists(select 'true' from inserted join TranDau on inserted.MaTD = TranDau.MaTD where @maDoi = MaDoiKhach or @maDoi = MaDoiNha ) and (not exists(select 'true' from deleted join TranDau on deleted.MaTD = TranDau.MaTD where @maDoi2 = MaDoiKhach or @maDoi2 = MaDoiNha ))
		begin
			raiserror('Đội bóng này không nằm trong trận đấu đó, bạn hãy thêm đội bóng khác cho phù hợp',16,1)
			rollback tran 
		end 
	else
		begin
			update CauThu
			set SoBanThang = SoBanThang + @sluong
			where MaCT = @mact
			
			update CauThu
			set SoBanThang = SoBanThang - @sluong2
			where MaCT = @mact2

			select @madk = madoikhach, @sbthang = SoBanThangDoiNha from inserted join trandau on inserted.matd = trandau.matd
			select @madn = madoinha, @sbthua = SoBanThuaDoiNha from inserted join trandau on inserted.matd = trandau.matd
			select @madk2 = madoikhach, @sbthang2 = SoBanThangDoiNha from deleted join trandau on deleted.matd = trandau.matd
			select @madn2 = madoinha, @sbthua2 = SoBanThuaDoiNha from deleted join trandau on deleted.matd = trandau.matd

			if @madoi = @madn
				begin
					update TranDau
					set SoBanThangDoiNha = SoBanThangDoiNha + @sluong
					from inserted where TranDau.MaTD = inserted.MaTD

					update DoiBong
					set SoBanThang = SoBanThang + SoBanThangDoiNha,
					SoBanThua = SoBanThua + SoBanThuaDoiNha
					from inserted join TranDau on inserted.MaTD = TranDau.MaTD
					where MaDoi = @madn

					if @sbthua <> 0
						begin
							update DoiBong
							set SoBanThua = SoBanThua + SoBanThangDoiNha
							from inserted join TranDau on inserted.MaTD = TranDau.MaTD
							where MaDoi = @madk
						end
					end

			if @madoi2 = @madn2
				begin
					if @sbthua2 <> 0
						begin
							update DoiBong
							set SoBanThua = SoBanThua - SoBanThangDoiNha
							from deleted join TranDau on deleted.MaTD = TranDau.MaTD
							where MaDoi = @madk2
						end

					update DoiBong
					set SoBanThang = SoBanThang - SoBanThangDoiNha,
					SoBanThua = SoBanThua - SoBanThuaDoiNha
					from deleted join TranDau on deleted.MaTD = TranDau.MaTD
					where MaDoi = @madn2

					update TranDau
					set SoBanThangDoiNha = SoBanThangDoiNha - @sluong2
					from deleted where TranDau.MaTD = deleted.MaTD
				end

			if @madoi = @madk
				begin
					update TranDau
					set SoBanThuaDoiNha = SoBanThuaDoiNha + @sluong
					from inserted where TranDau.MaTD = inserted.MaTD

					update DoiBong
					set SoBanThang = SoBanThang + SoBanThuaDoiNha,
					SoBanThua = SoBanThua + SoBanThangDoiNha
					from inserted join TranDau on inserted.MaTD = TranDau.MaTD
					where MaDoi = @madk
			
					if @sbthang <> 0
						begin
							update DoiBong
							set SoBanThua = SoBanThua + SoBanThuaDoiNha
							from inserted join TranDau on inserted.MaTD = TranDau.MaTD
							where MaDoi = @madn
						end
					end

			if @madoi2 = @madk2
				begin
					if @sbthang2 <> 0
						begin
							update DoiBong
							set SoBanThua = SoBanThua - SoBanThuaDoiNha
							from deleted join TranDau on deleted.MaTD = TranDau.MaTD
							where MaDoi = @madn2
						end

					update DoiBong
					set SoBanThang = SoBanThang - SoBanThuaDoiNha,
					SoBanThua = SoBanThua - SoBanThangDoiNha
					from deleted join TranDau on deleted.MaTD = TranDau.MaTD
					where MaDoi = @madk2

					update TranDau
					set SoBanThuaDoiNha = SoBanThuaDoiNha - @sluong2
					from deleted where TranDau.MaTD = deleted.MaTD
				end
		end
end	

insert into TranDau_BanThang (MaTD, MaCT, SoLuong) values ('TD01', 'CT01', 3)
insert into TranDau_BanThang (MaTD, MaCT, SoLuong) values ('TD01', 'CT02', 1)

update TranDau_BanThang
set SoLuong = 2
where MaTD = 'TD03' and MaCT = 'CT06'

update TranDau_BanThang
set SoLuong = 1
where MaTD = 'TD03' and MaCT = 'CT07'

select * from CauThu
select * from TranDau
select * from DoiBong
select * from TranDau_BanThang

delete from TranDau_BanThang where MaTD = 'TD01' and MaCT = 'CT01'
delete from TranDau_BanThang where MaTD = 'TD01' and MaCT = 'CT02'










--cau 5_ TranDau_The:
go
create or alter trigger CauThu_The on TranDau_the for insert, update, delete
as
begin

	declare @inMaCT1 nvarchar(10), @inLoaiThe1 nvarchar(10)
	declare @deMaCT2 nvarchar(10), @deLoaiThe2 nvarchar(10)


	select @inMaCT1 = inserted.MaCT , @inLoaiThe1 = inserted.LoaiThe
	from inserted

	select @deMaCT2 = deleted.MaCT , @deLoaiThe2 = deleted.LoaiThe
	from deleted 


	declare @inMaCT3 nvarchar(10), @inLoaiThe3 nvarchar(10), @inMaDoi nvarchar(20)
	declare @deMaCT4 nvarchar(10), @deLoaiThe4 nvarchar(10), @deMaDoi nvarchar(20)


	select @inMaCT3 =  inserted.MaCT , @inMaDoi  = ct.MaDoi, @inLoaiThe3 = LoaiThe
	from inserted join CauThu ct on ct.MaCT = inserted.MaCT

	select @deMaCT4 =  deleted.MaCT , @deMaDoi  = ct.MaDoi, @deLoaiThe4 = LoaiThe
	from deleted join CauThu ct on ct.MaCT = deleted.MaCT

	
	update TranDau
	set SoTheVangDoiNha = ISNULL(SoTheVangDoiNha,0) + (IIF(@inLoaiThe3=N'Thẻ vàng',1,0)) - (IIF(@deLoaiThe4=N'Thẻ vàng',1,0)) ,SoTheDoDoiNha = ISNULL(SoTheDoDoiNha,0) + (IIF(@inLoaiThe3=N'Thẻ đỏ',1,0)) - (IIF(@deLoaiThe4=N'Thẻ đỏ',1,0))
	where MaDoiNha = ISNULL(@inMaDoi,@deMaDoi)


	update TranDau
	set SoTheVangDoiKhach = ISNULL(SoTheVangDoiKhach,0) + (IIF(@inLoaiThe3=N'Thẻ vàng',1,0)) -(IIF(@deLoaiThe4=N'Thẻ vàng',1,0))  ,SoTheDoDoiKhach = ISNULL(SoTheDoDoiKhach,0) + (IIF(@inLoaiThe3=N'Thẻ đỏ',1,0)) - (IIF(@deLoaiThe4=N'Thẻ đỏ',1,0))
	where MaDoiKhach = ISNULL(@inMaDoi,@deMaDoi)


	update CauThu
	set SoTheVang = ISNULL(SoTheVang,0) + (IIF(@inLoaiThe1=N'Thẻ vàng',1,0)) - (IIF(@deLoaiThe2=N'Thẻ vàng',1,0)) ,SoTheDo = ISNULL(SoTheDo,0) + (IIF(@inLoaiThe1=N'Thẻ đỏ',1,0)) - (IIF(@deLoaiThe2=N'Thẻ đỏ',1,0))
	where MaCT = ISNULL(@inMaCT1, @deMaCT2)
end	


insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD10', 'CT06', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD09', 'CT06', N'Thẻ vàng')
select * from CauThu
select * from TranDau_The
select * from TranDau

delete from TranDau_The
where MaTD = 'TD10' and MaCT = 'CT06'


--câu 6
go
create or alter trigger DoiBong_Diem on TranDau for insert, update, delete
as
begin

	declare @MaDoiNha nvarchar(10),@MaDoiKhach nvarchar(10), @SoBanThangDoiNha int, @SoBanThuaDoiNha int,
	@MaDoiNha2 nvarchar(10),@MaDoiKhach2 nvarchar(10), @SoBanThangDoiNha2 int, @SoBanThuaDoiNha2 int

	select @MaDoiNha = inserted.MaDoiNha, @MaDoiKhach= MaDoiKhach , @SoBanThangDoiNha = inserted.SoBanThangDoiNha, @SoBanThuaDoiNha = inserted.SoBanThuaDoiNha
	from inserted 

	select @MaDoiNha2 = deleted.MaDoiNha, @MaDoiKhach2= MaDoiKhach , @SoBanThangDoiNha2 = deleted.SoBanThangDoiNha, @SoBanThuaDoiNha2 = deleted.SoBanThuaDoiNha
	from deleted 

	if	@SoBanThangDoiNha > @SoBanThuaDoiNha
		begin
			update DoiBong
			set Diem = ISNULL(Diem,0) + 3
			where MaDoi = @MaDoiNha
		end

	else if @SoBanThangDoiNha < @SoBanThuaDoiNha
		begin
			update DoiBong
			set Diem = ISNULL(Diem,0) + 3
			where MaDoi = @MaDoiKhach
		end
	
	else if @SoBanThangDoiNha = @SoBanThuaDoiNha
		begin
			update DoiBong
			set Diem = ISNULL(Diem,0) + 1
			where MaDoi = @MaDoiKhach

			update DoiBong
			set Diem = ISNULL(Diem,0) + 1
			where MaDoi = @MaDoiNha
		end

	if	@SoBanThangDoiNha2 > @SoBanThuaDoiNha2
		begin
			update DoiBong
			set Diem = ISNULL(Diem,0) - 3
			where MaDoi = @MaDoiNha2
		end

	else if @SoBanThangDoiNha2 < @SoBanThuaDoiNha2
		begin
			update DoiBong
			set Diem = ISNULL(Diem,0) - 3
			where MaDoi = @MaDoiKhach2
		end
	
	else if @SoBanThangDoiNha2 = @SoBanThuaDoiNha2
		begin
			update DoiBong
			set Diem = ISNULL(Diem,0) - 1
			where MaDoi = @MaDoiKhach2

			update DoiBong
			set Diem = ISNULL(Diem,0) - 1
			where MaDoi = @MaDoiNha2
		end

end

insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,SoBanThangDoiNha,SoBanThuaDoiNha,GhiChu) values(N'TD12',3,3,N'DB02',N'DB03',3,4,null)
insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,SoBanThangDoiNha,SoBanThuaDoiNha,GhiChu) values(N'TD13',3,3,N'DB05',N'DB06',4,4,null)
insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,SoBanThangDoiNha,SoBanThuaDoiNha,GhiChu) values(N'TD14',3,3,N'DB07',N'DB08',5,4,null)
update TranDau
set SoBanThangDoiNha = 5
where MaTD = 'TD12'

delete from TranDau
where MaTD = 'TD13'

select * from TranDau
select * from DoiBong