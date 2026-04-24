-- Department Table

create table Dept
(
   Deptno int         primary key,
   Dname  varchar(15),
   Loc    varchar(15)
)

Insert into dept values
(10, 'Accounting', 'New York'),
(20, 'Research', 'Dallas'),
(30, 'Sales', 'Chicago'),
(40, 'Operations', 'Boston')

select * from Dept

-- Employee table

create table Emp
(
   Empno    int         primary key,
   Ename    varchar(15) not null,
   Job      varchar(15),
   Mgr_Id   int,
   Hiredate date,
   Sal      int,
   Comm     int,
   Deptno   int          references dept(deptno)
)

Insert into emp values
(7369, 'Smith', 'Clerk', 7902, '17-Dec-80', 800, NULL, 20),
(7499, 'Allen', 'Salesman', 7698, '20-Feb-81', 1600, 300, 30),
(7521, 'Ward', 'Salesman', 7698, '22-Feb-81', 1250, 500, 30),
(7566, 'Jones', 'Manager', 7839, '02-Apr-81', 2975, NULL, 20),
(7654, 'Martin', 'Salesman', 7698, '28-Sep-81', 1250, 1400, 30),
(7698, 'Blake', 'Manager', 7839, '01-May-81', 2850, NULL, 30),
(7782, 'Clark', 'Manager', 7839, '09-Jun-81', 2450, NULL, 10),
(7788, 'Scott', 'Analyst', 7566, '19-Apr-87', 3000, NULL, 20),
(7839, 'King', 'President',NULL, '17-Nov-81', 5000, NULL, 10),
(7844, 'Turner', 'Salesman', 7698, '08-Sep-81', 1500, 0, 30),
(7876, 'Adams', 'Clerk', 7788, '23-May-87', 1100, NULL, 20),
(7900, 'James', 'Clerk', 7698, '03-Dec-81',  950, NULL, 30),
(7902, 'Ford', 'Analyst', 7566, '03-Dec-81', 3000, NULL, 20),
(7934, 'Miller', 'Clerk', 7782, '23-Jan-82', 1300, NULL, 10)

select * from emp

-- 1. Employee name starts with A

select * from emp where ename like 'A%'

-- 2. Employee not have manager

select * from emp where mgr_id is null

--3. Salary between 1200 - 1400

select empno, ename, sal from emp where sal between 1200 and 1400

-- 4. 

select e.empno, e.ename, e.job, e.sal as 'Before salary', (e.sal + (e.sal * 10/100)) as 'After salary', d.dname
from emp e join dept d on e.Deptno = d.Deptno
where Dname = 'Research'

-- 5.

select count(*) as 'Number of Clerk' from emp where job = 'clerk'

-- 6.

select Job, avg(sal) as 'average salary', count(empno) as 'No of emp' from emp
group by job

-- 7. 

select * from emp
where sal = (select min(sal) from emp) or sal = (Select max(sal) from emp)

-- 8. 

select * from Dept d
where not exists( select null from emp e where e.Deptno = d.Deptno)

-- 9.

select ename, sal from emp
where job = 'Analyst' and sal > 1200 and Deptno = 20
order by ename

-- 10.

select d.deptno, d.dname, sum(e.sal) as total_salary
from dept d
join emp e on d.deptno = e.deptno
group by d.deptno, d.dname

-- 11.

select ename, sal from emp
where ename in ('MILLER', 'SMITH')

-- 12.

select ename from emp
where ename like 'A%' or ename like 'M%'

-- 13.

select ename, sal * 12 as 'Annual salary' from emp where ename = 'smith'

-- 14.

select ename, sal from emp where sal not between 1500 and 2850

-- 15.

select mgr_id, count(*) as num_employees from emp
where mgr_id is not null
group by mgr_id
having count(*) > 2

