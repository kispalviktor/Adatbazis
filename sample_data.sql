INSERT INTO ORVOS (nev, szakterulet, telefonszam, email) VALUES
  ('Dr. Kovács Péter',  'Kardiológia',   '+36 1 234 5678', 'kovacs.peter@rendelo.hu'),
  ('Dr. Szabó Anna',    'Belgyógyászat', '+36 1 234 5679', 'szabo.anna@rendelo.hu'),
  ('Dr. Nagy Gábor',    'Ortopédia',     '+36 1 234 5680', 'nagy.gabor@rendelo.hu'),
  ('Dr. Horváth Éva',   'Dermatológia',  '+36 1 234 5681', 'horvath.eva@rendelo.hu'),
  ('Dr. Fekete Zoltán', 'Neurológia',    '+36 1 234 5682', 'fekete.zoltan@rendelo.hu');

INSERT INTO BETEG (nev, szuletesi_datum, taj_szam, telefonszam, email) VALUES
  ('Tóth László',      '1975-03-12', '123456789', '+36 30 111 2233', 'toth.laszlo@gmail.com'),
  ('Varga Mária',      '1988-07-24', '234567890', '+36 30 222 3344', 'varga.maria@gmail.com'),
  ('Kiss Imre',        '1962-11-05', '345678901', '+36 20 333 4455', 'kiss.imre@freemail.hu'),
  ('Molnár Katalin',   '1991-02-18', '456789012', '+36 70 444 5566', 'molnar.katalin@gmail.com'),
  ('Papp Tibor',       '1955-09-30', '567890123', '+36 30 555 6677', 'papp.tibor@citromail.hu'),
  ('Balogh Zsuzsanna', '1980-06-14', '678901234', '+36 20 666 7788', 'balogh.zs@gmail.com'),
  ('Farkas Dániel',    '2001-12-01', '789012345', '+36 70 777 8899', 'farkas.daniel@gmail.com'),
  ('Németh Ágnes',     '1969-04-22', '890123456', '+36 30 888 9900', 'nemeth.agnes@freemail.hu');

INSERT INTO IDOPONT (orvos_id, beteg_id, idopont_datum, statusz, megjegyzes) VALUES
  (1, 1, '2026-06-02 09:00:00', 'teljesitett', 'Éves szívvizsgálat'),
  (2, 2, '2026-06-03 10:30:00', 'teljesitett', 'Vérnyomás kontroll'),
  (3, 3, '2026-06-04 14:00:00', 'teljesitett', 'Térdpanasz kivizsgálás'),
  (1, 5, '2026-06-05 08:30:00', 'lemondott',   NULL),
  (4, 4, '2026-06-06 11:00:00', 'teljesitett', 'Bőrgyógyászati szűrés'),
  (5, 6, '2026-06-09 13:00:00', 'teljesitett', 'Fejfájás kivizsgálása'),
  (2, 7, '2026-06-10 09:30:00', 'teljesitett', 'Általános laborvizsgálat'),
  (3, 8, '2026-06-11 15:00:00', 'foglalt',     'Vállfájás konzultáció'),
  (1, 2, '2026-06-12 10:00:00', 'foglalt',     'EKG vizsgálat'),
  (4, 1, '2026-06-13 11:30:00', 'foglalt',     'Anyajegy ellenőrzés'),
  (5, 3, '2026-06-16 14:30:00', 'foglalt',     'MRI eredmény megbeszélés'),
  (2, 5, '2026-06-17 08:00:00', 'foglalt',     'Cukorbetegség kontroll');
  
-- Még több INSERT
  
  INSERT INTO BETEG (nev, szuletesi_datum, taj_szam, telefonszam, email) VALUES
  ('Szőke Béla',        '1978-08-15', '901234567', '+36 30 910 1122', 'szoke.bela@gmail.com'),
  ('Fekete Renáta',     '1995-03-28', '012345678', '+36 20 920 2233', 'fekete.renata@gmail.com'),
  ('Takács György',     '1960-12-10', '112233445', '+36 70 930 3344', 'takacs.gyorgy@freemail.hu'),
  ('Lakatos Ildikó',    '1983-05-07', '223344556', '+36 30 940 4455', 'lakatos.ildiko@gmail.com'),
  ('Vincze Márton',     '2000-09-19', '334455667', '+36 20 950 5566', 'vincze.marton@gmail.com'),
  ('Bíró Eszter',       '1972-01-31', '445566778', '+36 70 960 6677', 'biro.eszter@citromail.hu'),
  ('Oláh Richárd',      '1989-07-03', '556677889', '+36 30 970 7788', 'olah.richard@gmail.com'),
  ('Szalai Veronika',   '1967-11-22', '667788990', '+36 20 980 8899', 'szalai.veronika@freemail.hu');
 
INSERT INTO IDOPONT (orvos_id, beteg_id, idopont_datum, statusz, megjegyzes) VALUES
 
  -- Január
  (1, 9,  '2026-01-06 08:00:00', 'teljesitett', 'Szívultrahang'),
  (2, 10, '2026-01-07 09:00:00', 'teljesitett', 'Pajzsmirigy labor'),
  (3, 11, '2026-01-08 10:00:00', 'teljesitett', 'Gerincfájdalom konzultáció'),
  (4, 12, '2026-01-09 11:00:00', 'teljesitett', 'Ekcéma kezelés'),
  (5, 13, '2026-01-10 13:00:00', 'teljesitett', 'Migrén kivizsgálás'),
 
  -- Február
  (1, 1,  '2026-02-03 08:30:00', 'teljesitett', 'Holter monitor leolvasás'),
  (2, 3,  '2026-02-04 10:00:00', 'teljesitett', 'Koleszterin kontroll'),
  (3, 5,  '2026-02-05 14:30:00', 'teljesitett', 'Csípőprotézis utánkövetés'),
  (4, 7,  '2026-02-06 09:30:00', 'teljesitett', 'Akné kezelés'),
  (5, 9,  '2026-02-07 11:30:00', 'teljesitett', 'EEG kiértékelés'),
  (1, 14, '2026-02-10 08:00:00', 'teljesitett', 'Stresszteszt'),
  (2, 15, '2026-02-11 09:00:00', 'teljesitett', 'Vércukorszint ellenőrzés'),
 
  -- Március
  (3, 2,  '2026-03-03 10:30:00', 'teljesitett', 'Bokasérülés kontroll'),
  (4, 4,  '2026-03-04 11:00:00', 'teljesitett', 'Szemölcs eltávolítás'),
  (5, 6,  '2026-03-05 13:30:00', 'teljesitett', 'Szédülés kivizsgálás'),
  (1, 8,  '2026-03-06 08:00:00', 'teljesitett', 'Szívritmus zavar kontroll'),
  (2, 10, '2026-03-10 09:30:00', 'teljesitett', 'Vérnyomás beállítás'),
  (3, 12, '2026-03-11 14:00:00', 'teljesitett', 'Térdszalag ellenőrzés'),
  (4, 14, '2026-03-12 10:30:00', 'teljesitett', 'Pikkelysömör kontroll'),
  (5, 16, '2026-03-13 12:00:00', 'teljesitett', 'Fejfájás napló kiértékelés'),
 
  -- Április
  (1, 3,  '2026-04-01 08:30:00', 'teljesitett', 'EKG kontroll'),
  (2, 5,  '2026-04-02 10:00:00', 'teljesitett', 'Inzulin beállítás'),
  (3, 7,  '2026-04-03 11:30:00', 'teljesitett', 'Lábszárcsonttörés utánkövetés'),
  (4, 9,  '2026-04-04 09:00:00', 'teljesitett', 'Anyajegy mappálás'),
  (5, 11, '2026-04-07 13:00:00', 'teljesitett', 'Alvászavar konzultáció'),
  (1, 13, '2026-04-08 08:00:00', 'lemondott',   NULL),
  (2, 15, '2026-04-09 09:30:00', 'lemondott',   NULL),
 
  -- Május
  (1, 2,  '2026-05-05 08:00:00', 'teljesitett', 'Szívultrahang ismétlés'),
  (2, 4,  '2026-05-06 10:30:00', 'teljesitett', 'Pajzsmirigy kontroll'),
  (3, 6,  '2026-05-07 14:00:00', 'teljesitett', 'Vállfájás fizikoterápia utánkövetés'),
  (4, 8,  '2026-05-08 11:00:00', 'teljesitett', 'Bőrgyógyászati szűrés'),
  (5, 10, '2026-05-09 13:30:00', 'teljesitett', 'Neuropátia kivizsgálás'),
  (1, 12, '2026-05-12 08:30:00', 'teljesitett', 'Holter kontroll'),
  (2, 14, '2026-05-13 09:00:00', 'teljesitett', 'Pajzsmirigyhormon labor'),
  (3, 16, '2026-05-14 10:30:00', 'lemondott',   NULL),
  (4, 1,  '2026-05-15 11:30:00', 'teljesitett', 'Melanóma szűrés'),
  (5, 3,  '2026-05-16 13:00:00', 'teljesitett', 'MS kontroll');