DROP TABLE IF EXISTs "permission";

CREATE TABLE "permission"
(
    id INT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    display_label VARCHAR(255) NOT NULL,
    status INT4 DEFAULT 1,
    module_name VARCHAR(255)
);