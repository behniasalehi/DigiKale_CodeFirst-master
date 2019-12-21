use digikala
go
CREATE PROCEDURE dbo.usp_Create_Person_Table
    
AS
begin tran 

begin try 
 IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Person') AND type in (N'U'))
		begin
			create table Person
				(	
					PersonId int not null identity(1,1) primary key,
					Title nvarchar(20) not null,
					Surname nvarchar(20) not null , 
					Age nvarchar(2) ,
					Address nvarchar(150) not null,
					Phone nvarchar(11) not null,
					CONSTRAINT CHK_Person CHECK ( Phone like '09[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
				)
		end
		print'Successful'
  commit tran 
  end try 
  begin catch  
  print 'Error'
rollback tran 
end catch 
 exec dbo.usp_Create_Person_Table