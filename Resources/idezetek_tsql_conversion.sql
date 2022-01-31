-- CREATE DATABASE idezetek;
-- USE idezetek;

CREATE TABLE szerzo (
  szerzoID INT PRIMARY KEY,
  nev VARCHAR(100));
  
CREATE TABLE tema (
  temaID INT PRIMARY KEY,
  megnevezes VARCHAR(100));
  
CREATE TABLE forras (
  forrasID INT PRIMARY KEY,
  cim VARCHAR(100),
  szerzoID INT FOREIGN KEY REFERENCES szerzo(szerzoID));

CREATE TABLE idezet (
  idezetID INT PRIMARY KEY,
  szoveg TEXT,
  forrasID INT FOREIGN KEY REFERENCES forras(forrasID));
  
CREATE TABLE utalas (
  idezetID INT FOREIGN KEY REFERENCES idezet(idezetID),
  temaID INT FOREIGN KEY REFERENCES tema(temaID));

INSERT INTO szerzo VALUES
(1,'Milan Kundera'),
(2,'Thomas Mann'),
(3,'Voltaire'),
(4,'Lev Tolsztoj'),
(5,'Stendhal'),
(6,'John Steinbeck'),
(7,'William Shakespeare'),
(8,'Seneca'),
(9,'Antione de Saint Exupery'),
(10,'Edmond Rostand'),
(11,'George Orwell'),
(12,'Ernest Hemingway'),
(13,'Friedrich D�renmatt'),
(14,'Dosztojevszkij'),
(15,'Albert Camus');
  
INSERT INTO tema VALUES
(1,'F�lelem'),
(2,'Tolerancia'),
(3,'Tanul�s'),
(4,'M�v�szet'),
(5,'Optimizmus'),
(6,'Becs�let'),
(7,'Szeretet'),
(8,'Nyelv'),
(9,'Egy�tt�rz�s'),
(10,'�nismeret'),
(11,'Munka'),
(12,'Szabads�g'),
(13,'Besz�d');

INSERT INTO forras VALUES
(2,'Lass�s�g',1),
(3,'A var�zshegy',2),
(4,'Hal�l Velenc�ben',2),
(5,'Candide vagy az optimizmus',3),
(6,'Anna Karenina',4),
(7,'V�r�s �s fekete',5),
(8,'�dent�l keletre',6),
(9,'Sok h�h� semmi�rt',7),
(10,'Hamlet, d�n kir�lyfi',7),
(11,'Vigasztal�sok',8),
(12,'Erk�lcsi levelek',8),
(13,'Az ember f�ldje',9),
(14,'Cyrano De Bergerac',10),
(15,'1984',11),
(16,'A j�ghegy cs�csa',12),
(17,'Fizikusok',13),
(18,'�rd�g�k',14),
(19,'Megal�zottak �s megszomor�tottak',14),
(20,'A k�z�ny',15);

INSERT INTO idezet VALUES
(2,'A f�lelem forr�sa a j�v�ben van, s aki megszabadul a j�v�t�l, annak nincs f�lnival�ja.',2),
(3,'A tolerancia b�n, ha a gonosz megt�r�s�t jelenti.',3),
(4,'Az ember gyorsan beletanul abba, aminek bels�leg sz�ks�g�t �rzi.',3),
(5,'A m�v�szet f�lfokozott �let. M�lyebben boldog�t, gyorsabban f�lem�szt.',4),
(6,'- Mi az az optimizmus? (...) - Semmi m�s, sajnos (...), mint annak a d�h�s bizonygat�sa, hogy minden a legeslegjobb, mikor minden a legrosszabb.',3),
(7,'�r�l�k annak, amim van, s nem b�sulok azon, amim nincs.',4),
(8,'Minden olyan szerzem�ny, amely nem felel meg a r�ford�tott munk�nak, becstelen.',4),
(9,'Ha szeret�nk, az eg�sz embert szeretj�k, amilyen, nem amilyennek akarom, hogy legyen.',4),
(10,'A szavak arra val�k, hogy elrejts�k gondolatainkat.',7),
(11,'Egy embert csak akkor �rthetsz meg, ha bele tudod k�pzelni magadat az �rzelmeibe.',8),
(12,'Minden j� azoknak jut, akik megszerzik a tud�st.',8),
(13,'Jobban szeretem, ha mindenki ut�l, mint ha sz�neskednem kell b�rki szeretet��rt.',9),
(14,'Mindenek f�l�tt L�gy h� magadhoz: �gy, mint napra �j, K�vetkezik, hogy �l m�shoz se l�ssz.',10),
(15,'Nincs mi�rt f�lned, hogy k�rba v�sz a f�rads�god: magadnak tanult�l.',11),
(16,'A legnagyobb hatalom: �nmagunknak parancsolni.',12),
(17,'Az ember akkor fedezi f�l mag�t, amikor megm�rk�zik az akad�llyal.',13),
(18,'Szeretni nem annyit jelent, mint egym�s szem�be n�zni, hanem azt jelenti: egy�tt n�zni ugyanabba az ir�nyba.',13),
(19,'Mert magamat kig�nyolom, ha kell, De hogy m�s mondja, azt nem t�r�m el!',14),
(20,'Tal�n nem is annyira azt k�v�nja az ember, hogy szeress�k, ink�bb azt, hogy meg�rts�k.',15),
(21,'Mindny�jan arra sz�lett�nk, amit csin�lunk (...). Ahhoz van tehets�ged, amivel a meg�lhet�sedet megszerzed, mindegy, hogy mivel.',16),
(22,'Az igazi szabads�g nem m�s, mint annak bel�t�sa, hogy nem vagyunk szabadok.',17),
(23,'Azok, akik j�l tudnak besz�lni, r�viden besz�lnek.',18),
(24,'Nincs is a f�ld�n olyan szerelem, hogy mind a ketten egyform�n szeress�k egym�st.',14),
(25,'Abban tal�n nem vagyok biztos, hogy mi �rdekel val�j�ban, de hogy mi nem �rdekel, abban eg�szen biztos vagyok.',15);

INSERT INTO utalas VALUES
(2,1),
(3,2),
(4,3),
(5,4),
(6,5),
(7,5),
(8,6),
(9,7),
(10,8),
(11,9),
(12,3),
(13,10),
(14,10),
(15,3),
(16,10),
(17,10),
(18,7),
(19,10),
(20,7),
(21,11),
(22,12),
(23,13),
(24,7),
(25,10);