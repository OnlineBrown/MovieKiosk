CREATE Procedure [dbo].[usp_Movie_WithDuplicateTitleCheck_Insert]
			@movieTitle varchar(250)
           ,@movieDescription varchar(8000)
           ,@releaseYear char(4)
		   
As


declare @resultMessage varchar(100) = 'There was an error adding this entry'

Begin Try

If Exists (Select top 1 MovieId From [Movie] Where MovieTitle = @MovieTitle) 
	Begin
	
		Set  @resultMessage  = 'This movie title already exists'
		Select @resultMessage
		Return

	End



INSERT INTO [dbo].[Movie]
	(
		[MovieTitle]
		,[MovieDescription]
		,[ReleaseYear]
	)
     VALUES
	(
		@movieTitle
		,@movieDescription
		,@releaseYear
	)

Set  @resultMessage  = 'Movie successfully added'

Select @resultMessage
Return

End Try

Begin Catch

Select @resultMessage
Return

End Catch


GO
