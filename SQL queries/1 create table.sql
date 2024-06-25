--CREATE TABLE Usuarios (
--	ID INT PRIMARY KEY IDENTITY,
--	NOMBRE VARCHAR(50) NOT NULL UNIQUE,
--	CLAVE VARCHAR(50) NOT NULL
--)

--CREATE TABLE Clientes (
--	ID INT PRIMARY KEY IDENTITY,
--	NOMBRE VARCHAR(50) NOT NULL,
--	DNI INT NOT NULL UNIQUE
--)

--CREATE TABLE Especies (
--	ID INT PRIMARY KEY IDENTITY,
--	NOMBRE VARCHAR(50) NOT NULL,
--	EDAD_MADUREZ INT,
--	PESO_PROMEDIO DECIMAL(10, 2)
--)

--CREATE TABLE Animales (
--	ID INT PRIMARY KEY IDENTITY,
--	NOMBRE VARCHAR(50) NOT NULL,
--	EDAD INT,
--	PESO DECIMAL(10, 2),
--	CLIENTE_ID INT FOREIGN KEY REFERENCES Clientes(id),
--	ESPECIE_ID INT FOREIGN KEY REFERENCES Especies(id)
--)



SELECT * FROM Usuarios 
SELECT * FROM Clientes 
SELECT * FROM Especies 
SELECT * FROM Animales 

--INSERT INTO Clientes VALUES ('C1',123456789)
--INSERT INTO Especies VALUES ('PERRO',3,6.5)
--INSERT INTO Especies VALUES ('GATO',1,2)
--INSERT INTO Animales VALUES ('TOGA',10,5,1,2)

--INSERT INTO Usuarios VALUES ('admin',123)


--SELECT a.NOMBRE AS NombreAnimal,e.NOMBRE as NombreEspecie,a.EDAD as EdadAnimal ,c.NOMBRE as Dueño 
--    FROM Animales as a
--    JOIN Clientes as c ON a.CLIENTE_ID = c.ID
--    JOIN Especies as e ON a.ESPECIE_ID = e.ID

--SELECT * FROM Animales ORDER BY PESO asc
--SELECT ESPECIE_ID, AVG(EDAD) AS PromedioEdad FROM Animales GROUP BY ESPECIE_ID

--SELECT E.NOMBRE AS NombreEspecie,MAX(A.PESO) AS PesoMaximo , MIN (A.PESO) AS PesoMinimo ,AVG (A.PESO)AS PesoPromedio 
--            FROM Animales AS A
--            JOIN Especies AS E ON E.ID = A.ESPECIE_ID
--            WHERE A.EDAD BETWEEN 0 AND 20 GROUP BY E.NOMBRE

SELECT d.id AS id_dueño, d.nombre AS nombre_del_dueño, COUNT(a.id) AS cantidad_de_animales
FROM clientes as d
LEFT JOIN animales a ON d.id = a.CLIENTE_ID
GROUP BY d.ID, d.NOMBRE
ORDER BY cantidad_de_animales ASC;
