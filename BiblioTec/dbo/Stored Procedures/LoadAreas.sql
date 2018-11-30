CREATE PROCEDURE [dbo].[LoadAreas]
AS
BEGIN
SELECT a.id AS 'ID'
,a.area AS 'AREA'
FROM dbo.Areas AS a
END