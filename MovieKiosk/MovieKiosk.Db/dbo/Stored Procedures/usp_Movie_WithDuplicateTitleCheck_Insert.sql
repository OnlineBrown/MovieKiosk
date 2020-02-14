CREATE PROCEDURE [dbo].[usp_Movie_WithDuplicateTitleCheck_Insert] @movieTitle       VARCHAR(250), 
                                                                  @movieDescription VARCHAR(8000), 
                                                                  @releaseYear      CHAR(4)
AS
     DECLARE @resultMessage VARCHAR(100)= 'There was an error adding this entry';
    BEGIN TRY
        IF EXISTS
        (
            SELECT TOP 1 MovieId
            FROM [Movie]
            WHERE MovieTitle = @MovieTitle
                  AND dbo.Movie.ReleaseYear = @releaseYear
        )
            BEGIN
                SET @resultMessage = 'This movie title already exists';
                SELECT @resultMessage;
                RETURN;
        END;
        INSERT INTO [dbo].[Movie]
        ([MovieTitle], 
         [MovieDescription], 
         [ReleaseYear]
        )
        VALUES
        (@movieTitle, 
         @movieDescription, 
         @releaseYear
        );
        SET @resultMessage = 'Movie successfully added';
        SELECT @resultMessage;
        RETURN;
    END TRY
    BEGIN CATCH
        SELECT @resultMessage;
        RETURN;
    END CATCH;
GO