CREATE TABLE employees (
  id bigint generated always as identity primary key,
  payroll_number varchar(30) not null,
  forename varchar(30) not null,
  surname varchar(30) not null,
  date_of_birth date not null,
  telephone varchar(10) not null,
  mobile varchar(10) not null,
  address varchar(50) not null,
  address2 varchar(50) not null,
  postcode varchar(20) not null,
  email varchar(50) not null,
  start_date date not null
);
