CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerFirstName] [varchar](255) NULL,
	[CustomerLastName] [varchar](255) NULL,
	[CustomerEmailAddress] [varchar](500) NULL,
	[customerCreaditCardTypeId] [int] NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_Customer_DateAdded]  DEFAULT (getdate())

PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)
)

GO
