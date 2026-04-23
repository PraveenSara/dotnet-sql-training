create database Assignment

-- 1. Clients Table

create table clients (
  Client_id   int          primary key,
  Cname       varchar(40)  not null,
  Address     varchar(30),  
  Email       varchar(30)  unique,
  Phone       int, 
  Business    varchar(20)  not null
)

alter table clients alter column phone bigint

Insert into clients values
(1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', 9567880032, 'Manufacturing'),
(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090, 'Consultant'),
(1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886655, 'Reseller'),
(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional')

select * from clients