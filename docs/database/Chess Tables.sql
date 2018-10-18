use Chess;

drop table if exists userinfo,leaderboard;
create table userinfo
(
	username varchar(15) not null constraint PK_userinfo Primary key(username),
	userpassword varchar(15) not null,
	useremail varchar (50) not null
);

create table leaderboard
(
	username varchar(15) not null constraint FK_username foreign key(username) references userinfo,
	score int not null,
	ranking int not null constraint PK_leaderboard primary key(ranking)
);
