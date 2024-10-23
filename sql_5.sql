Uber

CREATE TABLE customer
  (
     customerid      INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     address         VARCHAR(100),
  )

CREATE TABLE driver
  (
     driverid       INT PRIMARY KEY IDENTITY(1, 1),
     drivername     VARCHAR(25),
     driveremail    VARCHAR(25) UNIQUE,
     driverphoneno  VARCHAR(13),
     address         VARCHAR(100),
	 RegistrationNo VARCHAR(25),
     FOREIGN KEY(RegistrationNo) REFERENCES car(RegistrationNo),
  )

CREATE TABLE ridedetails
  (
     rideid         INT PRIMARY KEY IDENTITY(1, 1),
     customerid     INT,
     driverid       INT,
	 startlocation  VARCHAR(50),
	 endlocation    VARCHAR(50),
     startdatetime  DATETIME,
	 enddatetime    DATETIME,
     amount         DECIMAL(10, 2),
     paymentmethod  VARCHAR(25),
	 review         INT,
     FOREIGN KEY(driverid) REFERENCES driver(driverid),
     FOREIGN KEY(customerid) REFERENCES customer(customerid)
  ) 
CREATE TABLE car
  (
     RegistrationNo VARCHAR(25) PRIMARY KEY,
     CarType        VARCHAR(25),
     FuelType       VARCHAR(25),
     SeatCapacity   INT,
  )


-----------------------------------------------------------------------------------------------------------------
book my show

CREATE TABLE customers
  (
     customerid      INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     address         VARCHAR(100),
  )
CREATE TABLE movies
  (
     movieid      INT PRIMARY KEY IDENTITY(1, 1),
     moviename    VARCHAR(25),
     directorname VARCHAR(25),
     producername VARCHAR(25),
     actorname    VARCHAR(25),
  )
CREATE TABLE theatres
  (
     theatreid       INT PRIMARY KEY IDENTITY(1, 1),
     theatrename     VARCHAR(25),
     numberofscreens INT,
     phoneno         VARCHAR(13),
     address         VARCHAR(100),
  )
  CREATE TABLE screens
  (
	 screenid  INT PRIMARY KEY IDENTITY(1, 1),
	 theatreid INT,
	 screenno  INT,
	 capacity  INT,	 
     FOREIGN KEY(theatreid) REFERENCES theatres(theatreid),
  )
  CREATE TABLE shows
  (
	 showid  INT PRIMARY KEY IDENTITY(1, 1),
	 screenid INT,
	 movieid  INT,
	 time	DATETIME,	 
     FOREIGN KEY(screenid) REFERENCES screens(screenid),
     FOREIGN KEY(movieid) REFERENCES movies(movieid)
  )

  
CREATE TABLE language
  (	 
	 languageid  INT PRIMARY KEY IDENTITY(1, 1),
	 language	 VARCHAR(25)	
  )

CREATE TABLE movielanguage
  (
	 movielanguageid  INT PRIMARY KEY IDENTITY(1, 1),
	 languageid		  INT,
	 movieid		  INT,
     FOREIGN KEY(languageid) REFERENCES language(languageid),
     FOREIGN KEY(movieid) REFERENCES movies(movieid)
  )
     


CREATE TABLE orderdetails
  (
	 orderdetailsid INT PRIMARY KEY IDENTITY(1, 1),
     customerid     INT,
     theatreid      INT,
     movieid        INT,
     orderdatetime  DATETIME,
     showdatetime   DATETIME,
     amount         DECIMAL(10, 2),
     paymentmethod  VARCHAR(25),
     FOREIGN KEY(theatreid) REFERENCES theatres(theatreid),
     FOREIGN KEY(customerid) REFERENCES customers(customerid),
     FOREIGN KEY(movieid) REFERENCES movies(movieid)
  ) 

  CREATE TABLE seats
  (
	 seatid         INT PRIMARY KEY IDENTITY(1, 1),
	 screenid		INT,
	 seatnumber		INT,
	 isavailable   BIT DEFAULT 1,
	 price			DECIMAL(10, 2),
     FOREIGN KEY(screenid) REFERENCES screens(screenid),
  )

  CREATE TABLE bookedseats
  (
	 bookedseatsid  INT PRIMARY KEY IDENTITY(1, 1),
	 seatid		    INT,
	 orderdetailsid INT,
     FOREIGN KEY(seatid) REFERENCES seats(seatid),
     FOREIGN KEY(orderdetailsid) REFERENCES orderdetails(orderdetailsid)
  )

  
------------------------------------------------------------------------------------------------------------------------
amazon


CREATE TABLE customers
  (
     customerid      INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     address         VARCHAR(100),
  )

CREATE TABLE sellers
  (
     sellerid      INT PRIMARY KEY IDENTITY(1, 1),
     sellername    VARCHAR(25),
     selleremail   VARCHAR(25) UNIQUE,
     sellerphoneno VARCHAR(13),
     address         VARCHAR(100),
  )

CREATE TABLE products
  (
     productid   INT PRIMARY KEY IDENTITY(1, 1),
     productname VARCHAR(25),
     category    VARCHAR(25),
     price       DECIMAL(10, 2)
  )

CREATE TABLE orders
  (
     orderid           INT PRIMARY KEY IDENTITY(1, 1),
     customerid        INT,
     sellerid          INT,
     orderdate         DATE,
	 paymentmethod  VARCHAR(20),
     FOREIGN KEY(customerid) REFERENCES customers(customerid),
     FOREIGN KEY(sellerid) REFERENCES sellers(sellerid)
  )

CREATE TABLE orderdetails
  (
     orderdetailsid INT PRIMARY KEY IDENTITY(1, 1),
     orderid        INT,
     productid      INT,
     quantity       INT,
	 orderstatus	VARCHAR(20),
	 amount         DECIMAL(10, 2),
	 estimateddelivery DATE,
     FOREIGN KEY(productid) REFERENCES products(productid),
     FOREIGN KEY(orderid) REFERENCES orders(orderid)
  )

CREATE TABLE category
  (
     categoryid   INT PRIMARY KEY IDENTITY(1, 1),
     productid    INT,
     categoryname VARCHAR(25),
     FOREIGN KEY(productid) REFERENCES products(productid)
  ) 