CREATE TABLE [dbo].[Movie](
	[MovieId] [int] IDENTITY(1,1)  NOT NULL constraint pk_Movie primary key clustered,
	[MovieTitle] [varchar](250) NULL,
	[MovieDescription] [varchar](8000) NULL,
	[ReleaseYear] [char](4) NULL,
	[DateTimeAdded] [datetime2](7) NULL CONSTRAINT [df_Movie_DateTimeAdded]  DEFAULT (getdate()),
	[DateTimeUpdated] [datetime2](7) NULL CONSTRAINT [df_Movie_DateTimeUpdated]  DEFAULT (getdate()),

)
