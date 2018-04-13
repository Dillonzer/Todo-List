SELECT * FROM Tasks

/*
Create the Tasks table
*/
CREATE TABLE Tasks
(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Owner nvarchar(MAX) NOT NULL,
	Task nvarchar(MAX) NOT NULL,
	Status smallint NOT NULL,
	InsertedDate datetime NOT NULL,
	CompletedDate datetime
);

--drop it
DROP TABLE Tasks