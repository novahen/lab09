USE g374_Tsvetkov_Zhukov
GO

CREATE TABLE l09_Planets(
PlanetName NVARCHAR(50),
DistanceFromSun FLOAT,
Inhabinants NVARCHAR(50)
);

INSERT INTO l09_Planets VALUES 
('��������', 57909, '����������'),
('������', 108200, '���������'),
('�����', 149600, '�������');

SELECT * FROM l09_Planets;
