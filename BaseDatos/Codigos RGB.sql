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
  
  #BEC0CB
  
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