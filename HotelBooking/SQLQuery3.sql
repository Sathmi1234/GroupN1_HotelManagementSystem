CREATE TABLE customerDetails(
   customerId INT IDENTITY(1,1),
   customerName VARCHAR(250) NOT NULL, 
   customerEmail VARCHAR(250),
   customerPhone VARCHAR(25) NOT NULL,
   customerIdentityNo VARCHAR(25) NOT NULL,
   PRIMARY KEY(customerId)
   );