CREATE TABLE [dbo].[Movie](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieTitle] [varchar](250) NULL,
	[MovieDescription] [varchar](8000) NULL,
	[ReleaseYear] [char](4) NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_Movie_DateAdded]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)
)
