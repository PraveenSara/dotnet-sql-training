select * from emp

insert into emp values
(8005, 'John', 'Clerk', 7902, '2020-03-12', 1100, NULL, 10),
(8006, 'Kiran', 'Analyst', 7566, '2023-07-18', 2600, NULL, 20),
(8007, 'Meena', 'Manager', 7839, '2018-11-25', 3200, NULL, 30),
(8008, 'Arjun', 'Salesman', 7698, '2019-05-10', 1500, 300, 30),
(8009, 'Pooja', 'Clerk', 7902, '2016-05-22', 1200, NULL, 10),
(8010, 'Rahul', 'Analyst', 7566, '2021-09-14', 2800, NULL, 20);


-- 1. Write a query to display your birthday( day of week)

select datename(weekday, '06/08/2003') as MyBirthday, DOB = '06/08/2003'

-- 2. Write a query to display your age in days

select datediff(day, '06/08/2003', GETDATE()) as 'My Age in Days',
datediff(year, '06/08/2003', GETDATE()) as Age



-- 3. Write a query to display all employees information those who joined before 5 years in the current month

select * from emp
where hiredate <= dateadd(year, -5, getdate())
and month(hiredate) = month(getdate())



-- 4. 

begin transaction

-- a. insert 3 rows
insert into emp values
(9001, 'asha', 'clerk', 7902, '2021-05-10', 1000, null, 10),
(9002, 'vijay', 'analyst', 7566, '2020-05-15', 2000, null, 20),
(9003, 'neel', 'manager', 7839, '2019-05-20', 3000, null, 30)

select * from emp


save transaction after_insert;

-- b. update second row salary with 15% increment
update emp
set sal = sal + (sal * 15 / 100)
where empno = 9002


-- c. delete first row
delete from emp
where empno = 9001

select * from emp

-- d. rollback only delete 
rollback transaction after_insert
select * from emp

-- commit final changes
commit transaction



-- 5. Bonus for all employees
create or alter function calculate_bonus (@deptno int, @sal int)
returns float
as
begin
    declare @bonus float
    if @deptno = 10
        set @bonus = @sal * 0.15
    else if @deptno = 20
        set @bonus = @sal * 0.20
    else
        set @bonus = @sal * 0.05
    return @bonus
end
-- executing
select empno, ename, deptno, sal,
       dbo.calculate_bonus(deptno, sal) as bonus 
from emp


-- 6. SP for Update salary who are in sales and earn below 1500

create or alter proc SP_Update_Salary
as
begin
    update emp set sal = sal + 500
    where job = 'salesman' and sal < 1500

    select * from emp where job = 'salesman'
end

exec SP_Update_Salary