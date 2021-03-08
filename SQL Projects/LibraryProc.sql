use dbLibrary
go

--Procedure 1
create proc dbo.uspGetLostTribeSharpstown
as
select 
copiesNumberOfCopies 
from libraryCopies
where libraryCopies.bookId = 21 and libraryCopies.branchId = 1;

exec [dbo].[uspGetLostTribeSharpstown]




--Procedure 2
create proc dbo.uspGetLostTribe
as
select libraryBranch.branchId, libraryCopies.copiesNumberOfCopies
from libraryCopies
inner join libraryBranch on libraryCopies.branchId = libraryBranch.branchId
where libraryCopies.bookId = 21;
go

exec [dbo].[uspGetLostTribe]




--Procedure 3
create proc dbo.uspGetNonBorrowers
as 
select borrowerName
from libraryBorrower
right join libraryLoans on libraryBorrower.cardNo = libraryLoans.cardNo
where libraryLoans.cardNo IS NULL;

exec [dbo].[uspGetNonBorrowers]



--Procedure 4
create proc dbo.uspGetDueBorrowers
as
select libraryBooks.bookTitle, libraryBorrower.borrowerName, libraryBorrower.borrowerAddress
from libraryBorrower
inner join libraryLoans on libraryBorrower.cardNo = libraryLoans.cardNo
inner join libraryBranch on libraryLoans.branchId = libraryBranch.branchId
inner join libraryBooks on libraryLoans.bookId = libraryBooks.bookId
where libraryLoans.loansDateDue = '2019/12/16' and libraryBranch.branchName = 'Sharpstown';

exec [dbo].[uspGetDueBorrowers]




--Procedure 5
create proc dbo.uspGetBranchBooksLoaned
as
select count(*) as 'Number of loaned books: ', libraryBranch.branchName
from libraryBranch 
inner join libraryLoans on libraryBranch.branchId = libraryLoans.branchId
group by libraryBranch.branchName;

exec [dbo].[uspGetBranchBooksLoaned]





--Procedure 6
create proc dbo.uspBooksChecked
as
select libraryBorrower.borrowerName, libraryBorrower.borrowerAddress, count(*) as 'Number of books checked out: '
from libraryBorrower
inner join libraryLoans on libraryBorrower.cardNo = libraryLoans.cardNo
group by libraryBorrower.borrowerName, libraryBorrower.borrowerAddress
having count(*) >= 5

exec [dbo].[uspBooksChecked]


--Procedure 7
create proc dbo.uspStephenKing
as
select libraryBooks.bookTitle as 'Book Title: ', libraryCopies.copiesNumberOfCopies as 'Number of copies: '
from libraryCopies
inner join libraryBooks on libraryCopies.bookId = libraryBooks.bookId
inner join libraryBranch on libraryCopies.branchId = libraryBranch.branchId
where ( libraryBranch.branchName = 'Central' and libraryBooks.bookId = 1) or ( libraryBranch.branchName = 'Central' and libraryBooks.bookId = 12)

exec [dbo].[uspStephenKing]