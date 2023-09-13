CREATE DATABASE dbLibrary

USE dbLibrary

CREATE TABLE [dbo].[tblBooks]
(
	[Book ID] INT PRIMARY KEY IDENTITY,
	[Book Name] VARCHAR(60) NOT NULL,
	[ISBN-10] BIGINT NOT NULL,
	[Net Quantity] INT NOT NULL,
	[Author Name] VARCHAR(60) NOT NULL
)

truncate table dbo.tblBooks
SELECT * FROM dbo.tblBooks

-- Insert book details
INSERT INTO dbo.tblBooks ([Book Name], [ISBN-10], [Net Quantity], [Author Name])
VALUES
('To Kill a Mockingbird', 9780061120084, 5, 'Harper Lee'),
('The Great Gatsby', 9780743273565, 3, 'F. Scott Fitzgerald'),
('1984', 9780451524935, 2, 'George Orwell'),
('Pride and Prejudice', 9780141439518, 4, 'Jane Austen'),
('The Catcher in the Rye', 9780316769174, 6, 'J.D. Salinger'),
('The Hobbit', 9780618260300, 1, 'J.R.R. Tolkien'),
('The Harry Potter Series', 9780545139700, 7, 'J.K. Rowling'),
('The Lord of the Rings', 9780544003415, 3, 'J.R.R. Tolkien'),
('The Alchemist', 9780061122415, 5, 'Paulo Coelho'),
('The Da Vinci Code', 9780307474278, 2, 'Dan Brown'),
('The Girl on the Train', 9780735212169, 4, 'Paula Hawkins'),
('Gone Girl', 9780307588364, 6, 'Gillian Flynn'),
('The Hunger Games', 9780439023481, 3, 'Suzanne Collins'),
('The Shining', 9780307743657, 5, 'Stephen King'),
('Brave New World', 9780060850524, 2, 'Aldous Huxley'),
('Sapiens: A Brief History of Humankind', 9780062316097, 1, 'Yuval Noah Harari'),
('The Road', 9780307387899, 4, 'Cormac McCarthy'),
('The Art of War', 9781590302255, 6, 'Sun Tzu'),
('The Odyssey', 9780140449112, 3, 'Homer'),
('Moby-Dick', 9780142437247, 2, 'Herman Melville'),
('The Count of Monte Cristo', 9780140449266, 4, 'Alexandre Dumas'),
('War and Peace', 9780199580507, 5, 'Leo Tolstoy'),
('Crime and Punishment', 9780199536399, 6, 'Fyodor Dostoevsky'),
('The Great Expectations', 9780141439563, 3, 'Charles Dickens'),
('One Hundred Years of Solitude', 9780061120084, 4, 'Gabriel García Márquez'),
('The Lord of the Flies', 9780571273577, 2, 'William Golding'),
('The Odyssey', 9780140449112, 5, 'Homer'),
('Moby-Dick', 9780142437247, 3, 'Herman Melville'),
('The Count of Monte Cristo', 9780140449266, 6, 'Alexandre Dumas'),
('War and Peace', 9780199580507, 4, 'Leo Tolstoy'),
('Crime and Punishment', 9780199536399, 2, 'Fyodor Dostoevsky'),
('The Great Expectations', 9780141439563, 1, 'Charles Dickens'),
('One Hundred Years of Solitude', 9780061120084, 7, 'Gabriel García Márquez'),
('The Lord of the Flies', 9780571273577, 6, 'William Golding'),
('The Odyssey', 9780140449112, 3, 'Homer'),
('Moby-Dick', 9780142437247, 2, 'Herman Melville'),
('The Count of Monte Cristo', 9780140449266, 4, 'Alexandre Dumas'),
('War and Peace', 9780199580507, 5, 'Leo Tolstoy'),
('Crime and Punishment', 9780199536399, 6, 'Fyodor Dostoevsky'),
('The Great Expectations', 9780141439563, 3, 'Charles Dickens'),
('One Hundred Years of Solitude', 9780061120084, 4, 'Gabriel García Márquez'),
('The Lord of the Flies', 9780571273577, 2, 'William Golding'),
('The Odyssey', 9780140449112, 5, 'Homer'),
('Moby-Dick', 9780142437247, 3, 'Herman Melville'),
('The Count of Monte Cristo', 9780140449266, 6, 'Alexandre Dumas'),
('War and Peace', 9780199580507, 4, 'Leo Tolstoy'),
('Crime and Punishment', 9780199536399, 2, 'Fyodor Dostoevsky'),
('The Great Expectations', 9780141439563, 1, 'Charles Dickens');

