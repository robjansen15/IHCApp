ALTER PROCEDURE [dbo].[ForgotPassword]
	@USERNAME varchar(25)
AS
	select Admin_Password, Admin_Email from Admin 
	where Admin_Username = @USERNAME
RETURN 0



ALTER PROCEDURE [dbo].[Active_Applicants]
AS
	select count(*) as CNT from Applicant_Form
	where IsActive = 1
RETURN 0

go

ALTER PROCEDURE [dbo].[Active_Hosts]
AS
	select count(*)  as CNT from Family
	where IsActive = 1
RETURN 0

go

ALTER PROCEDURE [dbo].[Total_Applicants]
AS
	select count(*) as CNT from Applicant_Form 
RETURN 0






