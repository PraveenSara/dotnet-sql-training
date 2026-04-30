create database Assessment

create table Book
(
   id             int          primary key,
   title          varchar(30),
   authour        varchar(20),
   isbn           bigint       unique,
   published_date date
)

alter table Book
alter column published_date datetime

insert into book values
(1, 'My first sql book', 'Mary Parker', 981483029127,'2012-02-22 12:08:17'),
(2, 'My second sql book', 'John Mayer', 857300923713,'1972-07-03 09:22:45'),
(3, 'My third sql book', 'Cary Flint', 523120967812,'2015-10-18 14:05:44')

select * from book

create table review
(
   id             int          primary key,
   bookid         int          references book(id),
   reviewer_name  varchar(20),
   content        varchar(100),
   rating         int,
   published_date datetime
)
alter table review
alter column published_date datetime

insert into review values
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10')


--customer table

create table customer
(
   id      int primary key,
   name    varchar(30),
   age     int,
   address varchar(50),
   salary  decimal(10,2)
)

insert into customer values
(1, 'Ramesh', 32, 'Ahmedabad',2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai',6500.00),
(5, 'Hardik', 27, 'Bhopal',8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore',10000.00)

-- orders table

create table orders
(
   oid int primary key,
   date datetime,
   customer_id int references customer(id),
   amount int
)

insert into orders values
(102, '2009-10-08 00:00:00',3, 3000),
(100, '2009-10-08 00:00:00',3, 1500),
(101, '2009-11-20 00:00:00',2, 1500),
(103, '2008-05-20 00:00:00',4, 2060)

--employee table

create table employee
(
   id      int primary key,
   name    varchar(30),
   age     int,
   address varchar(50),
   salary  decimal(10,2)
)

insert into employee values
(1, 'Ramesh', 32, 'Ahmedabad',2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai',6500.00),
(5, 'Hardik', 27, 'Bhopal',8500.00),
(6, 'Komal', 22, 'MP', null),
(7, 'Muffy', 24, 'Indore',null)

-- Studet details

create table studentdetails
(
    registerno int primary key,
    name varchar(50),
    age int,
    qualification varchar(20),
    mobileno varchar(15),
    mail_id varchar(50),
    location varchar(50),
    gender char(1)
);

insert into studentdetails values
(2,'Sai',22,'B.E','9952836777','Sai@gmail.com','Chennai','M'),
(3,'Kumar',20,'BSC','7890125648','Kumar@gmail.com','Madurai','M'),
(4,'Selvi',22,'B.Tech','8904567342','selvi@gmail.com','Selam','F'),
(5,'Nisha',25,'M.E','7834672310','Nisha@gmail.com','Theni','F'),
(6,'SaiSaran',21,'B.A','7890345678','saran@gmail.com','Madurai','F'),
(7,'Tom',23,'BCA','8901234675','Tom@gmail.com','Pune','M');

select * from employee

-- 1. Write a query to fetch the details of the books written by author whose name ends with er.

select * from book where authour like '%er'

-- 2.Display the Title ,Author and ReviewerName for all the books from the above table  

select b.title, b.authour, r.reviewer_name from book b left join review r on b.id = r.bookid

--3. Display the  reviewer name who reviewed more than one book. 

 select reviewer_name from review
 group by reviewer_name
 having count(bookid) > 1

 -- 4. Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address 

 select name, address from customer where address like '%o%'

 -- 5. Write a query to display the   Date,Total no of customer  placed order on same Date  

 select cast(date as date), count(customer_id) as 'Total orders' from orders
 group by date

 -- 6. Display the Names of the Employee in lower case, whose salary is null  

 select lower(name) as name from employee where salary is null 

 --7. Write a sql server query to display the Gender,Total no of male and female from the above relation

select gender, count(*) as total from studentdetails
group by gender