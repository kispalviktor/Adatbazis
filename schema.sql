DROP DATABASE IF EXISTS `orvosirendelo`;
CREATE DATABASE IF NOT EXISTS `orvosirendelo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `orvosirendelo`;

CREATE TABLE ORVOS (
    orvos_id    INT AUTO_INCREMENT PRIMARY KEY,
    nev         VARCHAR(100) NOT NULL,
    szakterulet VARCHAR(100),
    telefonszam VARCHAR(20),
    email       VARCHAR(100)
);

CREATE TABLE BETEG (
    beteg_id        INT AUTO_INCREMENT PRIMARY KEY,
    nev             VARCHAR(100) NOT NULL,
    szuletesi_datum DATE,
    taj_szam        CHAR(9) UNIQUE,
    telefonszam     VARCHAR(20),
    email           VARCHAR(100)
);

CREATE TABLE IDOPONT (
    idopont_id    INT AUTO_INCREMENT PRIMARY KEY,
    orvos_id      INT NOT NULL,
    beteg_id      INT NOT NULL,
    idopont_datum DATETIME NOT NULL,
    statusz       VARCHAR(20) DEFAULT 'foglalt',
    megjegyzes    TEXT,
    FOREIGN KEY (orvos_id) REFERENCES ORVOS(orvos_id),
    FOREIGN KEY (beteg_id) REFERENCES BETEG(beteg_id)
);