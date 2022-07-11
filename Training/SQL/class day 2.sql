

select * from student;

insert into student values(3,'shri','karad',98565623523,84,'shri@mail.com');

alter table student add mailid varchar(30);

alter table student alter column smobile(bigint);

alter table student drop column email;

update student set mailid='sonu@mail.com' where rollno=3 ;

alter table student add constraint emailkey unique(mailid);

alter table student drop constraint emailkey;


alter table student add unique(email);

