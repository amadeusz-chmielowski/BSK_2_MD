Use BSK_2
go

create Table MacSec.Users
(
LoginName varchar(50),
ClearanceLevel varchar(50),
ClearanceLevelNumber int
)

--ClearanceLevelNumber:
--	0 - unclassified
--	1 - restricted
--	2 - confidential
--	3 - secret
--	4 - top secret

Insert into MacSec.Users Values('User1','Secret',3),('User2','Confidential',2),('User3','Restricted',1), ('User4','Unclassified',0)

