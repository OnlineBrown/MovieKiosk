CREATE TABLE [dbo].[LocationType](
	[LocationTypeId] [int] IDENTITY(1,1) NOT NULL,
	[LocationTypeName] [varchar](255) NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_LocationType_DateAdded]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[LocationTypeId] ASC
)
)

GO
