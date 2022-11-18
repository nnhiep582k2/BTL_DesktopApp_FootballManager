--create database QLGiaiBongNHA
--use QLGiaiBongNHA
--drop database QLGiaiBongNHA

create table Tinh (
	MaTinh nvarchar(10) not null primary key,
	TenTinh nvarchar(30) not null,
)



create table QuocTich (
	MaQuocTich nvarchar(10) not null primary key,
	TenQuocTich nvarchar(30) not null,
)

create table Vitri (
	MaVitri nvarchar(10) not null primary key,
	TenVitri nvarchar(30) not null,
)

create table SanBong (
	MaSan nvarchar(10) not null primary key,
	TenSan nvarchar(30) not null,
	DiaChi nvarchar(100) not null,
	SoGhe int not null,
)

create table DoiBong (
	MaDoi nvarchar(10) not null primary key,
	TenDoi nvarchar(30) not null,
	HLV nvarchar(30) not null,
	Logo image,
	Diem int default 0,
	SoBanThang int default 0,
	SoBanThua int default 0,
	SoLuongCT int default 0,
	MaSan nvarchar(10) not null UNIQUE,
	MaTinh nvarchar(10) not null,
	constraint fk_DoiBong_SanBong foreign key (MaSan) references SanBong(MaSan),
	constraint fk_DoiBong_Tinh foreign key (MaTinh) references Tinh(MaTinh)
)

create table CauThu (
	MaCT nvarchar(10) not null primary key,
	TenCT nvarchar(30) not null,
	MaVitri nvarchar(10) not null,
	NgaySinh date,
	SoAo int not null,
	SoBanThang int default 0,
	SoTheVang int default 0,
	SoTheDo int default 0,
	MaQuocTich nvarchar(10) not null,
	SoLanRaSan int default 0,
	Anh image,
	MaDoi nvarchar(10) not null,
	constraint fk_CauThu_DoiBong foreign key (MaDoi) references DoiBong(MaDoi),
	constraint fk_CauThu_ViTri foreign key (MaVitri) references ViTri(MaVitri),
	constraint fk_CauThu_QuocTich foreign key (MaQuocTich) references QuocTich(MaQuocTich)
)

create table TranDau (
	MaTD nvarchar(10) not null primary key,
	LuotDau int null,
	VongDau int null,
	MaDoiNha nvarchar(10) not null,
	MaDoiKhach nvarchar(10) not null,
	SoBanThangDoiNha int default 0,
	SoBanThuaDoiNha int default 0,
	SoTheVangDoiNha int default 0,
	SoTheDoDoiNha int default 0,
	SoTheVangDoiKhach int default 0,
	SoTheDoDoiKhach int default 0,
	Ghichu nvarchar(255),
)

create table TranDau_BanThang (
	MaTD nvarchar(10) not null,
	MaCT nvarchar(10) not null,
	Thoigian int,
	Ghichu nvarchar(255),
	SoLuong int not null,
	constraint fk_TranDau foreign key (MaTD) references TranDau(MaTD),
	constraint fk_CauThu foreign key (MaCT) references CauThu(MaCT),
 CONSTRAINT [PK_TranDau_BanThang] PRIMARY KEY CLUSTERED 
(
	[MaTD] ASC,
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

create table TranDau_The (
	MaTD nvarchar(10) not null,
	MaCT nvarchar(10) not null,
	Thoigian int,
	LoaiThe nvarchar(10),
	Ghichu nvarchar(255),
	constraint fk_TranDauThe_TD foreign key (MaTD) references TranDau(MaTD),
	constraint fk_TranDauThe_CT foreign key (MaCT) references CauThu(MaCT),
 CONSTRAINT [PK_TranDau_The] PRIMARY KEY CLUSTERED 
(
	[MaTD] ASC,
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

create table TranDau_CauThu (
	MaTD nvarchar(10) not null,
	MaCT nvarchar(10) not null,
	constraint fk_TDCT_TranDau foreign key (MaTD) references TranDau(MaTD),
	constraint fk_TDCT_CauThu foreign key (MaCT) references CauThu(MaCT),
 CONSTRAINT [PK_TranDau_CauThu] PRIMARY KEY CLUSTERED 
(
	[MaTD] ASC,
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--ALTER TABLE TranDau_CauThu 
--ADD CONSTRAINT PK_TranDau_CauThu PRIMARY KEY (MaTD, MaCT);

-- Insert tỉnh
insert into Tinh values ('01', N'London')
insert into Tinh values ('02', N'Leeds')
insert into Tinh values ('03', N'Sheffield')
insert into Tinh values ('04', N'Liverpool')
insert into Tinh values ('05', N'Manchester')
insert into Tinh values ('06', N'Bristol')
insert into Tinh values ('07', N'Leicester')
insert into Tinh values ('08', N'Cardiff')
insert into Tinh values ('09', N'Wolverhampton')
insert into Tinh values ('10', N'Southampton')

-- Insert QuocTich
insert into QuocTich values('QT01', 'BElGIUM')
insert into QuocTich values('QT02', 'ENGLAND')
insert into QuocTich values('QT03', 'PORTUGAL')
insert into QuocTich values('QT04', 'SPAIN')
insert into QuocTich values('QT05', 'FRANCE')
insert into QuocTich values('QT06', 'KOREAN')
insert into QuocTich values('QT07', 'ARGENTINA')

-- Insert Vitri
insert into Vitri values ('CB', N'Hậu vệ giữa') 
insert into Vitri values ('LB', N'Hậu vệ trái') 
insert into Vitri values ('RB', N'Hậu vệ phải') 
insert into Vitri values ('GK', N'Thủ Môn')
insert into Vitri values ('DM', N'Tiền vệ phòng ngự') 
insert into Vitri values ('CM', N'Tiền vệ trung tâm') 
insert into Vitri values ('LM', N'Tiền vệ cánh trái')
insert into Vitri values ('RM', N'Tiền vệ cánh phải')
insert into Vitri values ('AM', N'Tiền vệ công')   
insert into Vitri values ('LW', N'Tiền đạo cánh trái') 
insert into Vitri values ('RW', N'Tiền đạo cánh phải')
insert into Vitri values ('CF', N'Tiền đạo trung tâm')


-- Insert Sân bóng
insert into SanBong values ('SB01', N'Emirates', N'Arsenal', 120000 ) 
insert into SanBong values ('SB02', N'Old Trafford', N'Manchester United', 400000 ) 
insert into SanBong values ('SB03', N'Anfield', N'Liverpool', 360000 ) 
insert into SanBong values ('SB04', N'Etihad Stadium', N'Manchester City', 300000 ) 
insert into SanBong values ('SB05', N'Wembley Stadium', N'England', 80000 ) 
insert into SanBong values ('SB06', N'Stamford Bridge', N'Chelsea', 180000 )
insert into SanBong values ('SB07', N'John Smith’s Stadium', N'Huddersfield Town', 150000 )
insert into SanBong values ('SB08', N'Falmer Stadium', N'Brighton', 100000 )
insert into SanBong values ('SB09', N'London Stadium1', N'West Ham', 200000 )
insert into SanBong values ('SB10', N'London Stadium3', N'West Ham3', 200000 )
insert into SanBong values ('SB11', N'London Stadium4', N'West Ham4', 300000 )
insert into SanBong values ('SB12', N'London Stadium0', N'West Ham0', 400000 )
insert into SanBong values ('SB13', N'London Stadium5', N'West Ham5', 500000 )
insert into SanBong values ('SB14', N'London Stadium6', N'West Ham6', 700000 )
insert into SanBong values ('SB15', N'London Stadium7', N'West Ham7', 200000 )
insert into SanBong values ('SB16', N'London Stadium8', N'West Ham8', 500000 )
insert into SanBong values ('SB17', N'London Stadium9', N'West Ham9', 900000 )



-- Insert Đội bóng

INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB01',N'Arsenal','SB01', N'Vicente del Bosque','03',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB02',N'Man City','SB02',N'Pep Guardiola','01',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB03',N'Tottenham','SB03',N'Sir Alex Ferguson','02',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB04',N'Man Utd','SB04',N'Zinedine Zidane','07',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB05',N'Chelsea','SB05',N'Carlos Ancelotti','06',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB06',N'Fullham','SB06',N'Jose Mourinho','02',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB07',N'Brighton','SB07',N'Joachim Low','04',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB08',N'Liverpool','SB08',N'Didier Deschamps','04',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB09',N'Crystal Palace','SB09',N'Jurgen Klopp','03',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB10',N'Brenfford','SB10',N'Luiz Felipe Scolari','03',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB11',N'Everton','SB11',N'George Graham','01',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB12',N'West Ham','SB12',N'Bruce Rioch','06',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB13',N'Leeds','SB13',N'Ron Atkinson','08',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB14',N'Aston Villa','SB14',N'John Gregory','10',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB15',N'Southampton','SB15',N'Nguyễn Thế Tài','05',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB16',N'Leicester','SB16',N'Gérard Houllier','08',NULL)
INSERT [DoiBong] ([MaDoi],[TenDoi],[MaSan],[HLV],[MaTinh],[Logo]) VALUES ('DB17',N'Wolves','SB17',N'Alex McLeish','09',NULL)


-- Insert CauThu
INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT01','DB01',N'DAVID DE GEA','GK','2000-09-19','1','QT04',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT02','DB02',N'HARRY MAGUIRE','CF','2002-09-19','23','QT02',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT03','DB05',N'LISANDRO MARTINEZ','CF','1999-09-10','6','QT07',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT04','DB03',N'son heung-min','LW','1999-09-12','27','QT06',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT05','DB04',N'Harry Kane','LW','1993-09-10','10','QT02',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT06','DB08',N'Cristiano Ronaldo','CF','1997-09-10','7','QT03',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT07','DB07',N'Kevin De Bruyne','AM','1998-09-10','17','QT01',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT08','DB06',N'Gavi','CM','1995-11-10','5','QT04',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT09','DB01',N'Ilkay Gündogan','DM','1992-09-10','8','QT01',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT10','DB02',N'Erling Haaland','AM','1999-09-18','9','QT02',NULL)

INSERT [CauThu] ([MaCT],[MaDoi],[TenCT],[MaVitri],[NgaySinh],[SoAo],[MaQuocTich],[Anh]) 
VALUES ('CT11','DB09',N'Pedri','DM','1995-09-10','1','QT04',NULL)

-- Insert TranDau
insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,GhiChu) values(N'TD01',3,3,N'DB01',N'DB02',null)
insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,GhiChu) values(N'TD02',4,4,N'DB03',N'DB04',null)
insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,GhiChu) values(N'TD03',4,4,N'DB08',N'DB07',null)
insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,GhiChu) values(N'TD04',3,3,N'DB06',N'DB05',null)
insert into TranDau(MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,GhiChu) values(N'TD05',4,4,N'DB09',N'DB10',null)


-- Insert TranDau_CauThu
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD01','CT01')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD01','CT02')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD02','CT03')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD02','CT04')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD02','CT05')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD02','CT07')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD03','CT05')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD03','CT06')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD04','CT07')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD04','CT08')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD05','CT09')
insert into TranDau_CauThu(MaTD,MaCT) values(N'TD05','CT10')

-- Insert TranDau_The
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD01', 'CT02', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD01', 'CT05', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD01', 'CT06', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD02', 'CT07', N'Thẻ đỏ')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD02', 'CT08', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD03', 'CT09', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD03', 'CT10', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD04', 'CT02', N'Thẻ đỏ')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD05', 'CT05', N'Thẻ vàng')
insert into TranDau_The (MaTD, MaCT, LoaiThe) values ('TD05', 'CT06', N'Thẻ đỏ')

-- Insert TranDau_BanThang
insert into TranDau_BanThang (MaTD, MaCT,Thoigian, SoLuong) values('TD01', 'CT01',94 , 3)
insert into TranDau_BanThang (MaTD, MaCT,Thoigian, SoLuong) values('TD01', 'CT02', 92, 4)
insert into TranDau_BanThang (MaTD, MaCT,Thoigian, SoLuong) values('TD02','CT05', 93,1)
insert into TranDau_BanThang (MaTD, MaCT,Thoigian, SoLuong) values('TD02','CT06', 94,1)
insert into TranDau_BanThang (MaTD, MaCT,Thoigian, SoLuong) values('TD04','CT12', 96,2)
insert into TranDau_BanThang (MaTD, MaCT,Thoigian, SoLuong) values('TD04','CT10', 95,5)




