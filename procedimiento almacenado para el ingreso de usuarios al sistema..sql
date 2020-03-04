create procedure [dbo].[SPUsuario_los_negritos]
@opcion int,
@cedula_usuario varchar(50) = null,
@nombre_usuario varchar(50) = null,
@apellido1 varchar(50)= null,
@apellido2 varchar(50)=null,
@nick_name varchar(50)=null,
@correo_electronico varchar(50) = null,
@clave_usuario varchar(50) = null,
@rol varchar(50) = null,
@estado int=null
as
if @opcion = 1
Begin
 insert into tb_Usuarios_Los_negritos values(@cedula_usuario,@nombre_usuario,@apellido1,@apellido2,@nick_name,@correo_electronico,CONVERT(varbinary(8000),ENCRYPTBYPASSPHRASE('password',@clave_usuario)),@rol,@estado)	
end

if @opcion = 2

begin
select * from TbUsuario
end
--- este update le corresponde al adminstaror de base de datos donde puede actualizar solo los datos que se le permiten del usuario 
if @opcion = 3
begin
	update tb_Usuarios_Los_negritos set nombre_usuario = @nombre_usuario,apellido1 = @apellido1,apellido2=@apellido2,nick_name=@nick_name,correo_electronico=@correo_electronico,rol=@rol,
	estado=@estado where cedula_usuario= @cedula_usuario
end
-- este update es para actualizar el perfil del usuario..
if @opcion = 4
begin
update tb_Usuarios_Los_negritos set nombre_usuario = @nombre_usuario,apellido1 = @apellido1,apellido2=@apellido2,nick_name=@nick_name,correo_electronico=@correo_electronico,
	clave_usuario=CONVERT(varbinary(8000),ENCRYPTBYPASSPHRASE('password',@clave_usuario)) where cedula_usuario= @cedula_usuario
end

-----------------------------------------------------------------------------------------------

--validacion de la calve para el ingreso al sistema.

create procedure [dbo].[SPValidacionUsu_los_negritos]
@opcion int,
@nick_name varchar(50)=null,
@clave_usuario varchar(50)=null
as
-- declaracion de variables para almacenar los datos a desencriptar
declare @ClaveEncriptada as Nvarchar (max)
declare @DesencriptarClave as Nvarchar(max)

if @opcion=1

begin 
--- aqui llamamos el valor a desencriptar y lo saginamos a las variables 
select @ClaveEncriptada=clave_usuario from tb_Usuarios_Los_negritos where nick_name=@nick_name
set @DesencriptarClave=convert(varchar(max),DECRYPTBYPASSPHRASE('password',@ClaveEncriptada))

select * from tb_Usuarios_Los_negritos where nick_name=@nick_name and @clave_usuario=@DesencriptarClave 

end

insert into tb_Usuarios_Los_negritos values('02069961','Carlos','lezcano','Montoya','cl7','carlos.lezcano988@gmail.com',ENCRYPTBYPASSPHRASE('password','123'),'Administrador',1)