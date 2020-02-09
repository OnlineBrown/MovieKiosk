CREATE TABLE [dbo].[TransportType](
	[TransportTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TransportTypeName] [varchar](255) NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_TransportType_DateAdded]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[TransportTypeId] ASC
)
)

GO
