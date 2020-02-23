CREATE Procedure [dbo].[usp_Movie_ByTitle_Search]
	@titleSearch varchar(255)

As

Select 
	*
From [Movie]
Where MovieTitle like '%' + @titleSearch + '%'
GO