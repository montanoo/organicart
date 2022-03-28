-- integrantes: 
--	Fernando Josué Montano González. MG210111 | Andrea Guadalupe Velásquez Joyar. VJ210576 |
--  Ivania María Lebrón Flores. LF212591 | Luciana María Munguía Villacorta. MV210941 
--  Carlos Vicente Castillo Sayes. CS210003

USE master
GO

CREATE DATABASE Organicart
GO

USE Organicart
GO

CREATE TABLE [user] (
    id int IDENTITY(1,1) NOT NULL,
    username varchar(255) UNIQUE NOT NULL,
    [role_id] int NOT NULL DEFAULT (0), -- default 0: user, 1: admin.
    password varchar(255) NOT NULL,

    CONSTRAINT PK_user_id PRIMARY KEY (id),
    CONSTRAINT CHK_password CHECK(DATALENGTH([password]) >= 8),
    CONSTRAINT UNQ_username UNIQUE (username)
)

CREATE TABLE client (
    id int IDENTITY (1,1) NOT NULL, -- pk
    [user_id] int NOT NULL, -- fk
    dui varchar(10) NOT NULL, -- unique
    [name] varchar(255) NOT NULL,
    lastname varchar(255) NOT NULL,
    email varchar(255), -- unique.
    phone int,
    photo image,

    CONSTRAINT PK_client_id PRIMARY KEY (id),
    CONSTRAINT UNQ_email UNIQUE (email),
    CONSTRAINT UNQ_dui UNIQUE (dui)
)

CREATE TABLE products (
    id int IDENTITY (1,1) NOT NULL, -- pk
    [name] varchar(255),
    photo image,
    category_id int,
    price float,

    CONSTRAINT PK_products_id PRIMARY KEY (id)
)

CREATE TABLE inventory (
    id int IDENTITY (1,1) NOT NULL, -- pk
    product_id int,
    stock int,
    store_id int,

    CONSTRAINT PK_inventory_id PRIMARY KEY (id)
)

CREATE TABLE client_address (
    id int IDENTITY (1,1) NOT NULL, --pk,
    [client_id] int,
    [address] varchar(MAX),

    CONSTRAINT PK_client_address_id PRIMARY KEY (id)
)

CREATE TABLE billing (
    id int IDENTITY (1,1) NOT NULL,
    [client_id] int,
    [date] date,
    [product_id] int,
    [address_id] int,
    quantity int,
    [store_id] int,

    CONSTRAINT PK_billing PRIMARY KEY (id)
)

CREATE TABLE stores (
    id int IDENTITY(1,1) NOT NULL,
    [name] varchar(255),
    [store_address] varchar(MAX),

    CONSTRAINT PK_stores PRIMARY KEY (id)
)

CREATE TABLE categories (
    id int IDENTITY(1,1) NOT NULL,
    [type] varchar(255),
    [description] varchar (MAX),

    CONSTRAINT PK_categories PRIMARY KEY (id)
) 

ALTER TABLE client
ADD CONSTRAINT FK_clientuser_id FOREIGN KEY ([user_id]) REFERENCES [user](id)
ON DELETE CASCADE
ON UPDATE CASCADE 
GO

ALTER TABLE [products]
ADD CONSTRAINT FK_products_category_id FOREIGN KEY ([category_id]) REFERENCES categories([id])
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE [inventory]
ADD CONSTRAINT FK_inventory_product_id FOREIGN KEY ([product_id]) REFERENCES products([id])
ON DELETE CASCADE
ON UPDATE CASCADE 
GO

ALTER TABLE [inventory]
ADD CONSTRAINT FK_inventory_store_id FOREIGN KEY ([store_id]) REFERENCES stores([id])
GO

ALTER TABLE [billing]
ADD CONSTRAINT FK_billing_client_id FOREIGN KEY ([client_id]) REFERENCES client(id)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE [billing]
ADD CONSTRAINT FK_billing_product_id FOREIGN KEY ([product_id]) REFERENCES products(id)
GO

ALTER TABLE [billing]
ADD CONSTRAINT FK_billing_store_id FOREIGN KEY ([store_id]) REFERENCES stores(id)
GO

ALTER TABLE [client_address]
ADD CONSTRAINT FK_client_address_id FOREIGN KEY ([client_id]) REFERENCES client(id)
GO

INSERT INTO [user] VALUES 
	('admin', 1, 'password')
GO
INSERT INTO [user] (username, password) VALUES 
	('MG210111', 'password')
GO