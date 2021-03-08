use AdventureWorks2014
go
create proc dbo.uspGetAddress @City nvarchar(30) = NULL, @AddressLine1 nvarchar(60) = NULL
as
select * from Person.Address where City = ISNULL(@City,City) and AddressLine1 like '%' + isnull(@AddressLine1,AddressLine1) + '%'
go


drop proc dbo.uspGetAddress
create proc dbo.uspGetAddres @City nvarchar(30)
as
select * from Person.Address where City = @City

[dbo].[uspGetAddres] @City = 'New York'


exec [dbo].[uspGetAddress] @City = 'Calgary', @AddressLine1 = 'A'



create proc dbo.uspGetAddressCount @City nvarchar(30), @AddressCount int output
as
select @AddressCount = count(*) from AdventureWorks2014.Person.Adress where City = @City

declare @AddressCount int 
exec dbo.uspGetAddressCount @City = 'Calgary', @AddressCount = @AddressCount output
select @AddressCount



create proc dbo.uspTryCatchTest
as
begin try 
	select 1/0
end try
begin catch
	select ERROR_NUMBER() AS ErrorNumber,
	ERROR_SEVERITY() AS ErrorSeverity,
	ERROR_STATE() AS ErrorState,
	ERROR_PROCEDURE() AS ErrorPorcedure,
	ERROR_LINE() AS ErrorLine,
	ERROR_MESSAGE() AS ErrorMessage;
end catch

select * from Person.Address;
select * from Person.AddressType;
select * from Person.BusinessEntityId;
select * from [Person].[BusinessEntityContact]
select * from Person.BusinessEntityAddress;
select * from Person.Person a3 
inner join Person.BusinessEntityAddress a1 on a1.AddressID = a3.BusinessEntityID
inner join Person.Address a2 on a2.AddressID =  a1.AddressID where FirstName = ISNULL(@FirstName,FirstName)

create proc dbo.uspGetName @FirstName nvarchar(30) = NULL, @LastName nvarchar(50) = NULL
as
select * from Person.Person a3 
inner join Person.BusinessEntityAddress a1 on a1.AddressID = a3.BusinessEntityID
inner join Person.Address a2 on a2.AddressID =  a1.AddressID where FirstName = ISNULL(@FirstName,FirstName) and LastName = ISNULL(@LastName,LastName)
go

[dbo].[uspGetName] @FirstName = 'Ken', @LastName = 'Myer'


