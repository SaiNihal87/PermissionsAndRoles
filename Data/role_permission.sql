DROP TABLE IF EXISTS "role_permisson";

CREATE TABLE "role_permission"
(
    role_id INT8 REFERENCES role(id) ON UPDATE NO ACTION ON DELETE NO ACTION,
    permission_id INT REFERENCES permission(id) ON UPDATE NO ACTION ON DELETE NO ACTION
);