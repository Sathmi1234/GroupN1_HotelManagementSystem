﻿CREATE TABLE user_table(
   user_id INT IDENTITY(1,1),
   user_name VARCHAR(20),
   password VARCHAR(30),
   user_role INT,
   PRIMARY KEY(user_id)


);