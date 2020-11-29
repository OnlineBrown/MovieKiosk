CREATE PROCEDURE [dbo].[usp_Movie_Update]
     @movieId          INT
    ,@movieTitle       VARCHAR(250)
    ,@movieDescription VARCHAR(8000)
    ,@releaseYear      CHAR(4)
AS
     UPDATE [dbo].[Movie]
       SET
           MovieTitle=ISNULL(@movieTitle ,MovieTitle)
          ,MovieDescription=ISNULL(@movieDescription ,MovieDescription)
          ,ReleaseYear=ISNULL(@releaseYear ,ReleaseYear)
     WHERE
        [dbo].[Movie].MovieId = @movieId;

        --Return Updated Data
        Select 
            MovieTitle
            , MovieDescription
            , ReleaseYear
        from dbo.Movie
        WHERE
            MovieId = @movieId;
            