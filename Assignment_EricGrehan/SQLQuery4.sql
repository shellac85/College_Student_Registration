﻿Alter PROC uspInsertIntoStudent
@studentnumber varchar (20),
@firstname VARCHAR(20),
@surname varchar (20),
@email varchar(20),
@phone varchar (20),
@addressLine1 varchar (20),
@addressLine2 varchar (20),
@city varchar (20),
@county varchar (20),
@level varchar (20),
@course varchar (20)
AS
INSERT INTO Student VALUES(@studentnumber,@firstname,@surname,@email,@phone,@addressLine1,@addressLine2,@city,@county,@level,@course)

EXEC uspInsertIntoStudent
@studentnumber = '023435646',
@firstname = 'Toby' ,
@surname = 'Ward',
@email = 'email@yahoo.com',
@phone = '01234567' ,
@addressLine1 = 'Street1' ,
@addressLine2 ='Street2',
@city = 'Dublin4' ,
@county = 'Cork',
@level = 'PostGraduate' ,
@course = 'Programming'
