﻿CREATE TABLE [dbo].[Location](
	[LocationId] [int] IDENTITY(1,1) NOT NULL,
	[LocationTypeId] [int] NULL,
	[DateAdded] [datetime2](7) NOT NULL CONSTRAINT [df_Location_DateAdded]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
) 
)

GO

ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [fk_Location_LocationType_LocationTypeId] FOREIGN KEY([LocationTypeId])
REFERENCES [dbo].[LocationType] ([LocationTypeId])
GO

ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [fk_Location_LocationType_LocationTypeId]
GO
