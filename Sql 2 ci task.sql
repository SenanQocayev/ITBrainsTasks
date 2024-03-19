 create database Employee
 use Employee
  
  create table Department(
  Id int primary key identity(1,1),
  Name nvarchar (50) not null
  
  )
  Insert into Department
  Values
  ('Meneger'),
  ('Airsaid Operator')


  select*from Department

  create table Employee
  (
  Id int primary key identity(1,1),
   Name nvarchar (50),
   DepartmentId int not null,
   foreign key (DepartmentId) references Department(Id),
   SalarieId int unique not null,
   foreign key (SalarieId) references Salaries(Id)
   
   );
   insert into Employee
   Values
   ('Senan',1)


   select*from Employee
   drop table Employee

    create table Salaries
  (
  Id int primary key identity(1,1),
  amout float not null,
  effective date not null
   );
   Insert into Salaries
   Values
   (1000,'2024-05-02')
   select* from Salaries

   select sum (amout) as 'cemi' from Salaries

   select count (amout) as 'sayi' from Salaries

   select max (amout) as 'en boyuk' from Salaries

   select min (amout) as 'en kicik' from Salaries

   select avg (amout) as 'ededi orta' from Salaries























