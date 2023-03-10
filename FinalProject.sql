USE [FinalProject]
GO
/****** Object:  Table [dbo].[tCoupon]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCoupon](
	[fSID] [int] IDENTITY(1,1) NOT NULL,
	[fCode] [nvarchar](10) NOT NULL,
	[fStartDate] [smalldatetime] NOT NULL,
	[fEndDate] [smalldatetime] NOT NULL,
	[fRatio] [tinyint] NOT NULL,
	[fAvailableTimes] [int] NOT NULL,
	[fUsedTimes] [int] NOT NULL,
 CONSTRAINT [PK_tCoupon_1] PRIMARY KEY CLUSTERED 
(
	[fCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCustomer]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCustomer](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fLastName] [nvarchar](20) NOT NULL,
	[fFirstName] [nvarchar](20) NOT NULL,
	[fGender] [tinyint] NOT NULL,
	[fTel] [nvarchar](20) NOT NULL,
	[fMobile] [nvarchar](20) NOT NULL,
	[fEmail] [nvarchar](50) NOT NULL,
	[fPassword] [nvarchar](20) NOT NULL,
	[fBirthDate] [smalldatetime] NOT NULL,
	[fPoint] [int] NOT NULL,
	[fBlackList] [bit] NOT NULL,
	[fRemark] [nvarchar](255) NULL,
	[fCreationDate] [smalldatetime] NOT NULL,
	[fLastUpdateDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tCustomer] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tCustomerOrderSheet]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tCustomerOrderSheet](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fCustomerID] [int] NOT NULL,
	[fCouponCode] [nvarchar](10) NULL,
	[fCreationDate] [smalldatetime] NOT NULL,
	[fCheckedDate] [smalldatetime] NULL,
 CONSTRAINT [PK_tOrderSheet] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tGender]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tGender](
	[fID] [tinyint] NOT NULL,
	[fDescription] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tGender] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tManager]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tManager](
	[fSID] [int] IDENTITY(1,1) NOT NULL,
	[fAccount] [nvarchar](20) NOT NULL,
	[fPassword] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tManager_1] PRIMARY KEY CLUSTERED 
(
	[fAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tOrderDetail]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tOrderDetail](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fCustomerOrderSheetID] [int] NOT NULL,
	[fProductID] [int] NOT NULL,
	[fPurchaseQuantity] [int] NOT NULL,
 CONSTRAINT [PK_tOrderDetail] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPeriod]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPeriod](
	[fID] [tinyint] NOT NULL,
	[fDescription] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tPeriod] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tProduct]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tProduct](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fName] [nvarchar](50) NOT NULL,
	[fPeriodID] [tinyint] NOT NULL,
	[fCost] [money] NOT NULL,
	[fPrice] [money] NOT NULL,
	[fStocks] [int] NOT NULL,
	[fDescription] [nvarchar](255) NOT NULL,
	[fImagePath] [nvarchar](255) NOT NULL,
	[fMinParticipants] [tinyint] NOT NULL,
	[fMaxParticipants] [tinyint] NOT NULL,
	[fAssemblyPoint] [nvarchar](100) NOT NULL,
	[fStartDate] [smalldatetime] NOT NULL,
	[fEndDate] [smalldatetime] NOT NULL,
	[fProviderID] [int] NOT NULL,
	[fRemoved] [bit] NOT NULL,
	[fRemark] [nvarchar](255) NULL,
	[fCreationDate] [smalldatetime] NOT NULL,
	[fLastUpdateDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tProduct] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tProductReport]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tProductReport](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fOrderDetailID] [int] NOT NULL,
	[fReportContent] [nvarchar](500) NOT NULL,
	[fCreationDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tProductReport] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tProductReview]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tProductReview](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fOrderDetailID] [int] NOT NULL,
	[fReviewContent] [nvarchar](500) NOT NULL,
	[fScore] [tinyint] NOT NULL,
	[fCreationDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tProductReview] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tProductsTag]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tProductsTag](
	[fSID] [int] IDENTITY(1,1) NOT NULL,
	[fProductID] [int] NOT NULL,
	[fTagID] [int] NOT NULL,
 CONSTRAINT [PK_tProductsTag] PRIMARY KEY CLUSTERED 
(
	[fSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tProvider]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tProvider](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fCompanyName] [nvarchar](50) NOT NULL,
	[fPassword] [nvarchar](20) NOT NULL,
	[fTaxID] [nchar](8) NOT NULL,
	[fFax] [nvarchar](20) NULL,
	[fOwnerName] [nvarchar](40) NOT NULL,
	[fOwnerTel] [nvarchar](20) NOT NULL,
	[fOwnerMobile] [nvarchar](20) NOT NULL,
	[fOwnerEmail] [nvarchar](50) NOT NULL,
	[fContactName] [nvarchar](40) NOT NULL,
	[fContactTel] [nvarchar](20) NOT NULL,
	[fContactMobile] [nvarchar](20) NOT NULL,
	[fContactEmail] [nvarchar](50) NOT NULL,
	[fAddress] [nvarchar](50) NOT NULL,
	[fBankName] [nvarchar](50) NOT NULL,
	[fBankDivisionName] [nvarchar](50) NOT NULL,
	[fBankAccountNumber] [nvarchar](50) NOT NULL,
	[fBankAccountName] [nvarchar](50) NOT NULL,
	[fBlackList] [bit] NOT NULL,
	[fRemark] [nvarchar](255) NULL,
	[fCreationDate] [smalldatetime] NOT NULL,
	[fLastUpdateDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tProvider] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPurchaseOrderSheet]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPurchaseOrderSheet](
	[fID] [int] IDENTITY(1,1) NOT NULL,
	[fOrderDetailID] [int] NOT NULL,
	[fCreationDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tPurchaseOrderSheet] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tShoppingCart]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tShoppingCart](
	[fSID] [int] IDENTITY(1,1) NOT NULL,
	[fCustomerID] [int] NOT NULL,
	[fProductID] [int] NOT NULL,
	[fPurchaseQuantity] [int] NOT NULL,
	[fAddDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tShoppingCart] PRIMARY KEY CLUSTERED 
(
	[fSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tTag]    Script Date: 2023/2/3 上午 02:52:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tTag](
	[fID] [int] NOT NULL,
	[fDescription] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tTag] PRIMARY KEY CLUSTERED 
(
	[fID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tCoupon] ON 

INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (1, N'triplook23', CAST(N'2023-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-03-31T00:00:00' AS SmallDateTime), 90, 30, 17)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (11, N'triplook50', CAST(N'2022-02-02T00:00:00' AS SmallDateTime), CAST(N'2022-02-03T00:00:00' AS SmallDateTime), 50, 1, 1)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (2, N'triplook55', CAST(N'2023-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 95, 100, 27)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (10, N'triplook60', CAST(N'2022-02-02T00:00:00' AS SmallDateTime), CAST(N'2022-02-03T00:00:00' AS SmallDateTime), 60, 5, 5)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (5, N'triplook64', CAST(N'2023-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-03-31T00:00:00' AS SmallDateTime), 80, 10, 6)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (9, N'triplook66', CAST(N'2022-02-02T00:00:00' AS SmallDateTime), CAST(N'2022-02-03T00:00:00' AS SmallDateTime), 80, 10, 10)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (6, N'triplook77', CAST(N'2022-09-01T00:00:00' AS SmallDateTime), CAST(N'2022-12-31T00:00:00' AS SmallDateTime), 90, 500, 249)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (4, N'triplook84', CAST(N'2022-09-01T00:00:00' AS SmallDateTime), CAST(N'2022-12-31T00:00:00' AS SmallDateTime), 95, 1000, 967)
INSERT [dbo].[tCoupon] ([fSID], [fCode], [fStartDate], [fEndDate], [fRatio], [fAvailableTimes], [fUsedTimes]) VALUES (8, N'triplook99', CAST(N'2022-02-02T00:00:00' AS SmallDateTime), CAST(N'2022-02-03T00:00:00' AS SmallDateTime), 75, 5, 5)
SET IDENTITY_INSERT [dbo].[tCoupon] OFF
GO
SET IDENTITY_INSERT [dbo].[tCustomer] ON 

INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (1, N'陳', N'晗運', 1, N'025522866', N'0934532944', N'sam@gmail.com', N'FHvZXq8V', CAST(N'1998-05-06T00:00:00' AS SmallDateTime), 100, 0, NULL, CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2023-01-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (3, N'黃', N'宇容', 2, N'05279370', N'0913644811', N'lin@yahoo.com', N'cqSJa8MB', CAST(N'1997-04-21T00:00:00' AS SmallDateTime), 0, 0, NULL, CAST(N'2023-01-03T00:00:00' AS SmallDateTime), CAST(N'2023-01-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (4, N'林', N'勁易', 1, N'032714065', N'0961958500', N'jacob5041@hotmail.com', N'f75mLASz', CAST(N'1999-06-09T00:00:00' AS SmallDateTime), 50, 1, N'未付錢', CAST(N'2022-04-15T00:00:00' AS SmallDateTime), CAST(N'2023-01-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (6, N'潘', N'諄驥', 1, N'05248448', N'0938747385', N'clyde5853@hotmail.com', N'9ZTZL8Ku', CAST(N'1998-01-17T00:00:00' AS SmallDateTime), 0, 0, NULL, CAST(N'2022-11-18T00:00:00' AS SmallDateTime), CAST(N'2022-11-18T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (8, N'梁', N'梁菡', 2, N'04832391', N'0988841028', N'janet9932@yahoo.com', N'aTa6rd8G', CAST(N'2008-05-23T00:00:00' AS SmallDateTime), 0, 0, NULL, CAST(N'2022-06-17T00:00:00' AS SmallDateTime), CAST(N'2022-06-17T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (9, N'王', N'王妹', 2, N'045407677', N'0911952856', N'carey4566@gmail.com', N'MRc44A27', CAST(N'1961-12-06T00:00:00' AS SmallDateTime), 150, 0, NULL, CAST(N'2022-08-19T00:00:00' AS SmallDateTime), CAST(N'2022-11-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (10, N'何', N'星淑', 2, N'022319421', N'0953261827', N'janice1852@yahoo.com', N'qU2xTS56', CAST(N'1976-01-01T00:00:00' AS SmallDateTime), 300, 0, NULL, CAST(N'2022-06-01T00:00:00' AS SmallDateTime), CAST(N'2022-09-18T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (11, N'卓', N'偉德', 1, N'06622036', N'0921392838', N'mickey5655@gmail.com', N'5hpJ873k', CAST(N'1992-02-27T00:00:00' AS SmallDateTime), 0, 0, NULL, CAST(N'2022-03-07T00:00:00' AS SmallDateTime), CAST(N'2022-04-18T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (12, N'黃', N'千湘', 2, N'022743020', N'0934412241', N'margaret9353@gmail.com', N'9Mdu67vW', CAST(N'1972-11-28T00:00:00' AS SmallDateTime), 500, 0, NULL, CAST(N'2023-01-05T00:00:00' AS SmallDateTime), CAST(N'2023-01-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomer] ([fID], [fLastName], [fFirstName], [fGender], [fTel], [fMobile], [fEmail], [fPassword], [fBirthDate], [fPoint], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (13, N'馬', N'磊禧', 1, N'049392922', N'0934532944', N'harmon9568@gmail.com', N'FHvZXq8V', CAST(N'2018-12-01T00:00:00' AS SmallDateTime), 0, 0, NULL, CAST(N'2022-09-17T00:00:00' AS SmallDateTime), CAST(N'2022-12-16T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tCustomer] OFF
GO
SET IDENTITY_INSERT [dbo].[tCustomerOrderSheet] ON 

INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (1, 1, N'triplook23', CAST(N'2023-01-31T00:00:00' AS SmallDateTime), CAST(N'2023-01-31T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (2, 4, NULL, CAST(N'2022-12-25T00:00:00' AS SmallDateTime), CAST(N'2022-12-31T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (3, 3, N'triplook55', CAST(N'2023-01-15T00:00:00' AS SmallDateTime), NULL)
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (5, 6, N'triplook64', CAST(N'2023-01-02T00:00:00' AS SmallDateTime), CAST(N'2023-01-19T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (6, 8, N'triplook64', CAST(N'2023-01-04T00:00:00' AS SmallDateTime), CAST(N'2023-01-09T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (7, 9, NULL, CAST(N'2023-01-05T00:00:00' AS SmallDateTime), CAST(N'2023-01-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (8, 10, N'triplook66', CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-01-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (9, 11, N'triplook77', CAST(N'2023-02-01T00:00:00' AS SmallDateTime), NULL)
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (10, 12, NULL, CAST(N'2023-02-02T00:00:00' AS SmallDateTime), NULL)
INSERT [dbo].[tCustomerOrderSheet] ([fID], [fCustomerID], [fCouponCode], [fCreationDate], [fCheckedDate]) VALUES (11, 13, N'triplook77', CAST(N'2023-02-02T00:00:00' AS SmallDateTime), NULL)
SET IDENTITY_INSERT [dbo].[tCustomerOrderSheet] OFF
GO
INSERT [dbo].[tGender] ([fID], [fDescription]) VALUES (0, N'未指定')
INSERT [dbo].[tGender] ([fID], [fDescription]) VALUES (1, N'男性')
INSERT [dbo].[tGender] ([fID], [fDescription]) VALUES (2, N'女性')
GO
SET IDENTITY_INSERT [dbo].[tManager] ON 

INSERT [dbo].[tManager] ([fSID], [fAccount], [fPassword]) VALUES (1, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[tManager] OFF
GO
SET IDENTITY_INSERT [dbo].[tOrderDetail] ON 

INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (1, 1, 1, 2)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (2, 1, 3, 1)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (3, 2, 1, 1)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (4, 2, 3, 2)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (5, 1, 3, 2)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (6, 2, 1, 1)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (7, 1, 1, 1)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (8, 1, 1, 1)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (9, 1, 1, 1)
INSERT [dbo].[tOrderDetail] ([fID], [fCustomerOrderSheetID], [fProductID], [fPurchaseQuantity]) VALUES (10, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[tOrderDetail] OFF
GO
INSERT [dbo].[tPeriod] ([fID], [fDescription]) VALUES (0, N'未指定')
INSERT [dbo].[tPeriod] ([fID], [fDescription]) VALUES (1, N'早上')
INSERT [dbo].[tPeriod] ([fID], [fDescription]) VALUES (2, N'中午')
INSERT [dbo].[tPeriod] ([fID], [fDescription]) VALUES (3, N'下午')
INSERT [dbo].[tPeriod] ([fID], [fDescription]) VALUES (4, N'晚上')
GO
SET IDENTITY_INSERT [dbo].[tProduct] ON 

INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (1, N'四大月老廟參拜半日遊', 1, 250.0000, 520.0000, 25, N'全新方案一人成行，1人包團一試就靈，2-3人包團就試試吧！4人以上我愛你！
千里姻緣一線牽，月老樂成好姻緣！帶你一次參拜台南四大必拜月老廟
大觀音亭闊嘴月老—祈良緣，能言善道，舌燦蓮花，說媒本事技高一籌
重慶寺醋矸月老—保復合，可化爭吵為和諧，有勸情人合和、夫妻恩愛的神奇功效
大天后宮緣粉月老—求搓合，可塗抹「緣粉」在眉毛四周（夫妻宮），有助旺桃花，使有緣人接近
祀典武廟拐杖月老—斬桃花，在月老宮廟前申訴個人案件，神明都會協助處理', N'四大月老廟參拜半日遊.jpg', 1, 4, N'大觀音亭', CAST(N'2020-09-08T00:00:00' AS SmallDateTime), CAST(N'2023-12-01T00:00:00' AS SmallDateTime), 2, 0, N'0 - 3 歲兒童可免費 參加此活動
4 歲以上兒童與成人同價
0 - 12 歲兒童需由付費成人陪同
戶外活動請自備遮陽防曬用品以及水分補充
全程皆以走讀方式進行請考量自身行動能力與體能負荷
戶外活動請自備遮陽防曬用品以及水分補充
如遇天候不佳本公司保有出團（併團與否）之權利
行程包含大量步行及階梯攀爬，請確保有足夠體力參加', CAST(N'2020-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-01-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (3, N'漁光船影單車行＆Adosi 銀戀銀戒指手作體驗｜林默娘公園．德陽艦', 2, 1500.0000, 2200.0000, 15, N'行程包含近期安門安平景點，觀光密度高度集中
全台唯一擁有仿古王船與古董軍艦的港區
1.5小時自行車小旅行，提供每人一輛自行車
導覽尋幽後，再前往具日式古宅情懷的銀戀Adosi安平本館，參加純銀手工戒指DIY', N'漁光船影單車行.jpg', 2, 10, N'奇美博物館', CAST(N'2021-05-19T00:00:00' AS SmallDateTime), CAST(N'2023-12-01T00:00:00' AS SmallDateTime), 6, 0, NULL, CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-01-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (5, N'四草綠色隧道', 1, 150.0000, 250.0000, 25, N'請至四草大眾廟服務台掃描憑證列印船票
坐擁全台種類數量之冠的紅樹林濕地生態，四草綠色隧道，有著「台版亞馬遜河」的美譽！
搭觀光漁筏悠遊四草綠色隧道，一窺天使之吻、綠色之眼的獨特仙境', N'綠色隧道.jpg', 1, 10, N'綠色隧道', CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 8, 0, NULL, CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (8, N'左鎮化石園區', 1, 50.0000, 150.0000, 200, N'全台唯一的化石主題園區！擁有超過4,600件館藏，也是本土化石館藏最多的博物館
設有自然史教育館、故事館、化石館、生命演化館、探索館等5座展館及戶外廣場，化石迷絕不能錯過
園區內可體驗趣味知性的多媒體互動裝置，寓教於樂，適合親子同遊', N'左鎮化石園區.jpg', 1, 20, N'左鎮化石園區', CAST(N'2021-08-31T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 10, 0, NULL, CAST(N'2021-08-31T00:00:00' AS SmallDateTime), CAST(N'2023-01-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (10, N'四大月老廟參拜半日遊', 2, 250.0000, 520.0000, 25, N'全新方案一人成行，1人包團一試就靈，2-3人包團就試試吧！4人以上我愛你！
千里姻緣一線牽，月老樂成好姻緣！帶你一次參拜台南四大必拜月老廟
大觀音亭闊嘴月老—祈良緣，能言善道，舌燦蓮花，說媒本事技高一籌
重慶寺醋矸月老—保復合，可化爭吵為和諧，有勸情人合和、夫妻恩愛的神奇功效
大天后宮緣粉月老—求搓合，可塗抹「緣粉」在眉毛四周（夫妻宮），有助旺桃花，使有緣人接近
祀典武廟拐杖月老—斬桃花，在月老宮廟前申訴個人案件，神明都會協助處理', N'四大月老廟參拜半日遊.jpg', 1, 4, N'大觀音亭', CAST(N'2020-09-08T00:00:00' AS SmallDateTime), CAST(N'2023-12-01T00:00:00' AS SmallDateTime), 2, 0, N'0 - 3 歲兒童可免費 參加此活動
4 歲以上兒童與成人同價
0 - 12 歲兒童需由付費成人陪同
戶外活動請自備遮陽防曬用品以及水分補充
全程皆以走讀方式進行請考量自身行動能力與體能負荷
戶外活動請自備遮陽防曬用品以及水分補充
如遇天候不佳本公司保有出團（併團與否）之權利
行程包含大量步行及階梯攀爬，請確保有足夠體力參加', CAST(N'2020-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-01-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (12, N'漁光船影單車行＆Adosi 銀戀銀戒指手作體驗｜林默娘公園．德陽艦', 1, 150.0000, 2200.0000, 15, N'行程包含近期安門安平景點，觀光密度高度集中
全台唯一擁有仿古王船與古董軍艦的港區
1.5小時自行車小旅行，提供每人一輛自行車
導覽尋幽後，再前往具日式古宅情懷的銀戀Adosi安平本館，參加純銀手工戒指DIY', N'漁光船影單車行.jpg', 2, 4, N'奇美博物館', CAST(N'2021-05-19T00:00:00' AS SmallDateTime), CAST(N'2023-12-01T00:00:00' AS SmallDateTime), 6, 0, NULL, CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-01-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (13, N'四草綠色隧道', 2, 150.0000, 250.0000, 25, N'請至四草大眾廟服務台掃描憑證列印船票
坐擁全台種類數量之冠的紅樹林濕地生態，四草綠色隧道，有著「台版亞馬遜河」的美譽！
搭觀光漁筏悠遊四草綠色隧道，一窺天使之吻、綠色之眼的獨特仙境', N'綠色隧道.jpg', 1, 10, N'綠色隧道', CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 8, 0, NULL, CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (15, N'四草綠色隧道', 3, 150.0000, 250.0000, 25, N'請至四草大眾廟服務台掃描憑證列印船票
坐擁全台種類數量之冠的紅樹林濕地生態，四草綠色隧道，有著「台版亞馬遜河」的美譽！
搭觀光漁筏悠遊四草綠色隧道，一窺天使之吻、綠色之眼的獨特仙境', N'綠色隧道.jpg', 1, 10, N'綠色隧道', CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 8, 0, NULL, CAST(N'2021-01-01T00:00:00' AS SmallDateTime), CAST(N'2022-12-06T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (16, N'南瀛天文館', 2, 185.0000, 500.0000, 50, N'來到南瀛天文館，跳脫時空限制，感受宇宙星空的震撼，啟發學習天文科學的興趣
天文展示館配合地勢及自然條件設計，以「月亮」為象徵意象
採用數位球幕3D的星象劇場，運用全世界最新技術，提供觀眾一個真實而撼動人心的模擬星空
天文教育館透過生動、活潑而豐富的天文主題，結合熱門天文主題特展，啟發民眾對天文科學的喜愛', N'南瀛天文館.jpg', 1, 20, N'南瀛天文館', CAST(N'2020-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 13, 0, NULL, CAST(N'2021-06-17T00:00:00' AS SmallDateTime), CAST(N'2023-01-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (17, N'南瀛天文館', 3, 185.0000, 500.0000, 50, N'來到南瀛天文館，跳脫時空限制，感受宇宙星空的震撼，啟發學習天文科學的興趣
天文展示館配合地勢及自然條件設計，以「月亮」為象徵意象
採用數位球幕3D的星象劇場，運用全世界最新技術，提供觀眾一個真實而撼動人心的模擬星空
天文教育館透過生動、活潑而豐富的天文主題，結合熱門天文主題特展，啟發民眾對天文科學的喜愛', N'南瀛天文館.jpg', 1, 20, N'南瀛天文館', CAST(N'2020-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 13, 0, NULL, CAST(N'2021-06-17T00:00:00' AS SmallDateTime), CAST(N'2023-01-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProduct] ([fID], [fName], [fPeriodID], [fCost], [fPrice], [fStocks], [fDescription], [fImagePath], [fMinParticipants], [fMaxParticipants], [fAssemblyPoint], [fStartDate], [fEndDate], [fProviderID], [fRemoved], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (18, N'南瀛天文館', 4, 185.0000, 500.0000, 50, N'來到南瀛天文館，跳脫時空限制，感受宇宙星空的震撼，啟發學習天文科學的興趣
天文展示館配合地勢及自然條件設計，以「月亮」為象徵意象
採用數位球幕3D的星象劇場，運用全世界最新技術，提供觀眾一個真實而撼動人心的模擬星空
天文教育館透過生動、活潑而豐富的天文主題，結合熱門天文主題特展，啟發民眾對天文科學的喜愛', N'南瀛天文館.jpg', 1, 20, N'南瀛天文館', CAST(N'2020-01-01T00:00:00' AS SmallDateTime), CAST(N'2023-12-31T00:00:00' AS SmallDateTime), 13, 0, NULL, CAST(N'2021-06-17T00:00:00' AS SmallDateTime), CAST(N'2023-01-02T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[tProductReport] ON 

INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (1, 1, N'導遊沒來，爛透了', CAST(N'2023-01-01T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (2, 2, N'超無趣。再也不買了', CAST(N'2023-01-12T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (3, 3, N'人潮擁擠，價格昂貴，垃圾污染問題嚴重', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (4, 4, N'交通堵塞，空氣污染嚴重，景點過於擁擠', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (5, 5, N'交通不便，風景遭破壞，衛生情況較差', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (6, 6, N'景點過於商業化，環境污染嚴重，商家服務差', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (7, 7, N'價格過高，環境污染嚴重，景點過於繁忙', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (8, 8, N'人潮太多，根本沒辦法好好體驗', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (9, 9, N'交通混亂且停車困難，酒店房價昂貴', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReport] ([fID], [fOrderDetailID], [fReportContent], [fCreationDate]) VALUES (10, 10, N'人擠人，還不如在家自己做飯', CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tProductReport] OFF
GO
SET IDENTITY_INSERT [dbo].[tProductReview] ON 

INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (3, 3, N'好好玩，物超所值', 5, CAST(N'2022-01-10T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (4, 4, N'非常有趣，下次有機會會再買', 5, CAST(N'2023-01-16T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (6, 5, N'服務態度差，餐點沒有預期的美味，不太推薦', 1, CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (7, 6, N'周邊環境整治不佳，水質不好，不適合嬉水', 1, CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (8, 7, N'人潮擁擠，價格高昂，不太適合沉溺於此', 1, CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (9, 8, N'環境嘈雜，附近沒有美食，不適合放鬆休息', 1, CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (10, 9, N'價格過高，環境污染嚴重，景點過於繁忙', 1, CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProductReview] ([fID], [fOrderDetailID], [fReviewContent], [fScore], [fCreationDate]) VALUES (11, 10, N'交通不便，風景遭破壞，衛生情況較差', 1, CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tProductReview] OFF
GO
SET IDENTITY_INSERT [dbo].[tProductsTag] ON 

INSERT [dbo].[tProductsTag] ([fSID], [fProductID], [fTagID]) VALUES (1, 1, 1)
INSERT [dbo].[tProductsTag] ([fSID], [fProductID], [fTagID]) VALUES (2, 1, 2)
INSERT [dbo].[tProductsTag] ([fSID], [fProductID], [fTagID]) VALUES (3, 3, 3)
SET IDENTITY_INSERT [dbo].[tProductsTag] OFF
GO
SET IDENTITY_INSERT [dbo].[tProvider] ON 

INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (2, N'台灣國玉科技股份有限公司', N'123456789', N'91768804', N'06-2357594', N'柯美玲', N'06-2357594', N'0911786561', N'PbGNWv0ny4SYwq@gmail.com', N'柯美玲', N'06-2357594', N'0911786561', N'PbGNWv0ny4SYwq@gmail.com', N'臺中市梧棲區頂寮里中橫十路100號', N'台灣銀行', N'台中分行', N'73958419824761', N'台灣國玉科技股份有限公司', 0, NULL, CAST(N'2023-01-15T00:00:00' AS SmallDateTime), CAST(N'2023-01-15T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (6, N'曜吉智能製造有限公司', N'123456789', N'43354994', N'06-5291164', N'楊芳茲', N'06-5291164', N'0988659055', N'l5CHKfWAZju@gmail.com', N'楊芳茲
', N'06-5291164', N'0988659055', N'l5CHKfWAZju@gmail.com', N'臺中市大里區東湖里中興路一段159之1號3樓A339', N'台企銀', N'大里分行', N'79581348679240', N'曜吉智能製造有限公司', 0, NULL, CAST(N'2023-01-30T00:00:00' AS SmallDateTime), CAST(N'2023-02-01T23:48:00' AS SmallDateTime))
INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (8, N'寶緹貿易有限公司
', N'1234', N'11147396', N'06-2584689', N'辛瑋濬
', N'06-2584689', N'0917961183', N'qoKTJWEsX@gmail.com', N'辛瑋濬
', N'06-2584689', N'0917961183', N'qoKTJWEsX@gmail.com', N'臺南市東區裕聖里裕信五街2號1樓
', N'土地銀行', N'玉峰分行', N'76814685794975', N'寶緹貿易有限公司
', 0, NULL, CAST(N'2023-02-01T09:39:00' AS SmallDateTime), CAST(N'2023-02-02T09:39:00' AS SmallDateTime))
INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (10, N'大歸仁服裝有限公司
', N'1234', N'23418133', N'06-6523753', N'黃志翔
', N'06-6523753', N'0924038444', N'SUsiaPowSP@gmail.com', N'黃志翔
', N'06-6523753', N'0924038444', N'SUsiaPowSP@gmail.com', N'臺南市歸仁區文化里民權北路208號1樓
', N'台銀', N'歸仁分行', N'98746855713228', N'大歸仁服裝有限公司
', 0, NULL, CAST(N'2022-06-15T00:00:00' AS SmallDateTime), CAST(N'2023-01-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (11, N'鋕達有限公司
', N'1234', N'76099072', N'06-5905231', N'吳宗翰
', N'06-5905231', N'0934641746', N'QWZ7OK0bb@gmail.com', N'吳宗翰
', N'06-5905231', N'0934641746', N'QWZ7OK0bb@gmail.com', N'臺南市東區仁和路178巷5號1樓
', N'台新銀', N'歸仁分行', N'45779355813658', N'鋕達有限公司
', 0, NULL, CAST(N'2022-01-05T00:00:00' AS SmallDateTime), CAST(N'2022-11-09T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (12, N'五探哥漁村有限公司
', N'1234', N'43275078', N'06-6216787', N'劉育郡
', N'06-6216787', N'0910665230', N'B1K0DkS4Sg5@gmail.com', N'劉育郡
', N'06-6216787', N'0910665230', N'B1K0DkS4Sg5@gmail.com', N'臺南市佳里區建南里安南路300號1樓
', N'中信銀', N'佳里分行', N'14659732184493', N'祥槿企業有限公司', 0, NULL, CAST(N'2022-01-18T00:00:00' AS SmallDateTime), CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (13, N'子葳股份有限公司
', N'1234', N'70844291', N'06-5638990', N'王子建
', N'06-5638990', N'0926774162', N'ox9eytd4kHJ@gmail.com', N'王子建
', N'06-5638990', N'0926774162', N'ox9eytd4kHJ@gmail.com', N'臺南市安平區怡平里永華六街35巷1號5樓之1
', N'台新銀', N'怡平分行', N'57994881366647', N'子葳股份有限公司
', 0, NULL, CAST(N'2022-02-02T00:00:00' AS SmallDateTime), CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tProvider] ([fID], [fCompanyName], [fPassword], [fTaxID], [fFax], [fOwnerName], [fOwnerTel], [fOwnerMobile], [fOwnerEmail], [fContactName], [fContactTel], [fContactMobile], [fContactEmail], [fAddress], [fBankName], [fBankDivisionName], [fBankAccountNumber], [fBankAccountName], [fBlackList], [fRemark], [fCreationDate], [fLastUpdateDate]) VALUES (14, N'金嘉泓企業有限公司
', N'1234', N'92353965', N'06-7714861', N'高建泓
', N'06-7714861', N'0915217033', N'yz1s6J8ERbzn0I@gmail.com', N'高建泓
', N'06-7714861', N'0915217033', N'yz1s6J8ERbzn0I@gmail.com', N'臺南市善化區光文里光華路62號1樓
', N'國泰銀', N'光文分房', N'68884715793488', N'金嘉泓企業有限公司
', 0, NULL, CAST(N'2022-02-02T00:00:00' AS SmallDateTime), CAST(N'2022-02-02T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tProvider] OFF
GO
SET IDENTITY_INSERT [dbo].[tPurchaseOrderSheet] ON 

INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (1, 1, CAST(N'2023-01-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (2, 2, CAST(N'2023-01-02T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (3, 3, CAST(N'2023-01-05T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (4, 4, CAST(N'2023-01-06T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (5, 5, CAST(N'2023-01-06T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (6, 6, CAST(N'2023-01-07T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (10, 7, CAST(N'2023-01-09T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (12, 8, CAST(N'2023-01-11T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (13, 9, CAST(N'2023-01-19T00:00:00' AS SmallDateTime))
INSERT [dbo].[tPurchaseOrderSheet] ([fID], [fOrderDetailID], [fCreationDate]) VALUES (14, 10, CAST(N'2023-01-25T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tPurchaseOrderSheet] OFF
GO
INSERT [dbo].[tTag] ([fID], [fDescription]) VALUES (1, N'廟')
INSERT [dbo].[tTag] ([fID], [fDescription]) VALUES (2, N'古蹟')
INSERT [dbo].[tTag] ([fID], [fDescription]) VALUES (3, N'手做')
GO
ALTER TABLE [dbo].[tCustomer]  WITH CHECK ADD  CONSTRAINT [FK_tCustomer_tGender1] FOREIGN KEY([fGender])
REFERENCES [dbo].[tGender] ([fID])
GO
ALTER TABLE [dbo].[tCustomer] CHECK CONSTRAINT [FK_tCustomer_tGender1]
GO
ALTER TABLE [dbo].[tCustomerOrderSheet]  WITH CHECK ADD  CONSTRAINT [FK_tCustomerOrderSheet_tCoupon] FOREIGN KEY([fCouponCode])
REFERENCES [dbo].[tCoupon] ([fCode])
GO
ALTER TABLE [dbo].[tCustomerOrderSheet] CHECK CONSTRAINT [FK_tCustomerOrderSheet_tCoupon]
GO
ALTER TABLE [dbo].[tCustomerOrderSheet]  WITH CHECK ADD  CONSTRAINT [FK_tCustomerOrderSheet_tCustomer] FOREIGN KEY([fCustomerID])
REFERENCES [dbo].[tCustomer] ([fID])
GO
ALTER TABLE [dbo].[tCustomerOrderSheet] CHECK CONSTRAINT [FK_tCustomerOrderSheet_tCustomer]
GO
ALTER TABLE [dbo].[tOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tOrderDetail_tCustomerOrderSheet] FOREIGN KEY([fCustomerOrderSheetID])
REFERENCES [dbo].[tCustomerOrderSheet] ([fID])
GO
ALTER TABLE [dbo].[tOrderDetail] CHECK CONSTRAINT [FK_tOrderDetail_tCustomerOrderSheet]
GO
ALTER TABLE [dbo].[tOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tOrderDetail_tProduct] FOREIGN KEY([fProductID])
REFERENCES [dbo].[tProduct] ([fID])
GO
ALTER TABLE [dbo].[tOrderDetail] CHECK CONSTRAINT [FK_tOrderDetail_tProduct]
GO
ALTER TABLE [dbo].[tProduct]  WITH CHECK ADD  CONSTRAINT [FK_tProduct_tPeriod] FOREIGN KEY([fPeriodID])
REFERENCES [dbo].[tPeriod] ([fID])
GO
ALTER TABLE [dbo].[tProduct] CHECK CONSTRAINT [FK_tProduct_tPeriod]
GO
ALTER TABLE [dbo].[tProduct]  WITH CHECK ADD  CONSTRAINT [FK_tProduct_tProvider] FOREIGN KEY([fProviderID])
REFERENCES [dbo].[tProvider] ([fID])
GO
ALTER TABLE [dbo].[tProduct] CHECK CONSTRAINT [FK_tProduct_tProvider]
GO
ALTER TABLE [dbo].[tProductReport]  WITH CHECK ADD  CONSTRAINT [FK_tProductReport_tOrderDetail] FOREIGN KEY([fOrderDetailID])
REFERENCES [dbo].[tOrderDetail] ([fID])
GO
ALTER TABLE [dbo].[tProductReport] CHECK CONSTRAINT [FK_tProductReport_tOrderDetail]
GO
ALTER TABLE [dbo].[tProductReview]  WITH CHECK ADD  CONSTRAINT [FK_tProductReview_tOrderDetail] FOREIGN KEY([fOrderDetailID])
REFERENCES [dbo].[tOrderDetail] ([fID])
GO
ALTER TABLE [dbo].[tProductReview] CHECK CONSTRAINT [FK_tProductReview_tOrderDetail]
GO
ALTER TABLE [dbo].[tProductsTag]  WITH CHECK ADD  CONSTRAINT [FK_tProductsTag_tProduct] FOREIGN KEY([fProductID])
REFERENCES [dbo].[tProduct] ([fID])
GO
ALTER TABLE [dbo].[tProductsTag] CHECK CONSTRAINT [FK_tProductsTag_tProduct]
GO
ALTER TABLE [dbo].[tProductsTag]  WITH CHECK ADD  CONSTRAINT [FK_tProductsTag_tTag] FOREIGN KEY([fTagID])
REFERENCES [dbo].[tTag] ([fID])
GO
ALTER TABLE [dbo].[tProductsTag] CHECK CONSTRAINT [FK_tProductsTag_tTag]
GO
ALTER TABLE [dbo].[tPurchaseOrderSheet]  WITH CHECK ADD  CONSTRAINT [FK_tPurchaseOrderSheet_tOrderDetail] FOREIGN KEY([fOrderDetailID])
REFERENCES [dbo].[tOrderDetail] ([fID])
GO
ALTER TABLE [dbo].[tPurchaseOrderSheet] CHECK CONSTRAINT [FK_tPurchaseOrderSheet_tOrderDetail]
GO
ALTER TABLE [dbo].[tShoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_tShoppingCart_tCustomer] FOREIGN KEY([fCustomerID])
REFERENCES [dbo].[tCustomer] ([fID])
GO
ALTER TABLE [dbo].[tShoppingCart] CHECK CONSTRAINT [FK_tShoppingCart_tCustomer]
GO
ALTER TABLE [dbo].[tShoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_tShoppingCart_tProduct] FOREIGN KEY([fProductID])
REFERENCES [dbo].[tProduct] ([fID])
GO
ALTER TABLE [dbo].[tShoppingCart] CHECK CONSTRAINT [FK_tShoppingCart_tProduct]
GO
