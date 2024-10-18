
CREATE TABLE customers
  (
     customerid      INT PRIMARY KEY IDENTITY(1, 1),
     customername    VARCHAR(25),
     customeremail   VARCHAR(25) UNIQUE,
     customerphoneno VARCHAR(13),
     address         VARCHAR(100),
	 joindate		 DATETIME
  )
  CREATE TABLE premiumcustomers
  (	
	 premiumcustomers INT PRIMARY KEY IDENTITY(1, 1),
     customerid       INT,
     startdate        DATETIME,
     enddate          DATETIME,
 	 FOREIGN KEY(customerid) REFERENCES customers(customerid)
)


CREATE TABLE drivers
  (
     driverid       INT PRIMARY KEY IDENTITY(1, 1),
     drivername     VARCHAR(25),
     driveremail    VARCHAR(25) UNIQUE,
     driverphoneno  VARCHAR(13),
     address        VARCHAR(100),
	 joindate       DATETIME,
  )


  CREATE TABLE restaurants
  (
     restaurantid   INT PRIMARY KEY IDENTITY(1, 1),
     restaurentname VARCHAR(25),
     email			VARCHAR(25) UNIQUE,
     phoneno		VARCHAR(13),
     address        VARCHAR(100),
  )
   CREATE TABLE coupons
  (
     couponid       INT PRIMARY KEY IDENTITY(1, 1),
	 code           VARCHAR(20) UNIQUE,
	 discountamount DECIMAL(10,2),
	 minordervalue   DECIMAL(10,2),
	 startdate      DATETIME,
     enddate        DATETIME,
  ) 

  CREATE TABLE orders
  (
     orderid         INT PRIMARY KEY IDENTITY(1, 1),
     customerid      INT,
     driverid        INT,
	 couponid        INT,
	 totalprice      DECIMAL(10,2),
	 paymentmethod   VARCHAR(25),
	 status          VARCHAR(20),
	 FOREIGN KEY(couponid) REFERENCES coupons(couponid),
	 FOREIGN KEY(customerid) REFERENCES customers(customerid),
     FOREIGN KEY(driverid) REFERENCES drivers(driverid),

  )
  CREATE TABLE reviews
  (
     reviewid  INT PRIMARY KEY IDENTITY(1, 1),
	 orderid   INT,
     stars     INT,
     comments  TEXT,
     FOREIGN KEY(orderid) REFERENCES orders(orderid),
  ) 
   CREATE TABLE menu
  (
     menuid       INT PRIMARY KEY IDENTITY(1, 1),
     itemname     VARCHAR(25),
     vegornonveg  VARCHAR(25),
     restaurantid INT,
	 price        DECIMAL(10,2),
     FOREIGN KEY(restaurantid) REFERENCES restaurants(restaurantid)

  )
 CREATE TABLE customizations
  (
     customizationid     INT PRIMARY KEY IDENTITY(1, 1),
	 customizationname   VARCHAR(25),
	 additionalamount    DECIMAL(10, 2)	 

  ) 
  CREATE TABLE orderdetails
  (
     orderdetailsid    INT PRIMARY KEY IDENTITY(1, 1),
     orderid           INT,
	 menuid            INT,
     customizationid   INT,
	 quantity          INT,
     amount            DECIMAL(10, 2),
     FOREIGN KEY(menuid) REFERENCES menu(menuid),
     FOREIGN KEY(orderid) REFERENCES orders(orderid),
     FOREIGN KEY(customizationid) REFERENCES customizations(customizationid),
  )
   




  


 
    
