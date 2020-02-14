/*
Inserting forum names 
*/
INSERT INTO Forums(Name) VALUES('CS3220')
GO

INSERT INTO Forums(Name) VALUES('CS5661')
GO

INSERT INTO Forums(Name) VALUES('CS4540')
GO

INSERT INTO Forums(Name) VALUES('CS5112')
GO

/* inserting topic names */

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Midterm CS3220','Web Programming', '07/01/2019 13:15 PM','1')
GO

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Assignment CS3220','Web Programming', '07/05/2019 21:29 PM','1')
GO

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Project CS5661','Data Science', '07/12/2019 20:14 PM','2')
GO

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Homework CS5661','Data Science', '03/02/2019 13:48 PM','2')
GO

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Lab cs4540','C#', '06/05/2019 11:12 AM','3')
GO

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Homework CS4540','C#', '06/15/2019 23:59 PM','3')
GO

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Quiz CS5661','Algorithm', '06/15/2018  13:24 PM','4')
GO

INSERT INTO Topics(Subject,Content,time,ForumId) VALUES ('Presentation','Algorithm', '06/21/2019  13:30 PM','4')
GO
/* inserting replies */

INSERT INTO Replies(Rep, time, TopicId) VALUES ('when is the midterm?', '07/01/2019 14:02 PM', '1')
GO

INSERT INTO Replies(Rep, time, TopicId) VALUES ('what is the deadline for assignment?', '07/05/2019 21:45 PM', '2')
GO

INSERT INTO Replies(Rep, time, TopicId) VALUES ('topic of project?', '07/12/2019 20:17 PM', '3')
GO

INSERT INTO Replies(Rep, time, TopicId) VALUES ('I am getting an error', '03/02/2019 14:02 PM', '4')
GO

INSERT INTO Replies(Rep, time, TopicId) VALUES ('what files do we need to upload?', '06/05/2019 14:03 PM', '5')
GO

INSERT INTO Replies(Rep, time, TopicId) VALUES ('Is server down?', '03/02/2019 14:02 PM', '6')
GO

INSERT INTO Replies(Rep, time, TopicId) VALUES ('how is the difficulty level of Quiz?', '06/16/2019 10:02 AM', '7')
GO

INSERT INTO Replies(Rep, time, TopicId) VALUES ('I want to know the grading Policy', '06/21/2019 17:07 PM', '8')
GO
