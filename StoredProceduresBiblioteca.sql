USE [Biblioteca]
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 07/11/2022 2:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[InsertarUsuario](
@NombreUsuario varchar(20),
@Cuenta varchar(20),
@Contraseña varchar(20)
)
as
begin
insert into Usuarios (NombreUsuario,Cuenta,Contraseña)
values (@NombreUsuario,@Cuenta,@Contraseña)
end


/****** Object:  StoredProcedure [dbo].[InsertarLibro]    Script Date: 07/11/2022 2:32:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[InsertarLibro](
@Titulo varchar(200),
@Autor varchar(50),
@Categoria varchar(50),
@NumeroPaginas int,
@Editorial varchar(50),
@FechaEdicion date,
@FechaPublicacion date,
@Edicion varchar(200),
@Idioma varchar(50),
@NumeroEjemplares int)
as
begin
insert into Libros 
(Titulo,Autor,Categoria,NumeroPaginas,Editorial,FechaEdicion,FechaPublicacion,Edicion,Idioma,NumeroEjemplares)
values
(@Titulo,@Autor,@Categoria,@NumeroPaginas,@Editorial,@FechaEdicion,@FechaPublicacion,@Edicion,@Idioma,@NumeroEjemplares);
end



GO
/****** Object:  StoredProcedure [dbo].[NuevoLector]    Script Date: 07/11/2022 2:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[NuevoLector](
@CedulaLector bigint,
@NombreLector varchar(100),
@TelefonoLector bigint,
@DireccionLector varchar(200)
)
as
begin
insert into Lectores (CedulaLector,NombreLector,TelefonoLector,DireccionLector)
values (@CedulaLector,@NombreLector,@TelefonoLector,@DireccionLector) 
end



GO
/****** Object:  StoredProcedure [dbo].[GuardarPrestamo]    Script Date: 07/11/2022 2:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[GuardarPrestamo](
@IdLibro1 int,
@FechaSalida date,
@FechaDevolucion date,
@IdLector1 int
)
as
begin
insert into Prestamo (IdLibro1,FechaSalida,FechaDevolucion,IdLector1)
values (@IdLibro1,@FechaSalida,@FechaDevolucion,@IdLector1);
update Libros set NumeroEjemplares = NumeroEjemplares - 1 where IdLibro = @IdLibro1
end


GO
/****** Object:  StoredProcedure [dbo].[ModificarLector]    Script Date: 07/11/2022 2:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ModificarLector](
@IdLector integer,
@CedulaLector bigint,
@NombreLector varchar(100),
@TelefonoLector bigint,
@DireccionLector varchar(200)
)
as
begin
update Lectores
set
CedulaLector = @CedulaLector,
NombreLector = @NombreLector,
TelefonoLector = @TelefonoLector,
DireccionLector = @DireccionLector
where IdLector = @IdLector
end



GO
/****** Object:  StoredProcedure [dbo].[ModificarLibro]    Script Date: 07/11/2022 2:34:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ModificarLibro](
@IdLibro integer,
@Titulo varchar(200),
@Autor varchar(50),
@Categoria varchar(50),
@NumeroPaginas int,
@Editorial varchar(50),
@FechaEdicion date,
@FechaPublicacion date,
@Edicion varchar(200),
@Idioma varchar(50),
@NumeroEjemplares int)
as
begin
update Libros
set 
Titulo = @Titulo,
Autor = @Autor,
Categoria = @Categoria,
NumeroPaginas = @NumeroPaginas,
Editorial = @Editorial,
FechaEdicion = @FechaEdicion,
FechaPublicacion = @FechaPublicacion,
Edicion = @Edicion,
Idioma = @Idioma,
NumeroEjemplares = @NumeroEjemplares
where IdLibro = @IdLibro
end



GO
/****** Object:  StoredProcedure [dbo].[ActualizarUsuario]    Script Date: 07/11/2022 2:35:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ActualizarUsuario](
@IdUsuario int,
@NombreUsuario varchar(20),
@Cuenta varchar(20),
@Contraseña varchar(20)
)
as
begin
update Usuarios
set
NombreUsuario = @NombreUsuario,
Cuenta = @Cuenta,
Contraseña = @Contraseña
where IdUsuario = @IdUsuario
end



GO
/****** Object:  StoredProcedure [dbo].[BuscarLibro]    Script Date: 07/11/2022 2:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[BuscarLibro]
@Titulo varchar (200)
as
begin
select *from Libros
where Titulo = @Titulo
end



GO
/****** Object:  StoredProcedure [dbo].[BuscarPrestamo]    Script Date: 07/11/2022 2:35:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[BuscarPrestamo](
@IdPrestamo int
)
as
begin
select * from Prestamo where IdPrestamo = @IdPrestamo
end



GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 07/11/2022 2:35:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[BuscarUsuario](
@NombreUsuario varchar(20)
)
as
begin
select *from Usuarios where NombreUsuario = @NombreUsuario
end



GO
/****** Object:  StoredProcedure [dbo].[DevolverLibro]    Script Date: 07/11/2022 2:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[DevolverLibro](
@IdPrestamo1 int,
@IdLibro2 int,
@FechaDevolucion date,
@ObservacionDevolucion varchar(200)
)
as
begin
insert into Devolucion(IdPrestamo1,FechaDevolucion,ObservacionDevolucion,IdLibro2)
values (@IdPrestamo1,@FechaDevolucion,@ObservacionDevolucion,@IdLibro2);
delete from Prestamo where IdPrestamo = @IdPrestamo1;
update Libros set NumeroEjemplares = NumeroEjemplares + 1 where IdLibro = @IdLibro2;
end


GO
/****** Object:  StoredProcedure [dbo].[EliminarLector]    Script Date: 07/11/2022 2:37:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[EliminarLector]
@IdLector int
as
begin
delete from Lectores
where IdLector = @IdLector
end


E [Biblioteca]
GO
/****** Object:  StoredProcedure [dbo].[EliminarLibro]    Script Date: 07/11/2022 2:37:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[EliminarLibro]
@IdLibro int
as begin
delete from Libros
where IdLibro = @IdLibro
end 


GO
/****** Object:  StoredProcedure [dbo].[EliminarPrestamo]    Script Date: 07/11/2022 2:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[EliminarPrestamo](
@IdPrestamo1 int
)
as
delete from Prestamo where IdPrestamo = @IdPrestamo1



GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 07/11/2022 2:38:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[EliminarUsuario](
@IdUsuario int
)
as
begin
delete from Usuarios where IdUsuario = @IdUsuario
end