DROP TABLE IF EXISTS "role";

CREATE TABLE "role"
(
    "id" SERIAL8 PRIMARY KEY,
    "name" VARCHAR(255) NOT NULL,
    "display_label" VARCHAR(255) NOT NULL,
    "status" INT4 DEFAULT 1
);