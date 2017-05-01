ALTER PROCEDURE [dbo].[ForgotPassword]
	@USERNAME varchar(25)
AS
	select Admin_Password, Admin_Email from Admin 
	where Admin_Username = @USERNAME
RETURN 0


select Admin_Password, Admin_Email from Admin 
where Admin_Username = 'Xiao'



