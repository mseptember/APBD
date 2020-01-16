CREATE SCHEMA apbd;

GO

-- tables
-- Table: Student
CREATE TABLE apbd.Student (
    IdStudent int  NOT NULL IDENTITY,
    FirstName nvarchar(100)  NOT NULL,
    LastName nvarchar(100)  NOT NULL,
    Address nvarchar(100)  NOT NULL,
	IndexNumber nvarchar(50) NOT NULL,
    IdStudies int  NOT NULL,
    CONSTRAINT Student_pk PRIMARY KEY  (IdStudent)
);

-- Table: Student_Subject
CREATE TABLE apbd.Student_Subject (
    IdStudentSubject int  NOT NULL IDENTITY,
    IdStudent int  NOT NULL,
    IdSubject int  NOT NULL,
    CreatedAt datetime  NOT NULL,
    CONSTRAINT Student_Subject_pk PRIMARY KEY  (IdStudentSubject,IdStudent,IdSubject)
);

-- Table: Studies
CREATE TABLE apbd.Studies (
    IdStudies int  NOT NULL IDENTITY,
    Name nvarchar(100)  NOT NULL,
    CONSTRAINT Studies_pk PRIMARY KEY  (IdStudies)
);

-- Table: Subject
CREATE TABLE apbd.Subject (
    IdSubject int  NOT NULL IDENTITY,
    Name nvarchar(100)  NOT NULL,
    CONSTRAINT Subject_pk PRIMARY KEY  (IdSubject)
);

-- End of file.
