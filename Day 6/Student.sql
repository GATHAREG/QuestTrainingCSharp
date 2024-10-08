use myDb;

CREATE TABLE STUDENTS(
 ID INT PRIMARY KEY IDENTITY(1,1),
 NAME VARCHAR(100) NOT NULL,
 EMAIL VARCHAR(50) UNIQUE NOT NULL,
 CLASS INT NOT NULL DEFAULT 1
 )
 ----insert into students---
 INSERT INTO STUDENTS (NAME, EMAIL, CLASS)
VALUES 
('Alice Johnson', 'alice.johnson@example.com', 3),
('Bob Smith', 'bob.smith@example.com', 2),
('Charlie Davis', 'charlie.davis@example.com', 4),
('Diana Green', 'diana.green@example.com', 1),
('Ethan Moore', 'ethan.moore@example.com', 5),
('Fiona White', 'fiona.white@example.com', 2),
('George Brown', 'george.brown@example.com', 3),
('Hannah Lee', 'hannah.lee@example.com', 4);
---usage of where clause----
select id,name,class from students where email ='george.brown@example.com';
select id,name from students where id in(1,5);
----order by----
select id, name ,class from students order by name asc;
select id, name ,class from students order by name desc;

select id,name as full_name ,class as grade from students;
----group by and having clause -----
select class,count(id) as count_of_students from students group by class;
select class,count(id) as count_of_students from students group by class having count(id)<2;
----top 5 listing and avoiding first 5 and fetching next 5----
select top 5 id,name ,class from students;

select id,name,class from students 
     order by id
     offset 5 rows
     fetch next 3 rows only;
select len('hello');
select  name,len(name) as length_of_name from students;
----aggregate functions------
select count(id) as total_students from STUDENTS;
select sum(class) as total_students from STUDENTS;
select min(class) from students;
select max(class) from STUDENTS;
select avg(class) from students;