use bookstore;

insert into Genre  (GenreName) values ('Action');

insert into Book (BookName,GenreCode) values ('Fairy Tale',(select GenreCode from Genre where GenreName = 'Action'));