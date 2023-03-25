use project;

create table users (
	username nvarchar(30),
	phone nvarchar(30),
	dob date,
	pass nvarchar(30),
	accBalance bigInt,
	gender bit
)

insert into users values ('phuc', '0915692401', '05/05/2001', '123', 15000000, 1);

select * from users where username = 'phuc' and pass = '123';

select * from users where username = 'phuc' and pass = '123'

select * from users where phone = '0918090705';

delete from users where pass = '4'

update users set accBalance = 15000000 where phone = '0918090705';

insert into users values ('kiet', '0918090705', '01/01/1963', '123', 15000000, 1)
