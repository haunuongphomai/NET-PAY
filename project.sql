use project;

create table users (
	username nvarchar(30),
	phone nvarchar(30) primary key,
	dob date,
	pass nvarchar(30),
	accBalance bigInt,
	gender bit,
	email nvarchar(30),
	accType int foreign key references accountType (id),
	active int foreign key references activeType (id)
)

create table activeType (
	id int primary key,
	describe nvarchar(30)
)
insert into activeType values (0, 'inactive');
insert into activeType values (1, 'active');

create table accountType (
	id int primary key,
	describe nvarchar(30)
)
insert into accountType values (0, 'user')
insert into accountType values (1, 'employees')

select * from users where accType not like 1

insert into users values ('#admin', '0833773901', '01/01/2001', '123', 15000000, 1, 'netpaycompanyvn@gmail.com', 1, 1)

insert into users values ('phuc', '0915692401', '05/05/2001', '123', 15000000, 1, 'phanbadaiphuc123@gmail.com', 0, 1);
select * from users where phone = '0915692401';

insert into users values ('kiet', '0918090705', '01/01/1963', '123', 15000000, 1, 'phantuankiet1010@gmail.com', 0, 1)
select * from users where phone = '0918090705'

create table history (
	usersname nvarchar(30),
	phone nvarchar(30) foreign key references users (phone),
	currDate date,
	act nvarchar(30),
	sender nvarchar(30),
	receiver nvarchar(30),
	amount nvarchar(30),
	phone2 nvarchar(30)
)

drop table history 
drop table users

delete from users where username = 'phuc2'
delete from history

select * from history

update users set accBalance = 15000000