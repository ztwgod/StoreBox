USE [StoreBox]
GO
ALTER TABLE [dbo].[WuXiangZhuangTai] DROP CONSTRAINT [DF_WuXiangZhuangTai_YouWuLeiXing]
GO
/****** Object:  Table [dbo].[XianZhi]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[XianZhi]
GO
/****** Object:  Table [dbo].[WuXiangZhuangTai]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[WuXiangZhuangTai]
GO
/****** Object:  Table [dbo].[T_Log_Platform_Transfer]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[T_Log_Platform_Transfer]
GO
/****** Object:  Table [dbo].[RiZhi]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[RiZhi]
GO
/****** Object:  Table [dbo].[PeiZhi]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[PeiZhi]
GO
/****** Object:  Table [dbo].[KuaiDiYuan]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[KuaiDiYuan]
GO
/****** Object:  Table [dbo].[GuZhangXinXi]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[GuZhangXinXi]
GO
/****** Object:  Table [dbo].[GuanLiYuan]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[GuanLiYuan]
GO
/****** Object:  Table [dbo].[CunQuJianXinXi]    Script Date: 2014/3/25 18:26:32 ******/
DROP TABLE [dbo].[CunQuJianXinXi]
GO
/****** Object:  Table [dbo].[CunQuJianXinXi]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CunQuJianXinXi](
	[Key_ID] [varchar](50) NOT NULL,
	[KuaiDiGongSi] [tinyint] NULL,
	[YunDanHao] [nvarchar](30) NOT NULL,
	[ShouJianRen] [nvarchar](10) NULL,
	[ShouJianDianHua] [nvarchar](11) NULL,
	[JiJianRen] [nvarchar](10) NULL,
	[JiJianDianHua] [nvarchar](11) NULL,
	[BaoCunWeiZhi] [nvarchar](50) NULL,
	[BaoCunXiangHao] [smallint] NULL,
	[BaoCunShiJian] [datetime] NULL,
	[QuJianShiJian] [datetime] NULL,
	[QuJianMiMa] [nchar](8) NULL,
	[FuFeiE] [smallint] NULL,
	[YuQiShouFei] [smallint] NULL,
	[YeWuLeiXing] [tinyint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GuanLiYuan]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuanLiYuan](
	[XingMing] [nvarchar](10) NULL,
	[DianHua] [nchar](11) NULL,
	[KaHao] [nchar](10) NULL,
	[MiMa] [nchar](6) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GuZhangXinXi]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuZhangXinXi](
	[WuXiangID] [nchar](10) NULL,
	[BianHao] [nchar](2) NULL,
	[GuZhangShiJian] [datetime] NULL,
	[HuiFuShiJian] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KuaiDiYuan]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KuaiDiYuan](
	[XingMing] [nvarchar](10) NULL,
	[DianHua] [nchar](11) NULL,
	[KaHao] [nchar](10) NULL,
	[MiMa] [nchar](6) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PeiZhi]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeiZhi](
	[StoreBoxID] [nvarchar](15) NULL,
	[Tel] [nvarchar](15) NULL,
	[StoreBoxSum] [tinyint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RiZhi]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RiZhi](
	[ShiJian] [datetime] NULL,
	[YeWuLeiXing] [tinyint] NULL,
	[CaoZuoLeiXing] [nvarchar](10) NULL,
	[CaoZuoRen] [nvarchar](11) NULL,
	[YunDanHao] [nvarchar](30) NULL,
	[XiangHao] [smallint] NULL,
	[NeiRong] [nvarchar](30) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Log_Platform_Transfer]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Log_Platform_Transfer](
	[Log_Id] [varchar](50) NOT NULL,
	[Request_Name] [varchar](50) NULL,
	[Request_ApplyCode] [varchar](50) NULL,
	[Request_MSG] [nvarchar](max) NULL,
	[Response_Body] [nvarchar](max) NULL,
	[Result_Code] [varchar](10) NULL,
	[Result_Message] [nvarchar](max) NULL,
	[Date_Created] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Log_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WuXiangZhuangTai]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WuXiangZhuangTai](
	[Key_ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupNo] [tinyint] NULL,
	[BianHao] [tinyint] NULL,
	[DaXiaoZhuangTai] [tinyint] NULL,
	[ZhengChangZhuangTai] [tinyint] NULL,
	[KaiGuanZhuangTai] [tinyint] NULL,
	[YouWuZhuangTai] [tinyint] NULL,
	[YouWuLeiXing] [tinyint] NULL,
	[SheZhiShiJian] [datetime] NULL,
	[SheZhiRen] [nvarchar](10) NULL,
	[ShiYongFlag] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XianZhi]    Script Date: 2014/3/25 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XianZhi](
	[Tel] [nvarchar](11) NULL,
	[XianZhiTime] [datetime] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'72', 0, N'', N'本人', N'13333333333', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2F00135D946 AS DateTime), CAST(0x0000A2F700E932D4 AS DateTime), N'11111111', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'73', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C55404 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79511568', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'74', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5565C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'27688578', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'75', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C55788 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'32463570', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'76', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C558B4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'59595504', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'77', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C559E0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'95703976', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'78', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C55B0C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79240744', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'79', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C55C38 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'49918892', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'80', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C55D64 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'53394088', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'81', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C55E90 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'88314576', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'82', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C55FBC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'21889900', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'83', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C560E8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'33028550', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'84', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56214 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63393728', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'85', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56340 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'22829816', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'86', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5646C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'77301696', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'87', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56598 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42420596', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'88', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C566C4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'70835272', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'89', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C567F0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'96152160', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'90', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5691C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42893744', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'91', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56A48 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'61467220', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'92', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56B74 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'18727136', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'93', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56CA0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79881344', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'94', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56DCC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'91991832', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'95', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C56EF8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'25816004', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'96', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57024 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'83251576', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'97', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57150 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'36095612', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'98', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5727C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66486240', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'99', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C573A8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'55421176', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'100', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C574D4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'67670928', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'101', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57600 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'65632980', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'102', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5772C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'51987912', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'103', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57858 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79074848', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'104', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57984 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78733840', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'105', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57AB0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78872472', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'106', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57D08 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'75484768', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'107', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57E34 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'21438274', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'108', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C57F60 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'55581544', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'109', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5808C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'39015380', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'110', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C581B8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'95497936', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'111', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C582E4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'12573102', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'112', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58410 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'41154116', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'113', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5853C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'47866520', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'114', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58668 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'14737972', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'115', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58794 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79972616', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'116', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C588C0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'26096688', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'117', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C589EC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'94115464', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'118', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58B18 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'75261160', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'119', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58C44 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'85165728', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'120', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58D70 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'94117800', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'121', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58E9C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'16125726', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'122', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C58FC8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'60384552', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'123', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C590F4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'86135296', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'124', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59220 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'45176392', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'125', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5934C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'53548100', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'126', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59478 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'28822998', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'127', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C595A4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'51203260', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'128', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C596D0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'21322608', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'129', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C597FC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'83559160', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'130', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59928 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'85940680', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'131', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59A54 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'90897568', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'132', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59B80 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'11597583', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'133', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59CAC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'77160504', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'134', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59DD8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'54357840', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'135', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C59F04 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'90482512', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'136', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A030 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'50833472', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'137', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A15C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'47980668', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'138', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A288 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78813856', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'139', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A3B4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'48864952', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'140', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A4E0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'12934696', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'141', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A60C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42431392', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'142', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A738 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'25698502', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'143', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A864 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'80000568', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'144', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5A990 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'56659188', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'145', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5AABC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'62363876', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'146', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5ABE8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'75083184', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'147', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5AD14 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'76800136', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'148', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5AE40 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'13899648', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'149', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5AF6C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'10225016', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'150', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B098 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'75252208', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'151', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B1C4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'27535746', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'152', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B2F0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'60464792', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'153', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B41C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'16713666', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'154', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B548 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'89734008', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'155', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B674 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'84747072', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'156', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B7A0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'59360600', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'157', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B8CC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'70936880', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'158', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5B9F8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66832432', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'159', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5BB24 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'26647614', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'160', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5BC50 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'96571576', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'161', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5BD7C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'33066172', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'162', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5BEA8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'71657936', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'163', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5BFD4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'91030952', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'164', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C100 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'49341972', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'165', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C22C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'29493748', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'166', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C358 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'90658904', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'167', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C484 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'31676990', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'168', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C5B0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'76957072', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'169', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C6DC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'60488776', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'170', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C808 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'38652820', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'171', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5C934 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'87258216', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'172', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5CA60 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'54024420', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'173', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5CB8C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'80353624', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'174', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5CCB8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'58357596', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'175', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5CDE4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'82745952', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'176', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5CF10 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'16255078', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'177', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D03C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'10080112', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'178', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D294 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'83316576', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'179', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D3C0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'88744864', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'180', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D4EC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42505768', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'181', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D618 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'17960738', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'182', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D744 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'80757808', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'183', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D870 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'76755624', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'184', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5D99C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'69970064', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'185', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5DAC8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'73578104', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'186', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5DBF4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'62374960', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'187', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5DD20 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'68996472', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'188', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5DE4C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'34470684', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'189', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5DF78 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'18906806', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'190', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E0A4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'12397144', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'191', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E1D0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'73405016', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'192', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E2FC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'30319762', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'193', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E428 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'26635452', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'194', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E554 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'25883570', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'195', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E680 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'35428644', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'196', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E7AC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'69300136', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'197', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5E8D8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'67040528', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'198', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5EA04 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'85129768', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'199', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5EB30 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'58805772', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'200', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5EC5C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'48321588', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'201', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5ED88 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'95017664', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'202', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5EEB4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'38573852', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'203', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5EFE0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'18847058', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'204', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F10C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'99577120', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'205', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F238 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79612880', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'206', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F364 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'52202756', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'207', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F490 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'98216688', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'208', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F5BC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63199180', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'209', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F6E8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'56053836', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'210', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F814 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'93458496', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'211', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5F940 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'85213624', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'212', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5FA6C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'62415912', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'213', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5FB98 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'20281084', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'214', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5FCC4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'67644424', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'215', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5FDF0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'44552812', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'216', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C5FF1C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'21207418', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'217', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60048 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'25979320', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'218', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60174 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66831460', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'219', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C602A0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'20646498', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'220', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C603CC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'14462005', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'221', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C604F8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'34108624', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'222', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60624 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'11264350', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'223', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60750 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'33385424', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'224', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C6087C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'10632433', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'225', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C609A8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'54935720', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'226', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60AD4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'33267928', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'227', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60C00 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'96420104', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'228', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60D2C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'86892160', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'229', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60E58 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42565220', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'230', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C60F84 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'73653344', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'231', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C610B0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'77942064', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'232', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C611DC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'36791608', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'233', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61308 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'81970880', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'234', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61434 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'40624348', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'235', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61560 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'33965104', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'236', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C6168C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'80414392', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'237', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C617B8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'81183488', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'238', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C618E4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'24106526', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'239', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61A10 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'67033580', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'240', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61B3C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'70038912', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'241', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61C68 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'65038416', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'242', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61D94 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'39868408', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'243', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61EC0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'50267952', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'244', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C61FEC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'51275748', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'245', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C62118 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'81008096', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'246', 0, N'', N'', N'18801754005', N'', N'18801754005', N'021-001', 1, CAST(0x0000A2E300C62244 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'45418844', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'247', 0, N'', N'管理员', N'', N'', N'', N'021-001', 3, CAST(0x0000A2E300D0320C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'        ', 0, 0, 5)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'248', 0, N'', N'管理员', N'', N'', N'', N'021-001', 3, CAST(0x0000A2E300D03464 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'        ', 0, 0, 5)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'249', 0, N'2333', N'', N'18801754005', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D08B1C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'61610288', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'250', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0B7A4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'87738792', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'251', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0B9FC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'64189764', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'252', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0BC54 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'20661432', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'253', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0BD80 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'38147672', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'254', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0BEAC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'71860224', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'255', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0BFD8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'21583774', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'256', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C104 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'81704496', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'257', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C230 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'77843184', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'258', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C35C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'26799560', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'259', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C488 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'47188120', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'260', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C5B4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'86124368', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'261', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C6E0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'23384834', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'262', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C80C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66270796', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'263', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0C938 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'52985832', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'264', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0CA64 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78596952', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'265', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0CB90 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'38869912', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'266', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0CCBC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63607064', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'267', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0CDE8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42102524', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'268', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0CF14 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'10370418', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'269', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D040 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'28678914', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'270', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D16C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'41291880', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'271', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D298 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'20212628', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'272', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D3C4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'95046448', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'273', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D4F0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'10131782', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'274', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D61C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42990404', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'275', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D748 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'19445668', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'276', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D874 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'16861492', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'277', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0D9A0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'58644168', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'278', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0DACC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'28080690', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'279', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0DBF8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'54792484', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'280', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0DD24 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'51468020', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'281', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0DE50 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'95383672', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'282', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0DF7C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'58684932', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'283', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0E0A8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'13011498', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'284', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0E1D4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'49215756', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'285', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0E300 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'57426100', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'286', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0E42C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'59200708', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'287', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0E558 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'60932956', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'288', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0E7B0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'90411712', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'289', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0E8DC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'48332248', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'290', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0EA08 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'74875208', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'291', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0EB34 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'86207624', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'292', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0EC60 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'43701472', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'293', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0ED8C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'33621664', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'294', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0EEB8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66030896', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'295', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0EFE4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'24168796', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'296', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F110 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'68033296', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'297', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F23C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'18480206', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'298', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F368 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'50393252', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'299', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F494 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'96767760', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'300', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F5C0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'65678292', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'301', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F6EC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'31719526', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'302', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F818 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'14652345', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'303', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0F944 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'34559332', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'304', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0FA70 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63097040', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'305', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0FB9C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'89582904', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'306', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0FCC8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'73203312', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'307', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0FDF4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'84983080', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'308', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D0FF20 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66095816', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'309', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1004C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'90276528', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'310', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10178 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'64552632', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'311', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D102A4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63144596', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'312', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D103D0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'27482842', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'313', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D104FC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'91000704', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'314', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10628 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'70224344', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'315', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10754 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'45096744', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'316', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10880 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'17224552', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'317', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D109AC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'67481136', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'318', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10AD8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'56166332', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'319', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10C04 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'93620888', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'320', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10D30 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'55101828', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'321', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10E5C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'56000192', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'322', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D10F88 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'76656544', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'323', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D110B4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'96508168', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'324', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D111E0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'55866256', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'325', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1130C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'47928092', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'326', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11438 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'50709260', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'327', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11564 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'77340736', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'328', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11690 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66896380', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'329', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D117BC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'86754224', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'330', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D118E8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'10981345', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'331', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11A14 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78773016', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'332', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11B40 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78353944', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'333', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11C6C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'27618364', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'334', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11D98 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'15178487', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'335', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11EC4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'68312936', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'336', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D11FF0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'35840132', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'337', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1211C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'39341912', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'338', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12248 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79961456', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'339', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12374 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'46603200', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'340', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D124A0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'55551860', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'341', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D125CC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'48959176', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'342', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D126F8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'47352336', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'343', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12824 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'88202520', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'344', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12950 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'31937970', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'345', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12A7C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'18748598', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'346', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12CD4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'44866888', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'347', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12CD4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'77855520', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'348', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12E00 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'65764012', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'349', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D12F2C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'60790376', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'350', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13058 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'81330792', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'351', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13184 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'87226024', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'352', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D132B0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63865888', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'353', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D133DC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'10344610', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'354', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13508 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63588492', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'355', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13634 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'40191684', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'356', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13760 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78252592', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'357', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1388C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'99833424', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'358', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D139B8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'49675272', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'359', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13C10 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'60771672', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'360', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13D3C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'12491627', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'361', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13E68 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'61679300', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'362', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D13F94 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'82948680', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'363', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D140C0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'47018356', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'364', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D141EC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'88050896', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'365', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14318 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'24603556', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'366', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14444 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'97869760', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'367', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14570 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'43673556', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'368', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1469C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'86329920', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'369', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D147C8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'87532576', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'370', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D148F4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'28284356', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'371', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14A20 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'97324800', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'372', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14B4C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'53191144', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'373', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14C78 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'96004088', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'374', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14DA4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'28204298', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'375', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14ED0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'44061556', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'376', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D14FFC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'35991124', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'377', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15128 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'71073384', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'378', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15254 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'85088696', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'379', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15380 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'39631512', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'380', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D154AC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'23111824', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'381', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D155D8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'30719592', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'382', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15704 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'15625166', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'383', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15830 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'32096800', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'384', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1595C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'85991840', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'385', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15A88 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'13751917', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'386', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15BB4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'24011104', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'387', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15CE0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66990256', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'388', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15E0C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'93657656', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'389', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D15F38 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'36215888', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'390', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16064 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'22734908', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'391', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16190 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'74971672', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'392', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D162BC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'79754904', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'393', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D163E8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'70299624', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'394', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16514 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'55857252', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'395', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16640 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'41984044', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'396', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1676C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'92079616', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'397', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16898 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'45740048', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'398', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D169C4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'24792312', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'399', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16AF0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'21909812', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'400', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16C1C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'64609436', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'401', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16D48 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'53729192', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'402', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16E74 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66589048', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'403', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D16FA0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'81727128', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'404', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D170CC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'72034928', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'405', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17324 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'54712420', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'406', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17324 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'89166096', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'407', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17450 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'66790780', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'408', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1757C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'20334572', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'409', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D176A8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'22324660', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'410', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D177D4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'62865020', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'411', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17900 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'88587080', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'412', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17A2C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'58766488', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'413', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17B58 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'68066512', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'414', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17C84 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'95026656', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'415', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17DB0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'46440540', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'416', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D17EDC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'44690960', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'417', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D18008 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'14338500', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'418', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D18134 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'26574474', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'419', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D18260 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'63205784', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'420', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1838C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'42669156', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'421', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D184B8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'78082144', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'422', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D185E4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'44808884', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'423', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D18710 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'32606564', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'424', 0, N'', N'', N'18801754405', N'', N'18801754005', N'021-001', 7, CAST(0x0000A2E300D1883C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'84654800', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'35d91b3a4faa468c82801764435ff9f1', 0, N'13', N'', N'13333333333', N'', N'13333333333', N'021-001', 7, CAST(0x0000A2F700DAFAFC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'73499280', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'53d533d92f79459a8dcd4277dbc3a7b5', 0, N'123', N'', N'18018669090', N'', N'18018669090', N'021-001', 3, CAST(0x0000A2F700DE501C AS DateTime), CAST(0x0000000000000000 AS DateTime), N'73499280', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'c7e724a5ceab4c6ba89ca08f4ff548f9', 0, N'123', N'', N'18018669090', N'', N'18018669090', N'31010100010101', 3, CAST(0x0000A2F700E067A8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'87635744', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'9c99533a8f274b82bc926a7be8a15e94', 0, N'123', N'', N'18018669090', N'', N'18018669090', N'31010100010101', 3, CAST(0x0000A2F700E164C8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'81143200', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'9619ad6100024487be099ba7ce1253a7', 0, N'1234', N'', N'18018669091', N'', N'18018669091', N'31010100010101', 3, CAST(0x0000A2F700E19BDC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'43618256', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'c773afa891f34cdfad0b776f1d12ac0c', 0, N'124', N'', N'13333333333', N'', N'13666666666', N'31010100010101', 3, CAST(0x0000A2F700E2E9D8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'96575784', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'6bb957702eb4435d9b779350f00f7b6e', 0, N'666', N'', N'13333666696', N'', N'13333665555', N'31010100010101', 3, CAST(0x0000A2F700E88564 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'88430128', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'e023072e00e848448bb907b60ea22380', 0, N'6655', N'快递员', N'13355555555', N'', N'13355555555', N'31010100010101', 3, CAST(0x0000A2F700E8CBB4 AS DateTime), CAST(0x0000A2F700F0D458 AS DateTime), N'15061318', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'6254455c16b2407ab2aa8e76d2103b7e', 0, N'4', N'', N'13333333333', N'', N'18888888888', N'31010100010101', 4, CAST(0x0000A2F700E8EDB0 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'95460096', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'944c77ef1cbd434ea99822779ded852b', 0, N'', N'', N'13333333333', N'', N'13666666666', N'31010100010101', 7, CAST(0x0000A2F700E95BD8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'57238160', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'eaa4fbd97bd24cfdbb82c4f21a266535', 0, N'123', N'快递员', N'13333333333', N'', N'13333333333', N'31010100010101', 3, CAST(0x0000A2F700F1BEB8 AS DateTime), CAST(0x0000A2F700F59F4C AS DateTime), N'58008160', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'c78c6c600f994659aa259d606137c4ed', 0, N'444', N'', N'13344444444', N'', N'13335555555', N'31010100010101', 4, CAST(0x0000A2F700F1FBA8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'62156676', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'68888a66397e44c7b8ccd69efabd6050', 0, N'111', N'', N'13800000000', N'', N'13900000000', N'31010100010101', 7, CAST(0x0000A2F700F54060 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'73499280', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'93d6d7183e484630b3edcf3f33788bea', 0, N'222', N'本人', N'18018669090', N'快递员', N'', N'31010100010101', 3, CAST(0x0000A2F700F779E8 AS DateTime), CAST(0x0000A2F700F96AC8 AS DateTime), N'62156676', 0, 0, 4)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'87153fcdca624d74b5200202d9a78f76', 0, N'2222', N'', N'18018669090', N'快递员', N'', N'31010100010101', 3, CAST(0x0000A2F700FA14B4 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'58008160', 0, 0, 4)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'f1533ef0162e409e9f665e40fe18cee7', 0, N'', N'管理员', N'', N'', N'', N'31010100010101', 3, CAST(0x0000A2F700FAFDE8 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'        ', 0, 0, 5)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'fe58ced111f14248b9dd69d51322d44d', 0, N'', N'管理员', N'', N'', N'', N'31010100010101', 3, CAST(0x0000A2F700FAFF14 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'        ', 0, 0, 5)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'34e9f48a40634fc28e292b08aa097a6a', 0, N'', N'管理员', N'', N'', N'', N'31010100010101', 14, CAST(0x0000A2F700FB34FC AS DateTime), CAST(0x0000000000000000 AS DateTime), N'        ', 0, 0, 5)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'7f57125c29c9471ab5774fa68368e07d', 0, N'', N'管理员', N'', N'', N'', N'31010100010101', 14, CAST(0x0000A2F700FB3628 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'        ', 0, 0, 5)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'e0d191e21cba4cbab770718093dea8f9', 0, N'123456', N'快递员', N'18018669090', N'', N'18018669090', N'31010100010101', 8, CAST(0x0000A2F7010EE538 AS DateTime), CAST(0x0000A2F7010F9050 AS DateTime), N'73499280', 10, 0, 1)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'eda106e6b5c549e8b6f18dd3cac0b99a', 0, N'777', N'本人', N'18018669090', N'快递员', N'', N'31010100010101', 8, CAST(0x0000A2F70110DF78 AS DateTime), CAST(0x0000A2F70111A458 AS DateTime), N'62156676', 0, 0, 4)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'a7677c4081fb403da3f9a879848199e0', 0, N'', N'本人', N'18018669090', N'', N'18018669090', N'31010100010101', 3, CAST(0x0000A2F701132260 AS DateTime), CAST(0x0000A2F701134DBC AS DateTime), N'37175320', 5, 0, 3)
GO
INSERT [dbo].[CunQuJianXinXi] ([Key_ID], [KuaiDiGongSi], [YunDanHao], [ShouJianRen], [ShouJianDianHua], [JiJianRen], [JiJianDianHua], [BaoCunWeiZhi], [BaoCunXiangHao], [BaoCunShiJian], [QuJianShiJian], [QuJianMiMa], [FuFeiE], [YuQiShouFei], [YeWuLeiXing]) VALUES (N'9c6e1244fd154f81876c3c9bd8b60208', 0, N'123', N'', N'18018669090', N'', N'18018669090', N'31010100010101', 3, CAST(0x0000A2F7011CFB14 AS DateTime), CAST(0x0000000000000000 AS DateTime), N'11261588', 10, 0, 1)
GO
INSERT [dbo].[GuanLiYuan] ([XingMing], [DianHua], [KaHao], [MiMa]) VALUES (N'管理员', N'13788888888', N'0050663F94', N'123456')
GO
INSERT [dbo].[KuaiDiYuan] ([XingMing], [DianHua], [KaHao], [MiMa]) VALUES (N'快递员', N'13988888888', N'005055C744', N'123456')
GO
INSERT [dbo].[PeiZhi] ([StoreBoxID], [Tel], [StoreBoxSum]) VALUES (N'31010100010101', N'021-61104330', 2)
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E1012FDBE4 AS DateTime), 1, N'故障', N'', N'', 1, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10130167C AS DateTime), 3, N'故障', N'', N'', 1, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10130A448 AS DateTime), 1, N'故障', N'', N'', 7, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10130D6AC AS DateTime), 3, N'故障', N'', N'', 7, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E101310334 AS DateTime), 4, N'故障', N'', N'', 2, N'该箱已经处于打开状态！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E1013115F4 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'禁用！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10131184C AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'禁用！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E101312B0C AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E101313214 AS DateTime), 5, N'故障', N'', N'', 11, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E101318548 AS DateTime), 4, N'故障', N'', N'', 3, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E101321A1C AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E101322A84 AS DateTime), 5, N'故障', N'', N'', 1, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10132F1BC AS DateTime), 1, N'故障', N'', N'', 1, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10134A6D8 AS DateTime), 4, N'故障', N'', N'', 1, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10134D810 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10134E170 AS DateTime), 5, N'故障', N'', N'', 8, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E10136AA78 AS DateTime), 4, N'故障', N'', N'', 1, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E300C50B5C AS DateTime), 1, N'故障', N'', N'', 1, N'第1组第1号控制器故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E300C62370 AS DateTime), 3, N'关箱', N'', N'', 1, N'超时！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E300D02E88 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E300D0320C AS DateTime), 5, N'管理员开箱', N'管理员', N'', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E300D03464 AS DateTime), 5, N'管理员开箱', N'管理员', N'', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E300D08B1C AS DateTime), 1, N'寄件', N'18801754005', N'2333', 7, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2E300D18968 AS DateTime), 3, N'关箱', N'', N'', 7, N'超时！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F001382AD8 AS DateTime), 1, N'投币超时', N'18018669090', N'18018669090', 3, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F00138B070 AS DateTime), 1, N'投币超时', N'18018669090', N'18018669090', 3, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F001397B2C AS DateTime), 1, N'投币超时', N'18018669090', N'18018669090', 3, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0013ACF04 AS DateTime), 1, N'投币超时', N'18018669090', N'18018669090', 3, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0013F158C AS DateTime), 1, N'投币超时', N'13333333333', N'13444444444', 1, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0015B7D08 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0015D2090 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0015EE4E8 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0015F6828 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0015FDE84 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F001601CA0 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F00160E888 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F00163EA74 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F001647A98 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F001655DF0 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0016AB6B0 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0016E34D4 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0016EC3CC AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F0016FA97C AS DateTime), 5, N'关箱', N'', N'', 1, N'超时！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F301185348 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F301192F98 AS DateTime), 5, N'关箱', N'', N'', 1, N'超时！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F4014515E0 AS DateTime), 1, N'投币超时', N'13333333333', N'13444444441', 3, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F401498ECC AS DateTime), 1, N'故障', N'', N'', 1, N'开门故障！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F60127A460 AS DateTime), 2, N'投币超时', N'13333333333', N'', 1, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F60128F5E0 AS DateTime), 2, N'故障', N'', N'', 1, N'该箱已经处于打开状态！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DAFC28 AS DateTime), 1, N'寄件', N'13333333333', N'13', 7, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DE68B8 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700F0D458 AS DateTime), 4, N'快递员收件', N'快递员', N'005055C744', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700F1BEB8 AS DateTime), 1, N'寄件', N'13333333333', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700F1FBA8 AS DateTime), 1, N'寄件', N'13335555555', N'444', 4, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700F54060 AS DateTime), 1, N'寄件', N'13900000000', N'111', 7, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700F59F4C AS DateTime), 4, N'快递员收件', N'快递员', N'005055C744', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700F96AC8 AS DateTime), 2, N'收件', N'', N'', 0, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FAF6E0 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 0, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FAFDE8 AS DateTime), 5, N'管理员开箱', N'管理员', N'', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FAFF14 AS DateTime), 5, N'管理员开箱', N'管理员', N'', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FB1EB8 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 3, N'启用！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FB223C AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 3, N'禁用！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FB2DF4 AS DateTime), 5, N'管理员操作', N'管理员', N'0050663F94', 3, N'开箱！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FB34FC AS DateTime), 5, N'管理员开箱', N'管理员', N'', 14, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700FB3628 AS DateTime), 5, N'管理员开箱', N'管理员', N'', 14, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F70107B560 AS DateTime), 1, N'投币超时', N'13333333333', N'13666666666', 8, N'已投币0')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F7010EE538 AS DateTime), 1, N'寄件', N'18018669090', N'123456', 8, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F7010F917C AS DateTime), 4, N'快递员收件', N'快递员', N'005055C744', 8, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F70111A458 AS DateTime), 2, N'收件', N'', N'', 0, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F701134DBC AS DateTime), 2, N'收件', N'', N'', 0, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF4D0 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700DFF5FC AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E13390 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E164C8 AS DateTime), 1, N'寄件', N'18018669090', N'123', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E19BDC AS DateTime), 1, N'寄件', N'18018669091', N'1234', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E2E9D8 AS DateTime), 1, N'寄件', N'13666666666', N'124', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E88564 AS DateTime), 1, N'寄件', N'13333665555', N'666', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E8CBB4 AS DateTime), 1, N'寄件', N'13355555555', N'6655', 3, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E8EDB0 AS DateTime), 1, N'寄件', N'18888888888', N'4', 4, N'成功！')
GO
INSERT [dbo].[RiZhi] ([ShiJian], [YeWuLeiXing], [CaoZuoLeiXing], [CaoZuoRen], [YunDanHao], [XiangHao], [NeiRong]) VALUES (CAST(0x0000A2F700E932D4 AS DateTime), 2, N'收件', N'', N'', 0, N'成功！')
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'02406ffb-7566-4eaf-a532-4909f13a55cf', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"3dd47debca744cc484a0492421e62b44","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF5F4 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'0f23ec4b-9045-4c0e-b7cc-9e7405ca8c0f', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:29:38","clientUploadTime":"2014-03-23 13:29:38","transactionInfo":{"transactionID":"53d533d92f79459a8dcd4277dbc3a7b5","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DE6061 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'102352e3-3930-44fd-82c6-10eeb35bd811', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":3,"storageStationId":"31010100010101","clientTime":"2014-03-23 15:10:31","clientUploadTime":"2014-03-23 15:10:31","transactionInfo":{"transactionID":"87153fcdca624d74b5200202d9a78f76","boxCode":"31010100010101001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"87153fcdca624d74b5200202d9a78f76","storageStationId":31010100010101,"boxcode":"31010100010101001003","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":""}}', N'1', N'', CAST(0x0000A2F700FA152D AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'1f4fad8b-aa0d-4553-9a3c-9869e7f5ff8b', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"310101000101010","clientTime":"2014-03-22 17:21:26","clientUploadTime":"2014-03-22 17:21:26","transactionInfo":{"transactionID":"ABCDEF1234567890","boxCode":"310101000101010000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null}}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":310101000101010,"pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F6011E0A26 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'21d1117a-d8f1-4aeb-b1f4-d6ebaa0ae6f2', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 14:40:10","clientUploadTime":"2014-03-23 14:40:10","transactionInfo":{"transactionID":"eaa4fbd97bd24cfdbb82c4f21a266535","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700F1BF50 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'23e0f016-954c-4f2b-924e-a8a35c1017fc', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:39:56","clientUploadTime":"2014-03-23 13:39:56","transactionInfo":{"transactionID":"c7e724a5ceab4c6ba89ca08f4ff548f9","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E133F3 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'2c2b06dd-e98a-40b9-b594-869b9a2d8717', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-23 00:06:26","clientUploadTime":"2014-03-23 00:06:26","transactionInfo":{"transactionID":"ABCDEF1234567890","boxCode":"31010100010101000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"addressInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"courierInfo":null}}}', N'{"BaseResponse":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"接口异常！null"}}', N'2', N'接口异常！null', CAST(0x0000A2F70001C564 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'320c262d-296b-49ba-a857-482289bf6325', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"fb18d524d4fd458bb10e95f5fc99d65c","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF532 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'337a7554-3ca4-4fe0-94af-e48f09e26ab0', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:41:25","clientUploadTime":"2014-03-23 13:41:25","transactionInfo":{"transactionID":"9619ad6100024487be099ba7ce1253a7","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669091","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669091","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E19BEF AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'34c16da5-1184-4f61-8e64-3ff50857d0b7', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-23 16:26:18","clientUploadTime":"2014-03-23 16:26:18","transactionInfo":{"transactionID":"e0d191e21cba4cbab770718093dea8f9","boxCode":"31010100010101001008","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"e0d191e21cba4cbab770718093dea8f9","storageStationId":31010100010101,"boxcode":"31010100010101001008","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":""}}', N'1', N'', CAST(0x0000A2F7010EE618 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'39c017ab-6a52-4a5d-b4f9-15c9f0dac7e9', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":2,"storageStationId":"31010100010101","clientTime":"2014-03-23 16:28:44","clientUploadTime":"2014-03-23 16:28:44","transactionInfo":{"transactionID":"e0d191e21cba4cbab770718093dea8f9","boxCode":"31010100010101001008","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"73499280","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"e0d191e21cba4cbab770718093dea8f9","storageStationId":31010100010101,"boxcode":"31010100010101001008","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":73499280}}', N'1', N'', CAST(0x0000A2F7010F9166 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'3aad0b60-603f-462c-a170-3e578f6f2081', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"1319aaa491494c4283f045ff7c71fb20","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF5D8 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'3d61c39b-ed55-40c6-aa82-407bf2a0896e', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"1108df040ad34835b3e849a955b52e32","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF5B4 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'46426046-df30-4ba8-b987-4a7a449ed0d0', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"f9835fa9bddb4923a13a0a40f1d98600","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF5E7 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'50544f1d-bd99-427d-b443-6f0a7c8d0a9f', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":3,"storageStationId":"31010100010101","clientTime":"2014-03-23 16:33:30","clientUploadTime":"2014-03-23 16:33:30","transactionInfo":{"transactionID":"eda106e6b5c549e8b6f18dd3cac0b99a","boxCode":"31010100010101001008","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"eda106e6b5c549e8b6f18dd3cac0b99a","storageStationId":31010100010101,"boxcode":"31010100010101001008","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":""}}', N'1', N'', CAST(0x0000A2F70110E012 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'50d8d50d-6472-432e-8684-18570bf3ff93', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:23","clientUploadTime":"2014-03-23 13:35:23","transactionInfo":{"transactionID":"40f47e8fb6d643be82fe312e3c10ac44","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF4F7 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'53d13e9c-82d1-4de6-8614-a9077e2d229c', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-22 16:58:24","clientUploadTime":"2014-03-22 16:58:24","transactionInfo":{"transactionID":"ABCDEF1234567890","boxCode":"31010100010101000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null}}}}', N'', N'0', N'', CAST(0x0000A2F60117B6B7 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'59db824e-450e-49db-a866-dd5f7267896c', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":4,"storageStationId":"31010100010101","clientTime":"2014-03-23 15:08:06","clientUploadTime":"2014-03-23 15:08:06","transactionInfo":{"transactionID":"93d6d7183e484630b3edcf3f33788bea","boxCode":"31010100010101001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"62156676","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"93d6d7183e484630b3edcf3f33788bea","storageStationId":31010100010101,"boxcode":"31010100010101001003","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":62156676}}', N'1', N'', CAST(0x0000A2F700F96B78 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'60b970bf-abed-4e74-a51e-edb99ac990e1', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-22 16:58:25","clientUploadTime":"2014-03-22 16:58:25","transactionInfo":{"transactionID":"ABCDEF1234567890","boxCode":"31010100010101000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null}}}}', N'', N'0', N'', CAST(0x0000A2F60117B7C0 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'6462f469-fa37-4735-8fa5-381f889ea244', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 00:10:22","clientUploadTime":"2014-03-23 00:10:22","transactionInfo":{"transactionID":"72b5d8c4fe094cd0bb633dd69cfacc88","boxCode":"021-001000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"addressInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"courierInfo":null}}}', N'{"BaseResponse":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"接口异常！null"}}', N'2', N'接口异常！null', CAST(0x0000A2F70002D9DE AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'6a9753d6-7fdc-4972-91b9-8e040f4eb47b', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":2,"storageStationId":"31010100010101","clientTime":"2014-03-23 14:54:17","clientUploadTime":"2014-03-23 14:54:17","transactionInfo":{"transactionID":"eaa4fbd97bd24cfdbb82c4f21a266535","boxCode":"31010100010101001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"58008160","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"eaa4fbd97bd24cfdbb82c4f21a266535","storageStationId":31010100010101,"boxcode":"31010100010101001003","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":58008160}}', N'1', N'', CAST(0x0000A2F700F59F8B AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'8884b9d3-ee0e-4e78-8473-891f88b0a5c3', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:25","clientUploadTime":"2014-03-23 13:35:25","transactionInfo":{"transactionID":"2a70b68fe0e54dc7aa9cfa777d16c2ab","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF600 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'8969e4ee-5ec9-45cd-9e71-0f00d8c2169c', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 14:08:04","clientUploadTime":"2014-03-23 14:08:04","transactionInfo":{"transactionID":"6254455c16b2407ab2aa8e76d2103b7e","boxCode":"021-001001004","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18888888888","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E8EEA9 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'8be8c001-10b4-48d3-bc6a-e15958071247', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":4,"storageStationId":"021-001","clientTime":"2014-03-23 14:09:03","clientUploadTime":"2014-03-23 14:09:03","transactionInfo":{"transactionID":"72","boxCode":"021-001001001","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"11111111","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18888888888","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E93355 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'970ecd2b-c919-4442-ae95-b746f6281215', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 14:41:02","clientUploadTime":"2014-03-23 14:41:02","transactionInfo":{"transactionID":"c78c6c600f994659aa259d606137c4ed","boxCode":"021-001001004","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13335555555","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13344444444","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700F1FC8A AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'a510fea0-43b3-4ea9-b37d-cc73e4688b16', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":4,"storageStationId":"31010100010101","clientTime":"2014-03-23 16:36:18","clientUploadTime":"2014-03-23 16:36:18","transactionInfo":{"transactionID":"eda106e6b5c549e8b6f18dd3cac0b99a","boxCode":"31010100010101001008","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"62156676","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"eda106e6b5c549e8b6f18dd3cac0b99a","storageStationId":31010100010101,"boxcode":"31010100010101001008","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":62156676}}', N'1', N'', CAST(0x0000A2F70111A53F AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'a862dee3-90cb-42fe-aad0-b4df81c99a3e', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 14:07:35","clientUploadTime":"2014-03-23 14:07:35","transactionInfo":{"transactionID":"e023072e00e848448bb907b60ea22380","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13355555555","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13355555555","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E8CC1C AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'bbb67189-3b89-4a9f-baaa-ebdbfc93095a', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"e444312ec3b645588d5925c0cb58b7f9","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF552 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'c18c21f3-cbe8-4aca-8d70-04fa20d3a7d9', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 00:17:38","clientUploadTime":"2014-03-23 00:17:38","transactionInfo":{"transactionID":"bfbcb1d87344401fb1d7f51735376a5b","boxCode":"021-001000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F70004D8E4 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'c4850c17-34b3-4545-877c-5555f8f944f2', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-23 14:52:56","clientUploadTime":"2014-03-23 14:52:56","transactionInfo":{"transactionID":"68888a66397e44c7b8ccd69efabd6050","boxCode":"31010100010101001007","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13900000000","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13800000000","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"68888a66397e44c7b8ccd69efabd6050","storageStationId":31010100010101,"boxcode":"31010100010101001007","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":""}}', N'1', N'', CAST(0x0000A2F700F54114 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'c51b94f8-7a8b-449b-a2d8-cedb73f4a05f', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"c59c2f91634d405fbcfe99217300dbea","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF5C5 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'c533a344-6860-4860-8c0f-937fea5e9a08', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":4,"storageStationId":"31010100010101","clientTime":"2014-03-23 16:42:21","clientUploadTime":"2014-03-23 16:42:21","transactionInfo":{"transactionID":"a7677c4081fb403da3f9a879848199e0","boxCode":"31010100010101001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"37175320","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"a7677c4081fb403da3f9a879848199e0","storageStationId":31010100010101,"boxcode":"31010100010101001003","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":37175320}}', N'1', N'', CAST(0x0000A2F701134DF4 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'c97981ff-6906-43e0-aace-750dd94a328f', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":0,"storageStationId":"31010100010101","clientTime":"2014-03-23 15:01:02","clientUploadTime":"2014-03-23 15:01:02","transactionInfo":{"transactionID":"93d6d7183e484630b3edcf3f33788bea","boxCode":"31010100010101001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"93d6d7183e484630b3edcf3f33788bea","storageStationId":31010100010101,"boxcode":"31010100010101001003","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":""}}', N'1', N'', CAST(0x0000A2F700F77A6D AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'ce35191f-73ac-455c-8fb7-0f967833088e', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":5,"storageStationId":"021-001","clientTime":"2014-03-23 14:34:22","clientUploadTime":"2014-03-23 14:34:22","transactionInfo":{"transactionID":"90f02b02d62146c6b2ace9a6e88f4ab9","boxCode":"021-001001001","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13666666666","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700F0273A AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'ce669202-a27d-4f0c-b6f1-abb5df3c2e55', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:40:38","clientUploadTime":"2014-03-23 13:40:38","transactionInfo":{"transactionID":"9c99533a8f274b82bc926a7be8a15e94","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E16589 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'ce95d655-6f87-4438-a60f-119c0de1d153', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:46:10","clientUploadTime":"2014-03-23 13:46:10","transactionInfo":{"transactionID":"c773afa891f34cdfad0b776f1d12ac0c","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13666666666","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E2EABD AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'd0007b90-3610-4585-b399-52de8ca8e01f', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 14:06:35","clientUploadTime":"2014-03-23 14:06:35","transactionInfo":{"transactionID":"6bb957702eb4435d9b779350f00f7b6e","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13333665555","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13333666696","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E8861D AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'dc3cad77-e8d9-4179-8a4e-4de349e2faf3', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"310101000101010","clientTime":"2014-03-22 17:22:13","clientUploadTime":"2014-03-22 17:22:13","transactionInfo":{"transactionID":"ABCDEF1234567890","boxCode":"310101000101010000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null}}}}', N'', N'9', N'基础连接已经关闭: 接收时发生错误。', CAST(0x0000A2F6011E41F4 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'defc8bba-6c4c-48d8-8d29-0d2c0352d6ca', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":5,"storageStationId":"021-001","clientTime":"2014-03-23 14:09:38","clientUploadTime":"2014-03-23 14:09:38","transactionInfo":{"transactionID":"944c77ef1cbd434ea99822779ded852b","boxCode":"021-001001007","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":5.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":5.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13666666666","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700E95C6F AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'e2e0676c-7d98-45c9-8378-efd5f2ab2acb', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"92bc1520eab14135ae148e9c8799ba2d","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF586 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'e7b8779f-e9c1-4e84-8bf6-0e4ffd57903c', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:17:18","clientUploadTime":"2014-03-23 13:17:18","transactionInfo":{"transactionID":"35d91b3a4faa468c82801764435ff9f1","boxCode":"021-001001007","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"13333333333","address":null,"email":null},"courierInfo":null}}}', N'{"BaseResponse":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"接口异常！PreparedStatementCallback; SQL [INSERT INTO T_STORAGESTATION_INTF_LOG(LOG_ID,LOG_TIME,SS_ID,INTF_ID,MSG_CONTENT) VALUES(?,?,?,?,?)]; Communications link failure due to underlying exception: \n\n** BEGIN NESTED EXCEPTION ** \n\njava.net.SocketException\nMESSAGE: Software caused connection abort: socket write error\n\nSTACKTRACE:\n\njava.net.SocketException: Software caused connection abort: socket write error\r\n\tat java.net.SocketOutputStream.socketWrite0(Native Method)\r\n\tat java.net.SocketOutputStream.socketWrite(SocketOutputStream.java:92)\r\n\tat java.net.SocketOutputStream.write(SocketOutputStream.java:136)\r\n\tat java.io.BufferedOutputStream.flushBuffer(BufferedOutputStream.java:65)\r\n\tat java.io.BufferedOutputStream.flush(BufferedOutputStream.java:123)\r\n\tat com.mysql.jdbc.MysqlIO.send(MysqlIO.java:2744)\r\n\tat com.mysql.jdbc.MysqlIO.sendCommand(MysqlIO.java:1612)\r\n\tat com.mysql.jdbc.MysqlIO.sqlQueryDirect(MysqlIO.java:1723)\r\n\tat com.mysql.jdbc.Connection.execSQL(Connection.java:3283)\r\n\tat com.mysql.jdbc.PreparedStatement.executeInternal(PreparedStatement.java:1332)\r\n\tat com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1604)\r\n\tat com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1519)\r\n\tat com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1504)\r\n\tat org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)\r\n\tat org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)\r\n\tat org.springframework.jdbc.core.JdbcTemplate$2.doInPreparedStatement(JdbcTemplate.java:797)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.execute(JdbcTemplate.java:590)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:791)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:849)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:857)\r\n\tat cn.com.xb.dao.impl.StoragestationIntfLogDaoImpl.insert(StoragestationIntfLogDaoImpl.java:74)\r\n\tat cn.com.xb.service.impl.InterfaceLogServiceImpl.addInterfaceLogInfo(InterfaceLogServiceImpl.java:31)\r\n\tat sun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)\r\n\tat sun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:39)\r\n\tat sun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:25)\r\n\tat java.lang.reflect.Method.invoke(Method.java:597)\r\n\tat org.springframework.aop.support.AopUtils.invokeJoinpointUsingReflection(AopUtils.java:310)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.invokeJoinpoint(ReflectiveMethodInvocation.java:182)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:149)\r\n\tat org.springframework.transaction.interceptor.TransactionInterceptor.invoke(TransactionInterceptor.java:106)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)\r\n\tat org.springframework.aop.interceptor.ExposeInvocationInterceptor.invoke(ExposeInvocationInterceptor.java:89)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)\r\n\tat org.springframework.aop.framework.JdkDynamicAopProxy.invoke(JdkDynamicAopProxy.java:204)\r\n\tat $Proxy39.addInterfaceLogInfo(Unknown Source)\r\n\tat cn.com.xb.servlet.RootServlet.doPost(RootServlet.java:72)\r\n\tat javax.servlet.http.HttpServlet.service(HttpServlet.java:643)\r\n\tat javax.servlet.http.HttpServlet.service(HttpServlet.java:723)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:290)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)\r\n\tat cn.com.xb.util.EncodingFilter.doFilter(EncodingFilter.java:23)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:235)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)\r\n\tat org.apache.catalina.core.StandardWrapperValve.invoke(StandardWrapperValve.java:233)\r\n\tat org.apache.catalina.core.StandardContextValve.invoke(StandardContextValve.java:191)\r\n\tat org.apache.catalina.core.StandardHostValve.invoke(StandardHostValve.java:127)\r\n\tat org.apache.catalina.valves.ErrorReportValve.invoke(ErrorReportValve.java:103)\r\n\tat org.apache.catalina.core.StandardEngineValve.invoke(StandardEngineValve.java:109)\r\n\tat org.apache.catalina.connector.CoyoteAdapter.service(CoyoteAdapter.java:293)\r\n\tat org.apache.coyote.http11.Http11NioProcessor.process(Http11NioProcessor.java:891)\r\n\tat org.apache.coyote.http11.Http11NioProtocol$Http11ConnectionHandler.process(Http11NioProtocol.java:750)\r\n\tat org.apache.tomcat.util.net.NioEndpoint$SocketProcessor.run(NioEndpoint.java:2282)\r\n\tat java.util.concurrent.ThreadPoolExecutor$Worker.runTask(ThreadPoolExecutor.java:886)\r\n\tat java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:908)\r\n\tat java.lang.Thread.run(Thread.java:619)\r\n\n\n** END NESTED EXCEPTION **\n\n\n\nLast packet sent to the server was 27 ms ago.; nested exception is com.mysql.jdbc.CommunicationsException: Communications link failure due to underlying exception: \n\n** BEGIN NESTED EXCEPTION ** \n\njava.net.SocketException\nMESSAGE: Software caused connection abort: socket write error\n\nSTACKTRACE:\n\njava.net.SocketException: Software caused connection abort: socket write error\r\n\tat java.net.SocketOutputStream.socketWrite0(Native Method)\r\n\tat java.net.SocketOutputStream.socketWrite(SocketOutputStream.java:92)\r\n\tat java.net.SocketOutputStream.write(SocketOutputStream.java:136)\r\n\tat java.io.BufferedOutputStream.flushBuffer(BufferedOutputStream.java:65)\r\n\tat java.io.BufferedOutputStream.flush(BufferedOutputStream.java:123)\r\n\tat com.mysql.jdbc.MysqlIO.send(MysqlIO.java:2744)\r\n\tat com.mysql.jdbc.MysqlIO.sendCommand(MysqlIO.java:1612)\r\n\tat com.mysql.jdbc.MysqlIO.sqlQueryDirect(MysqlIO.java:1723)\r\n\tat com.mysql.jdbc.Connection.execSQL(Connection.java:3283)\r\n\tat com.mysql.jdbc.PreparedStatement.executeInternal(PreparedStatement.java:1332)\r\n\tat com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1604)\r\n\tat com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1519)\r\n\tat com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1504)\r\n\tat org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)\r\n\tat org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)\r\n\tat org.springframework.jdbc.core.JdbcTemplate$2.doInPreparedStatement(JdbcTemplate.java:797)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.execute(JdbcTemplate.java:590)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:791)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:849)\r\n\tat org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:857)\r\n\tat cn.com.xb.dao.impl.StoragestationIntfLogDaoImpl.insert(StoragestationIntfLogDaoImpl.java:74)\r\n\tat cn.com.xb.service.impl.InterfaceLogServiceImpl.addInterfaceLogInfo(InterfaceLogServiceImpl.java:31)\r\n\tat sun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)\r\n\tat sun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:39)\r\n\tat sun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:25)\r\n\tat java.lang.reflect.Method.invoke(Method.java:597)\r\n\tat org.springframework.aop.support.AopUtils.invokeJoinpointUsingReflection(AopUtils.java:310)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.invokeJoinpoint(ReflectiveMethodInvocation.java:182)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:149)\r\n\tat org.springframework.transaction.interceptor.TransactionInterceptor.invoke(TransactionInterceptor.java:106)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)\r\n\tat org.springframework.aop.interceptor.ExposeInvocationInterceptor.invoke(ExposeInvocationInterceptor.java:89)\r\n\tat org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)\r\n\tat org.springframework.aop.framework.JdkDynamicAopProxy.invoke(JdkDynamicAopProxy.java:204)\r\n\tat $Proxy39.addInterfaceLogInfo(Unknown Source)\r\n\tat cn.com.xb.servlet.RootServlet.doPost(RootServlet.java:72)\r\n\tat javax.servlet.http.HttpServlet.service(HttpServlet.java:643)\r\n\tat javax.servlet.http.HttpServlet.service(HttpServlet.java:723)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:290)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)\r\n\tat cn.com.xb.util.EncodingFilter.doFilter(EncodingFilter.java:23)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:235)\r\n\tat org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)\r\n\tat org.apache.catalina.core.StandardWrapperValve.invoke(StandardWrapperValve.java:233)\r\n\tat org.apache.catalina.core.StandardContextValve.invoke(StandardContextValve.java:191)\r\n\tat org.apache.catalina.core.StandardHostValve.invoke(StandardHostValve.java:127)\r\n\tat org.apache.catalina.valves.ErrorReportValve.invoke(ErrorReportValve.java:103)\r\n\tat org.apache.catalina.core.StandardEngineValve.invoke(StandardEngineValve.java:109)\r\n\tat org.apache.catalina.connector.CoyoteAdapter.service(CoyoteAdapter.java:293)\r\n\tat org.apache.coyote.http11.Http11NioProcessor.process(Http11NioProcessor.java:891)\r\n\tat org.apache.coyote.http11.Http11NioProtocol$Http11ConnectionHandler.process(Http11NioProtocol.java:750)\r\n\tat org.apache.tomcat.util.net.NioEndpoint$SocketProcessor.run(NioEndpoint.java:2282)\r\n\tat java.util.concurrent.ThreadPoolExecutor$Worker.runTask(ThreadPoolExecutor.java:886)\r\n\tat java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:908)\r\n\tat java.lang.Thread.run(Thread.java:619)\r\n\n\n** END NESTED EXCEPTION **\n\n\n\nLast packet sent to the server was 27 ms ago."}}', N'2', N'接口异常！PreparedStatementCallback; SQL [INSERT INTO T_STORAGESTATION_INTF_LOG(LOG_ID,LOG_TIME,SS_ID,INTF_ID,MSG_CONTENT) VALUES(?,?,?,?,?)]; Communications link failure due to underlying exception: 

** BEGIN NESTED EXCEPTION ** 

java.net.SocketException
MESSAGE: Software caused connection abort: socket write error

STACKTRACE:

java.net.SocketException: Software caused connection abort: socket write error
	at java.net.SocketOutputStream.socketWrite0(Native Method)
	at java.net.SocketOutputStream.socketWrite(SocketOutputStream.java:92)
	at java.net.SocketOutputStream.write(SocketOutputStream.java:136)
	at java.io.BufferedOutputStream.flushBuffer(BufferedOutputStream.java:65)
	at java.io.BufferedOutputStream.flush(BufferedOutputStream.java:123)
	at com.mysql.jdbc.MysqlIO.send(MysqlIO.java:2744)
	at com.mysql.jdbc.MysqlIO.sendCommand(MysqlIO.java:1612)
	at com.mysql.jdbc.MysqlIO.sqlQueryDirect(MysqlIO.java:1723)
	at com.mysql.jdbc.Connection.execSQL(Connection.java:3283)
	at com.mysql.jdbc.PreparedStatement.executeInternal(PreparedStatement.java:1332)
	at com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1604)
	at com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1519)
	at com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1504)
	at org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)
	at org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)
	at org.springframework.jdbc.core.JdbcTemplate$2.doInPreparedStatement(JdbcTemplate.java:797)
	at org.springframework.jdbc.core.JdbcTemplate.execute(JdbcTemplate.java:590)
	at org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:791)
	at org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:849)
	at org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:857)
	at cn.com.xb.dao.impl.StoragestationIntfLogDaoImpl.insert(StoragestationIntfLogDaoImpl.java:74)
	at cn.com.xb.service.impl.InterfaceLogServiceImpl.addInterfaceLogInfo(InterfaceLogServiceImpl.java:31)
	at sun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)
	at sun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:39)
	at sun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:25)
	at java.lang.reflect.Method.invoke(Method.java:597)
	at org.springframework.aop.support.AopUtils.invokeJoinpointUsingReflection(AopUtils.java:310)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.invokeJoinpoint(ReflectiveMethodInvocation.java:182)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:149)
	at org.springframework.transaction.interceptor.TransactionInterceptor.invoke(TransactionInterceptor.java:106)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)
	at org.springframework.aop.interceptor.ExposeInvocationInterceptor.invoke(ExposeInvocationInterceptor.java:89)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)
	at org.springframework.aop.framework.JdkDynamicAopProxy.invoke(JdkDynamicAopProxy.java:204)
	at $Proxy39.addInterfaceLogInfo(Unknown Source)
	at cn.com.xb.servlet.RootServlet.doPost(RootServlet.java:72)
	at javax.servlet.http.HttpServlet.service(HttpServlet.java:643)
	at javax.servlet.http.HttpServlet.service(HttpServlet.java:723)
	at org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:290)
	at org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)
	at cn.com.xb.util.EncodingFilter.doFilter(EncodingFilter.java:23)
	at org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:235)
	at org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)
	at org.apache.catalina.core.StandardWrapperValve.invoke(StandardWrapperValve.java:233)
	at org.apache.catalina.core.StandardContextValve.invoke(StandardContextValve.java:191)
	at org.apache.catalina.core.StandardHostValve.invoke(StandardHostValve.java:127)
	at org.apache.catalina.valves.ErrorReportValve.invoke(ErrorReportValve.java:103)
	at org.apache.catalina.core.StandardEngineValve.invoke(StandardEngineValve.java:109)
	at org.apache.catalina.connector.CoyoteAdapter.service(CoyoteAdapter.java:293)
	at org.apache.coyote.http11.Http11NioProcessor.process(Http11NioProcessor.java:891)
	at org.apache.coyote.http11.Http11NioProtocol$Http11ConnectionHandler.process(Http11NioProtocol.java:750)
	at org.apache.tomcat.util.net.NioEndpoint$SocketProcessor.run(NioEndpoint.java:2282)
	at java.util.concurrent.ThreadPoolExecutor$Worker.runTask(ThreadPoolExecutor.java:886)
	at java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:908)
	at java.lang.Thread.run(Thread.java:619)


** END NESTED EXCEPTION **



Last packet sent to the server was 27 ms ago.; nested exception is com.mysql.jdbc.CommunicationsException: Communications link failure due to underlying exception: 

** BEGIN NESTED EXCEPTION ** 

java.net.SocketException
MESSAGE: Software caused connection abort: socket write error

STACKTRACE:

java.net.SocketException: Software caused connection abort: socket write error
	at java.net.SocketOutputStream.socketWrite0(Native Method)
	at java.net.SocketOutputStream.socketWrite(SocketOutputStream.java:92)
	at java.net.SocketOutputStream.write(SocketOutputStream.java:136)
	at java.io.BufferedOutputStream.flushBuffer(BufferedOutputStream.java:65)
	at java.io.BufferedOutputStream.flush(BufferedOutputStream.java:123)
	at com.mysql.jdbc.MysqlIO.send(MysqlIO.java:2744)
	at com.mysql.jdbc.MysqlIO.sendCommand(MysqlIO.java:1612)
	at com.mysql.jdbc.MysqlIO.sqlQueryDirect(MysqlIO.java:1723)
	at com.mysql.jdbc.Connection.execSQL(Connection.java:3283)
	at com.mysql.jdbc.PreparedStatement.executeInternal(PreparedStatement.java:1332)
	at com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1604)
	at com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1519)
	at com.mysql.jdbc.PreparedStatement.executeUpdate(PreparedStatement.java:1504)
	at org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)
	at org.apache.tomcat.dbcp.dbcp.DelegatingPreparedStatement.executeUpdate(DelegatingPreparedStatement.java:105)
	at org.springframework.jdbc.core.JdbcTemplate$2.doInPreparedStatement(JdbcTemplate.java:797)
	at org.springframework.jdbc.core.JdbcTemplate.execute(JdbcTemplate.java:590)
	at org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:791)
	at org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:849)
	at org.springframework.jdbc.core.JdbcTemplate.update(JdbcTemplate.java:857)
	at cn.com.xb.dao.impl.StoragestationIntfLogDaoImpl.insert(StoragestationIntfLogDaoImpl.java:74)
	at cn.com.xb.service.impl.InterfaceLogServiceImpl.addInterfaceLogInfo(InterfaceLogServiceImpl.java:31)
	at sun.reflect.NativeMethodAccessorImpl.invoke0(Native Method)
	at sun.reflect.NativeMethodAccessorImpl.invoke(NativeMethodAccessorImpl.java:39)
	at sun.reflect.DelegatingMethodAccessorImpl.invoke(DelegatingMethodAccessorImpl.java:25)
	at java.lang.reflect.Method.invoke(Method.java:597)
	at org.springframework.aop.support.AopUtils.invokeJoinpointUsingReflection(AopUtils.java:310)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.invokeJoinpoint(ReflectiveMethodInvocation.java:182)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:149)
	at org.springframework.transaction.interceptor.TransactionInterceptor.invoke(TransactionInterceptor.java:106)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)
	at org.springframework.aop.interceptor.ExposeInvocationInterceptor.invoke(ExposeInvocationInterceptor.java:89)
	at org.springframework.aop.framework.ReflectiveMethodInvocation.proceed(ReflectiveMethodInvocation.java:171)
	at org.springframework.aop.framework.JdkDynamicAopProxy.invoke(JdkDynamicAopProxy.java:204)
	at $Proxy39.addInterfaceLogInfo(Unknown Source)
	at cn.com.xb.servlet.RootServlet.doPost(RootServlet.java:72)
	at javax.servlet.http.HttpServlet.service(HttpServlet.java:643)
	at javax.servlet.http.HttpServlet.service(HttpServlet.java:723)
	at org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:290)
	at org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)
	at cn.com.xb.util.EncodingFilter.doFilter(EncodingFilter.java:23)
	at org.apache.catalina.core.ApplicationFilterChain.internalDoFilter(ApplicationFilterChain.java:235)
	at org.apache.catalina.core.ApplicationFilterChain.doFilter(ApplicationFilterChain.java:206)
	at org.apache.catalina.core.StandardWrapperValve.invoke(StandardWrapperValve.java:233)
	at org.apache.catalina.core.StandardContextValve.invoke(StandardContextValve.java:191)
	at org.apache.catalina.core.StandardHostValve.invoke(StandardHostValve.java:127)
	at org.apache.catalina.valves.ErrorReportValve.invoke(ErrorReportValve.java:103)
	at org.apache.catalina.core.StandardEngineValve.invoke(StandardEngineValve.java:109)
	at org.apache.catalina.connector.CoyoteAdapter.service(CoyoteAdapter.java:293)
	at org.apache.coyote.http11.Http11NioProcessor.process(Http11NioProcessor.java:891)
	at org.apache.coyote.http11.Http11NioProtocol$Http11ConnectionHandler.process(Http11NioProtocol.java:750)
	at org.apache.tomcat.util.net.NioEndpoint$SocketProcessor.run(NioEndpoint.java:2282)
	at java.util.concurrent.ThreadPoolExecutor$Worker.runTask(ThreadPoolExecutor.java:886)
	at java.util.concurrent.ThreadPoolExecutor$Worker.run(ThreadPoolExecutor.java:908)
	at java.lang.Thread.run(Thread.java:619)


** END NESTED EXCEPTION **



Last packet sent to the server was 27 ms ago.', CAST(0x0000A2F700DAFC6E AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'e887e232-6b3c-4586-8d22-57882aeb1f21', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"7dc6459bff7240ee9ea01909ce03fdb5","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF56D AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'ecec146a-5cca-4e22-ac96-59b979ae0d99', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 00:11:14","clientUploadTime":"2014-03-23 00:11:14","transactionInfo":{"transactionID":"ea4f002caf814546a6bea6be5fcd29f0","boxCode":"021-001000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"addressInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"courierInfo":null}}}', N'{"BaseResponse":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"接口异常！null"}}', N'2', N'接口异常！null', CAST(0x0000A2F700031688 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'ee7af06c-ab9d-4f9f-bc80-757a6d101d7a', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":5,"storageStationId":"31010100010101","clientTime":"2014-03-23 16:41:44","clientUploadTime":"2014-03-23 16:41:44","transactionInfo":{"transactionID":"a7677c4081fb403da3f9a879848199e0","boxCode":"31010100010101001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":5.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":5.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"a7677c4081fb403da3f9a879848199e0","storageStationId":31010100010101,"boxcode":"31010100010101001003","pricingStarts":5,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":""}}', N'1', N'', CAST(0x0000A2F701132355 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'ee81b072-c2a7-4746-b529-54b7bb50e436', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-23 17:17:35","clientUploadTime":"2014-03-23 17:17:35","transactionInfo":{"transactionID":"9c6e1244fd154f81876c3c9bd8b60208","boxCode":"31010100010101001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'', N'9', N'操作超时', CAST(0x0000A2F7011CFB82 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'f36e10ea-5167-44e0-92e7-69fea14c91f1', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"021-001","clientTime":"2014-03-23 13:35:24","clientUploadTime":"2014-03-23 13:35:24","transactionInfo":{"transactionID":"dc4e9b6b84c04e3193bf20b278ff777e","boxCode":"021-001001003","supplierId":"","expressDeliveryId":"","expressCode":"","expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":10.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":10.0,"pickupPassword":"","isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"addresseeInfo":{"name":null,"mobilePhone":"18018669090","address":null,"email":null},"courierInfo":null}}}', N'{"cn.com.xb.inter.domain.response.TransactionResult":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"物箱在平台不存在。","storageStationId":"021-001","pricingStarts":0,"freeTime":0,"overTimeUnitPrice":0,"maximumPrice":0,"overdueTime":0}}', N'2', N'物箱在平台不存在。', CAST(0x0000A2F700DFF59C AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'f8db0827-99b7-4a0a-8b95-e956eb055a2a', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-23 00:06:36","clientUploadTime":"2014-03-23 00:06:36","transactionInfo":{"transactionID":"ABCDEF1234567890","boxCode":"31010100010101000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"addressInfo":{"name":null,"mobilePhone":null,"address":null,"email":null},"courierInfo":null}}}', N'{"BaseResponse":{"sequenceNumber":0,"resultStatus":0,"errorMsg":"接口异常！null"}}', N'2', N'接口异常！null', CAST(0x0000A2F700022A82 AS DateTime))
GO
INSERT [dbo].[T_Log_Platform_Transfer] ([Log_Id], [Request_Name], [Request_ApplyCode], [Request_MSG], [Response_Body], [Result_Code], [Result_Message], [Date_Created]) VALUES (N'f9777fc6-7c6c-49ff-9080-2b6ef3d0eea8', N'TransactionWrapper', N'2', N'{"TransactionWrapper":{"sequenceNumber":0,"transActionType":1,"storageStationId":"31010100010101","clientTime":"2014-03-22 17:20:33","clientUploadTime":"2014-03-22 17:20:33","transactionInfo":{"transactionID":"ABCDEF1234567890","boxCode":"31010100010101000000","supplierId":"","expressDeliveryId":"","expressCode":null,"expressDescription":"","storageTime":360,"pastDueTime":0,"totalAmount":0.0,"payType":1,"payMode":1,"voucherId":"","voucherTotal":0,"payPrice":0.0,"pickupPassword":null,"isStandardsCompliant":1,"notStandardsCompliantCause":"","expressSizeType":0,"senderInfo":{"name":null,"mobilePhone":null,"address":null,"email":null}}}}', N'{"TransactionResult":{"sequenceNumber":0,"resultStatus":1,"transactionID":"ABCDEF1234567890","storageStationId":31010100010101,"boxcode":"31010100010101000000","pricingStarts":0,"freeTime":360,"overTimeUnitPrice":1,"maximumPrice":10,"overdueTime":1440,"pickupPassword":"null"}}', N'1', N'', CAST(0x0000A2F6011DCCF4 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[WuXiangZhuangTai] ON 

GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (1, 1, 1, 2, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (2, 1, 2, 0, 1, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (3, 1, 3, 0, 0, 0, 0, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (4, 1, 4, 0, 0, 0, 0, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (5, 1, 5, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (6, 1, 6, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (7, 1, 7, 1, 0, 0, 0, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (8, 1, 8, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (9, 1, 9, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (10, 1, 10, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (11, 1, 11, 2, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (12, 1, 12, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (13, 1, 13, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (14, 1, 14, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (15, 1, 15, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (16, 1, 16, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (17, 1, 17, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (18, 1, 18, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (19, 1, 19, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (20, 1, 20, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (21, 2, 1, 2, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (22, 2, 2, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (23, 2, 3, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (24, 2, 4, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (25, 2, 5, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (26, 2, 6, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (27, 2, 7, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (28, 2, 8, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (29, 2, 9, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (30, 2, 10, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (31, 2, 11, 2, 1, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (32, 2, 12, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (33, 2, 13, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (34, 2, 14, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (35, 2, 15, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (36, 2, 16, 0, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (37, 2, 17, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (38, 2, 18, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (39, 2, 19, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
INSERT [dbo].[WuXiangZhuangTai] ([Key_ID], [GroupNo], [BianHao], [DaXiaoZhuangTai], [ZhengChangZhuangTai], [KaiGuanZhuangTai], [YouWuZhuangTai], [YouWuLeiXing], [SheZhiShiJian], [SheZhiRen], [ShiYongFlag]) VALUES (40, 2, 20, 1, 0, 0, 1, 0, CAST(0x0000A2A000000000 AS DateTime), N'李秀银', 1)
GO
SET IDENTITY_INSERT [dbo].[WuXiangZhuangTai] OFF
GO
ALTER TABLE [dbo].[WuXiangZhuangTai] ADD  CONSTRAINT [DF_WuXiangZhuangTai_YouWuLeiXing]  DEFAULT ((0)) FOR [YouWuLeiXing]
GO
