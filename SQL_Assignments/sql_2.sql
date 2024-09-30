Create a table students and insert names in malayalam

    create table employee(empid int primary key,empname nvarchar(20))
    insert into employee values(1,N'അഭിഷേക്')

Retrieve all employees who work in Sales, Marketing, or IT departments.


    select Firstname,lastname from emp where Department in('IT','managment','sales')


Find all employees with salaries ranging from $50,000 to $75,000 (inclusive).


    select firstname,lastname from emp where Salary between 50000 and 75000


List all employees whose last name begins with the letter 'S'.

    select firstname,lastname from emp where lastname like 's%'

Display all employees with exactly five letters in their first name.

    select firstname,lastname from emp where lastname like '_____'

Find employees whose last name starts with either 'B', 'R', or 'S'.

    select firstname,lastname from emp where lastname like 'B%' or lastname like 'S%' or lastname like 'R%'

Retrieve all employees whose first name begins with any letter from 'A' through 'M'.

    select firstname,lastname from emp where firstname like '[a-m]%'

List employees whose last name doesnt start with a vowel (A, E, I, O, U).

    select firstname,lastname from emp where lastname not like 'a%' and lastname not like 'e%' and lastname not like 'i%' and lastname not like 'o%' and lastname not like 'u%'



Identify employees earning more than $80,000 annually. 

    select firstname,lastname from emp where Salary>80000


Find employees who joined the company before 2020. 

    select firstname,lastname from emp where HireDate<'01-01-2020'

 List all employees not named 'John' (first name).

    select firstname,lastname from emp where FirstName not like 'john'
Identify Marketing department employees earning $60,000 or less who were hired after June 30, 2019.

    select firstname,lastname from emp  where Department ='marketing' and Salary <70000 and HireDate> '06-30-2019'

Find employees whose first name contains the letters 'an' anywhere and ends with 'e'.

    select firstname,lastname from emp  where FirstName like '%an%e'








CREATE TABLE Sales (
    SaleID INT PRIMARY KEY,
    ProductID INT,
    CustomerID INT,
    SaleDate DATE,
    Quantity INT,
    UnitPrice DECIMAL(10, 2)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50)
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    City VARCHAR(50),
    State VARCHAR(2)
);






    insert into customers values(1000,'Abhishek','Trivandrum','kerala')


Calculate the total sales amount for each product. Display the ProductID and total sales amount.

    select productid,sum(quantity*unitprice) as total_sales from totalsales group by productid


Find the average quantity sold per sale for each product category.


    select p.category,avg(quantity) as average from products p,totalsales s where p.productid =s.productid group by p.category

List the top 5 customers by their total purchase amount. Include the CustomerID and total purchase amount.

    select customerid,(quantity*unitprice) as total_purchase from sales order by (quantity*unitprice) desc offset 0  rows fetch next 5 rows only

Determine the number of sales made each month in the year 2023. Display the month and the count of sales.
    
    select month(saledate) as monthofsale,count(quantity) as total_sales from sales where year(saledate)=2024 group by month(saledate)


Calculate the total revenue for each state, but only for states with more than $10,000 in total sales.

    select sum(quantity*unitprice)as sales,state from totalsales s,customers c where s.customerid=c.customerid group by state having sum(quantity*unitprice)>10000



Find products that have been sold more than 100 times in total. Display the ProductID, ProductName, and the total quantity sold.

    select p.productname,p.productid,sum(quantity) as total_quantity from products p,totalsales s where s.productid=p.productid group by p.productid,p.productname having sum(quantity)>100



For each customer, find the date of their first purchase and the date of their most recent purchase.

    select c.customerid,c.customername ,min(saledate) as firstpurchase,max(saledate) as lastpurchase from customers c,totalsales s where s.customerid=c.customerid group by c.customerid,c.customername



Find the customers who have made purchases on at least 5 different dates. Display the CustomerID and the count of distinct purchase dates.

    select c.customerid,count(distinct s.saledate) as dates from customers c,totalsales s where c.customerid=s.customerid group by c.customerid having count(distinct s.saledate) >5

