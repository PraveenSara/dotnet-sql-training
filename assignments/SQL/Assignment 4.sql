create database Assignment_4

-- 1. Factorial

declare @num int = 7
declare @fact bigint = 1

while @num > 0
begin
 set @fact = @fact * @num
 set @num = @num - 1
end

print 'Factorial = ' + cast(@fact as varchar)

-- 2. Multiplication Table

create or alter proc sp_multipletable (@num int, @limit int)
as
begin
 declare @n int = 1

 while @n <= @limit
 begin
  print cast(@num as varchar) + ' X ' + cast(@n as varchar) + ' = ' + cast(@num * @n as varchar)
  set @n = @n + 1;
 end
end

exec sp_multipletable 5,10

-- 3. Function for check pass/fail


-- Student table
create table Student
(
   sid   int primary key,
   sname varchar(15)
)


Insert into Student values
(1,'Jack'),
(2,'Rithvik'),
(3,'Jaspreeth'),
(4,'Praveen'),
(5,'Bisa'),
(6,'Suraj')

select * from Student


-- Marks table
create table Marks
(
   mid   int primary key,
   sid   int references Student(sid),
   score int
)

Insert into marks values
(1, 1, 23),
(2, 6, 95),
(3, 4, 98),
(4, 2, 17),
(5, 3, 53),
(6, 5, 13)

select * from marks


-- function for predict
create or alter function fn_CheckPass (@mark int)
returns varchar(10)
as
begin
  declare @result varchar(10)

  if (@mark >= 50)
    set @result = 'Pass'
  else
    set @result = 'Fail'

  return @result
end

select s.sid, s.sname, m.score, dbo.fn_CheckPass(m.score) as result
from Student s join Marks m on s.sid = m.sid
order by s.sid