﻿create database pharmacy

create table users(
id int identity(1,1) primary key,
userRole varchar(50) not null,
name varchar(250) not null,
dob varchar(250) not null,
mobile bigint not null,
email varchar(250) not null,
username varchar(250) unique not null,
pass varchar(250) not null

)

userRole, name, dob, mobile, email, username, pass

select * from users


ADD CONSTRAINT constraint_name UNİQUE (username);

create table medic(
id int identity(1,1) primary key,
mid varchar(250) not null,
mname varchar(250) not null,
mnumber varchar(250) not null,
mDate varchar(250) not null,
eDate varchar(250) not null,
quantity bigint not null,
perUnit bigint not null
);
select mname from medic where eDate >= getDate() and quantity >'0'
mid,mname,mnumber,mDate,eDate,quantity,perUnit

select * from medic

select * from medic where eDate <= '4/13/2022';

select * from medic where eDate >= '10/15/2020'

select * from medic where eDate >= getDate()