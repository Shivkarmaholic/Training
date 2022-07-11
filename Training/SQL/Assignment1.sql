
create table Doctor(
did int primary key,
dname varchar(25),
daddress varchar(40),
dqualification varchar(15),
noofpatient_handled int,
)





create table Patient(
pcode int primary key,
pname varchar(25),
paddr varchar(40),
p_age int,
pgender varchar(10),
pbloodgroup varchar(5),
)


create table AdmittedPatient
(
Pcode int primary key,
Entry_date date,
Discharge_date date,
wardno int,
disease varchar(25),
did int,
)

alter table AdmittedPatient 
add constraint fkey2
foreign key(did)
references Doctor(did)

drop table Doctor

select * from doctor


create table bill(
BillNo int primary key,
Pcode int,
bill_amount int,
)

alter table bill 
add constraint fkey3                        
foreign key(pcode)
references patient(pcode)


create table book(
bid int primary key,
bname varchar(20),
bprice int,
bauthor varchar(30),
)


create table author(
authorid int primary keśy,     ś
authorname varchar(30)
)







