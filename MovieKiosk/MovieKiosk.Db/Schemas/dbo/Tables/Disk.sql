CREATE TABLE [dbo].[Disk](
	[DiskId] [int] IDENTITY(1,1) NOT NULL constraint pk_Disk primary key clustered,
	[MovieId] [int] NOT NULL  CONSTRAINT [fk_Disk_Movie_MovieId] FOREIGN KEY([MovieId]) REFERENCES [dbo].[Movie] ([MovieId]),
	[DateTimeAdded] [datetime2](7) NOT NULL CONSTRAINT [df_Disk_DatTimeAdded]  DEFAULT (getdate()),
	[DateTimeUpdated] [datetime2](7) NOT NULL CONSTRAINT [df_Disk_DatTimeUpdated]  DEFAULT (getdate()),
)

GO

