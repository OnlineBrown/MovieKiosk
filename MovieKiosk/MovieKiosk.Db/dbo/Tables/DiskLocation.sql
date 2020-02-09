CREATE TABLE [dbo].[DiskLocation]
(
	[DiskLocationId] INT Identity NOT NULL constraint pk_DiskLocation PRIMARY KEY Clustered
	,DiskId Int Not null constraint fk_DiskLocation_Disk foreign key references dbo.disk(DiskId)
	, LocationId int not null constraint fk_DiskLocation_Location foreign key references dbo.Location(LocationId)
	, DateTimeInserted Datetime2 not null constraint df_DiskLocation_DateTimeInserted default (getdate())
	, DateTimeUpdated datetime2 not null constraint df_DiskLocation_DateTimeUpdated default (getdate())
)
