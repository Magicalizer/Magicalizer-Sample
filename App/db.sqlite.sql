BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Products" (
	"Id"	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	"CategoryId"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	"Price"	REAL NOT NULL,
	"Created"	TEXT NOT NULL,
	FOREIGN KEY("CategoryId") REFERENCES "Categories"("Id")
);
CREATE TABLE IF NOT EXISTS "Categories" (
	"Id"	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	"Name"	TEXT NOT NULL
);
INSERT INTO "Products" VALUES (1,5,'Margarita',100.0,'2020-05-01');
INSERT INTO "Products" VALUES (2,5,'Napoletana',125.0,'2020-05-01');
INSERT INTO "Products" VALUES (3,5,'Pepperoni',150.0,'2020-05-01');
INSERT INTO "Products" VALUES (4,5,'Hawaiian',150.0,'2020-05-01');
INSERT INTO "Products" VALUES (5,5,'Bavarian',175.0,'2020-05-01');
INSERT INTO "Products" VALUES (6,5,'Toscana',150.0,'2020-05-01');
INSERT INTO "Products" VALUES (7,5,'4 seasons',200.0,'2020-05-01');
INSERT INTO "Categories" VALUES (1,'Soups');
INSERT INTO "Categories" VALUES (2,'Starters');
INSERT INTO "Categories" VALUES (3,'Salads');
INSERT INTO "Categories" VALUES (4,'Main dishes');
INSERT INTO "Categories" VALUES (5,'Pizza');
INSERT INTO "Categories" VALUES (6,'Burgers');
INSERT INTO "Categories" VALUES (7,'Desserts');
COMMIT;
