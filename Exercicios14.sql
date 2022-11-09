create database empresa_db

create table departamentos
(
	id integer primary key identity,
	nome varchar(40) not null,
	localizacao varchar(30),
	orcamento integer
)

create table empregados
(
	id integer primary key identity,
	nome varchar(40) not null,
	idGerente integer,
	funcao varchar(40) not null,
	fk_departamento integer,
	dataAdmissao date,
	salario integer,
	comissao integer,
	foreign key(idGerente) references empregados(id),
	foreign key(fk_departamento) references departamentos(id)
)

INSERT INTO Departamentos VALUES('Banco de Dados','Porto Alegre', 2346);
INSERT INTO Departamentos VALUES('Balconistas','Pelotas', 10000);
INSERT INTO Departamentos VALUES('Inteligência Artific','Pelotas', 333);
INSERT INTO Departamentos VALUES('Compiladores','Novo Hamburgo', 5050);
INSERT INTO Departamentos VALUES('Redes','Taquara', 12122);

INSERT INTO Empregados VALUES('Mariewa',NULL,'Gerente',1,'2000-04-05',2300,0);
INSERT INTO Empregados VALUES('Zico',1,'Operário',1,'1999-08-13',100,0);
INSERT INTO Empregados VALUES('Lula',NULL,'Presidente',5,'1950-01-01',10000,0);
INSERT INTO Empregados VALUES('Vera Fixer',5,'Balconista',2,'1999-05-05',3300,0);
INSERT INTO Empregados VALUES('Luana Pyovany',NULL,'Gerente',2,'1998-06-23',2300,0);
INSERT INTO Empregados VALUES('Daniela Schicarelli',NULL,'Gerente',3,'1999-10-10',2300,0);
INSERT INTO Empregados VALUES('Luize Altenhofen',NULL,'Gerente',4,'1999-04-26',2300,0);
INSERT INTO Empregados VALUES('Helo Pinheiro',NULL,'Gerente',5,'1997-09-25',2300,0);
INSERT INTO Empregados VALUES('Pelé',1,'Operário',1,'2000-09-09',100,NULL);
INSERT INTO Empregados VALUES('Romário',1,'Operário',5,'2001-12-25',100,0);
INSERT INTO Empregados VALUES('Malu Mader',5,'Balconista',2,'2001-10-20',3400,0);
INSERT INTO Empregados VALUES('Antônio Fagundes',7,'Vendedor',3,'2002-12-22',5000,10);

update empregados set idGerente = 5 where id = 4;

select * from departamentos
select * from empregados

select nome, orcamento * 12
from departamentos 
where orcamento > 10000

------------------------------

select nome as 'Departamento', orcamento * 12 as 'Orcamento anual'
from departamentos 
where orcamento > 10000

------------------------------

select distinct funcao
from empregados

------------------------------

select nome, funcao
from empregados
order by nome desc

------------------------------

select * from empregados 
where salario < 1000 or salario > 3500

------------------------------

select * from empregados 
where salario between 3400 and 4000 and funcao = 'balconista'

------------------------------

select lower(nome)
from empregados

------------------------------

select substring(nome,1,5)
from empregados

------------------------------

select avg(salario) as 'Média', max(salario) as 'Maior', min(salario) as 'Menor'
from empregados

------------------------------

select departamentos.nome as 'Departamento', avg(comissao) as 'Média'
from empregados
inner join departamentos
on departamentos.id = empregados.fk_departamento
group by departamentos.nome

------------------------------

select departamentos.nome as 'Departamento', avg(comissao) as 'Média', count(fk_departamento) as 'Quantidade'
from empregados
inner join departamentos
on departamentos.id = empregados.fk_departamento
group by departamentos.nome
having count(fk_departamento) > 2

------------------------------

select empregados.nome, funcao, departamentos.nome
from empregados
inner join departamentos
on departamentos.id = empregados.fk_departamento

------------------------------

select id as 'Código', nome as 'Funcionário', funcao as 'Função', idGerente as 'Gerente'
from empregados

------------------------------

-- INSERT
INSERT INTO Departamentos (nome, localizacao, orcamento) VALUES ('PRODUCAO','RIO DE JANEIRO','1200');

-- UPDATE
UPDATE Empregados 
SET Empregados.salario = Empregados.salario * 1.2 
WHERE Empregados.salario < 1000;

-- DELETE
DELETE FROM Empregados
WHERE Empregados.salario > 5000;


select empregados.nome as 'Funcionário', empregados.funcao as 'Cargo'
from empregados
inner join departamentos
on departamentos.id = empregados.fk_departamento
where departamentos.orcamento = 10000


select departamentos.nome as 'Departamento', empregados.nome as 'Funcionário', empregados.salario as 'Salário'
from departamentos
inner join empregados
on empregados.fk_departamento = departamentos.id
where empregados.salario > 3000