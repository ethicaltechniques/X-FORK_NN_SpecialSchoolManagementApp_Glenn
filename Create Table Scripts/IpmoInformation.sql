<!-- 1) Create Table for storing all Field Data -->
create table IpmoInformation(Id int primary key identity, FieldName varchar(max), FieldValue varchar(max), StudentUniqueId varchar(max) NOT NULL)
alter table IpmoInformation add FormName nvarchar(max)