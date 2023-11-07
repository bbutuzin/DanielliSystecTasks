ALTER TYPE member_status ADD VALUE 'frequent';
CREATE TYPE movie_status AS ENUM ('borrowed', 'not borrowed');
update TYPE member_status AS ENUM ('active', 'frequent', 'inactive');

CREATE TABLE Members (
    userId SERIAL PRIMARY KEY,
    naziv VARCHAR(100) NOT NULL,
    adresa VARCHAR(200) NOT NULL,
    kontakt VARCHAR(20) NOT NULL,
    datumUclanjenja DATE NOT NULL,
    status member_status NOT NULL DEFAULT 'active'
);

CREATE TABLE Movies (
    movieId SERIAL PRIMARY KEY,
    naziv VARCHAR(100) NOT NULL,
    zanr VARCHAR(50) NOT NULL,
    godina INT NOT NULL,
    status movie_status NOT NULL DEFAULT 'not borrowed'
);

CREATE TABLE Rentals (
    rentalId SERIAL PRIMARY KEY,
    userId INT,
    movieId INT,
    datumRezervacije DATE NOT NULL,
    datumRezervacijaIsteka DATE NOT NULL,
    FOREIGN KEY (userId) REFERENCES Members (userId),
    FOREIGN KEY (movieId) REFERENCES Movies (movieId)
);

CREATE TABLE RentalHistory (
    rentalId SERIAL PRIMARY KEY,
    userId INT NOT NULL,
    movieId INT NOT NULL,
    datumRezervacije DATE NOT NULL,
    datumRezervacijaIsteka DATE not NULL,
    FOREIGN KEY (userId) REFERENCES Members (userId),
    FOREIGN KEY (movieId) REFERENCES Movies (movieId)
);


-- Populate the Members table
INSERT INTO Members (naziv, adresa, kontakt, datumUclanjenja, status)
VALUES 
('John Doe', '123 Main St, Anytown, CA', '555-123-4567', '2023-01-01', 'active'),
('Jane Smith', '456 Elm St, Anyville, OR', '555-567-8901', '2022-03-15', 'inactive'),
('Peter Jones', '789 Oak St, Anycity, WA', '555-987-6543', '2023-02-20', 'active'),
('Mary Johnson', '1011 Birch St, Anyplace, UT', '555-321-0987', '2021-06-01', 'active'),
('Harry Brown', '1213 Maple St, Anystate, ID', '555-741-5632', '2022-07-10', 'inactive');

-- Populate the Movies table
INSERT INTO Movies (naziv, zanr, godina, status)
VALUES 
('The Shawshank Redemption', 'Drama', 1994, 'not borrowed'),
('The Lord of the Rings: The Return of the King', 'Fantasy', 2003, 'not borrowed'),
('The Godfather', 'Drama', 1972, 'borrowed'),
('The Dark Knight', 'Action', 2008, 'not borrowed'),
('Pulp Fiction', 'Crime', 1994, 'not borrowed');

-- Populate the Rentals table
INSERT INTO Rentals (userId, movieId, datumRezervacije, datumRezervacijaIsteka)
VALUES 
(1, 2, '2023-05-03', '2023-05-10'),
(3, 4, '2023-04-25', '2023-05-02'),
(1, 3, '2023-05-11', '2023-05-18'),
(2, 1, '2023-04-18', '2023-04-25'),
(4, 5, '2023-05-08', '2023-05-15');