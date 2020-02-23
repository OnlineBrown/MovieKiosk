CREATE TABLE [dbo].[Transport](
	[TransportId] [int] IDENTITY(1,1) NOT NULL,
	[TransportName] [varchar](255) NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_Transport_DateAdded]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[TransportId] ASC
)
)

GO
