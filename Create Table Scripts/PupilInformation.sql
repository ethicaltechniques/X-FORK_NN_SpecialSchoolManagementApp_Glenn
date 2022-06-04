/****** Object:  Table [dbo].[PupilInformation]    Script Date: 16-04-2022 19:31:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PupilInformation](
	[UniqueId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[SecondName] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[AddressStreet] [nvarchar](max) NULL,
	[HouseNumber] [nvarchar](max) NULL,
	[Zip] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL,
	[PassportNumber] [nvarchar](max) NULL,
	[FirstNameParent1] [nvarchar](max) NULL,
	[SurnameParent1] [nvarchar](max) NULL,
	[AddressStreetParent1] [nvarchar](max) NULL,
	[HouseNumberParent1] [nvarchar](max) NULL,
	[ZipParent1] [nvarchar](max) NULL,
	[CityParent1] [nvarchar](max) NULL,
	[MobileParent1] [nvarchar](max) NULL,
	[LandlineParent1] [nvarchar](max) NULL,
	[IdParent1] [nvarchar](max) NULL,
	[EmailParent1] [nvarchar](max) NULL,
	[PassportNumberParent1] [nvarchar](max) NULL,
	[ParentalAuthorityParent1] [nvarchar](max) NULL,
	[FirstNameParent2] [nvarchar](max) NULL,
	[SurnameParent2] [nvarchar](max) NULL,
	[AddressStreetParent2] [nvarchar](max) NULL,
	[HouseNumberParent2] [nvarchar](max) NULL,
	[ZipParent2] [nvarchar](max) NULL,
	[CityParent2] [nvarchar](max) NULL,
	[MobileParent2] [nvarchar](max) NULL,
	[LandlineParent2] [nvarchar](max) NULL,
	[IdParent2] [nvarchar](max) NULL,
	[EmailParent2] [nvarchar](max) NULL,
	[PassportNumberParent2] [nvarchar](max) NULL,
	[ParentalAuthorityParent2] [nvarchar](max) NULL,
	[FamilyGuardian] [nvarchar](max) NULL,
	[NameFamilyGuardian] [nvarchar](max) NULL,
	[OrganizationFamilyGuardian] [nvarchar](max) NULL,
	[EmailFamilyGuardian] [nvarchar](max) NULL,
	[MobilePhoneFamilyGuardian] [nvarchar](max) NULL,
	[YouthProtector] [nvarchar](max) NULL,
	[NameYouthProtector] [nvarchar](max) NULL,
	[OrganizationYouthProtector] [nvarchar](max) NULL,
	[EmailAddressYouthProtector] [nvarchar](max) NULL,
	[MobileYouthProtector] [nvarchar](max) NULL,
	[ImportantInformationOthers] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[UniqueId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


