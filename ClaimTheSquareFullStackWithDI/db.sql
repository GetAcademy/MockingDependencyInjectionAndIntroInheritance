/* CRUD */

/*
  Create - legge til nye data
*/

INSERT INTO TextObject VALUES (5, 'Fem','yellow','red')

/*
  Read   - lese data
*/
SELECT [Index], Text, ForeColor, BackColor 
FROM TextObject

/*
  Update - endre data
*/
UPDATE TextObject
SET ForeColor = 'gray'
WHERE [Index] = 5

/*
  Delete - slette data
*/
DELETE FROM TextObject
WHERE [Index] = 5