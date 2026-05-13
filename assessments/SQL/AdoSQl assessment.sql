create database Employeemanagement

create table employee_details
(
    empno int primary key,
    empname varchar(50) not null,
    empsal numeric(10,2) check (empsal >= 25000),
    emptype char(1) check (emptype in ('f','p'))
)

drop table Employee_Details

----------------------------------------------------------------------------------
--1.  stored procedure

create or alter proc sp_insertEmployees (@empname varchar(50),@empsal numeric(10,2), @emptype char(1))
as 
begin
	declare @newempno int

    select @newempno = isnull(max(empno),0) + 1
    from employee_details

    insert into employee_details (empno, empname,empsal,emptype)
    values
    (
        @newempno,@empname, @empsal, @emptype
    )
end

-- test sp

exec sp_insertEmployees 'Rajesh', 67000, 'f'
select * from Employee_Details
delete from Employee_Details where empname = 'praveen'

-----------------------------------------------------------------
-- 2. sp for update salary

create or alter proc sp_updatesalary(@empid int, @updatedsalary numeric(10,2) output)
as
begin
    update employee_details
    set empsal = empsal + 100
    where empno = @empid

    select @updatedsalary = empsal
    from employee_details
    where empno = @empid
end

declare @sal numeric(10,2)

-- executing

exec sp_updatesalary @empid = 1, @updatedsalary = @sal output

select * from employee_details


