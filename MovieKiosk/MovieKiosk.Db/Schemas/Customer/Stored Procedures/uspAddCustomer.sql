CREATE PROCEDURE [Customer].[uspAddCustomer]
	@firstName varchar(255)
	, @lastName varchar(255)
	, @emailAddress varchar(255)
AS

INSERT INTO	Customer.Customer
(

    CustomerFirstName
    ,CustomerLastName
    ,CustomerEmailAddress
)
VALUES
(
    @firstName
    ,@lastName
    ,@emailAddress
)