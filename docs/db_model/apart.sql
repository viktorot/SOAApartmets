SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`apartment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`apartment` (
  `idapartment` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NULL,
  `description` VARCHAR(255) NULL,
  `latitude` FLOAT(10,6) NULL,
  `longitude` FLOAT(10,6) NULL,
  `pet_friendly` TINYINT(1) NULL,
  `no_king_beds` INT NULL,
  `no_single_beds` INT NULL,
  `no_extra_beds` INT NULL,
  `internet` TINYINT(1) NULL,
  `air_conditioning` TINYINT(1) NULL,
  `tv` TINYINT(1) NULL,
  `kitchen` TINYINT(1) NULL,
  `class_stars` INT NULL,
  `balcony` TINYINT(1) NULL,
  `accessible` TINYINT(1) NULL,
  PRIMARY KEY (`idapartment`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`customer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`customer` (
  `idcustomer` INT NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(45) NULL,
  `last_name` VARCHAR(45) NULL,
  `email` VARCHAR(90) NULL,
  `address` VARCHAR(255) NULL,
  `pass` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`idcustomer`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`comments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`comments` (
  `idcomments` INT NOT NULL AUTO_INCREMENT,
  `comment` VARCHAR(255) NULL,
  `grade` INT NOT NULL,
  `apartment_idapartment` INT NOT NULL,
  `customer_idcustomer` INT NOT NULL,
  PRIMARY KEY (`idcomments`),
  INDEX `fk_comments_apartment_idx` (`apartment_idapartment` ASC),
  INDEX `fk_comments_customer1_idx` (`customer_idcustomer` ASC),
  CONSTRAINT `fk_comments_apartment`
    FOREIGN KEY (`apartment_idapartment`)
    REFERENCES `mydb`.`apartment` (`idapartment`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_comments_customer1`
    FOREIGN KEY (`customer_idcustomer`)
    REFERENCES `mydb`.`customer` (`idcustomer`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`payment_method`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`payment_method` (
  `idpayment_method` INT NOT NULL AUTO_INCREMENT,
  `card_number` VARCHAR(45) NULL,
  `bank_payment` TINYINT(1) NULL,
  PRIMARY KEY (`idpayment_method`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`arrangement_package`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`arrangement_package` (
  `idarrangement_package` INT NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(45) NULL,
  `description` VARCHAR(45) NULL,
  `max_resevations` VARCHAR(45) NULL,
  `valid_from` INT NULL,
  `valid_to` INT NULL,
  `price` FLOAT NULL,
  PRIMARY KEY (`idarrangement_package`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`discounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`discounts` (
  `iddiscounts` INT NOT NULL AUTO_INCREMENT,
  `code` VARCHAR(255) NOT NULL,
  `valiid_from` INT NOT NULL,
  `valid_to` INT NOT NULL,
  `discount_percentage` FLOAT NOT NULL,
  `title` VARCHAR(45) NULL,
  `description` VARCHAR(45) NULL,
  PRIMARY KEY (`iddiscounts`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`booked`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`booked` (
  `idBooked` INT NOT NULL AUTO_INCREMENT,
  `date_from` INT NOT NULL,
  `date_to` INT NOT NULL,
  `canceled` TINYINT(1) NULL,
  `apartment_idapartment` INT NOT NULL,
  `customer_idcustomer` INT NOT NULL,
  `payment_method_idpayment_method` INT NOT NULL,
  `payment_completed` TINYINT(1) NULL,
  `arrangement_package_idarrangement_package` INT NULL,
  `discounts_iddiscounts` INT NOT NULL,
  PRIMARY KEY (`idBooked`),
  INDEX `fk_Booked_apartment1_idx` (`apartment_idapartment` ASC),
  INDEX `fk_Booked_customer1_idx` (`customer_idcustomer` ASC),
  INDEX `fk_Booked_payment_method1_idx` (`payment_method_idpayment_method` ASC),
  INDEX `fk_booked_arrangement_package1_idx` (`arrangement_package_idarrangement_package` ASC),
  INDEX `fk_booked_discounts1_idx` (`discounts_iddiscounts` ASC),
  CONSTRAINT `fk_Booked_apartment1`
    FOREIGN KEY (`apartment_idapartment`)
    REFERENCES `mydb`.`apartment` (`idapartment`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Booked_customer1`
    FOREIGN KEY (`customer_idcustomer`)
    REFERENCES `mydb`.`customer` (`idcustomer`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Booked_payment_method1`
    FOREIGN KEY (`payment_method_idpayment_method`)
    REFERENCES `mydb`.`payment_method` (`idpayment_method`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_booked_arrangement_package1`
    FOREIGN KEY (`arrangement_package_idarrangement_package`)
    REFERENCES `mydb`.`arrangement_package` (`idarrangement_package`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_booked_discounts1`
    FOREIGN KEY (`discounts_iddiscounts`)
    REFERENCES `mydb`.`discounts` (`iddiscounts`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`arrangement_package_has_apartment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`arrangement_package_has_apartment` (
  `arrangement_package_idarrangement_package` INT NOT NULL,
  `apartment_idapartment` INT NOT NULL,
  PRIMARY KEY (`arrangement_package_idarrangement_package`, `apartment_idapartment`),
  INDEX `fk_arrangement_package_has_apartment_apartment1_idx` (`apartment_idapartment` ASC),
  INDEX `fk_arrangement_package_has_apartment_arrangement_package1_idx` (`arrangement_package_idarrangement_package` ASC),
  CONSTRAINT `fk_arrangement_package_has_apartment_arrangement_package1`
    FOREIGN KEY (`arrangement_package_idarrangement_package`)
    REFERENCES `mydb`.`arrangement_package` (`idarrangement_package`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_arrangement_package_has_apartment_apartment1`
    FOREIGN KEY (`apartment_idapartment`)
    REFERENCES `mydb`.`apartment` (`idapartment`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`apartment_has_discounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`apartment_has_discounts` (
  `apartment_idapartment` INT NOT NULL,
  `discounts_iddiscounts` INT NOT NULL,
  PRIMARY KEY (`apartment_idapartment`, `discounts_iddiscounts`),
  INDEX `fk_apartment_has_discounts_discounts1_idx` (`discounts_iddiscounts` ASC),
  INDEX `fk_apartment_has_discounts_apartment1_idx` (`apartment_idapartment` ASC),
  CONSTRAINT `fk_apartment_has_discounts_apartment1`
    FOREIGN KEY (`apartment_idapartment`)
    REFERENCES `mydb`.`apartment` (`idapartment`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_apartment_has_discounts_discounts1`
    FOREIGN KEY (`discounts_iddiscounts`)
    REFERENCES `mydb`.`discounts` (`iddiscounts`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
