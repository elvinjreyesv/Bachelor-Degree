USE [taller_f]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado](
	[cod_est] [int] NOT NULL,
	[desc_est] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_est] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[estado] ([cod_est], [desc_est]) VALUES (1, N'activo')
INSERT [dbo].[estado] ([cod_est], [desc_est]) VALUES (2, N'inactivo')
/****** Object:  Table [dbo].[det_fact]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[det_fact](
	[cod_fact] [int] NULL,
	[desc_fact] [varchar](100) NULL,
	[precio] [float] NULL,
	[cant] [int] NULL,
	[descripcion] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (2, N'11', 1500, 1, N'calibrar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (2, N'9', 1200, 1, N'cambiar registros a culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (2, N'13', 1500, 1, N'correccion escape a culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (2, N'1', 200, 1, N'desarmar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (2, N'10', 100, 1, N'esmerilar valvulas y asientos')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (2, N'3', 1000, 3, N'replanar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (3, N'11', 1500, 1, N'calibrar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (3, N'7', 300, 2, N'chequear guias a culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (3, N'10', 100, 3, N'esmerilar valvulas y asientos')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (3, N'8', 1000, 4, N'rectificar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (4, N'9', 1200, 1, N'cambiar registros a culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (4, N'7', 300, 1, N'chequear guias a culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (4, N'3', 1000, 1, N'replanar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (4, N'8', 1000, 1, N'rectificar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (5, N'11', 1500, 1, N'calibrar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (6, N'11', 1500, 1, N'calibrar culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (6, N'9', 1200, 1, N'cambiar registros a culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (6, N'13', 1500, 1, N'correccion escape a culata')
INSERT [dbo].[det_fact] ([cod_fact], [desc_fact], [precio], [cant], [descripcion]) VALUES (6, N'1', 200, 1, N'desarmar culata')
/****** Object:  Table [dbo].[usuarios]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[cod_tercero] [int] NULL,
	[ape_usu] [varchar](50) NULL,
	[usuario] [varchar](50) NOT NULL,
	[clave] [varchar](50) NULL,
	[cod_tipo] [int] NULL,
	[cod_est] [int] NULL,
	[fec_reg] [datetime] NULL,
	[nivel_acceso] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[usuarios] ([cod_tercero], [ape_usu], [usuario], [clave], [cod_tipo], [cod_est], [fec_reg], [nivel_acceso]) VALUES (1, N'reyes', N'elvin', N'1110145', 1, 1, CAST(0x0000A40C00000000 AS DateTime), 1)
/****** Object:  Table [dbo].[cif]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cif](
	[cod_cif] [int] NOT NULL,
	[detalle] [varchar](100) NULL,
	[porciento] [float] NULL,
	[fec_rec] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cif] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modelo]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modelo](
	[cod_modelo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_modelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marca]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marca](
	[cod_marca] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_marca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[itbis]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[itbis](
	[cod_itbis] [int] NOT NULL,
	[porciento] [float] NULL,
	[descripcion] [varchar](30) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_itbis] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[unidades]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[unidades](
	[cod_unidad] [int] NOT NULL,
	[des_unidad] [varchar](50) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_unidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trabajos]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trabajos](
	[cod_trab] [int] NOT NULL,
	[descrip_trab] [varchar](100) NULL,
	[precio] [float] NULL,
	[cod_est] [int] NULL,
	[fec_reg] [datetime] NULL,
	[area] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_trab] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (1, N'desarmar culata', 200, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (2, N'probar culata', 400, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (3, N'replanar culata', 1000, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (4, N'esmerilar culata', 500, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (6, N'armar culata', 500, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (7, N'chequear guias a culata', 300, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (8, N'rectificar culata', 1000, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (9, N'cambiar registros a culata', 1200, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (10, N'esmerilar valvulas y asientos', 100, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (11, N'calibrar culata', 1500, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (12, N'extraer tornillos a culata', 100, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
INSERT [dbo].[trabajos] ([cod_trab], [descrip_trab], [precio], [cod_est], [fec_reg], [area]) VALUES (13, N'correccion escape a culata', 1500, 1, CAST(0x0000A40C00000000 AS DateTime), N'culatas')
/****** Object:  Table [dbo].[tipo_usuario]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_usuario](
	[cod_tipo] [int] NOT NULL,
	[descrip] [varchar](25) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_pago]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_pago](
	[tipo_pago] [int] NOT NULL,
	[descripcion] [varchar](25) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[tipo_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_movimiento]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_movimiento](
	[cod_tipo_mov] [int] NOT NULL,
	[det_tmov] [varchar](50) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_tipo_mov] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tercero]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tercero](
	[cod_tercero] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[cod_est] [int] NULL,
	[fecha_reg] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_tercero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tercero] ([cod_tercero], [nombre], [cod_est], [fecha_reg]) VALUES (1, N'Manuel', 1, CAST(0x0000A40C00000000 AS DateTime))
INSERT [dbo].[tercero] ([cod_tercero], [nombre], [cod_est], [fecha_reg]) VALUES (2, N'Maria', 1, CAST(0x0000A40C00000000 AS DateTime))
INSERT [dbo].[tercero] ([cod_tercero], [nombre], [cod_est], [fecha_reg]) VALUES (3, N'Pedro', 1, CAST(0x0000A40C00000000 AS DateTime))
INSERT [dbo].[tercero] ([cod_tercero], [nombre], [cod_est], [fecha_reg]) VALUES (4, N'Eduardo', 1, CAST(0x0000A40C00000000 AS DateTime))
INSERT [dbo].[tercero] ([cod_tercero], [nombre], [cod_est], [fecha_reg]) VALUES (5, N'Luis', 1, CAST(0x0000A40C00000000 AS DateTime))
INSERT [dbo].[tercero] ([cod_tercero], [nombre], [cod_est], [fecha_reg]) VALUES (6, N'Anastasia', 1, CAST(0x0000A40C00000000 AS DateTime))
INSERT [dbo].[tercero] ([cod_tercero], [nombre], [cod_est], [fecha_reg]) VALUES (12, N'Mario', 1, CAST(0x0000A40C00000000 AS DateTime))
/****** Object:  Table [dbo].[descuento]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[descuento](
	[cod_desc] [int] NOT NULL,
	[porciento] [float] NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_desc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datos_sesiones]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[datos_sesiones](
	[cod_audit] [int] NOT NULL,
	[usuario] [varchar](50) NULL,
	[fec_ent] [datetime] NULL,
	[fec_sal] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_audit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[area]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[area](
	[cod_area] [int] NOT NULL,
	[descripcion] [varchar](25) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_area] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[almacen]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[almacen](
	[cod_alm] [int] NOT NULL,
	[descrip] [varchar](30) NULL,
	[cod_est] [int] NULL,
	[fec_reg] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_alm] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[cod_categ] [int] NOT NULL,
	[descrip] [varchar](25) NULL,
	[fec_reg] [datetime] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_categ] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vehiculo]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vehiculo](
	[cod_veh] [int] NOT NULL,
	[fec_reg] [datetime] NULL,
	[otros_det] [varchar](100) NULL,
	[cod_marca] [int] NULL,
	[cod_modelo] [int] NULL,
	[cod_estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_veh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[vehiculo] ([cod_veh], [fec_reg], [otros_det], [cod_marca], [cod_modelo], [cod_estado]) VALUES (1, NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[articulos]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[articulos](
	[cod_art] [int] NOT NULL,
	[descrip] [varchar](50) NULL,
	[cod_categ] [int] NULL,
	[cod_alm] [int] NULL,
	[costo] [float] NULL,
	[precio_unidad] [float] NULL,
	[precio_m] [float] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_art] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cod_tercero] [int] NULL,
	[cod_cli] [int] NOT NULL,
	[apellido] [varchar](50) NULL,
	[ced_cli] [varchar](13) NULL,
	[correo] [varchar](50) NULL,
	[cel_cli] [varchar](12) NULL,
	[tel_cli] [varchar](12) NULL,
	[dir_cli] [varchar](50) NULL,
	[fec_reg] [datetime] NULL,
	[cod_estado] [int] NULL,
	[ncf] [varchar](20) NULL,
	[rnc] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[cliente] ([cod_tercero], [cod_cli], [apellido], [ced_cli], [correo], [cel_cli], [tel_cli], [dir_cli], [fec_reg], [cod_estado], [ncf], [rnc]) VALUES (1, 1, N'Lopez', N'402-2154030-1', N'elvin_resyes01@hotmail.com', N'809-212-5901', N'849-212-5901', N'la vega', CAST(0x0000A40C00000000 AS DateTime), 1, N'A01001001020178615', N'401052611')
INSERT [dbo].[cliente] ([cod_tercero], [cod_cli], [apellido], [ced_cli], [correo], [cel_cli], [tel_cli], [dir_cli], [fec_reg], [cod_estado], [ncf], [rnc]) VALUES (2, 2, N'Vargas', N'402-2154030-1', N'elvin_resyes01@hotmail.com', N'809-212-5901', N'849-212-5901', N'la vega', CAST(0x0000A40C00000000 AS DateTime), 1, N'A01001001020178613', N'401052611')
INSERT [dbo].[cliente] ([cod_tercero], [cod_cli], [apellido], [ced_cli], [correo], [cel_cli], [tel_cli], [dir_cli], [fec_reg], [cod_estado], [ncf], [rnc]) VALUES (3, 3, N'Cabrera', N'402-2154030-1', N'elvin_resyes01@hotmail.com', N'809-212-5901', N'849-212-5901', N'la vega', CAST(0x0000A40C00000000 AS DateTime), 1, N'A01001001020178615', N'401052611')
INSERT [dbo].[cliente] ([cod_tercero], [cod_cli], [apellido], [ced_cli], [correo], [cel_cli], [tel_cli], [dir_cli], [fec_reg], [cod_estado], [ncf], [rnc]) VALUES (4, 4, N'Reyes', N'402-2154030-1', N'elvin_resyes01@hotmail.com', N'809-212-5901', N'849-212-5901', N'la vega', CAST(0x0000A40C00000000 AS DateTime), 1, N'A01001001020178593', N'401052611')
INSERT [dbo].[cliente] ([cod_tercero], [cod_cli], [apellido], [ced_cli], [correo], [cel_cli], [tel_cli], [dir_cli], [fec_reg], [cod_estado], [ncf], [rnc]) VALUES (5, 5, N'Cespedes', N'402-2154030-1', N'elvin_resyes01@hotmail.com', N'809-212-5901', N'849-212-5901', N'la vega', CAST(0x0000A40C00000000 AS DateTime), 1, N'A01001001020171593', N'401052611')
/****** Object:  Table [dbo].[suplidor]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[suplidor](
	[cod_sup] [int] NOT NULL,
	[cod_tercero] [int] NULL,
	[ape_sup] [varchar](50) NULL,
	[nom_rep] [varchar](50) NULL,
	[cod_rnc] [varchar](15) NULL,
	[cel_rep] [varchar](12) NULL,
	[tel_sup] [varchar](12) NULL,
	[dir_sup] [varchar](100) NULL,
	[fec_reg] [datetime] NULL,
	[correo] [varchar](50) NULL,
	[fax_sup] [varchar](12) NULL,
	[cod_estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_sup] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empresa](
	[cod_emp] [int] NOT NULL,
	[cod_tercero] [int] NULL,
	[dir_emp] [varchar](100) NULL,
	[tel_emp] [varchar](12) NULL,
	[correo] [varchar](50) NULL,
	[fec_reg] [datetime] NULL,
	[fax_emp] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_emp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleado](
	[cod_emp] [int] NOT NULL,
	[cod_tercero] [int] NULL,
	[ape_emp] [varchar](50) NULL,
	[dir_emp] [varchar](50) NULL,
	[ced_emp] [varchar](13) NULL,
	[cel_emp] [varchar](12) NULL,
	[cod_area] [int] NULL,
	[fec_ing] [datetime] NULL,
	[cod_est] [int] NULL,
	[correo] [varchar](100) NULL,
	[cod_estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_emp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gastos]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gastos](
	[cod_gasto] [int] NOT NULL,
	[concepto] [varchar](50) NULL,
	[valor] [float] NULL,
	[fec_reg] [datetime] NULL,
	[cod_sup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_gasto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[factura]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[factura](
	[cod_fact] [int] NOT NULL,
	[fec_fact] [datetime] NULL,
	[cod_cli] [int] NULL,
	[cod_est] [int] NULL,
	[cod_ncf] [varchar](18) NULL,
	[cod_rnc] [varchar](15) NULL,
	[desc_fact] [float] NULL,
	[tipo_pago] [int] NULL,
	[subtotal] [float] NULL,
	[total] [float] NULL,
	[cod_itbis] [int] NULL,
	[usuario] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_fact] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[factura] ([cod_fact], [fec_fact], [cod_cli], [cod_est], [cod_ncf], [cod_rnc], [desc_fact], [tipo_pago], [subtotal], [total], [cod_itbis], [usuario]) VALUES (1, CAST(0x0000A39100000000 AS DateTime), 1, 1, N'402-2154030-1', N'402-2154030-1', 5, 1, 2500, 3000, 18, NULL)
INSERT [dbo].[factura] ([cod_fact], [fec_fact], [cod_cli], [cod_est], [cod_ncf], [cod_rnc], [desc_fact], [tipo_pago], [subtotal], [total], [cod_itbis], [usuario]) VALUES (2, CAST(0x0000A39200B196E4 AS DateTime), 1, 1, N'A01001001020178615', N'401052611', 0, 1, 7500, 8850, 18, N'elvin')
INSERT [dbo].[factura] ([cod_fact], [fec_fact], [cod_cli], [cod_est], [cod_ncf], [cod_rnc], [desc_fact], [tipo_pago], [subtotal], [total], [cod_itbis], [usuario]) VALUES (3, CAST(0x0000A39200B224B0 AS DateTime), 1, 1, N'A01001001020178615', N'401052611', 0, 1, 6400, 7552, 18, N'elvin')
INSERT [dbo].[factura] ([cod_fact], [fec_fact], [cod_cli], [cod_est], [cod_ncf], [cod_rnc], [desc_fact], [tipo_pago], [subtotal], [total], [cod_itbis], [usuario]) VALUES (4, CAST(0x0000A392014B6008 AS DateTime), 1, 1, N'A01001001020178615', N'401052611', 0, 1, 3500, 4130, 18, N'elvin')
INSERT [dbo].[factura] ([cod_fact], [fec_fact], [cod_cli], [cod_est], [cod_ncf], [cod_rnc], [desc_fact], [tipo_pago], [subtotal], [total], [cod_itbis], [usuario]) VALUES (5, CAST(0x0000A392014D6984 AS DateTime), 1, 1, N'', N'401052611', 0, 1, 1500, 1770, 18, N'elvin')
INSERT [dbo].[factura] ([cod_fact], [fec_fact], [cod_cli], [cod_est], [cod_ncf], [cod_rnc], [desc_fact], [tipo_pago], [subtotal], [total], [cod_itbis], [usuario]) VALUES (6, CAST(0x0000A3930011C9E8 AS DateTime), 1, 1, N'A01001001020178615', N'401052611', 0, 1, 4400, 5192, 18, N'elvin')
/****** Object:  Table [dbo].[existencia]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[existencia](
	[cod_alm] [int] NULL,
	[cod_art] [int] NULL,
	[costo_prom] [float] NULL,
	[cant] [int] NULL,
	[cod_und] [int] NULL,
	[precio_v] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[movimiento]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movimiento](
	[num_mov] [int] NOT NULL,
	[cod_alm] [int] NULL,
	[cod_sup] [int] NULL,
	[cod_tipo_mov] [int] NULL,
	[cod_cif] [int] NULL,
	[fec_mov] [datetime] NULL,
	[total] [float] NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[num_mov] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cxp]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cxp](
	[cod_cp] [int] NOT NULL,
	[cod_sup] [int] NULL,
	[monto_cp] [int] NULL,
	[fec_adq] [datetime] NULL,
	[fec_venc] [datetime] NULL,
	[con_cp] [varchar](100) NULL,
	[cod_est] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cxc]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cxc](
	[cod_cc] [int] NOT NULL,
	[cod_cli] [int] NULL,
	[monto_cc] [int] NULL,
	[fec_adq] [datetime] NULL,
	[fec_venc] [datetime] NULL,
	[con_cc] [varchar](100) NULL,
	[cod_estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[recepcion]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[recepcion](
	[cod_recep] [int] NOT NULL,
	[cod_veh] [int] NULL,
	[cod_cli] [int] NULL,
	[nom_contacto] [varchar](50) NULL,
	[cel_contacto] [varchar](12) NULL,
	[fecha_rec] [datetime] NULL,
	[fec_ent] [datetime] NULL,
	[color_veh] [varchar](15) NULL,
	[tipo_veh] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_recep] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[recepcion] ([cod_recep], [cod_veh], [cod_cli], [nom_contacto], [cel_contacto], [fecha_rec], [fec_ent], [color_veh], [tipo_veh]) VALUES (1, 1, 1, N'809-212-5901', N'809-212-5901', CAST(0x0000A40C00000000 AS DateTime), CAST(0x0000A40B00000000 AS DateTime), N'negro', N'carro')
INSERT [dbo].[recepcion] ([cod_recep], [cod_veh], [cod_cli], [nom_contacto], [cel_contacto], [fecha_rec], [fec_ent], [color_veh], [tipo_veh]) VALUES (2, 1, 2, N'809-212-5901', N'809-212-5901', CAST(0x0000A40C00000000 AS DateTime), CAST(0x0000A40C00000000 AS DateTime), N'negro', N'carro')
INSERT [dbo].[recepcion] ([cod_recep], [cod_veh], [cod_cli], [nom_contacto], [cel_contacto], [fecha_rec], [fec_ent], [color_veh], [tipo_veh]) VALUES (3, 1, 3, N'809-212-5901', N'809-212-5901', CAST(0x0000A40C00000000 AS DateTime), CAST(0x0000A40C00000000 AS DateTime), N'negro', N'carro')
INSERT [dbo].[recepcion] ([cod_recep], [cod_veh], [cod_cli], [nom_contacto], [cel_contacto], [fecha_rec], [fec_ent], [color_veh], [tipo_veh]) VALUES (4, 1, 4, N'809-212-5901', N'809-212-5901', CAST(0x0000A40C00000000 AS DateTime), CAST(0x0000A40C00000000 AS DateTime), N'negro', N'carro')
INSERT [dbo].[recepcion] ([cod_recep], [cod_veh], [cod_cli], [nom_contacto], [cel_contacto], [fecha_rec], [fec_ent], [color_veh], [tipo_veh]) VALUES (5, 1, 5, N'809-212-5901', N'809-212-5901', CAST(0x0000A40C00000000 AS DateTime), CAST(0x0000A40C00000000 AS DateTime), N'negro', N'carro')
/****** Object:  Table [dbo].[det_reparac]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[det_reparac](
	[cod_recep] [int] NULL,
	[det_reparac] [varchar](100) NULL,
	[precio] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pago_impuestos]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pago_impuestos](
	[cod_isr] [int] NOT NULL,
	[porciento] [float] NULL,
	[fec_reg] [datetime] NULL,
	[monto] [float] NULL,
	[cod_emp] [int] NULL,
	[cod_gasto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_isr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[est_reparac]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[est_reparac](
	[cod_recep] [int] NULL,
	[desrip_est] [varchar](20) NULL,
	[fec_est] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cotizacion]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cotizacion](
	[cod_cot] [int] NOT NULL,
	[cod_recep] [int] NULL,
	[cod_cli] [int] NULL,
	[fec_cot] [datetime] NULL,
	[subtotal] [float] NULL,
	[itbis] [float] NULL,
	[desc_cot] [float] NULL,
	[total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cot] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reparacion]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reparacion](
	[cod_recep] [int] NULL,
	[cod_veh] [int] NULL,
	[cod_cli] [int] NULL,
	[fec_rec] [datetime] NULL,
	[fec_ent] [datetime] NULL,
	[cod_est] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cierre_caja]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cierre_caja](
	[cod_cierre] [int] NOT NULL,
	[cod_fac] [int] NULL,
	[f_pago] [varchar](15) NULL,
	[total] [float] NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cierre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[devolucion_venta]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[devolucion_venta](
	[cod_dev] [int] NOT NULL,
	[cod_fact] [int] NULL,
	[cod_art] [int] NULL,
	[monto] [float] NULL,
	[fec_reg] [datetime] NULL,
	[observ] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_dev] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[devolucion_compra]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[devolucion_compra](
	[cod_dev] [int] NOT NULL,
	[cod_mov] [int] NULL,
	[cod_art] [int] NULL,
	[monto] [float] NULL,
	[fec_reg] [datetime] NULL,
	[observ] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_dev] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_movimiento]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_movimiento](
	[num_mov] [int] NULL,
	[cod_art] [int] NULL,
	[cant] [int] NULL,
	[cod_und] [int] NULL,
	[costo] [float] NULL,
	[itbis] [float] NULL,
	[precio_art] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detall_cot]    Script Date: 08/26/2014 02:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detall_cot](
	[cod_Cot] [int] NULL,
	[descrip_cot] [varchar](100) NULL,
	[pre_t] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK__almacen__cod_est__05D8E0BE]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[almacen]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__almacen__cod_est__6BE40491]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[almacen]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__area__cod_est__06CD04F7]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[area]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__area__cod_est__6CD828CA]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[area]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__articulos__cod_a__07C12930]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD FOREIGN KEY([cod_alm])
REFERENCES [dbo].[almacen] ([cod_alm])
GO
/****** Object:  ForeignKey [FK__articulos__cod_a__6DCC4D03]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD FOREIGN KEY([cod_alm])
REFERENCES [dbo].[almacen] ([cod_alm])
GO
/****** Object:  ForeignKey [FK__articulos__cod_c__08B54D69]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD FOREIGN KEY([cod_categ])
REFERENCES [dbo].[categoria] ([cod_categ])
GO
/****** Object:  ForeignKey [FK__articulos__cod_c__6EC0713C]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD FOREIGN KEY([cod_categ])
REFERENCES [dbo].[categoria] ([cod_categ])
GO
/****** Object:  ForeignKey [FK__articulos__cod_e__09A971A2]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__articulos__cod_e__6FB49575]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__categoria__cod_e__0A9D95DB]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[categoria]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__categoria__cod_e__70A8B9AE]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[categoria]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__cierre_ca__cod_f__0B91BA14]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cierre_caja]  WITH CHECK ADD FOREIGN KEY([cod_fac])
REFERENCES [dbo].[factura] ([cod_fact])
GO
/****** Object:  ForeignKey [FK__cierre_ca__cod_f__719CDDE7]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cierre_caja]  WITH CHECK ADD FOREIGN KEY([cod_fac])
REFERENCES [dbo].[factura] ([cod_fact])
GO
/****** Object:  ForeignKey [FK__cliente__cod_est__0C85DE4D]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__cliente__cod_est__72910220]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__cliente__cod_ter__0D7A0286]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__cliente__cod_ter__73852659]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__cotizacio__cod_c__0E6E26BF]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__cotizacio__cod_c__74794A92]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__cotizacio__cod_r__0F624AF8]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__cotizacio__cod_r__756D6ECB]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__cxc__cod_cli__10566F31]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxc]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__cxc__cod_cli__76619304]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxc]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__cxc__cod_estado__114A936A]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxc]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__cxc__cod_estado__7755B73D]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxc]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__cxp__cod_est__123EB7A3]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxp]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__cxp__cod_est__7849DB76]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxp]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__cxp__cod_sup__1332DBDC]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxp]  WITH CHECK ADD FOREIGN KEY([cod_sup])
REFERENCES [dbo].[suplidor] ([cod_sup])
GO
/****** Object:  ForeignKey [FK__cxp__cod_sup__793DFFAF]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[cxp]  WITH CHECK ADD FOREIGN KEY([cod_sup])
REFERENCES [dbo].[suplidor] ([cod_sup])
GO
/****** Object:  ForeignKey [FK__datos_ses__usuar__14270015]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[datos_sesiones]  WITH CHECK ADD FOREIGN KEY([usuario])
REFERENCES [dbo].[usuarios] ([usuario])
GO
/****** Object:  ForeignKey [FK__datos_ses__usuar__7A3223E8]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[datos_sesiones]  WITH CHECK ADD FOREIGN KEY([usuario])
REFERENCES [dbo].[usuarios] ([usuario])
GO
/****** Object:  ForeignKey [FK__descuento__cod_e__151B244E]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[descuento]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__descuento__cod_e__7B264821]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[descuento]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__det_repar__cod_r__17036CC0]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[det_reparac]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__det_repar__cod_r__7D0E9093]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[det_reparac]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__detall_co__cod_C__17F790F9]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detall_cot]  WITH CHECK ADD FOREIGN KEY([cod_Cot])
REFERENCES [dbo].[cotizacion] ([cod_cot])
GO
/****** Object:  ForeignKey [FK__detall_co__cod_C__7E02B4CC]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detall_cot]  WITH CHECK ADD FOREIGN KEY([cod_Cot])
REFERENCES [dbo].[cotizacion] ([cod_cot])
GO
/****** Object:  ForeignKey [FK__detalle_m__cod_a__18EBB532]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detalle_movimiento]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__detalle_m__cod_a__7EF6D905]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detalle_movimiento]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__detalle_m__cod_u__19DFD96B]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detalle_movimiento]  WITH CHECK ADD FOREIGN KEY([cod_und])
REFERENCES [dbo].[unidades] ([cod_unidad])
GO
/****** Object:  ForeignKey [FK__detalle_m__cod_u__7FEAFD3E]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detalle_movimiento]  WITH CHECK ADD FOREIGN KEY([cod_und])
REFERENCES [dbo].[unidades] ([cod_unidad])
GO
/****** Object:  ForeignKey [FK__detalle_m__num_m__00DF2177]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detalle_movimiento]  WITH CHECK ADD FOREIGN KEY([num_mov])
REFERENCES [dbo].[movimiento] ([num_mov])
GO
/****** Object:  ForeignKey [FK__detalle_m__num_m__1AD3FDA4]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[detalle_movimiento]  WITH CHECK ADD FOREIGN KEY([num_mov])
REFERENCES [dbo].[movimiento] ([num_mov])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_a__01D345B0]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_compra]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_a__1BC821DD]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_compra]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_m__02C769E9]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_compra]  WITH CHECK ADD FOREIGN KEY([cod_mov])
REFERENCES [dbo].[movimiento] ([num_mov])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_m__1CBC4616]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_compra]  WITH CHECK ADD FOREIGN KEY([cod_mov])
REFERENCES [dbo].[movimiento] ([num_mov])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_a__03BB8E22]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_venta]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_a__1DB06A4F]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_venta]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_f__04AFB25B]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_venta]  WITH CHECK ADD FOREIGN KEY([cod_fact])
REFERENCES [dbo].[factura] ([cod_fact])
GO
/****** Object:  ForeignKey [FK__devolucio__cod_f__1EA48E88]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[devolucion_venta]  WITH CHECK ADD FOREIGN KEY([cod_fact])
REFERENCES [dbo].[factura] ([cod_fact])
GO
/****** Object:  ForeignKey [FK__empleado__cod_ar__05A3D694]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_area])
REFERENCES [dbo].[area] ([cod_area])
GO
/****** Object:  ForeignKey [FK__empleado__cod_ar__1F98B2C1]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_area])
REFERENCES [dbo].[area] ([cod_area])
GO
/****** Object:  ForeignKey [FK__empleado__cod_es__0697FACD]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__empleado__cod_es__078C1F06]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__empleado__cod_es__208CD6FA]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__empleado__cod_es__2180FB33]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__empleado__cod_te__0880433F]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__empleado__cod_te__22751F6C]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__empresa__cod_ter__09746778]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empresa]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__empresa__cod_ter__236943A5]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[empresa]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__est_repar__cod_r__0A688BB1]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[est_reparac]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__est_repar__cod_r__245D67DE]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[est_reparac]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__existenci__cod_a__0B5CAFEA]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[existencia]  WITH CHECK ADD FOREIGN KEY([cod_alm])
REFERENCES [dbo].[almacen] ([cod_alm])
GO
/****** Object:  ForeignKey [FK__existenci__cod_a__0C50D423]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[existencia]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__existenci__cod_a__25518C17]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[existencia]  WITH CHECK ADD FOREIGN KEY([cod_alm])
REFERENCES [dbo].[almacen] ([cod_alm])
GO
/****** Object:  ForeignKey [FK__existenci__cod_a__2645B050]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[existencia]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulos] ([cod_art])
GO
/****** Object:  ForeignKey [FK__existenci__cod_u__0D44F85C]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[existencia]  WITH CHECK ADD FOREIGN KEY([cod_und])
REFERENCES [dbo].[unidades] ([cod_unidad])
GO
/****** Object:  ForeignKey [FK__existenci__cod_u__2739D489]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[existencia]  WITH CHECK ADD FOREIGN KEY([cod_und])
REFERENCES [dbo].[unidades] ([cod_unidad])
GO
/****** Object:  ForeignKey [FK__factura__cod_cli__0E391C95]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__factura__cod_cli__282DF8C2]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__factura__cod_est__0F2D40CE]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__factura__cod_est__29221CFB]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__gastos__cod_sup__10216507]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[gastos]  WITH CHECK ADD FOREIGN KEY([cod_sup])
REFERENCES [dbo].[suplidor] ([cod_sup])
GO
/****** Object:  ForeignKey [FK__gastos__cod_sup__2A164134]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[gastos]  WITH CHECK ADD FOREIGN KEY([cod_sup])
REFERENCES [dbo].[suplidor] ([cod_sup])
GO
/****** Object:  ForeignKey [FK__itbis__cod_est__11158940]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[itbis]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__itbis__cod_est__2B0A656D]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[itbis]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__marca__cod_est__1209AD79]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[marca]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__marca__cod_est__2BFE89A6]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[marca]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__modelo__cod_est__12FDD1B2]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[modelo]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__modelo__cod_est__2CF2ADDF]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[modelo]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__movimient__cod_a__13F1F5EB]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_alm])
REFERENCES [dbo].[almacen] ([cod_alm])
GO
/****** Object:  ForeignKey [FK__movimient__cod_a__2DE6D218]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_alm])
REFERENCES [dbo].[almacen] ([cod_alm])
GO
/****** Object:  ForeignKey [FK__movimient__cod_c__14E61A24]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_cif])
REFERENCES [dbo].[cif] ([cod_cif])
GO
/****** Object:  ForeignKey [FK__movimient__cod_c__2EDAF651]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_cif])
REFERENCES [dbo].[cif] ([cod_cif])
GO
/****** Object:  ForeignKey [FK__movimient__cod_e__15DA3E5D]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__movimient__cod_e__2FCF1A8A]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__movimient__cod_s__16CE6296]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_sup])
REFERENCES [dbo].[suplidor] ([cod_sup])
GO
/****** Object:  ForeignKey [FK__movimient__cod_s__30C33EC3]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_sup])
REFERENCES [dbo].[suplidor] ([cod_sup])
GO
/****** Object:  ForeignKey [FK__movimient__cod_t__17C286CF]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_tipo_mov])
REFERENCES [dbo].[tipo_movimiento] ([cod_tipo_mov])
GO
/****** Object:  ForeignKey [FK__movimient__cod_t__31B762FC]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[movimiento]  WITH CHECK ADD FOREIGN KEY([cod_tipo_mov])
REFERENCES [dbo].[tipo_movimiento] ([cod_tipo_mov])
GO
/****** Object:  ForeignKey [FK__pago_impu__cod_e__18B6AB08]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[pago_impuestos]  WITH CHECK ADD FOREIGN KEY([cod_emp])
REFERENCES [dbo].[empresa] ([cod_emp])
GO
/****** Object:  ForeignKey [FK__pago_impu__cod_e__32AB8735]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[pago_impuestos]  WITH CHECK ADD FOREIGN KEY([cod_emp])
REFERENCES [dbo].[empresa] ([cod_emp])
GO
/****** Object:  ForeignKey [FK__pago_impu__cod_g__19AACF41]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[pago_impuestos]  WITH CHECK ADD FOREIGN KEY([cod_gasto])
REFERENCES [dbo].[gastos] ([cod_gasto])
GO
/****** Object:  ForeignKey [FK__pago_impu__cod_g__339FAB6E]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[pago_impuestos]  WITH CHECK ADD FOREIGN KEY([cod_gasto])
REFERENCES [dbo].[gastos] ([cod_gasto])
GO
/****** Object:  ForeignKey [FK__recepcion__cod_c__1A9EF37A]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[recepcion]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__recepcion__cod_c__3493CFA7]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[recepcion]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__recepcion__cod_v__1B9317B3]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[recepcion]  WITH CHECK ADD FOREIGN KEY([cod_veh])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
/****** Object:  ForeignKey [FK__recepcion__cod_v__3587F3E0]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[recepcion]  WITH CHECK ADD FOREIGN KEY([cod_veh])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_c__1C873BEC]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_c__367C1819]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_e__1D7B6025]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_e__37703C52]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_r__1E6F845E]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_r__3864608B]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_recep])
REFERENCES [dbo].[recepcion] ([cod_recep])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_v__1F63A897]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_veh])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
/****** Object:  ForeignKey [FK__reparacio__cod_v__395884C4]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[reparacion]  WITH CHECK ADD FOREIGN KEY([cod_veh])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
/****** Object:  ForeignKey [FK__suplidor__cod_es__2057CCD0]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[suplidor]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__suplidor__cod_es__3A4CA8FD]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[suplidor]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__suplidor__cod_te__214BF109]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[suplidor]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__suplidor__cod_te__3B40CD36]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[suplidor]  WITH CHECK ADD FOREIGN KEY([cod_tercero])
REFERENCES [dbo].[tercero] ([cod_tercero])
GO
/****** Object:  ForeignKey [FK__tercero__cod_est__22401542]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tercero]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__tercero__cod_est__3C34F16F]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tercero]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__tipo_movi__cod_e__2334397B]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tipo_movimiento]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__tipo_movi__cod_e__3D2915A8]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tipo_movimiento]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__tipo_pago__cod_e__24285DB4]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tipo_pago]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__tipo_pago__cod_e__3E1D39E1]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tipo_pago]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__tipo_usua__cod_e__251C81ED]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tipo_usuario]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__tipo_usua__cod_e__3F115E1A]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[tipo_usuario]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__trabajos__cod_es__2610A626]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[trabajos]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__trabajos__cod_es__40058253]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[trabajos]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__unidades__cod_es__2704CA5F]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[unidades]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__unidades__cod_es__40F9A68C]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[unidades]  WITH CHECK ADD FOREIGN KEY([cod_est])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_es__27F8EE98]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_es__41EDCAC5]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_estado])
REFERENCES [dbo].[estado] ([cod_est])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_ma__28ED12D1]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_marca])
REFERENCES [dbo].[marca] ([cod_marca])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_ma__42E1EEFE]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_marca])
REFERENCES [dbo].[marca] ([cod_marca])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_mo__29E1370A]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_modelo])
REFERENCES [dbo].[modelo] ([cod_modelo])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_mo__43D61337]    Script Date: 08/26/2014 02:10:54 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_modelo])
REFERENCES [dbo].[modelo] ([cod_modelo])
GO
