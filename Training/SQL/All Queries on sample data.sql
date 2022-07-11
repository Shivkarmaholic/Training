
select distinct department_id from employees;

select COUNT(distinct country_id) from locations;


select * from employees where job_id=5;

select * from employees where job_id<=5;

select * from employees where job_id >=5;

select * from employees where job_id!=5;

select *from employees where job_id between 3 and 5;


select * from locations where country_id in ('us','uk');

select * from employees where first_name like 'a%';    -- for multiple characters

select * from employees where first_name like 'a_a_'; -- for single character

select * from employees where department_id=6 and manager_id=103;

select * from employees where department_id=6 or manager_id=103;

select * from employees where department_id not in (2,3,4,9,10);

select * from employees where not department_id=1;

select * from employees where job_id=9 or job_id=5 and department_id=5 ;

select * from employees order by first_name ;


select * from employees order by first_name desc ;

insert into employees (first_name, last_name,email,hire_date,job_id,salary) values ('mahesh','suresh','om@mail.com','2021-05-21',7,50000);

select * from employees where job_id =7;

select * from employees where department_id is null;

select * from employees where department_id is not null;

update employees set first_name='bharat' where employee_id=101;

select * from employees where first_name='bharat';

begin try

begin transaction
update employees set first_name='bharat' where employee_id=101 and department_id=7;

select * from employees where first_name='bharat';

commit transaction

end try
begin catch

rollback transaction

end catch



create table trainer(
tid int primary key identity(0,2),
tname varchar(25),
experience int
)

insert into trainer(tname,experience) values ('mahesh',25),('shambhu',18),('shivam',22);

select * from trainer;

select department_id,MAX(salary) from employees group by department_id;

select department_id,Min(salary) from employees group by department_id;

select SUM(salary) from employees;

select department_id,AVG(salary) from employees group by department_id;

select department_id,count(*)as TotalEmployees from employees group by department_id;

select first_name from employees where department_id=(select department_id from departments where department_name='it');

select first_name,department_name from employees e inner join departments d on d.department_id=e.department_id;

--select first_name from employees inner join ();

select * from employees e left join departments d on d.department_id=e.department_id;

select * from employees e right join departments d on d.department_id=e.department_id;



select GETDATE();   ---- time stamp
select CURRENT_TIMESTAMP;   --- timestamp
select CURRENT_USER;   ---dbo(user)
select DAY(GETDATE());    -----7
select DATENAME(M,getdate());  --- 7(july)
select DATENAME(D,getdate());     ---7 th
select DATENAME(YEAR,getdate());  --- 2022
select DATENAME(DW,getdate()); -- thrusday
select DATENAME(WEEKDAY,getdate());-- thrusday

select DATEDIFF(YEAR,'1997-5-03',GETDATE());  --- year difference

select DATEDIFF(MONTH,'2013-3-14',GETDATE());   ---- month difference

select DATEDIFF(DAY,'2013-3-14',GETDATE());   --- days difference   

select month(hire_date) from employees;

select CONCAT('Mr.',first_name,'-',last_name) from employees;

select UPPER(first_name),LEN(first_name) from employees;

select first_name, LEN(TRIM(first_name)) from employees;

select SUBSTRING(first_name,1,3)from employees;

select ASCII('a');

select CHAR(72);

select REPLICATE ('ram',3);

------------------------------------------------------------------------------------------------------------------------------------------

select first_name,salary,salary+2000 as SalaryBonus from employees;

select * from employees e1 group by department_id where salary>=(select avg(salary) as sal from employees e2); ----error

select * from employees e1 where salary >= (select AVG(salary) from employees e2 where e2.department_id=e1.department_id);

select * from employees e1 where 5= (select COUNT (*)from (select distinct salary from employees)e2 where e2.salary=e1.salary);---- wrong ans


select employee_id,first_name from employees union
select department_id,department_name from departments

delete t1 from employees t1 inner join departments d1 on t1.department_id=d1.department_id where department_name='it';

select * from employees;

--------------------------------------------------------------------------------------------------------------------------------------

create index indxSalary on employees(salary);

create unique index indxManagerid on employees(email);

--------------------------------------------------------------------------------------------------------------------------------------























































