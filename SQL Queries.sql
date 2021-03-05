SELECT C.Id,
       B.BrandName,
       CL.ColorName,
       C.ModelYear,
       C.DailyPrice,
       C.Description
  FROM Cars C
  LEFT JOIN Brands B
    ON C.BrandId = B.Id
  LEFT JOIN Colors CL
    ON C.ColorId = CL.Id

----

CREATE TABLE [dbo].[Customers] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [UserId]      INT          NULL,
    [CompanyName] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);


CREATE TABLE [dbo].[Rentals]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CarId] INT NULL, 
    [CustomerId] INT NULL, 
    [RentDate] DATETIME NULL, 
    [ReturnDate] DATETIME NULL
)

CREATE TABLE [dbo].[Users]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [PasswordHash] VARBINARY(500) NOT NULL, 
    [PasswordSalt] VARBINARY(500) NOT NULL, 
    [Status] BIT NOT NULL
)

CREATE TABLE [dbo].[OperationClaims]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(250) NOT NULL
)

CREATE TABLE [dbo].[UserOperationClaims]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [OperationClaimId] INT NOT NULL
)

