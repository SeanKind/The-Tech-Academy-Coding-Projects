create database dbLibrary
use dbLibrary

create table libraryBranch (
	branchId int primary key NOT NULL identity (1,1),
	branchName varchar(50) NOT NULL,
	branchAddress varchar(50) NOT NULL
);

create table libraryPublisher (
	publisherName varchar(50) primary key NOT NULL,
	publisherAddress varchar(50) NOT NULL,
	publisherPhone varchar(50) NOT NULL
);

create table libraryBooks (
	bookId int primary key NOT NULL identity (1,1),
	bookTitle varchar(50) NOT NULL,
	publisherName varchar(50) NOT NULL constraint fkPublisherName foreign key references libraryPublisher(publisherName) on update cascade on delete cascade
);

create table libraryAuthors (
	bookId int NOT NULL constraint fkBookId foreign key references libraryBooks(bookId) on update cascade on delete cascade,
	authorsName varchar(50) NOT NULL
);

create table libraryBorrower (
	cardNo int primary key NOT NULL identity (1,1),
	borrowerName varchar(50) NOT NULL,
	borrowerAddress varchar(50) NOT NULL,
	borrowerPhone varchar(50) NOT NULL
);

create table libraryLoans (
	bookId int NOT NULL constraint fkBookIdLoan foreign key references libraryBooks(bookId) on update cascade on delete cascade,
	branchId int NOT NULL constraint fkBranchIdLoans foreign key references libraryBranch(branchId) on update cascade on delete cascade,
	cardNo int NOT NULL constraint fkCardNo foreign key references libraryBorrower(cardNo) on update cascade on delete cascade,
	loansDateOut date NOT NULL,
	loansDateDue date NOT NULL
);

create table libraryCopies (
	bookId int NOT NULL constraint fkBookIdCopies foreign key references libraryBooks(bookId) on update cascade on delete cascade,
	branchId int NOT NULL constraint fkBranchIdCopies foreign key references libraryBranch(branchId) on update cascade on delete cascade,
	copiesNumberOfCopies int NOT NULL
);

insert into libraryBranch
	(branchName, branchAddress)
	values
	('Sharpstown', '3992 E Atom Dr'),
	('Central', '0855 N Bork St'),
	('Boardwalk', '5802 E Copper Road'),
	('Gregory', '0032 W Silk Ave')
;

insert into libraryPublisher
	(publisherName, publisherAddress, publisherPhone)
	values
	('PublishCO', '4410 S Decon St', '992-852-2252'),
	('WePublishNow', '5296 W Emerald Dr', '205-582-8205'),
	('PubForYou', '2950 N Fault Way','935-392-7483')
;

insert into libraryBooks 
	(bookTitle, publisherName)
	values
	('The Shining', 'WePublishNow'), ('The Book Thief', 'PublishCo'), ('Holes', 'PublishCO'), ('The Outsiders', 'PubForYou'),
	('The Golden Compass', 'PubForYou'), ('Bridge to Terabithia', 'WePublishNow'), ('The Maze Runner', 'PublishCO'), ('The City of Ember', 'PublishCO'),
	('Lord of the Flies', 'WePublishNow'), ('Coraline', 'PubForYou'), ('The Curious Incident of the Dog in the Night-Time', 'PublishCO'), ('It', 'PubForYou'),
	('The Fault in Our Stars', 'PubForYou'), ('Divergent', 'PublishCO'), ('To Kill a Mockingbird', 'WePublishNow'), ('Eragon', 'PublishCO'),
	('Harry Potter', 'WePublishNow'), ('The Lightning Thief', 'PubForYou'), ('Twilight', 'PublishCO'), ('The Giver', 'PubForYou'), ('The Lost Tribe', 'PubForYou')
;

insert into libraryAuthors
	(bookId, authorsName)
	values
	(1,'Stephen King'), (2, 'Markus Zusak'), (3, 'Louis Sachar'), (4, 'S.E. Hinton'), (5, 'Philip Pullman'),
	(6, 'Katherine Paterson'), (7, 'James Dashner'), (8, 'Jeanne DuPrau'), (9, 'William Golding'), (10, 'Neil Gaiman'), 
	(11, 'Mark Haddon'), (12, 'Stephen King'), (13, 'John Green'), (14, 'Veronica Roth'), (15, 'Harper Lee'),
	(16, 'Christopher Paolini'), (17, 'J.K. Rowling'), (18, 'Rick Riordan'), (19, 'Stephenie Meyer'), (20, 'Lois Lowry'), (21, 'Mark Lee')
;

insert into libraryCopies
	(bookId, branchId, copiesNumberOfCopies)
	values
	(21, 1, 3), (15, 1, 4), (4, 1, 5), (6, 1, 3), (13, 1, 2), (7, 1, 5), (9, 1, 4), (8, 1, 2), (10, 1, 3), (11, 1, 2),
	(1, 2, 4), (12, 2, 2), (3, 2, 2), (7, 2, 5), (5, 2, 3), (18, 2, 4), (20, 2, 2), (14, 2, 6), (11, 2, 5), (2, 2, 2),
	(5, 3, 2), (3, 3, 4), (6, 3, 3), (9, 3, 3), (10, 3, 6), (2, 3, 5), (1, 3, 4), (18, 3, 2), (19, 3, 3), (15, 3, 5),
	(16, 4, 5), (1, 4, 4), (8, 4, 2), (5, 4, 4), (17, 4, 3), (21, 4, 5), (2, 4, 2), (3, 4, 3), (9, 4, 4), (20, 4, 2)
;

insert into libraryBorrower 
	(borrowerName, borrowerAddress, borrowerPhone)
	values
	('Joshua Daniels', '3965 N Addison St', '392-559-2955'), ('Adam Rodgers', '2773 W Berkley Dr', '883-296-5392'), 
	('Frank Rodriguez', '5788 S Carolina Way', '387-539-2885'), ('Blake Brennan', '2852 N Detroit St', '100-285-2885'), 
	('Jessica Smith', '2993 W Eddy Ave', '995-395-7548'), ('Ashley Jenkins', '2005 S Garrison Ave', '820-285-2869'), 
	('Cameron Simmons', '8685 S Hardstone Dr', '385-229-3872'), ('Isabella Jones', '8503 N Indigo St', '587-295-5928'), 
	('Sam Lanier', '4452 W Jamestown Rd', '288-387-2858'), ('Sarah Hunt', '5820 E Kraken Way', '385-225-8500')
;

insert into libraryLoans 
	(bookId, branchId, cardNo, loansDateOut, loansDateDue)
	values
	(21, 1, 5, '2019/11/20', '2019/12/20'), (15, 1, 5, '2019/11/20', '2019/12/20'), (7, 1, 5, '2019/11/20', '2019/12/20'), (8, 1, 5, '2019/11/20', '2019/12/20'), (11, 1, 5, '2019/11/20', '2019/12/20'), 
	(4, 1, 5, '2019/11/20', '2019/12/20'), (13, 1, 5, '2019/11/20', '2019/12/20'), (10, 1, 5, '2019/11/20', '2019/12/20'), (5, 3, 7, '2019/11/18', '2019/12/18'), (10, 3, 7, '2019/11/18', '2019/12/18'), 
	(1, 3, 7, '2019/11/18', '2019/12/18'), (2, 3, 7, '2019/11/21', '2019/12/21'), (19, 3, 7, '2019/11/21', '2019/12/21'), (15, 3, 7, '2019/11/21', '2019/12/21'), (18, 3, 7, '2019/11/21', '2019/12/21'), 
	(6, 3, 7, '2019/11/21', '2019/12/21'), (15, 1, 2, '2019/11/15', '2019/12/15'), (10, 1, 2, '2019/11/15', '2019/12/15'), (9, 1, 2, '2019/11/16', '2019/12/16'), (4, 1, 2, '2019/11/16', '2019/12/16'), 
	(1, 2, 9, '2019/11/22', '2019/12/22'), (7, 2, 9, '2019/11/22', '2019/12/22'), (20, 2, 9, '2019/11/22', '2019/12/22'), (21, 4, 10, '2019/11/14', '2019/12/14'), (9, 4, 10, '2019/11/23', '2019/11/23'), 
	(17, 4, 10, '2019/11/14', '2019/12/14'), (1, 4, 10, '2019/11/14', '2019/12/14'), (16, 4, 10, '2019/11/23', '2019/12/23'), (5, 3, 6, '2019/11/20', '2019/12/20'), (3, 3, 6, '2019/11/20', '2019/12/20'), 
	(10, 3, 6, '2019/11/17', '2019/12/17'), (18, 3, 6, '2019/11/17', '2019/12/17'), (5, 4, 4, '2019/11/18', '2019/12/18'), (9, 4, 4, '2019/11/20', '2019/12/20'), (20, 4, 4, '2019/11/23', '2019/12/23'), 
	(1, 2, 1, '2019/11/13', '2019/12/13'), (12, 2, 1, '2019/11/13', '2019/12/13'), (14, 2, 1, '2019/11/13', '2019/12/13'), (11, 2, 1, '2019/11/13', '2019/12/13'), (20, 2, 1, '2019/11/13', '2019/12/13'), 
	(3, 2, 1, '2019/11/13', '2019/12/13'), (21, 1, 3, '2019/11/24', '2019/12/24'), (13, 1, 3, '2019/11/24', '2019/12/24'), (8, 4, 8, '2019/11/19', '2019/12/19'), (5, 4, 8, '2019/11/19', '2019/12/19'), 
	(16, 4, 8, '2019/11/19', '2019/12/19'), (20, 4, 8, '2019/11/19', '2019/12/19'), (9, 4, 8, '2019/11/19', '2019/12/19'), (17, 4, 8, '2019/11/19', '2019/12/19'), (2, 4, 8, '2019/11/19', '2019/12/19')
;

select * from libraryBranch
select * from libraryPublisher
select * from libraryBooks
select * from libraryAuthors
select * from libraryCopies
select * from libraryLoans
select * from libraryBorrower