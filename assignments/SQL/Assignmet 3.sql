select * from emp

-- 1. Manager list
select * from emp where job = 'Manager'

-- 2. Emp earning more than 1000
select ename, sal from emp where sal > 1000

-- 3. Emps except James
select ename, sal from emp where ename <> 'James'

-- 4. Name starts with S
select * from emp where ename like 's%'

-- 5. Name contains A in anywhere
select * from emp where ename like '%A%'

-- 6. Emp name with 3rd letter as L
select * from emp where ename like '__L%'

--7. Daily salary of Jones
select cast(sal/22 as decimal) as 'Daily sal' from emp where ename = 'Jones'

-- 8. Total monthly salary of all
select sum(sal) as  'total sal' from emp

-- 9. Average annual salary
select avg(sal)*12 as 'Average annual salary' from emp

-- 10. Emps except salesman from dept 30
select ename, job, sal, deptno from emp where job <> 'Salesman' and deptno = 30

-- 11. Unique dept from dept table
select distinct deptno from emp

-- 12. Emps earn more than 1500 and in dept 10 or 30
select ename as Name, sal as MonthlySalary, Deptno from emp where sal > 1500 and deptno = 30 or deptno = 10

-- 13. Manager or analyst and salary not equals to 1000, 3000, 5000
select ename, job, sal from emp 
where (job = 'Manager' or job = 'Analyst')
and (sal <> 3000 or sal <> 1000 or sal <> 5000)

--14. Commision is greater than salary inc by 10%
select ename, sal, comm from emp where
comm > (sal + (sal * 10/100))

-- 15. Emps have 2Ls in name and in dept 30 or manager 
select ename from emp where ename like '%ll%' and
(deptno = 30 or Mgr_Id = 7782)

-- 16. Emps experience between 30 and 40
select ename from emp where datediff(year, hiredate, getdate()) between 30 and 40

-- 17. Dept name in asc and Emp name in desc
select d.dname, e.ename from emp e join dept d on e.Deptno = d.Deptno
order by d.dname, e.ename desc

-- 18. Exp of Miller
select datediff(year, hiredate, getdate()) from emp where ename = 'Miller'


