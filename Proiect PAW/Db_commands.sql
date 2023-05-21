-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema DbOrar
-- -----------------------------------------------------
-- Baza de date proiect PAW

-- -----------------------------------------------------
-- Schema DbOrar
--
-- Baza de date proiect PAW
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `DbOrar` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE `DbOrar` ;

-- -----------------------------------------------------
-- Table `DbOrar`.`Profesori`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DbOrar`.`Profesori` (
  `ID_Profesor` INT NOT NULL,
  `Nume` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Profesor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DbOrar`.`Profesori_Discipline`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DbOrar`.`Profesori_Discipline` (
  `ID_Profesori_Discipline` INT NOT NULL,
  `FK_ID_Disciplina` INT NOT NULL,
  `FK_ID_Profesor` INT NOT NULL,
  PRIMARY KEY (`ID_Profesori_Discipline`),
  INDEX `FK_ID_Disciplina_idx` (`FK_ID_Disciplina` ASC) VISIBLE,
  INDEX `FK_ID_Profesor_idx` (`FK_ID_Profesor` ASC) VISIBLE,
  CONSTRAINT `FK_ID_Disciplina`
    FOREIGN KEY (`FK_ID_Disciplina`)
    REFERENCES `DbOrar`.`Discipline` (`ID_Disciplina`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ID_Profesor`
    FOREIGN KEY (`FK_ID_Profesor`)
    REFERENCES `DbOrar`.`Profesori` (`ID_Profesor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DbOrar`.`Discipline`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DbOrar`.`Discipline` (
  `ID_Disciplina` INT NOT NULL,
  `Nr_credite` INT NOT NULL,
  `An_studiu` INT NOT NULL,
  `Denumire` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Disciplina`),
  CONSTRAINT `FK_ID_Disciplina`
    FOREIGN KEY (`ID_Disciplina`)
    REFERENCES `DbOrar`.`Profesori_Discipline` (`ID_Profesori_Discipline`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DbOrar`.`Sali`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DbOrar`.`Sali` (
  `ID_Sala` INT NOT NULL,
  `Cladire` VARCHAR(45) NOT NULL,
  `Cod_Sala` VARCHAR(45) NOT NULL,
  `Nr_Locuri` INT NOT NULL,
  PRIMARY KEY (`ID_Sala`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DbOrar`.`Serii`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DbOrar`.`Serii` (
  `ID_Serie` INT NOT NULL,
  `An_studiu` INT NOT NULL,
  `Nr_grupe` INT NOT NULL,
  PRIMARY KEY (`ID_Serie`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DbOrar`.`Grupe`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DbOrar`.`Grupe` (
  `ID_Grupa` INT NOT NULL,
  `FK_ID_Serie` INT NOT NULL,
  PRIMARY KEY (`ID_Grupa`),
  INDEX `FK_ID_Serie_idx` (`FK_ID_Serie` ASC) VISIBLE,
  CONSTRAINT `FK_ID_Serie`
    FOREIGN KEY (`FK_ID_Serie`)
    REFERENCES `DbOrar`.`Serii` (`ID_Serie`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DbOrar`.`Activitati`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DbOrar`.`Activitati` (
  `ID_Activitate` INT NOT NULL,
  `FK_ID_Serie` INT NULL,
  `FK_ID_Grupa` INT NULL,
  `FK_ID_Disciplina` INT NOT NULL,
  `FK_ID_Profesor` INT NOT NULL,
  `FK_ID_Sala` INT NOT NULL,
  `Zi` VARCHAR(45) NOT NULL,
  `Interval` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID_Activitate`),
  INDEX `FK_ID_Disciplina_idx` (`FK_ID_Disciplina` ASC) VISIBLE,
  INDEX `FK_ID_Profesor_idx` (`FK_ID_Profesor` ASC) VISIBLE,
  INDEX `FK_ID_Sala_idx` (`FK_ID_Sala` ASC) VISIBLE,
  INDEX `FK_ID_SERIE_idx` (`FK_ID_Serie` ASC) VISIBLE,
  INDEX `FK_ID_Grupa_idx` (`FK_ID_Grupa` ASC) VISIBLE,
  CONSTRAINT `FK_ID_Disciplina`
    FOREIGN KEY (`FK_ID_Disciplina`)
    REFERENCES `DbOrar`.`Discipline` (`ID_Disciplina`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ID_Profesor`
    FOREIGN KEY (`FK_ID_Profesor`)
    REFERENCES `DbOrar`.`Profesori` (`ID_Profesor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ID_Sala`
    FOREIGN KEY (`FK_ID_Sala`)
    REFERENCES `DbOrar`.`Sali` (`ID_Sala`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ID_Serie`
    FOREIGN KEY (`FK_ID_Serie`)
    REFERENCES `DbOrar`.`Serii` (`ID_Serie`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ID_Grupa`
    FOREIGN KEY (`FK_ID_Grupa`)
    REFERENCES `DbOrar`.`Grupe` (`ID_Grupa`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
