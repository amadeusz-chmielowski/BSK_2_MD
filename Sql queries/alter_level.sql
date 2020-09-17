Use BSK_2
go

UPDATE MacSec.Users
      SET ClearanceLevel = 'Secret'
	  where LoginName = 'User2';

UPDATE MacSec.Users
      SET ClearanceLevelNumber = 3
	  where LoginName = 'User2';