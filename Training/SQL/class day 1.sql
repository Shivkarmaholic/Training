create table student(
rollno tinyint primary key,
sname varchar(15) not null,
scity varchar(20) default 'Pune',
smobile bigint unique,
marks int check(marks>0)
);

select * from student;

insert into student(rollno,sname,smobile,marks) values(2,'Mahesh',95956856565,15);


insert into student(rollno,sname,smobile) values(5,'Sonu',9475142323);


update student set smobile=1122337755 where sname='sonu';


delete from student where rollno=3;