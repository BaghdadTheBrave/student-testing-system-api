Create table user_table (
    id int primary key,
    login varchar(255),
    password varchar(255),

);

Create table lecturer (
    id int primary key,
    userId int foreign key references user_table(id)

);

Create table student (
    id int primary key,
    userId int foreign key references user_table(id)

);

Create table subject (
    id int primary key,
    title varchar(255)

);

Create table theme (
    id int primary key,
    title varchar(255),
    subjectId int foreign key references subject(id),
    amount_of_questions_per_attempt int,
    number_of_attempts int

);

Create table question (
    id int primary key,
    text_of_question varchar(510),
    themeId int foreign key references theme(id)
    
);

create table attempt(
    id int primary key,
    mark int,
    studentId int FOREIGN KEY REFERENCES student(id),
    themeId int foreign key references theme(id)
)

create table answer(
    id int primary key,
    mark int,
    questionId int FOREIGN KEY REFERENCES question(id),
    studentId int FOREIGN KEY REFERENCES student(id),
    attemptId int foreign key references attempt(id)
)
