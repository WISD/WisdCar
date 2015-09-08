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

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CarID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���ƺ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CarNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ʒ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Brand'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CarModel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Capacity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ɫ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Color'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���ܺ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'FrameNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'EngineNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�������������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'MaintainKM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'InsureDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'ASDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Car', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա����ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CustName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardPwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ŵ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'OpenCardStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������Ա' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'SalesMan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ۿ�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'SalesTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Balance'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա�����ͱ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա����������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ExpireDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա��״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CardStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'ClubCardNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCard', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա���ײ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'PackageName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ӧ�ս��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'OriginalAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ʵ�ս��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'ActualAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ۿ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'DiscountRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ۿ���Ϣ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'DiscountInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'PackageStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������Ա' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Salesman'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'SalesTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ŵ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'SaleStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ײͱ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'PackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա����ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackage', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ�������ϸID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'PackageDetailID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ĿID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ŀ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'ItemName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'UnitPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ԭʼ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'OriginalCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ʣ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'RemainCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա���ײ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardPackageDetail', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա�����ͱ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'ClubCardTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա����������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'CardTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ��ۿ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'PackageDiscount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ֵ�ۿ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'PayDiscount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ClubCardType', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ĿID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ŀ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'ItemName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'ItemPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeItem', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ĿID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeLogID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�������κ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeBatchNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա��ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ClubCardNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CustID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CustName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ŵ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ŵ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'OriginalStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'֧������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'PayType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա���ײ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ�������ϸID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'PackageDetailID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������Ŀ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ItemName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���Ѵ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ConsumeCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���ѵ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'OriginalPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ĿID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ConsumeLog', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CustomerID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ֻ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'MobileNO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�Ա�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Birthday'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���֤��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'ICNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'΢��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Weixin'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��λ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Company'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������־' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CardFlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ա����ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ա�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ա������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ա���Ա�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ա���绰' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ְλ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'JobType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ա��סַ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeAddr'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ա������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'EmployeeResume'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ŵ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'StoreID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employee', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֵ������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LookupID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֵ�Key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LookupKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֵ�Value' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LookupValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�������ͱ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVLookup', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�������ͱ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CategoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CategoryName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'KVCategory', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ײͱ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'PackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'PackageName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ��ܼ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'TotalPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Package', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ײ���Ŀ��ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'PackageItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���Ѵ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'ConsumeCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ײͱ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'PackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ĿID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'ItemID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PackageItemMapping', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ֵ��¼ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeLogID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ֵ��ˮ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeSerialNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա��ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ClubCardID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ClubCardNo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CustID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ͻ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CustName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ֵ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������Ա' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'SalesMan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ֵ�ŵ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ŵ�' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'OriginalStore'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ʵ�ճ�ֵ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ActualRechargeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ֵ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'RechargeType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'֧������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'PayType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��Ա���ײ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'ClubCardPackageID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ƽ̨���˽��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'PlatformRechargeAmount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ۿ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'DiscountRate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ۿ���Ϣ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'DiscountInfo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RechargeLog', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ŵ�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ŵ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ŵ��ַ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StoreAddress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ŵ�绰' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'StorePhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ŵ괫��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Fax'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�߼�״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'LogicalStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'CreatorID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'CreatedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸���ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'LastModifierID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'LastModifiedDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Reserved1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Reserved2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�����ֶ�3' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Store', @level2type=N'COLUMN',@level2name=N'Reserved3'
GO