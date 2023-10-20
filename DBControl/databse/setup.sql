create database bookstore;

use  bookstore;

create table Genre (
	GenreCode int primary key identity (1,1) not null,
	GenreName NVarchar(50) not null
);

create table Book (
	BookCode int primary key identity (1,1) not null,
	BookName Nvarchar(200) not null default 'N/A',
	GenreCode int default 0,

	foreign key (GenreCode) references Genre(GenreCode),
);