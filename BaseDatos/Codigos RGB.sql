/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [idColor]
      ,[Codigo]
      ,[Descripcion]
      ,[RGB]
      ,[BajaLogica]
      ,[R]
      ,[G]
      ,[B]
  FROM [Conexco].[dbo].[Articulos_Color]
   
  update articulos_color
  set RGB = 'BEC0CB'
  where Codigo = 0
  
  update articulos_color
  set RGB = 'FFFFFF'
  where Codigo = 1
  
  
  
    update articulos_color
  set RGB = '0000FF'
  where Codigo = 2
  
  
      update articulos_color
  set RGB = 'FF0000'
  where Codigo = 3
  
        update articulos_color
  set RGB = 'FFFF00'
  where Codigo = 4
  
          update articulos_color
  set RGB = '00FF00'
  where Codigo = 5
  
          update articulos_color
  set RGB = '000000'
  where Codigo = 6
  
            update articulos_color
  set RGB = 'FFA500'
  where Codigo = 7
  
  update articulos_color
  set RGB = 'EE82EE'
  where Codigo = 8
  
 delete from articulos_color where idColor > 1
  
  insert into Articulos_Color values(1,'Blanco', 'FFFFFF', 0, 0, 0, 0)
  insert into Articulos_Color values(2,'Azul', '0000FF', 0, 0, 0, 0)
  insert into Articulos_Color values(3,'Rojo', 'FF0000', 0, 0, 0, 0)
  insert into Articulos_Color values(4,'Amarillo', 'FFFF00', 0, 0, 0, 0)
  insert into Articulos_Color values(5,'Verde', '00FF00', 0, 0, 0, 0)
  insert into Articulos_Color values(6,'Negro', '000000', 0, 0, 0, 0)
  insert into Articulos_Color values(7,'Naranja', 'FFA500', 0, 0, 0, 0)
  insert into Articulos_Color values(8,'Violeta', 'EE82EE', 0, 0, 0, 0)
  