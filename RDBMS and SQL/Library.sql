CREATE DATABASE	libraryDb

USE libraryDb


CREATE TABLE Publishers (
publisher_id INT PRIMARY KEY IDENTITY(1,1),
publisher_name INT NOT NULL,
publisher_address varchar(100),
publisher_contact BIGINT
)

CREATE TABLE Books(
book_id INT PRIMARY KEY IDENTITY(100,1),
book_name VARCHAR(50) NOT NULL,
book_price FLOAT CHECK(book_price > 0),
publisher int FOREIGN KEY REFERENCES Publishers(publisher_id)
)

CREATE TABLE Readers(
reader_id INT PRIMARY KEY IDENTITY(1000,1),
reader_name VARCHAR(20) NOT NULL,
reader_contact VARCHAR(255) NOT NULL,
)