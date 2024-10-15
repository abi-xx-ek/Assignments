Uber



create table Address(Pincode int primary key,Street varchar(25),City varchar(25),StateName varchar(25),Country varchar(25))

create table Customer(CustomerId int primary key identity(1,1),CustomerName varchar(25),CustomerEmail varchar(25) unique,CustomerPhoneNo varchar(13),Pincode int,foreign key(Pincode) references AllAddress(pincode))

create table Driver(DriverId int primary key identity(1,1),DriverName varchar(25),DriverEmail varchar(25) unique,DriverPhoneNo varchar(13),Pincode int,foreign key(Pincode) references AllAddress(pincode))

create table RideDetails(RideId int primary key identity(1,1),CustomerId int,DriverId int,RideDateTime Datetime,Amount decimal(10,2),PaymentMethod varchar(25),foreign key(DriverId) references Driver(DriverId),foreign key(CustomerId) references Customer(CustomerId))

book my show


create table Address(Pincode int primary key,Street varchar(25),city varchar(25),StateName varchar(25),Country varchar(25))

create table Customers(CustomerId int primary key identity(1,1),CustomerName varchar(25),CustomerEmail varchar(25) unique,CustomerPhoneNo varchar(13),Pincode int,foreign key(Pincode) references Address(Pincode))

create table Theatres(TheatreId int primary key identity(1,1),TheatreName varchar(25),NumberOfScreens int,PhoneNo varchar(13),Pincode int,foreign key(Pincode) references Address(Pincode))

create table Movies(MovieId int primary key identity(1,1),MovieName varchar(25),DirectorName varchar(25),ProducerName varchar(25),ActorName varchar(25),Language varchar(25))


create table OrderDetails(CustomerId int,TheatreId int,MovieId int,OrderDateTime Datetime,ShowDateTime datetime,Amount decimal(10,2),PaymentMethod varchar(25),
foreign key(TheatreId) references theatres(TheatreId),foreign key(CustomerId) references Customer(CustomerId),foreign key(MovieId) references movies(MovieId));


amazon

create table Address(Pincode int primary key,Street varchar(25),City varchar(25),StateName varchar(25),Country varchar(25))

create table Customers(CustomerId int primary key identity(1,1),CustomerName varchar(25),CustomerEmail varchar(25) unique,CustomerPhoneNo varchar(13),Pincode int,foreign key(Pincode) references Address(Pincode))

create table Sellers(SellerId int primary key identity(1,1),SellerName varchar(25),SellerEmail varchar(25) unique,SellerPhoneNo varchar(13))

create table Products(ProductId int primary key identity(1,1),ProductName varchar(25),Category varchar(25),Price decimal(10,2))

create table Orders(OrderId int primary key identity(1,1),CustomerId int,SellerId int,OrderDate date,EstimatedDelivery date,Amount decimal(10,2),PaymentMethod varchar(20),foreign key(CustomerId) references Customers(CustomerId),foreign key(SellerId) references sellers(SellerId))

create table OrderDetails(OrderDetailsId int primary key identity(1,1),OrderId int,ProductId int,Quantity int,foreign key(ProductId) references Products(ProductId),foreign key(OrderId) references Orders(OrderId))

create table Category(CategoryId int primary key identity(1,1),ProductId int,CategoryName varchar(25),foreign key(ProductId) references Products(ProductId))
