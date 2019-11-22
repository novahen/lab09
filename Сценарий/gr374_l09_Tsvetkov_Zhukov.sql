USE g374_Tsvetkov_Zhukov
GO

CREATE TABLE l09_Planets(
PlanetName NVARCHAR(50),
DistanceFromSun FLOAT,
Inhabinants NVARCHAR(50)
);

INSERT INTO l09_Planets VALUES 
('Меркурий', 57909, 'Меркуриане'),
('Венера', 108200, 'Венериане'),
('Земля', 149600, 'Земляне');

SELECT * FROM l09_Planets;
