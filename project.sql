use project;

create table users (
	username nvarchar(30),
	name nvarchar(30),
	id nvarchar(30),
	dob date,
	pass nvarchar(30),
	addr nvarchar(30),
	accBalance bigInt,
)

insert into users values ('phuc', 'phuc', 1, '05/05/2001', '123', 'Can Tho', 15000000);

select * from users where username = 'phuc' and pass = '123';