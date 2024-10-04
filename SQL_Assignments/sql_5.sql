uber



create table all_address(pincode int primary key,street varchar(25),city varchar(25),state_name varchar(25),country varchar(25))

create table Customers(Customer_id int primary key,Customer_name varchar(25),Customer_email varchar(25) unique,customer_phone_no varchar(13),pincode int,foreign key(pincode) references all_address(pincode))

create table Drivers(Driver_id int primary key,driver_name varchar(25),Driver_email varchar(25) unique,driver_phone_no varchar(13),pincode int,foreign key(pincode) references all_address(pincode))

create table ride_details(Customer_id int,Driver_id int,Ride_date_time Datetime,amount int,payment_method varchar(25),foreign key(Driver_id) references Drivers(Driver_id),foreign key(Customer_id) references Customers(Customer_id))


book my show


create table all_address(pincode int primary key,street varchar(25),city varchar(25),state_name varchar(25),country varchar(25))

create table Customers(Customer_id int primary key,Customer_name varchar(25),Customer_email varchar(25) unique,customer_phone_no varchar(13),pincode int,foreign key(pincode) references all_address(pincode))

create table Theatre(theatre_name varchar(25),number_of_screens int,phone_no varchar(13),pincode int,foreign key(pincode) references all_address(pincode),primary key(theatre_name,pincode))

create table movies(movie_name varchar(25),director_name varchar(25),producer_name varchar(25),Actor_name varchar(25),language_name varchar(25),primary key(movie_name,director_name))


create table order_details(Customer_id int,theatre_name varchar(25),pincode int,movie_name varchar(25),director_name varchar(25),order_date_time Datetime,show_date_time datetime,amount int,payment_method varchar(25),
foreign key(theatre_name,pincode) references theatre(theatre_name,pincode),foreign key(Customer_id) references Customers(Customer_id),foreign key(movie_name,director_name) references movies(movie_name,director_name));



amazon

create table all_address(pincode int primary key,street varchar(25),city varchar(25),state_name varchar(25),country varchar(25))

create table Customers(Customer_id int primary key,Customer_name varchar(25),Customer_email varchar(25) unique,customer_phone_no varchar(13),pincode int,foreign key(pincode) references all_address(pincode))

create table sellers(Seller_id int primary key,seller_name varchar(25),seller_email varchar(25) unique,seller_phone_no varchar(13))

create table products(product_id int primary key,product_name varchar(25),category varchar(25),price int)

create table orders(order_id int primary key,customer_id int,seller_id int,product_id int,foreign key(customer_id) references customers(customer_id),foreign key(seller_id) references sellers(seller_id))

create table orderdetails(order_id int,order_date date,ship_date date,estimated_delivery date,quantity int,amount int,payment_method varchar(20),foreign key(order_id) references orders(order_id))


