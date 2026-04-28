
-- 1. Pay Slip
create table Employees
(
   empid int primary key,
   ename varchar(15),
   erole varchar(20),
   salary int
)

insert into employees values
(1,'Praveen', 'Software engineer', 50000),
(2,'Rajesh', 'HR', 60000),
(3, 'Karthick', 'Analyst', 45000),
(4, 'Vimal', 'Tester', 40000)

select * from Employees

create or alter proc sp_Payslip @empid int
as
begin
 declare @empname varchar(15),
 @role varchar(20), @salary int,
 @hra decimal(10,2), @da decimal(10,2),
 @pf decimal(10,2), @it decimal(10,2),
 @deduction decimal(10,2), @grossSalary decimal(10,2),
 @netsalary decimal(10,2)

 select @empname = ename, @role = erole, @salary = salary
 from Employees where empid = @empid

 set @hra = @salary*0.10
 set @da = @salary*0.20
 set @pf = @salary*0.08
 set @it = @salary*0.05

 set @deduction = @pf + @it
 set @grossSalary = @salary + @hra + @da
 set @netsalary = @grossSalary - @deduction

 select
  
  @empid as Empid,
  @empname as Name,
  @role as Role,
  @salary as Basicsalary,
  @hra as HRA,
  @da as DA,
  @grossSalary as GrossSalary,
  @pf as PF,
  @it as IT,
  @deduction as Deductions,
  @netsalary as Netsalary
end

exec sp_Payslip 2


--2. Trigger

create table HolidayDetails
(
   Holiday_name varchar(20),
   HOliday_date date
)

Insert into HolidayDetails values
('New year', '2026-01-01'),
('Pongal', '2026-01-15'),
('Independence Day', '2026-08-15'),
('Diwali', '2026-11-08')

select * from HolidayDetails

create or alter trigger trg_NotChange
on employees
for insert, update, delete
as
begin

   declare @todaydate date = '2026-01-01'
   declare @holiday_name varchar(20)

   select @holiday_name = Holiday_name
   from HolidayDetails
   where holiday_date = @todaydate

   if (@todaydate in (select holiday_date from holidaydetails))
   begin
     Print 'Due to ' + @holiday_name + ' You cant manipulate data'
     rollback transaction 
   end
end

insert into Employees values
(9, 'Naveen', 'se', 45000)

select * from Employees