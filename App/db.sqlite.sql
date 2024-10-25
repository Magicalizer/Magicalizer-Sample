BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Categories" (
	"Id"	INTEGER UNIQUE,
	"Name"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Products" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"CategoryId"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	"Price"	REAL NOT NULL,
	"Created"	TEXT NOT NULL,
	FOREIGN KEY("CategoryId") REFERENCES "Categories"("Id"),
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Photos" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"ProductId"	INTEGER,
	"Filename"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
INSERT INTO "Categories" ("Id","Name") VALUES (1,'Soups');
INSERT INTO "Categories" ("Id","Name") VALUES (2,'Starters');
INSERT INTO "Categories" ("Id","Name") VALUES (3,'Salads');
INSERT INTO "Categories" ("Id","Name") VALUES (4,'Main dishes');
INSERT INTO "Categories" ("Id","Name") VALUES (5,'Pizza');
INSERT INTO "Categories" ("Id","Name") VALUES (6,'Burgers');
INSERT INTO "Categories" ("Id","Name") VALUES (7,'Desserts');
INSERT INTO "Products" ("Id","CategoryId","Name","Price","Created") VALUES (1,5,'Margarita',100.0,'2020-05-01');
INSERT INTO "Products" ("Id","CategoryId","Name","Price","Created") VALUES (2,5,'Napoletana',125.0,'2020-05-01');
INSERT INTO "Products" ("Id","CategoryId","Name","Price","Created") VALUES (3,5,'Pepperoni',150.0,'2020-05-01');
INSERT INTO "Products" ("Id","CategoryId","Name","Price","Created") VALUES (4,5,'Hawaiian',150.0,'2020-05-01');
INSERT INTO "Products" ("Id","CategoryId","Name","Price","Created") VALUES (5,5,'Bavarian',175.0,'2020-05-01');
INSERT INTO "Products" ("Id","CategoryId","Name","Price","Created") VALUES (6,5,'Toscana',150.0,'2020-05-01');
INSERT INTO "Products" ("Id","CategoryId","Name","Price","Created") VALUES (7,5,'4 seasons',200.0,'2020-05-01');
INSERT INTO "Photos" ("Id","ProductId","Filename") VALUES (1,3,'Photo1.jpg');
INSERT INTO "Photos" ("Id","ProductId","Filename") VALUES (2,3,'Photo2.jpg');
INSERT INTO "Photos" ("Id","ProductId","Filename") VALUES (3,3,'Photo3.jpg');
COMMIT;
