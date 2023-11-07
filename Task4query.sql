-- a. ispisati sve filmove žanra „Akcija“ (SELECT)
SELECT * FROM Movies WHERE zanr = 'Action';

-- b. ispisati sve posuðene filmove žanra „Akcija“ (SELECT)
SELECT * FROM Movies WHERE zanr = 'Action' AND status = 'borrowed';

-- c. ažurirati žanr svih filmova starijih od 1980. na žanr „Klasika“ (UPDATE)
UPDATE Movies SET zanr = 'Classic' WHERE godina < 1980;

-- d. evidentirati povijest posudbe X na dan vraæanja filma u tabelu Povijest Posudbi (INSERT+SELECT) te obrisati posudbu X iz tabele Posudbe (DELETE)
INSERT INTO RentalHistory (rentalId, userId, movieId, datumRezervacije, datumRezervacijaIsteka)
SELECT rentalId, userId, movieId, datumRezervacije, CURRENT_DATE FROM Rentals WHERE rentalId = X;
DELETE FROM Rentals WHERE rentalId = X;

-- e. ažurirati status svih èlanova na status „Frequent“ koji imaju arhivirano više od 50 posudbi (UPDATE)

UPDATE Members 
SET status = 'Frequent' 
WHERE userId IN (
    SELECT userId 
    FROM RentalHistory 
    GROUP BY userId 
    HAVING COUNT(rentalId) > 50
);