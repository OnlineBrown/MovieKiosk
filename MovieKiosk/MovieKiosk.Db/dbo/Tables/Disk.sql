CREATE TABLE [dbo].[Disk](
	[DiskId] [int] IDENTITY(1,1) NOT NULL,
	[MovieId] [int] NOT NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_Disk_DateAdded]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[DiskId] ASC
)
)

GO

ALTER TABLE [dbo].[Disk]  WITH CHECK ADD  CONSTRAINT [fk_Disk_Movie_MovieId] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movie] ([MovieId])
GO

ALTER TABLE [dbo].[Disk] CHECK CONSTRAINT [fk_Disk_Movie_MovieId]
GO
