use dbZooActual


select * from tblSpecies;
select * from tblSpecialist;
select * from tblCare;
select * from tblNutrition;

select * from tblHabitat; /* Drill 1 */
select speciesName from tblSpecies where speciesOrder = 3; /* Drill 2 */
select nutritionType from tblNutrition where nutritionCost < 600.00; /* Drill 3 */
select speciesName from tblSpecies where speciesNutrition between 2202 and 2206; /* Drill 4 */
select a1.speciesName as 'Species Name: ', a2.nutritionType as 'Nutrition Type: '
	from tblSpecies a1
	inner join tblNutrition a2 on a2.nutritionId = a1.speciesNutrition; /* Drill 5 */
select speciesName, specialistFname, specialistLname, specialistContact from tblSpecialist 
inner join tblCare on tblCare.careSpecialist = convert(varchar(50),tblSpecialist.specialistId)
inner join tblSpecies on tblCare.careId = speciesCare where speciesName = 'penguin'; /* Drill 6 */



create database drill7

use drill7

create table phoneAddress (
	contactId int primary key NOT NULL identity (1,1),
	phoneNum varchar(50) NOT NULL,
	contactAdd varchar(50) NOT NULL
);
create table firstLast (
	fName varchar(50) NOT NULL,
	lName varchar(50) NOT NULL,
	link int NOT NULL constraint fkContactId foreign key references phoneAddress(contactId) on update cascade on delete cascade
);

insert into phoneAddress 
(phoneNum, contactAdd)
values
('523-834-6344', '44902 Robin Street'),
('894-339-9887','99203 Winston Avenue'),
('949-660-1039','88492 Cascades Drive')
;

insert into firstLast 
(fName, lName, link)
values
('james','hardy', 1),
('dillion','smith', 2),
('jessica','rodreguez', 3)
;

select fName, lName
from firstLast
inner join phoneAddress on firstLast.link = phoneAddress.contactId;
/* select phoneNum, contactAdd 
from phoneAddress
inner join firstLast on phoneAddress.contactId = firstLast.link; */ 
/* Drill 7 */




