
CREATE TABLE students
  (
     studentid       INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     address         VARCHAR(100),
	 joindate		 DATETIME
  )


CREATE TABLE instructors
  (
     instructorid       INT PRIMARY KEY IDENTITY(1, 1),
     instructorname     VARCHAR(25),
     instructoremail    VARCHAR(25) UNIQUE,
     instructorphoneno  VARCHAR(13),
     address			VARCHAR(100),
	 joindate			DATETIME,
  )


  CREATE TABLE courses
  (
     courseid   INT PRIMARY KEY IDENTITY(1, 1),
     coursename VARCHAR(25),
     duration	VARCHAR(25),
  
  )
   CREATE TABLE lessons
  (
     lessonid      INT PRIMARY KEY IDENTITY(1, 1),
	 lessonno      INT,
	 courseid      INT,
	 instructorid  INT,
	 FOREIGN KEY(courseid) REFERENCES courses(courseid),
	 FOREIGN KEY(instructorid) REFERENCES instructors(instructorid)


  ) 

  CREATE TABLE enrollment
  (
     enrollmentid   INT PRIMARY KEY IDENTITY(1, 1),
     studentid      INT,
     courseid       INT,
	 startdate      DATETIME,
     enddate        DATETIME,
	 completed      BIT DEFAULT 0,
	 FOREIGN KEY(studentid) REFERENCES students(studentid),
	 FOREIGN KEY(courseid) REFERENCES courses(courseid),

  )
  CREATE TABLE progress
  (
     progressid		INT PRIMARY KEY IDENTITY(1, 1),
	 enrollmentid   INT,
     lessonid       INT,
     precentage		DECIMAL(3,2),
     FOREIGN KEY(enrollmentid) REFERENCES enrollment(enrollmentid),
     FOREIGN KEY(lessonid) REFERENCES lessons(lessonid),
  ) 
   CREATE TABLE quiz
  (
     quizid       INT PRIMARY KEY IDENTITY(1, 1),
     lessonid     INT,
     FOREIGN KEY(lessonid) REFERENCES lessons(lessonid),

  )
   CREATE TABLE completedquiz
  (

     completedquizid    INT PRIMARY KEY IDENTITY(1, 1),
	 quizid				INT,
	 studentid			INT,
	 score				DECIMAL(3,2),
     FOREIGN KEY(quizid) REFERENCES quiz(quizid),
	 FOREIGN KEY(studentid) REFERENCES students(studentid)

  )

   CREATE TABLE Assignments
  (
     Assignmentid    INT PRIMARY KEY IDENTITY(1, 1),
     lessonid        INT,
	 duedate		 DATETIME,
	 assignmenttype  VARCHAR(20),
     FOREIGN KEY(lessonid) REFERENCES lessons(lessonid),

  )
   CREATE TABLE completedassignments
  (

     completedassignmentid  INT PRIMARY KEY IDENTITY(1, 1),
	 assignmentid			INT,
	 studentid				INT,
	 submitteddate			DATETIME,
	 score					DECIMAL(10,2),
     FOREIGN KEY(assignmentid) REFERENCES assignments(assignmentid),
	 FOREIGN KEY(studentid) REFERENCES students(studentid)

  )
   CREATE TABLE peerreviewed
  (

     peerreviewedid         INT PRIMARY KEY IDENTITY(1, 1),
	 completedassignmentid  INT,
	 peerid					INT NOT NULL,
	 remarks				VARCHAR(100),
     FOREIGN KEY(completedassignmentid) REFERENCES completedassignments(completedassignmentid),
	 FOREIGN KEY(peerid) REFERENCES students(studentid)

  )
  CREATE TABLE instructorgraded
  (

     instructorgradedid    INT PRIMARY KEY IDENTITY(1, 1),
	 completedassignmentid INT,
	 instructorid          INT NOT NULL,
	 remarks			   VARCHAR(100),
     FOREIGN KEY(completedassignmentid) REFERENCES completedassignments(completedassignmentid),
	 FOREIGN KEY(instructorid) REFERENCES instructors(instructorid)

  )
  CREATE TABLE autograded
  (

     autogradedid          INT PRIMARY KEY IDENTITY(1, 1),
	 completedassignmentid INT,
	 remarks			   VARCHAR(100),
     FOREIGN KEY(completedassignmentid) REFERENCES completedassignments(completedassignmentid),
  )


 CREATE TABLE certificates
  (
     certificateid     INT PRIMARY KEY IDENTITY(1, 1),
	 certificatecode   VARCHAR(25),
	 enrollmentid      INT,
     FOREIGN KEY(enrollmentid) REFERENCES enrollment(enrollmentid),

  ) 
  


 
    
