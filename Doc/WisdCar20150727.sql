
CREATE TABLE Car
(
	CarID                integer IDENTITY (1) ,
	CarNo                varchar(20)  NULL ,
	Brand                varchar(20)  NULL ,
	CarModel             varchar(20)  NULL ,
	Capacity             varchar(20)  NULL ,
	Color                varchar(20)  NULL ,
	FrameNo              varchar(20)  NULL ,
	EngineNo             varchar(20)  NULL ,
	MaintainKM           varchar(20)  NULL ,
	InsureDate           datetime  NULL ,
	ASDate               datetime  NULL ,
	CustomerID           integer  NOT NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE Car
	ADD CONSTRAINT XPKCar PRIMARY KEY  CLUSTERED (CarID ASC)
go


CREATE TABLE ClubCard
(
	ClubCardID           bigint IDENTITY (1000) ,
	ClubCardTypeName     varchar(20)  NULL ,
	CustName             varchar(20)  NULL ,
	ClubCardType         varchar(20)  NULL ,
	ClubCardPwd          varchar(20)  NULL ,
	OpenCardStore        varchar(20)  NULL ,
	SalesMan             varchar(20)  NULL ,
	SalesTime            datetime  NULL ,
	Balance              numeric(9,2)  NULL ,
	CustomerID           integer  NOT NULL ,
	ClubCardTypeID       integer  NOT NULL ,
	ExpireDate           datetime  NULL ,
	Status               integer  NULL ,
	ClubCardNo           varchar(20)  NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE ClubCard
	ADD CONSTRAINT XPKClubCard PRIMARY KEY  CLUSTERED (ClubCardID ASC)
go


CREATE TABLE ClubCardPackage
(
	ClubCardPackageID    integer IDENTITY (1) ,
	PackageName          varchar(20)  NULL ,
	OriginalAmount       numeric(9,2)  NULL ,
	ActualAmount         numeric(9,2)  NULL ,
	DiscountRate         numeric(5,2)  NULL ,
	DiscountInfo         varchar(20)  NULL ,
	Status               integer  NULL ,
	Salesman             varchar(20)  NULL ,
	SalesTime            datetime  NULL ,
	SaleStore            varchar(20)  NULL ,
	PackageID            integer  NOT NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE ClubCardPackage
	ADD CONSTRAINT XPKClubCardPackage PRIMARY KEY  CLUSTERED (ClubCardPackageID ASC)
go


CREATE TABLE ClubCardPackageDetail
(
	PackageDetailID      integer IDENTITY (1) ,
	ItemID               integer  NULL ,
	ItemName             varchar(20)  NULL ,
	UnitPrice            numeric(9,2)  NULL ,
	OriginalCount        integer  NULL ,
	RemainCount          integer  NULL ,
	ClubCardPackageID    integer  NOT NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE ClubCardPackageDetail
	ADD CONSTRAINT XPKClubCardPackageDetail PRIMARY KEY  CLUSTERED (PackageDetailID ASC)
go


CREATE TABLE ClubCardType
(
	ClubCardTypeID       integer IDENTITY (1) ,
	CardTypeName         integer  NULL ,
	PackageDiscount      numeric(5,2)  NULL ,
	PayDiscount          numeric(5,2)  NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE ClubCardType
	ADD CONSTRAINT XPKClubCardType PRIMARY KEY  CLUSTERED (ClubCardTypeID ASC)
go


CREATE TABLE ConsumeItem
(
	ItemID               integer IDENTITY (1) ,
	ItemName             varchar(20)  NULL ,
	ItemPrice            numeric(9,2)  NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE ConsumeItem
	ADD CONSTRAINT XPKConsumeItem PRIMARY KEY  CLUSTERED (ItemID ASC)
go


CREATE TABLE ConsumeLog
(
	ConsumeLogID         bigint IDENTITY (1) ,
	ClubCardID           integer  NULL ,
	ClubCardNo           integer  NULL ,
	CustID               integer  NULL ,
	CustName             varchar(20)  NULL ,
	ConsumeDate          datetime  NULL ,
	ConsumeStore         varchar(20)  NULL ,
	OriginalStore        varchar(20)  NULL ,
	ConsumeType          integer  NULL ,
	ClubCardPackageID    integer  NULL ,
	PackageDetailID      integer  NULL ,
	ItemName             varchar(20)  NULL ,
	ConsumeCount         integer  NULL ,
	OriginalPrice        numeric(9,2)  NULL ,
	ItemID               integer  NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE ConsumeLog
	ADD CONSTRAINT XPKConsumeLog PRIMARY KEY  CLUSTERED (ConsumeLogID ASC)
go


CREATE TABLE Customer
(
	Name                 varchar(20)  NULL ,
	CustomerID           integer IDENTITY (1000) ,
	MobileNO             varchar(20)  NULL ,
	Sex                  varchar(20)  NULL ,
	Birthday             varchar(20)  NULL ,
	ICNo                 varchar(20)  NULL ,
	Weixin               varchar(20)  NULL ,
	Company              varchar(20)  NULL ,
	CardFlag             integer  NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE Customer
	ADD CONSTRAINT XPKCustomer PRIMARY KEY  CLUSTERED (CustomerID ASC)
go


CREATE TABLE Employee
(
	EmployeeID           integer IDENTITY (1) ,
	EmployeeNo           integer  NULL ,
	Name                 varchar(20)  NULL ,
	Sex                  varchar(20)  NULL ,
	Phone                varchar(20)  NULL ,
	JobType              varchar(20)  NULL ,
	EmployeeAddr         varchar(20)  NULL ,
	Resume               varchar(20)  NULL ,
	StoreID              integer  NOT NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE Employee
	ADD CONSTRAINT XPKEmployee PRIMARY KEY  CLUSTERED (EmployeeID ASC)
go


CREATE TABLE KVLookup
(
	LookupID             integer IDENTITY (1) ,
	LookupKey            varchar(20)  NULL ,
	LookupValue          char(18)  NULL ,
	CategoryNo           char(18)  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE KVLookup
	ADD CONSTRAINT XPKKVLookup PRIMARY KEY  CLUSTERED (LookupID ASC)
go


CREATE TABLE Package
(
	PackageID            integer IDENTITY (1) ,
	PackageName          varchar(20)  NULL ,
	TotalPrice           numeric(9,2)  NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	LastModifierID       integer  NULL ,
	LastModifiedDate     datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE Package
	ADD CONSTRAINT XPKPackage PRIMARY KEY  CLUSTERED (PackageID ASC)
go


CREATE TABLE PackageItemMapping
(
	PackageItemID        integer IDENTITY (1) ,
	ConsumeCount         numeric(5,2)  NULL ,
	PackageID            integer  NOT NULL ,
	ItemID               integer  NOT NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE PackageItemMapping
	ADD CONSTRAINT XPKPackageItemMapping PRIMARY KEY  CLUSTERED (PackageItemID ASC)
go


CREATE TABLE RechargeLog
(
	RechargeLogID        bigint IDENTITY (1) ,
	ClubCardID           integer  NULL ,
	ClubCardNo           integer  NULL ,
	CustID               integer  NULL ,
	CustName             varchar(20)  NULL ,
	RechargeDate         datetime  NULL ,
	RechargeStore        varchar(20)  NULL ,
	OriginalStore        varchar(20)  NULL ,
	ActualRechargeAmount numeric(9,2)  NULL ,
	RechargeType         integer  NULL ,
	ClubCardPackageID    integer  NULL ,
	PlatformRechargeAmount numeric(9,2)  NULL ,
	DiscountRate         numeric(5,2)  NULL ,
	DiscountInfo         varchar(20)  NULL ,
	CreatorID            integer  NULL ,
	CreatedDate          datetime  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
)
go


ALTER TABLE RechargeLog
	ADD CONSTRAINT XPKRechargeLog PRIMARY KEY  CLUSTERED (RechargeLogID ASC)
go


CREATE TABLE Store
(
	StoreID              integer IDENTITY (1000) ,
	StoreName            varchar(20)  NULL ,
	StoreAddress         varchar(20)  NULL ,
	StorePhone           varchar(20)  NULL ,
	Fax                  varchar(20)  NULL ,
	Reserved1            varchar(20)  NULL ,
	Reserved2            varchar(20)  NULL ,
	Reserved3            varchar(20)  NULL 
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
	ADD CONSTRAINT  R_20 FOREIGN KEY (ClubCardTypeID) REFERENCES ClubCardType(ClubCardTypeID)
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

