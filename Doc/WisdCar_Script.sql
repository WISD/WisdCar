USE WisdCarDB

CREATE TABLE Car
(
	CarID                int IDENTITY(1,1) NOT NULL ,
	CarNo                nvarchar(50)  NOT NULL ,
	Brand                nvarchar(50)  NOT NULL ,
	CarModel             nvarchar(50)  NULL ,
	Capacity             nvarchar(50)  NULL ,
	Color                nvarchar(50)  NULL ,
	FrameNo              nvarchar(50)  NULL ,
	EngineNo             nvarchar(50)  NULL ,
	MaintainKM           nvarchar(50)  NULL ,
	InsureDate           datetime  NOT NULL ,
	ASDate               datetime  NOT NULL ,
	CustomerID           int  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE Car
	ADD CONSTRAINT XPKCar PRIMARY KEY  CLUSTERED (CarID ASC)
go


CREATE TABLE ClubCard
(
	ClubCardID           int IDENTITY(1,1) NOT NULL ,
	ClubCardTypeName     nvarchar(50)  NOT NULL ,
	CustName             nvarchar(50)  NOT NULL ,
	ClubCardPwd          nvarchar(50)  NOT NULL ,
	OpenCardStore        nvarchar(50)  NOT NULL ,
	SalesMan             nvarchar(50)  NOT NULL ,
	SalesTime            datetime  NOT NULL ,
	Balance              numeric(9,2)  NOT NULL ,
	CustomerID           int  NOT NULL ,
	ClubCardTypeID       int  NOT NULL ,
	[ExpireDate]           datetime  NOT NULL ,
	CardStatus               int  NOT NULL ,
	ClubCardNo           nvarchar(50)  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE ClubCard
	ADD CONSTRAINT XPKClubCard PRIMARY KEY  CLUSTERED (ClubCardID ASC)
go


CREATE TABLE ClubCardHis
(
	ClubCardID           int IDENTITY(1,1) NOT NULL ,
	ClubCardTypeName     nvarchar(50)  NOT NULL ,
	CustName             nvarchar(50)  NOT NULL ,
	ClubCardPwd          nvarchar(50)  NOT NULL ,
	OpenCardStore        nvarchar(50)  NOT NULL ,
	SalesMan             nvarchar(50)  NOT NULL ,
	SalesTime            datetime  NOT NULL ,
	Balance              numeric(9,2)  NOT NULL ,
	CustomerID           int  NOT NULL ,
	ClubCardTypeID       int  NOT NULL ,
	[ExpireDate]           datetime  NOT NULL ,
	CardStatus               int  NOT NULL ,
	ClubCardNo           nvarchar(50)  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE ClubCardHis
	ADD CONSTRAINT XPKClubCardHis PRIMARY KEY  CLUSTERED (ClubCardID ASC)
go

CREATE TABLE ClubCardPackage
(
	ClubCardPackageID    int  NOT NULL ,
	PackageName          nvarchar(50)  NOT NULL ,
	OriginalAmount       numeric(9,2)  NOT NULL ,
	ActualAmount         numeric(9,2)  NOT NULL ,
	DiscountRate         numeric(5,2)  NOT NULL ,
	DiscountInfo         nvarchar(50)  NOT NULL ,
	PackageStatus               int  NOT NULL ,
	Salesman             nvarchar(50)  NOT NULL ,
	SalesTime            datetime  NOT NULL ,
	SaleStore            nvarchar(50)  NOT NULL ,
	PackageID            int  NOT NULL ,
        ClubCardID           int  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE ClubCardPackage
	ADD CONSTRAINT XPKClubCardPackage PRIMARY KEY  CLUSTERED (ClubCardPackageID ASC)
go


CREATE TABLE ClubCardPackageDetail
(
	PackageDetailID      int IDENTITY(1,1) NOT NULL ,
	ItemID               int  NOT NULL ,
	ItemName             nvarchar(50)  NOT NULL ,
	UnitPrice            numeric(9,2)  NOT NULL ,
	OriginalCount        int  NOT NULL ,
	RemainCount          int  NOT NULL ,
	ClubCardPackageID    int  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE ClubCardPackageDetail
	ADD CONSTRAINT XPKClubCardPackageDetail PRIMARY KEY  CLUSTERED (PackageDetailID ASC)
go


CREATE TABLE ClubCardType
(
	ClubCardTypeID       int IDENTITY(1,1) NOT NULL ,
	CardTypeName         nvarchar(50)  NOT NULL ,
	PackageDiscount      numeric(5,2)  NOT NULL ,
	PayDiscount          numeric(5,2)  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE ClubCardType
	ADD CONSTRAINT XPKClubCardType PRIMARY KEY  CLUSTERED (ClubCardTypeID ASC)
go


CREATE TABLE ConsumeItem
(
	ItemID               int IDENTITY(1,1) NOT NULL ,
	ItemName             nvarchar(50)  NOT NULL ,
	ItemPrice            numeric(9,2)  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE ConsumeItem
	ADD CONSTRAINT XPKConsumeItem PRIMARY KEY  CLUSTERED (ItemID ASC)
go


CREATE TABLE ConsumeLog
(
	ConsumeLogID         int IDENTITY(1,1) NOT NULL,
	ConsumeBatchNo	     nvarchar(50)  NOT NULL ,
	ClubCardID           int  NOT NULL ,
	ClubCardNo           int  NOT NULL ,
	CustID               int  NOT NULL ,
	CustName             nvarchar(50)  NOT NULL ,
	ConsumeDate          datetime  NOT NULL ,
	ConsumeStore         nvarchar(50)  NOT NULL ,
	OriginalStore        nvarchar(50)  NOT NULL ,
	ConsumeType          int  NOT NULL ,
	PayType		     int  NOT NULL ,
	ClubCardPackageID    int  NOT NULL ,
	PackageDetailID      int  NOT NULL ,
	ItemName             nvarchar(50)  NOT NULL ,
	ConsumeCount         int  NOT NULL ,
	OriginalPrice        numeric(9,2)  NOT NULL ,
	ItemID               int  NOT NULL ,
	
	LogicalStatus        int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE ConsumeLog
	ADD CONSTRAINT XPKConsumeLog PRIMARY KEY  CLUSTERED (ConsumeLogID ASC)
go


CREATE TABLE Customer
(
	CustomerID           int IDENTITY(1,1) NOT NULL,
	Name                 nvarchar(50)  NOT NULL ,
	MobileNO             nvarchar(50)  NOT NULL ,
	Sex                  nvarchar(50)  NULL ,
	Birthday             nvarchar(50)  NULL ,
	ICNo                 nvarchar(50)  NULL ,
	Weixin               nvarchar(50)  NULL ,
	Company              nvarchar(50)  NULL ,
	CardFlag             int  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE Customer
	ADD CONSTRAINT XPKCustomer PRIMARY KEY  CLUSTERED (CustomerID ASC)
go


CREATE TABLE Employee
(
	EmployeeID           int IDENTITY(1,1) NOT NULL ,
	EmployeeNo           int  NOT NULL ,
	Name                 nvarchar(50)  NOT NULL ,
	Sex                  nvarchar(50)  NULL ,
	Phone                nvarchar(50)  NOT NULL ,
	JobType              nvarchar(50)  NOT NULL ,
	EmployeeAddr         nvarchar(50)  NULL ,
	EmployeeResume       nvarchar(50)  NULL ,
	StoreID              int  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE Employee
	ADD CONSTRAINT XPKEmployee PRIMARY KEY  CLUSTERED (EmployeeID ASC)
go


CREATE TABLE KVLookup
(
	LookupID             int IDENTITY(1,1) NOT NULL ,
	LookupKey            nvarchar(50)  NOT NULL ,
	LookupValue          char(18)  NOT NULL ,
	CategoryID           int  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE KVLookup
	ADD CONSTRAINT XPKKVLookup PRIMARY KEY  CLUSTERED (LookupID ASC)
go

CREATE TABLE KVCategory
(
	CategoryID             int IDENTITY(1,1) NOT NULL ,
	CategoryName            nvarchar(50)  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE KVCategory
	ADD CONSTRAINT XPKKVCategory PRIMARY KEY  CLUSTERED (CategoryID ASC)
go


CREATE TABLE Package
(
	PackageID            int IDENTITY(1,1) NOT NULL ,
	PackageName          nvarchar(50)  NOT NULL ,
	TotalPrice           numeric(9,2)  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE Package
	ADD CONSTRAINT XPKPackage PRIMARY KEY  CLUSTERED (PackageID ASC)
go


CREATE TABLE PackageItemMapping
(
	PackageItemID        int IDENTITY(1,1) NOT NULL ,
	ConsumeCount         int  NOT NULL ,
	PackageID            int  NOT NULL ,
	ItemID               int  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE PackageItemMapping
	ADD CONSTRAINT XPKPackageItemMapping PRIMARY KEY  CLUSTERED (PackageItemID ASC)
go


CREATE TABLE RechargeLog
(
	RechargeLogID        int IDENTITY(1,1) NOT NULL ,
	RechargeSerialNo     nvarchar(50)  NOT NULL ,
	ClubCardID           int  NOT NULL ,
	ClubCardNo           int  NOT NULL ,
	CustID               int  NOT NULL ,
	CustName             nvarchar(50)  NOT NULL ,
	RechargeDate         datetime  NOT NULL ,
	SalesMan	     nvarchar(50)  NOT NULL ,
	RechargeStore        nvarchar(50)  NOT NULL ,
	OriginalStore        nvarchar(50)  NOT NULL ,
	ActualRechargeAmount numeric(9,2)  NOT NULL ,
	RechargeType         int  NOT NULL ,
	PayType		     int  NOT NULL ,
	ClubCardPackageID    int  NOT NULL ,
	PlatformRechargeAmount numeric(9,2)  NOT NULL ,
	DiscountRate         numeric(5,2)  NOT NULL ,
	DiscountInfo         nvarchar(50)  NOT NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE RechargeLog
	ADD CONSTRAINT XPKRechargeLog PRIMARY KEY  CLUSTERED (RechargeLogID ASC)
go


CREATE TABLE Store
(
	StoreID              int IDENTITY(1,1) NOT NULL ,
	StoreName            nvarchar(50)  NOT NULL ,
	StoreAddress         nvarchar(50)  NOT NULL ,
	StorePhone           nvarchar(50)  NOT NULL ,
	Fax                  nvarchar(50)  NULL ,
	
	LogicalStatus          int  NOT NULL DEFAULT 1,
	CreatorID            nvarchar(50)  NOT NULL ,
	CreatedDate          datetime  NOT NULL ,
	LastModifierID       nvarchar(50)  NOT NULL ,
	LastModifiedDate     datetime  NOT NULL ,
	Reserved1            nvarchar(100)  NULL ,
	Reserved2            nvarchar(100)  NULL ,
	Reserved3            nvarchar(100)  NULL 
)
go


ALTER TABLE Store
	ADD CONSTRAINT XPKStore PRIMARY KEY  CLUSTERED (StoreID ASC)
go



ALTER TABLE Car
	ADD CONSTRAINT  R_14 FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE ClubCard
	ADD CONSTRAINT  R_19 FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE ClubCard
	ADD CONSTRAINT  R_50 FOREIGN KEY (ClubCardTypeID) REFERENCES ClubCardType(ClubCardTypeID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE ClubCardPackage
	ADD CONSTRAINT  R_21 FOREIGN KEY (PackageID) REFERENCES Package(PackageID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE ClubCardPackage
	ADD CONSTRAINT  R_23 FOREIGN KEY (ClubCardID) REFERENCES ClubCard(ClubCardID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE ClubCardPackageDetail
	ADD CONSTRAINT  R_22 FOREIGN KEY (ClubCardPackageID) REFERENCES ClubCardPackage(ClubCardPackageID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Employee
	ADD CONSTRAINT  R_12 FOREIGN KEY (StoreID) REFERENCES Store(StoreID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE PackageItemMapping
	ADD CONSTRAINT  R_16 FOREIGN KEY (PackageID) REFERENCES Package(PackageID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE PackageItemMapping
	ADD CONSTRAINT  R_18 FOREIGN KEY (ItemID) REFERENCES ConsumeItem(ItemID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE KVLookup
	ADD CONSTRAINT  R_20 FOREIGN KEY (CategoryID) REFERENCES KVCategory(CategoryID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'汽车ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CarID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车牌号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CarNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品牌' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Brand'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CarModel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'汽车排量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Capacity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'汽车颜色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Color'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车架号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'FrameNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发动机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'EngineNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近保养公里数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'MaintainKM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保险时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'InsureDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'年检时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'ASDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'汽车状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡类型名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CustName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardPwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开卡门店' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'OpenCardStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'销售人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'SalesMan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'售卡时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'SalesTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'余额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Balance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡类型表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡截至日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ExpireDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CardStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡套餐ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'PackageName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应收金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'OriginalAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实收金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'ActualAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣率' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'DiscountRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'DiscountInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'PackageStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'销售人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Salesman'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'销售时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'SalesTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'销售门店' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'SaleStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费套餐表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'PackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐余量明细ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'PackageDetailID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'ItemName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'UnitPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'原始次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'OriginalCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'剩余次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'RemainCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡套餐ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡类型表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'ClubCardTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡类型名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'CardTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐折扣' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'PackageDiscount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值折扣' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'PayDiscount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'项目名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'ItemName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'ItemPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeLogID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费批次号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeBatchNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ClubCardNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CustID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CustName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费门店' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开卡门店' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'OriginalStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支付类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'PayType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡套餐ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐余量明细ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'PackageDetailID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费项目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ItemName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费单价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'OriginalPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'MobileNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生日' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Birthday'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'身份证号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'ICNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Weixin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'单位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Company'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开卡标志' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CardFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职位类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'JobType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工住址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeAddr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'员工简历' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeResume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属门店ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'StoreID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据字典表主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LookupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据字典Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LookupKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据字典Value' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LookupValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据类型表主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据类型表主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据类型名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费套餐表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'PackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'PackageName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐总价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'TotalPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'套餐项目表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'PackageItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'ConsumeCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费套餐表ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'PackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消费项目ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值记录ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeLogID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值流水号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeSerialNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ClubCardNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CustID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CustName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'销售人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'SalesMan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值门店' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'开户门店' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'OriginalStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实收充值金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ActualRechargeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充值类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'支付类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'PayType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'会员卡套餐ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'平台入账金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'PlatformRechargeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣率' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'DiscountRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'折扣信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'DiscountInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'门店ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'门店名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'门店地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'门店电话' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StorePhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'门店传真' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Fax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逻辑状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'保留字段3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO