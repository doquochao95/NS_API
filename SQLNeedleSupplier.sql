USE master
GO
IF NOT EXISTS (
	SELECT name
	FROM sys.databases
	WHERE name = N'_NEEDLE_SUPPLIER_'
)
CREATE DATABASE [_NEEDLE_SUPPLIER_];
GO
USE [_NEEDLE_SUPPLIER_]
/****** Object:  Table [dbo].[NS_Buildings]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_Buildings](
	[BuildingID] [int] IDENTITY NOT NULL,
	[BuildingName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NS_BUILDINGS] PRIMARY KEY CLUSTERED 
(
	[BuildingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_Devices]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_Devices](
	[DeviceID] [int] IDENTITY NOT NULL,
	[DeviceName] [nvarchar](max) NOT NULL,
	[DeviceCode] [nvarchar](max) NOT NULL,
	[LastOnlineTime] [datetime] NULL,
	[LastOnlineTimeStr] [nvarchar](max) NULL,
	[LastOfflineTime] [datetime] NULL,
	[LastOfflineTimeStr] [nvarchar](max) NULL,
	[BuildingID] [int] NOT NULL,
 CONSTRAINT [PK_NS_DEVICES] PRIMARY KEY CLUSTERED 
(
	[DeviceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_GetRecords]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_GetRecords](
	[GetRecordID] [int] IDENTITY NOT NULL,
	[GetTime] [datetime] NOT NULL,
	[GetTimeStr] [nvarchar](max) NOT NULL,
	[DeviceID] [int] NOT NULL,
	[BuildingID] [int] NOT NULL,
 CONSTRAINT [PK_NS_GETRECORD] PRIMARY KEY CLUSTERED 
(
	[GetRecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_Lines]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_Lines](
	[LineID] [int] IDENTITY NOT NULL,
	[LineName] [nvarchar](max) NOT NULL,
	[BuildingID] [int] NOT NULL,
 CONSTRAINT [PK_NS_LINES] PRIMARY KEY CLUSTERED 
(
	[LineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_Needles]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_Needles](
	[NeedleID] [int] IDENTITY NOT NULL,
	[NeedleName] [nvarchar](max) NOT NULL,
	[NeedleCode] [nvarchar](max) NOT NULL,
	[NeedleSize] [nvarchar](max) NOT NULL,
	[NeedlePoint] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NS_NEEDLES] PRIMARY KEY CLUSTERED 
(
	[NeedleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_PostRecords]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_PostRecords](
	[PostRecordID] [int] IDENTITY NOT NULL,
	[PostTime] [datetime] NOT NULL,
	[PostTimeStr] [nvarchar](max) NOT NULL,
	[DeviceID] [int] NOT NULL,
	[BuildingID] [int] NOT NULL,
 CONSTRAINT [PK_NS_POSTRECORD] PRIMARY KEY CLUSTERED 
(
	[PostRecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_Staffs]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_Staffs](
	[StaffID] [int] IDENTITY NOT NULL,
	[StaffName] [nvarchar](max) NOT NULL,
	[CardNumber] [int] NOT NULL,
	[Department] [nvarchar](max) NOT NULL,
	[LineID] [int] NOT NULL,
	[BuildingID] [int] NOT NULL,
	[RFIDCode] [nvarchar](max) NOT NULL,
	[DeviceID] [int] NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[UserPassword] [nvarchar](max) NULL,
	[UserLayer] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NS_STAFFS] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_Stocks]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_Stocks](
	[StockID] [int] IDENTITY NOT NULL,
	[DeviceID] [int] NOT NULL,
	[NeedleID] [int] NOT NULL,
	[CurrentQuantity] [int] NOT NULL,
	[VaryingQuantity] [int] NOT NULL,
	[Time] [datetime] NOT NULL,
	[TimrStr] [nvarchar](max) NOT NULL,
	[StaffID] [int] NOT NULL,
 CONSTRAINT [PK_NS_STOCK] PRIMARY KEY CLUSTERED 
(
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NS_Trackings]    Script Date: 6/2/2021 3:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NS_Trackings](
	[TrackingID] [int] IDENTITY NOT NULL,
	[DeviceID] [int] NOT NULL,
	[LineID] [int] NOT NULL,
	[NeedleID] [int] NOT NULL,
	[TrackingTime] [datetime] NOT NULL,
	[TrackingTimeStr] [nvarchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ConfirmedPic] [image] NULL,
	[StaffID] [int] NOT NULL,
 CONSTRAINT [PK_NS_TRACKING] PRIMARY KEY CLUSTERED 
(
	[TrackingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[NS_Buildings] ( [BuildingName]) VALUES (N'Building E')
GO
INSERT [dbo].[NS_Buildings] ( [BuildingName]) VALUES (N'Building I')
GO
INSERT [dbo].[NS_Buildings] ( [BuildingName]) VALUES (N'Building J')
GO
INSERT [dbo].[NS_Buildings] ( [BuildingName]) VALUES (N'Building L')
GO
INSERT [dbo].[NS_Buildings] ( [BuildingName]) VALUES (N'Building M')
GO
INSERT [dbo].[NS_Buildings] ( [BuildingName]) VALUES (N'Building O')
GO
INSERT [dbo].[NS_Buildings] ( [BuildingName]) VALUES (N'Building P')
GO
INSERT [dbo].[NS_Devices] ([DeviceName], [DeviceCode], [BuildingID]) VALUES (N'Machine E1', N'NS_E123', 1)
GO
INSERT [dbo].[NS_Devices] ([DeviceName], [DeviceCode], [BuildingID]) VALUES (N'Machine I1', N'NS_I123', 2)
GO
INSERT [dbo].[NS_Devices] ([DeviceName], [DeviceCode], [BuildingID]) VALUES (N'Machine J1', N'NS_J123', 3)
GO
INSERT [dbo].[NS_Devices] ([DeviceName], [DeviceCode], [BuildingID]) VALUES (N'Machine L1', N'NS_L123', 4)
GO
INSERT [dbo].[NS_Devices] ([DeviceName], [DeviceCode], [BuildingID]) VALUES (N'Machine M1', N'NS_M123', 5)
GO
INSERT [dbo].[NS_Devices] ([DeviceName], [DeviceCode], [BuildingID]) VALUES (N'Machine O1', N'NS_O123', 6)
GO
INSERT [dbo].[NS_Devices] ([DeviceName], [DeviceCode], [BuildingID]) VALUES (N'Machine P1', N'NS_P123', 7)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'E1', 1)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'E2', 1)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'E3', 1)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'E4', 1)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'E5', 1)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'E6', 1)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'E7', 1)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I1', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I2', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I3', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I4', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I5', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I6', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I7', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I8', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I9', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I10', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'I11', 2)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'J1', 3)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'J2', 3)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'J3', 3)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'L1', 4)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'L2', 4)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'L3', 4)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'L4', 4)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'L5', 4)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'L6', 4)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'M1', 5)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'M2', 5)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'M3', 5)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'O1', 6)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'O2', 6)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'P1', 7)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'P2', 7)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'P3', 7)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'P4', 7)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'P5', 7)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'P6', 7)
GO
INSERT [dbo].[NS_Lines] ([LineName], [BuildingID]) VALUES (N'P7', 7)
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'715862', N'134 S/135X8NCR/PFX134KS 05', N'75-11', N'S')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'715892', N'134 S/135X8NCR/PFX134KS 90', N'90/14', N'S')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'715902', N'134 S/134 DI/135X8NCR/PFX134KS 100', N'100/16 S', N'S')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'715912', N'134 S/134 DI/135X8NCR/PFX134KS 110', N'110/18', N'S')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'716742', N'134-35/2134-35/DPX35 100', N'100/16', N'R ')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'716822', N'134-35/2134-35/DPX35 180', N'180/24', N'R')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'717242', N'134-35 LR/2134-35 LR 110', N'110/18', N'LR')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'717342', N'134-35S/2134-35S/DPX35S 100', N'100/16', N'S')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'717472', N'134/DPX5/135X5 75', N'75/11', N'R')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'717502', N'134/DPX5/135X5 75', N'90/14', N'R')
GO
INSERT [dbo].[NS_Needles] ([NeedleName], [NeedleCode], [NeedleSize], [NeedlePoint]) VALUES (N'717512', N'134/DPX5/135X5', N'100/16', N'R')
GO
INSERT [dbo].[NS_Staffs] ([StaffName], [CardNumber], [Department], [LineID], [BuildingID], [RFIDCode], [DeviceID], [UserName], [UserPassword], [UserLayer]) VALUES (N'Do Quoc Hao', 64230, N'A81', 1, 1, N'1A11A273', 1, N'haodo', N'shc@1234', N'admin')
GO
INSERT [dbo].[NS_Staffs] ([StaffName], [CardNumber], [Department], [LineID], [BuildingID], [RFIDCode], [DeviceID], [UserName], [UserPassword], [UserLayer]) VALUES (N'Banh Thi A', 99999, N'A99', 1, 1, N'009D602B', 1, N'abanh', N'shc@1234', N'client')
GO

ALTER TABLE [dbo].[NS_Devices]  WITH CHECK ADD  CONSTRAINT [FK_NS_Devices_NS_Buildings] FOREIGN KEY([BuildingID])
REFERENCES [dbo].[NS_Buildings] ([BuildingID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_Devices] CHECK CONSTRAINT [FK_NS_Devices_NS_Buildings]
GO

ALTER TABLE [dbo].[NS_GetRecords]  WITH CHECK ADD  CONSTRAINT [FK_NS_GetRecord_NS_Buildings] FOREIGN KEY([BuildingID])
REFERENCES [dbo].[NS_Buildings] ([BuildingID])
GO
ALTER TABLE [dbo].[NS_GetRecords] CHECK CONSTRAINT [FK_NS_GetRecord_NS_Buildings]
GO

ALTER TABLE [dbo].[NS_GetRecords]  WITH CHECK ADD  CONSTRAINT [FK_NS_GetRecords_NS_Devices] FOREIGN KEY([DeviceID])
REFERENCES [dbo].[NS_Devices] ([DeviceID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_GetRecords] CHECK CONSTRAINT [FK_NS_GetRecords_NS_Devices]
GO

ALTER TABLE [dbo].[NS_Lines]  WITH CHECK ADD  CONSTRAINT [FK_NS_Lines_NS_Buildings] FOREIGN KEY([BuildingID])
REFERENCES [dbo].[NS_Buildings] ([BuildingID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_Lines] CHECK CONSTRAINT [FK_NS_Lines_NS_Buildings]
GO

ALTER TABLE [dbo].[NS_PostRecords]  WITH CHECK ADD  CONSTRAINT [FK_NS_PostRecord_NS_Buildings] FOREIGN KEY([BuildingID])
REFERENCES [dbo].[NS_Buildings] ([BuildingID])
GO
ALTER TABLE [dbo].[NS_PostRecords] CHECK CONSTRAINT [FK_NS_PostRecord_NS_Buildings]
GO

ALTER TABLE [dbo].[NS_PostRecords]  WITH CHECK ADD  CONSTRAINT [FK_NS_PostRecords_NS_Devices] FOREIGN KEY([DeviceID])
REFERENCES [dbo].[NS_Devices] ([DeviceID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_PostRecords] CHECK CONSTRAINT [FK_NS_PostRecords_NS_Devices]
GO

ALTER TABLE [dbo].[NS_Staffs]  WITH CHECK ADD  CONSTRAINT [FK_NS_Staffs_NS_Buildings] FOREIGN KEY([BuildingID])
REFERENCES [dbo].[NS_Buildings] ([BuildingID])
GO
ALTER TABLE [dbo].[NS_Staffs] CHECK CONSTRAINT [FK_NS_Staffs_NS_Buildings]
GO

ALTER TABLE [dbo].[NS_Staffs]  WITH CHECK ADD  CONSTRAINT [FK_NS_Staffs_NS_Devices] FOREIGN KEY([DeviceID])
REFERENCES [dbo].[NS_Devices] ([DeviceID])
GO
ALTER TABLE [dbo].[NS_Staffs] CHECK CONSTRAINT [FK_NS_Staffs_NS_Devices]
GO

ALTER TABLE [dbo].[NS_Staffs]  WITH CHECK ADD  CONSTRAINT [FK_NS_Staffs_NS_Lines] FOREIGN KEY([LineID])
REFERENCES [dbo].[NS_Lines] ([LineID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_Staffs] CHECK CONSTRAINT [FK_NS_Staffs_NS_Lines]
GO

ALTER TABLE [dbo].[NS_Stocks]  WITH CHECK ADD  CONSTRAINT [FK_NS_Stocks_NS_Devices] FOREIGN KEY([DeviceID])
REFERENCES [dbo].[NS_Devices] ([DeviceID])
GO
ALTER TABLE [dbo].[NS_Stocks] CHECK CONSTRAINT [FK_NS_Stocks_NS_Devices]
GO

ALTER TABLE [dbo].[NS_Stocks]  WITH CHECK ADD  CONSTRAINT [FK_NS_Stocks_NS_Needles] FOREIGN KEY([NeedleID])
REFERENCES [dbo].[NS_Needles] ([NeedleID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_Stocks] CHECK CONSTRAINT [FK_NS_Stocks_NS_Needles]
GO

ALTER TABLE [dbo].[NS_Stocks]  WITH CHECK ADD  CONSTRAINT [FK_NS_Stocks_NS_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[NS_Staffs] ([StaffID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_Stocks] CHECK CONSTRAINT [FK_NS_Stocks_NS_Staffs]
GO

ALTER TABLE [dbo].[NS_Trackings]  WITH CHECK ADD  CONSTRAINT [FK_NS_Tracking_NS_Lines] FOREIGN KEY([LineID])
REFERENCES [dbo].[NS_Lines] ([LineID])
GO
ALTER TABLE [dbo].[NS_Trackings] CHECK CONSTRAINT [FK_NS_Tracking_NS_Lines]
GO

ALTER TABLE [dbo].[NS_Trackings]  WITH CHECK ADD  CONSTRAINT [FK_NS_Tracking_NS_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[NS_Staffs] ([StaffID])
GO
ALTER TABLE [dbo].[NS_Trackings] CHECK CONSTRAINT [FK_NS_Tracking_NS_Staffs]
GO

ALTER TABLE [dbo].[NS_Trackings]  WITH CHECK ADD  CONSTRAINT [FK_NS_Tracking_NS_Devices] FOREIGN KEY([DeviceID])
REFERENCES [dbo].[NS_Devices] ([DeviceID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_Trackings] CHECK CONSTRAINT [FK_NS_Tracking_NS_Devices]
GO

ALTER TABLE [dbo].[NS_Trackings]  WITH CHECK ADD  CONSTRAINT [FK_NS_Tracking_NS_Needles] FOREIGN KEY([NeedleID])
REFERENCES [dbo].[NS_Needles] ([NeedleID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NS_Trackings] CHECK CONSTRAINT [FK_NS_Tracking_NS_Needles]
GO
