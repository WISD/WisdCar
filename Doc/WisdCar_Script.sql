
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
	ClubCardType         nvarchar(50)  NOT NULL ,
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


CREATE TABLE ClubCardPackage
(
	ClubCardPackageID    int IDENTITY(1,1) NOT NULL ,
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
	CardTypeName         int  NOT NULL ,
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
	ClubCardID           int  NOT NULL ,
	ClubCardNo           int  NOT NULL ,
	CustID               int  NOT NULL ,
	CustName             nvarchar(50)  NOT NULL ,
	ConsumeDate          datetime  NOT NULL ,
	ConsumeStore         nvarchar(50)  NOT NULL ,
	OriginalStore        nvarchar(50)  NOT NULL ,
	ConsumeType          int  NOT NULL ,
	ClubCardPackageID    int  NOT NULL ,
	PackageDetailID      int  NOT NULL ,
	ItemName             nvarchar(50)  NOT NULL ,
	ConsumeCount         int  NOT NULL ,
	OriginalPrice        numeric(9,2)  NOT NULL ,
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
	CategoryNo           char(18)  NOT NULL ,
	
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
	ConsumeCount         numeric(5,2)  NOT NULL ,
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
	ClubCardID           int  NOT NULL ,
	ClubCardNo           int  NOT NULL ,
	CustID               int  NOT NULL ,
	CustName             nvarchar(50)  NOT NULL ,
	RechargeDate         datetime  NOT NULL ,
	RechargeStore        nvarchar(50)  NOT NULL ,
	OriginalStore        nvarchar(50)  NOT NULL ,
	ActualRechargeAmount numeric(9,2)  NOT NULL ,
	RechargeType         int  NOT NULL ,
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

