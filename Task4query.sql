-- a. ispisati sve filmove �anra �Akcija� (SELECT)
SELECT * FROM Movies WHERE zanr = 'Action';

-- b. ispisati sve posu�ene filmove �anra �Akcija� (SELECT)
SELECT * FROM Movies WHERE zanr = 'Action' AND status = 'borrowed';

-- c. a�urirati �anr svih filmova starijih od 1980. na �anr �Klasika� (UPDATE)
UPDATE Movies SET zanr = 'Classic' WHERE godina < 1980;

-- d. evidentirati povijest posudbe X na dan vra�anja filma u tabelu Povijest Posudbi (INSERT+SELECT) te obrisati posudbu X iz tabele Posudbe (DELETE)
INSERT INTO RentalHistory (rentalId, userId, movieId, datumRezervacije, datumRezervacijaIsteka)
SELECT rentalId, userId, movieId, datumRezervacije, CURRENT_DATE FROM Rentals WHERE rentalId = X;
DELETE FROM Rentals WHERE rentalId = X;

-- e. a�urirati status svih �lanova na status �Frequent� koji imaju arhivirano vi�e od 50 posudbi (UPDATE)

UPDATE Members 
SET status = 'Frequent' 
WHERE userId IN (
    SELECT userId 
    FROM RentalHistory 
    GROUP BY userId 
    HAVING COUNT(rentalId) > 50
);