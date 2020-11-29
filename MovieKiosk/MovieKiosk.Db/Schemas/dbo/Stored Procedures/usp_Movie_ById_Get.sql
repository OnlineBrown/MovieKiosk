CREATE PROCEDURE [dbo].[usp_Movie_ById_Get]
     @movieId INT   
AS
    Select 
            MovieId 
          , MovieTitle
          , MovieDescription
          , ReleaseYear
          From dbo.Movie
     WHERE
        [dbo].[Movie].MovieId = @movieId;