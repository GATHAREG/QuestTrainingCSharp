USE NewDb;

-- account fields in the accounts table
CREATE TABLE accounts (
    id INT PRIMARY KEY IDENTITY(100,1),
    account_number INT UNIQUE,
    name VARCHAR(50) NOT NULL,
    date_of_birth DATE,
    address VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20),
    email VARCHAR(50) NOT NULL UNIQUE,
    account_type VARCHAR(50) NOT NULL, --Savings, Checking
    balance DECIMAL(18,2) DEFAULT 0
);

-- Transactions table 
CREATE TABLE Transactions (
    id INT PRIMARY KEY IDENTITY(200,1),
    from_account_id INT,
    to_account_id INT, 
    amount DECIMAL(18,2),
    transaction_date DATETIME DEFAULT GETDATE(),
    transaction_type VARCHAR(50),
    CONSTRAINT fk_to_account_id FOREIGN KEY (to_account_id) REFERENCES accounts(id),
    CONSTRAINT fk_from_account_id FOREIGN KEY (from_account_id) REFERENCES accounts(id)
);
-- Insert 10 records into accounts table
INSERT INTO accounts (account_number, name, date_of_birth, address, phone_number, email, account_type, balance)
VALUES
(3456, 'Gatha', '1990-01-01', '123 Street, City', '1234567890', 'gatha@example.com', 'Savings', 10000.00),
(5678, 'Geethu', '1992-02-02', '456 Street, City', '0987654321', 'geethu@example.com', 'Savings', 2000.00),
(7890, 'Mohan', '1988-03-03', '789 Street, City', '1231231234', 'mohan@example.com', 'Checking', 1500.00),
(9012, 'Manu', '1995-04-04', '101 Street, City', '9876543210', 'manu@example.com', 'Savings', 500.00),
(1123, 'Sachin', '1987-05-05', '102 Street, City', '9876509876', 'sachin@example.com', 'Checking', 3000.00),
(1234, 'Sneha', '1990-06-06', '103 Street, City', '1230987654', 'sneha@example.com', 'Savings', 4000.00),
(2345, 'Nina', '1989-07-07', '104 Street, City', '3216549870', 'nina@example.com', 'Savings', 25000.00),
(3457, 'Vishal', '1993-08-08', '105 Street, City', '7654321098', 'vishal@example.com', 'Checking', 1200.00),
(4567, 'Priya', '1994-09-09', '106 Street, City', '5647382910', 'priya@example.com', 'Savings', 18000.00),
(5679, 'Rahul', '1991-10-10', '107 Street, City', '9988776655', 'rahul@example.com', 'Checking', 2200.00);
select * from accounts;

----questions---
---create an account--
insert into accounts(account_number, name, date_of_birth, address, phone_number, email, account_type, balance)
values(9999,'pourna','2001-10-06','pournika','9895589702','pourna@gmail.com','checking',80000.00)

---delete an account---

delete from accounts where account_number = 2345;

---update an account---
update accounts set account_type ='savings' where account_number = 1123;

---deposit an amount---
update accounts set balance = balance + 500 where id = 100;
insert into transactions(from_account_id, to_account_id, amount, transaction_type)
values(null,100,500,'deposit');
select id, account_number, name,balance from accounts where id = 100;

----withdraw an amount---
update accounts set balance = balance - 1000 where id =101;
insert into transactions(from_account_id, to_account_id, amount, transaction_type)
values(null,101,1000,'withdraw');
select account_number, name,balance from accounts where id = 101;

-- Insert 1 transfer into the transactions table--
INSERT INTO transactions (from_account_id, to_account_id, amount, transaction_type)
VALUES
(104,105 , 1000.00, 'Transfer')
update accounts set 
balance = balance -1000 where id = 104;
update accounts set balance = balance + 1000 where id = 105;

---view history---

select Transactions.id as transaction_id,
       Transactions.from_account_id ,
	   Transactions.to_account_id,
	   Transactions.amount,
	   Transactions.transaction_type,
	   Transactions.transaction_date,
	   accounts.name as customer_name,
	   accounts.balance
	   from Transactions left join accounts on accounts.id = Transactions.to_account_id order by Transactions.transaction_date desc;