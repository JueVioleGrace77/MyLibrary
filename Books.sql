USE[BOOKS]
DROP TABLE [Books]
DROP TABLE [LOGIN]
DROP SEQUENCE LoginId_Seq
DROP SEQUENCE BookId_Seq
USE[BOOKS]
CREATE TABLE [Books] (
	[BookId]	[int] IDENTITY(1,1)  NOT NULL,
    [BookTitle]       NVARCHAR (50)  NULL,
    [Author]          NVARCHAR (50)  NULL,
    [ISBN]            NVARCHAR (13)  NULL,
    [Genre]           NVARCHAR (50)  NULL,
    [NumberOfPage]    NVARCHAR (MAX) NULL,
    [LandedToAFriend] NVARCHAR (50)  NULL,
    [NameOfFriend]    NVARCHAR (50)  NULL,
    [Comment]         NVARCHAR (MAX) NULL)


CREATE SEQUENCE BookId_Seq
AS INT
START WITH 1
INCREMENT BY 1

GO
SET IDENTITY_INSERT [Books] ON
INSERT INTO [Books] ([BookID], [BookTitle], [Author], [ISBN], [Genre], [NumberOfPage], [LandedToAFriend], [NameOfFriend],[Comment] )
VALUES(NEXT VALUE FOR BookId_Seq, 'Against The Gods', 'MARS', '9859604938539', 'Action', '34', 'Yes', 'Lance', 'This Light novel is epic' )
INSERT INTO [Books] ([BookID], [BookTitle], [Author], [ISBN], [Genre], [NumberOfPage], [LandedToAFriend], [NameOfFriend],[Comment] )
VALUES(NEXT VALUE FOR BookId_Seq, 'Tower Of Gods', 'MARS', '9859604938540', 'Action', '56', 'Yes', 'Lance', 'The main character is too majestic' )
INSERT INTO [Books] ([BookID], [BookTitle], [Author], [ISBN], [Genre], [NumberOfPage], [LandedToAFriend], [NameOfFriend],[Comment] )
VALUES(NEXT VALUE FOR BookId_Seq, 'Moonlit Series', 'MARS', '9859604938541', 'Drama', '78', 'Yes', 'Konnor', 'No Comment' )
INSERT INTO [Books] ([BookID], [BookTitle], [Author], [ISBN], [Genre], [NumberOfPage], [LandedToAFriend], [NameOfFriend],[Comment] )
VALUES(NEXT VALUE FOR BookId_Seq, 'Fate Stay Night', 'MARS', '9859604938542', 'Action', '89', 'Yes', 'Alexzander', 'Character creation is superb' )
INSERT INTO [Books] ([BookID], [BookTitle], [Author], [ISBN], [Genre], [NumberOfPage], [LandedToAFriend], [NameOfFriend],[Comment] )
VALUES(NEXT VALUE FOR BookId_Seq, 'Fate Zero', 'MARS', '9859604938543', 'Fantasy', '95', 'Yes', 'Konnor', 'Series plot is excellent' )
SET IDENTITY_INSERT [Books] OFF

DROP PROCEDURE [UpdateBookDetails]


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [UpdateBookDetails]
(
  @ID Int,
  @NewGenre NVARCHAR (50),
  @NewNumberOfPage NVARCHAR (MAX),
  @NewNameOfFriend NVARCHAR (50),
  @NewComment NVARCHAR (MAX)
)
AS 
UPDATE Books
SET Genre = @NewGenre, NumberOfPage = @NewNumberOfPage, NameOfFriend = @NewNameOfFriend, Comment = @NewComment
WHERE BookId = @ID;
GO

CREATE TABLE [LOGIN] (
	[LoginID] [int] IDENTITY(1,1)  NOT NULL,
	[userName] varchar (50) NULL,
	[password] varchar (50)
)


CREATE SEQUENCE LoginId_Seq
AS INT
START WITH 1
INCREMENT BY 1

GO
SET IDENTITY_INSERT [LOGIN] ON
INSERT INTO [LOGIN] ([LoginID], [userName], [password])
VALUES (NEXT VALUE FOR LoginId_Seq, 'Admin', 'password')
SET IDENTITY_INSERT [LOGIN] OFF
