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

insert into users values ('kiet', '0918090705', '01/01/1963', '123', 15000000, 1)
select * from users where phone = '0918090705'

create table history (
	usersname nvarchar(30),
	phone nvarchar(30),
	currDate date,
	act nvarchar(30),
	sender nvarchar(30),
	receiver nvarchar(30),
	amount nvarchar(30)
)

delete from history

select * from history

update users set accBalance = 15000000
