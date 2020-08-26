CREATE PROCEDURE [dbo].[usp_Movie_ByTitle_Search]
     @titleSearch VARCHAR(255)
AS
     IF @titleSearch IS NULL
         BEGIN
             SELECT
                *
             FROM
                  [Movie];
        END;
         ELSE
         BEGIN
             SELECT
                *
             FROM
                  [Movie]
             WHERE MovieTitle LIKE '%' + @titleSearch + '%';
     END;
GO