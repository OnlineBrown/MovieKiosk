CREATE TABLE [dbo].[CreditCardType](
	[CreditCardTypeId] [int] IDENTITY(1,1) NOT NULL,
	[CreditCardTypeName] [varchar](100) NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_CreditCardType_DateAdded]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[CreditCardTypeId] ASC
)
)

GO
