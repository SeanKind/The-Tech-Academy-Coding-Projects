
create proc createZooDb
as
begin
	create table tblAnimalia (
		animaliaId int primary key NOT NULL identity (1,1),
		animaliaType varchar(50) NOT NULL
	);

	create table tblClass (
		classId int primary key NOT NULL identity (100,1),
		classType varchar(50) NOT NULL
	);

	create table tblOrder (
		orderId int primary key NOT NULL identity (1,1),
		orderType varchar(50) NOT NULL
	);

	create table tblCare (
		careId varchar(50) primary key NOT NULL,
		careType varchar(50) NOT NULL,
		careSpecialist int NOT NULL
	);

	create table tblNutrition ( 
		nutritionId int primary key NOT NULL identity (2200,1),
		nutritionType varchar(50) NOT NULL,
		nutritionCost money NOT NULL
	);

	create table tblHabitat (
		habitatId int primary key NOT NULL identity(5000,1),
		habitatType varchar(50) NOT NULL,
		habitatCost money NOT NULL
	);

	create table tblSpecialist (
		specialistId int primary key NOT NULL identity(1,1),
		specialistFname varchar(50) NOT NULL,
		specialistLname varchar(50) NOT NULL,
		specialistContact varchar(50) NOT NULL
	);

	create table tblSpecies (
		speciesId int primary key NOT NULL identity (1,1),
		speciesName varchar(50) NOT NULL,
		speciesAnimalia int NOT NULL constraint fkAnimaliaId foreign key references tblAnimalia(animaliaId) on update cascade on delete cascade,
		speciesClass int NOT NULL constraint fkClassId foreign key references tblClass(classId) on update cascade on delete cascade,
		speciesOrder int NOT NULL constraint fkOrderId foreign key references tblOrder(orderId) on update cascade on delete cascade,
		speciesHabitat int NOT NULL constraint fkHabitatId foreign key references tblHabitat(habitatId) on update cascade on delete cascade,
		speciesNutrition int NOT NULL constraint fkNutritionId foreign key references tblNutrition(nutritionId) on update cascade on delete cascade,
		speciesCare varchar(50) NOT NULL constraint fkCareId foreign key references tblCare(careId) on update cascade on delete cascade
	);




	insert into tblAnimalia 
		(animaliaType) 
		values
		('vertebrate'),
		('invertebrate')
	;

	insert into tblClass
		(classType)
		values
		('bird'),
		('reptilian'),
		('mammal'),
		('arthropod'),
		('fish'),
		('worm'),
		('cnidaria'),
		('echinoders')
	;

	insert into tblOrder
		(orderType)
		values
		('carnivore'),
		('herbivore'),
		('omnivore')
	;

	insert into tblCare
		(careId, careType, careSpecialist)
		values
		('care0', 'replace the straw', 1),
		('care1', 'repair or replace broken toys', 4),
		('care2', 'bottle feed vitimans', 1),
		('care3', 'human contactPet subject', 2),
		('care4', 'clean up animal waste', 1),
		('care5', 'move subject to exercise pen', 3),
		('care6', 'drain and refill aquarium', 1),
		('care7', 'extensive dental work', 3)
	;

	insert into tblNutrition 
		(nutritionType, nutritionCost)
		values
		('raw fish', 1500),
		('living rodents', 600),
		('mixture of fruit and rice', 800),
		('warm bottle of milk', 600),
		('syringe feed broth', 600),
		('lard and seed mix', 300),
		('aphids', 150),
		('vitimans and marrow', 3500)
	;

	insert into tblHabitat
		(habitatType, habitatCost)
		values
		('tundra', 40000),
		('grassy gnoll with trees', 12000),
		('10 ft pond and rocks', 30000),
		('icy aquarium with snoy facade', 50000),
		('short grass, shade, and moat', 50000),
		('neetted forrest atrium', 10000),
		('jungle vines and winding branches', 15000),
		('cliff with shaded cave', 15000)
	;

	insert into tblSpecialist 
		(specialistfName, specialistlName, specialistContact)
		values
		('margret', 'nyguen', '384-576-2899'),
		('mary', 'fischer', '384-784-4856'),
		('arnold', 'holden', '385-475-3944'),
		('kem', 'byesan', '384-485-4855'),
		('delmonte', 'fyedo', '768-288-3749')
	;

	insert into tblSpecies 
		(speciesName, speciesAnimalia, speciesClass, speciesOrder, speciesHabitat, speciesNutrition, speciesCare)
		values
		('brown bear', 1, 102, 3, 5007, 2200, 'care1'),
		('jaguar', 1, 102, 1, 5007, 2200, 'care4'),
		('penguin', 1, 100, 1, 5003, 2200, 'care6'),
		('ghost bat', 1, 102, 1, 5007, 2204, 'care2'),
		('chicken', 1, 100, 3, 5001, 2205, 'care0'),
		('panda', 1, 102, 3, 5006, 2202, 'care4'),
		('bobcat', 1, 102, 1, 5001, 2204, 'care5'),
		('gray wolf', 1, 102, 1, 5000, 2201, 'care4')
	;



	select 
		a1.speciesName, a2.animaliaType,
		a3.classType, a4.orderType, a5.habitatType,
		a6.nutritionType, a7.careType
		from tblSpecies a1
		inner join tblAnimalia a2 on a2.animaliaId = a1.speciesAnimalia
		inner join tblClass a3 on a3.classId = a1.speciesClass
		inner join tblOrder a4 on a4.orderId = a1.speciesOrder
		inner join tblHabitat a5 on a5.habitatId = a1.speciesHabitat
		inner join tblNutrition a6 on a6.nutritionId = a1.speciesNutrition
		inner join tblCare a7 on a7.careId = a1.speciesCare
		where speciesName = 'brown bear'
	;

	select 
		a1.speciesName, a2.animaliaType,
		a3.classType, a4.orderType, a5.habitatType,
		a6.nutritionType, a7.careType
		from tblSpecies a1
		inner join tblAnimalia a2 on a2.animaliaId = a1.speciesAnimalia
		inner join tblClass a3 on a3.classId = a1.speciesClass
		inner join tblOrder a4 on a4.orderId = a1.speciesOrder
		inner join tblHabitat a5 on a5.habitatId = a1.speciesHabitat
		inner join tblNutrition a6 on a6.nutritionId = a1.speciesNutrition
		inner join tblCare a7 on a7.careId = a1.speciesCare
		where speciesName = 'ghost bat'
	;

	select
		a1.speciesName, a2.habitatType, a2.habitatCost,
		a3.nutritionType, a3.nutritionCost
		from tblSpecies a1
		inner join tblHabitat a2 on a2.habitatId = a1.speciesHabitat
		inner join tblNutrition a3 on a3.nutritionId = a1.speciesNutrition
		where speciesName = 'ghost bat'
	;
end