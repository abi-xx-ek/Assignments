Uber

CREATE TABLE address
  (
     pincode   INT PRIMARY KEY,
     street    VARCHAR(25),
     city      VARCHAR(25),
     statename VARCHAR(25),
     country   VARCHAR(25)
  )

CREATE TABLE customer
  (
     customerid      INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     pincode         INT,
     FOREIGN KEY(pincode) REFERENCES alladdress(pincode)
  )

CREATE TABLE driver
  (
     driverid      INT PRIMARY KEY IDENTITY(1, 1),
     drivername    VARCHAR(25),
     driveremail   VARCHAR(25) UNIQUE,
     driverphoneno VARCHAR(13),
     pincode       INT,
     FOREIGN KEY(pincode) REFERENCES alladdress(pincode)
  )

CREATE TABLE ridedetails
  (
     rideid        INT PRIMARY KEY IDENTITY(1, 1),
     customerid    INT,
     driverid      INT,
     ridedatetime  DATETIME,
     amount        DECIMAL(10, 2),
     paymentmethod VARCHAR(25),
     FOREIGN KEY(driverid) REFERENCES driver(driverid),
     FOREIGN KEY(customerid) REFERENCES customer(customerid)
  ) 

-----------------------------------------------------------------------------------------------------------------
book my show


CREATE TABLE address
  (
     pincode   INT PRIMARY KEY,
     street    VARCHAR(25),
     city      VARCHAR(25),
     statename VARCHAR(25),
     country   VARCHAR(25)
  )

CREATE TABLE customers
  (
     customerid      INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     pincode         INT,
     FOREIGN KEY(pincode) REFERENCES address(pincode)
  )

CREATE TABLE theatres
  (
     theatreid       INT PRIMARY KEY IDENTITY(1, 1),
     theatrename     VARCHAR(25),
     numberofscreens INT,
     phoneno         VARCHAR(13),
     pincode         INT,
     FOREIGN KEY(pincode) REFERENCES address(pincode)
  )

CREATE TABLE movies
  (
     movieid      INT PRIMARY KEY IDENTITY(1, 1),
     moviename    VARCHAR(25),
     directorname VARCHAR(25),
     producername VARCHAR(25),
     actorname    VARCHAR(25),
     language     VARCHAR(25)
  )

CREATE TABLE orderdetails
  (
     customerid    INT,
     theatreid     INT,
     movieid       INT,
     orderdatetime DATETIME,
     showdatetime  DATETIME,
     amount        DECIMAL(10, 2),
     paymentmethod VARCHAR(25),
     FOREIGN KEY(theatreid) REFERENCES theatres(theatreid),
     FOREIGN KEY(customerid) REFERENCES customer(customerid),
     FOREIGN KEY(movieid) REFERENCES movies(movieid)
  ); 
------------------------------------------------------------------------------------------------------------------------
amazon

CREATE TABLE address
  (
     pincode   INT PRIMARY KEY,
     street    VARCHAR(25),
     city      VARCHAR(25),
     statename VARCHAR(25),
     country   VARCHAR(25)
  )

CREATE TABLE customers
  (
     customerid      INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     pincode         INT,
     FOREIGN KEY(pincode) REFERENCES address(pincode)
  )

CREATE TABLE sellers
  (
     sellerid      INT PRIMARY KEY IDENTITY(1, 1),
     sellername    VARCHAR(25),
     selleremail   VARCHAR(25) UNIQUE,
     sellerphoneno VARCHAR(13)
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
     estimateddelivery DATE,
     amount            DECIMAL(10, 2),
     paymentmethod     VARCHAR(20),
     FOREIGN KEY(customerid) REFERENCES customers(customerid),
     FOREIGN KEY(sellerid) REFERENCES sellers(sellerid)
  )

CREATE TABLE orderdetails
  (
     orderdetailsid INT PRIMARY KEY IDENTITY(1, 1),
     orderid        INT,
     productid      INT,
     quantity       INT,
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