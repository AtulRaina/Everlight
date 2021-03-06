/****** Script for SelectTopNRows command from SSMS  ******/


---1.	Return all Case Events for a case with a Case number of ‘12446’.
  SELECT * FROM tbleCaseEvents AS tce
  INNER JOIN tblcase AS tc ON
  tc.CaseRef=tce.CaseRef
  WHERE
  tc.CaseNO='12446'

---2.	Return all cases raised between 1st January 2013 and the current DateTime

SELECT * FROM tblecase AS TC
INNER JOIN tbleCaseEvents AS TCE ON
TC.CaseRef=TCE.CaseRef
WHERE
TCE.STARTDATE BETWEEN '20130101' AND GETDATE()

--3.	Insert a new Case Type with any name you like into the Case Type table.

INSERT INTO [dbo].[tblCaseType]
           ([TCT_CaseTypeRef]
           ,[TCT_CTNAME]
           ,[TCT_Abbrevation]
           ,[TCT_Usage]
           ,[TCT_Obselete])
     VALUES
           ((SELECT ISNULL(MAX(TCT_CaseTypeRef) + 1, 1) FROM [dbo].[tblCaseType])
           ,'Test'
           ,'TEST'
           ,'Regular'
           ,0)

---	   4.	Update the Case Type of Case ‘12446’ to be that of your newly created Case Type. 

UPDATE tblCase
SET CaseTypeRef= (SELECT CaseTypeRef FROM tblCaseType WHERE name='Test')
WHERE caseno='12446'


-------------------------------

----	Write a query to return a list of the 10 most recent cases, with the name of their Case Type 
SELECT TOP 10 tc.*,tct.Name FROM tblCase as tc
INNER JOIN tblCaseType as tct on
tc.CaseTypeRef =tct.CaseTypeRef  
ORDER BY tc.ACTIVE DATE DESC


 

