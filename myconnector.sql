
CREATE TABLE `farmer` (
  `Farmer_id` int NOT NULL AUTO_INCREMENT,
  `Farmer_Name` varchar(45) NOT NULL,
  `Email` varchar(200) NOT NULL,
  `Passwords` varchar(20) NOT NULL DEFAULT '123456',
  `Location` varchar(45) DEFAULT NULL,
  `Date_of_Birth` date DEFAULT NULL,
  `User_Type` varchar(45) DEFAULT 'User',
  `Gender` varchar(45) DEFAULT NULL,
  `phone` int DEFAULT NULL,
  `FarmName` varchar(100) DEFAULT NULL,
  `Livestock_No` bigint DEFAULT NULL,
  `Product` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Farmer_id`,`Email`),
  UNIQUE KEY `Farmer_id_UNIQUE` (`Farmer_id`),
  UNIQUE KEY `Email_UNIQUE` (`Email`),
  UNIQUE KEY `FarmName_UNIQUE` (`FarmName`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
