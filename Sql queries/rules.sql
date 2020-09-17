Use BSK_2
go

--CREATE FUNCTION MacSec.fn_SecretClearance
--(
--@ClearanceLevel int
--)
-- RETURNS TABLE
--WITH SCHEMABINDING
--AS
-- RETURN SELECT 1 AS Acess_Result
-- from MacSec.Users
--WHERE LoginName=User_Name() and ClearanceLevelNumber >= @ClearanceLevel;
 
 
----create after the function is created
 
CREATE SECURITY POLICY MacSec.SensitiveData0
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.SZPITALE
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData1
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.ODDZIALY
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData2
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.SALE_ZABIEGOWE
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData3
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.KARETKI
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData4
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.CHOROBY
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData5
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.ZABIEGI
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData6
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.PACJENCI
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData7
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.POBYT
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData8
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.LEKARZE
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData9
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.BTPOBYT_LEKARZE
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData10
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.TRANSPORTY
WITH (STATE = ON);

CREATE SECURITY POLICY MacSec.SensitiveData11
ADD FILTER PREDICATE MacSec.fn_SecretClearance(ClearanceLevelNumber) ON dbo.RECEPTY
WITH (STATE = ON);

 
 
-----Allows for security policy to be turned off without dropping related objects
--Alter SECURITY POLICY MacSec.SensitiveData0
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData1
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData2
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData3
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData4
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData5
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData6
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData7
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData8
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData9
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData10
--WITH (State = OFF)

--Alter SECURITY POLICY MacSec.SensitiveData11
--WITH (State = OFF)