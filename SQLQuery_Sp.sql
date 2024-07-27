CREATE PROCEDURE spRetrieveInfo(
@username varchar(10),
@password varchar(30)
)
as
begin
  SELECT * FROM UserInfo
  WHERE UserName=@username and Password=@password
  end