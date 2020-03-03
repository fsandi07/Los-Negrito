create procedure SPExtraccion_De_Xml
@opcion int,
@Axml xml=null
as 

if @opcion=1 
begin 
     declare @fecha_de_emison datetime
	 declare @numero_factura varchar(max)
	 declare @nombre_comercio varchar(max)
	 declare @cedula_juridica varchar(max)
	 declare @Plazo_credito varchar(max)
	 declare @total_IVA varchar(max)
	 declare @total_pagar varchar(max)
	 
	 

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica' as b)
SELECT 
      @fecha_de_emison=x.u.value('b:FechaEmision[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:FacturaElectronica') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica' as b)
SELECT 
     @numero_factura= x.u.value('b:NumeroConsecutivo[1]', 'varchar(100)')
from 
  @Axml .nodes('/b:FacturaElectronica') x(u)

  ;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica' as b)
SELECT 
     @nombre_comercio=x.u.value('b:Nombre[1]', 'varchar(100)') 
from 
    @Axml.nodes('/b:FacturaElectronica/b:Emisor') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica' as b)
SELECT 
     @cedula_juridica=x.u.value('b:Numero[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:FacturaElectronica/b:Emisor/b:Identificacion') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica' as b)
SELECT 
     @Plazo_credito=x.u.value('b:PlazoCredito[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:FacturaElectronica') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica' as b)
SELECT 
     @total_IVA =x.u.value('b:TotalImpuesto[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:FacturaElectronica/b:ResumenFactura') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica' as b)
SELECT 
    @total_pagar= x.u.value('b:TotalComprobante[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:FacturaElectronica/b:ResumenFactura') x(u)
	-- en esta parte se usa por si la etiqueta es de tipo tiquete electronico.
---------------------------------------------------------------------------------------------------------------------------------
	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico' as b)
SELECT 
      @fecha_de_emison=x.u.value('b:FechaEmision[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:TiqueteElectronico') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico' as b)
SELECT 
     @numero_factura= x.u.value('b:NumeroConsecutivo[1]', 'varchar(100)')
from 
  @Axml .nodes('/b:TiqueteElectronico') x(u)

  ;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico' as b)
SELECT 
     @nombre_comercio=x.u.value('b:Nombre[1]', 'varchar(100)') 
from 
    @Axml.nodes('/b:TiqueteElectronico/b:Emisor') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico' as b)
SELECT 
     @cedula_juridica=x.u.value('b:Numero[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:TiqueteElectronico/b:Emisor/b:Identificacion') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico' as b)
SELECT 
     @Plazo_credito=x.u.value('b:PlazoCredito[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:TiqueteElectronico') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico' as b)
SELECT 
     @total_IVA =x.u.value('b:TotalImpuesto[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:TiqueteElectronico/b:ResumenFactura') x(u)

	;WITH XMLNAMESPACES('https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/tiqueteElectronico' as b)
SELECT 
    @total_pagar= x.u.value('b:TotalComprobante[1]', 'varchar(100)')
from 
    @Axml.nodes('/b:TiqueteElectronico/b:ResumenFactura') x(u)

insert into Los_negritos_Extraccion_DE_Datos values(@fecha_de_emison,@numero_factura,@nombre_comercio,@cedula_juridica,convert (money,@Plazo_credito),@total_IVA,@total_pagar,@Axml)


end

--- mostrar Datos extraidos del Archivo xml

create procedure SPextracion
	@opcion int
	as 

	if @opcion=1
	begin
	select * from Los_negritos_Extraccion_DE_Datos where id_de_tabla in(select MAX(id_de_tabla) as maximo from Los_negritos_Extraccion_DE_Datos)
	end
	--- esto es para volver el campo identity a 0 nuevamente.
	DBCC CHECKIDENT (Los_negritos_Extraccion_DE_Datos, RESEED,0)
	delete Los_negritos_Extraccion_DE_Datos where id_de_tabla=1
