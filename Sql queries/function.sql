Use BSK_2
go

CREATE FUNCTION MacSec.fn_SecretClearance
(
@ClearanceLevel int
)
 RETURNS TABLE
WITH SCHEMABINDING
AS
 RETURN SELECT 1 AS Acess_Result
 from MacSec.Users
WHERE LoginName=User_Name() and ClearanceLevelNumber >= @ClearanceLevel;