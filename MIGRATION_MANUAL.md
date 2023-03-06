```sql
create table users(
	id int(8) PRIMARY KEY auto_increment,
    name varchar(250) NOT NULL    
);

insert into users (name) values ('Gabriel');
insert into users (name) values ('Jose');
insert into users (name) values ('Maria');
;
select * from users
```
homestead