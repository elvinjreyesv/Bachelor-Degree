USE [repuesto]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[cod_usu] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[login] [varchar](50) NULL,
	[clave] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_usu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[usuario] ([cod_usu], [nombre], [login], [clave]) VALUES (1, N'Elvin Reyes', N'elvin', N'1110145')
/****** Object:  Table [dbo].[transmision]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transmision](
	[cod_tran] [int] NOT NULL,
	[descrip_tran] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_tran] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_veh]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_veh](
	[cod_tipo] [int] NOT NULL,
	[descrip_tipo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_suplidor]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_suplidor](
	[cod_tip_sup] [int] NOT NULL,
	[descrip] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_tip_sup] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tercero]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tercero](
	[cod_ter] [int] NOT NULL,
	[des_ent] [varchar](100) NULL,
	[estado] [varchar](50) NULL,
	[fec_reg] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_ter] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[cod_cat] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[articulo]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[articulo](
	[cod_art] [int] NOT NULL,
	[descrip] [varchar](50) NULL,
	[prec_com] [varchar](50) NULL,
	[prec_ven] [varchar](50) NULL,
	[almacen] [varchar](50) NULL,
	[canexi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_art] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[descuento]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[descuento](
	[cod_des] [int] NOT NULL,
	[porc] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_des] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[departamento](
	[cod_dep] [int] NOT NULL,
	[descrip_dep] [varchar](50) NULL,
	[puesto] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_dep] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[combustible]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[combustible](
	[cod_com] [int] NOT NULL,
	[descrip_com] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_com] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[color]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[color](
	[cod_color] [int] NOT NULL,
	[descrip] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_color] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[recomendaciones]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[recomendaciones](
	[cod_recom] [int] NOT NULL,
	[descrip] [varchar](200) NULL,
	[fec_reg] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_recom] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modelo]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modelo](
	[cod_model] [int] NOT NULL,
	[descrip_model] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_model] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[marca]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marca](
	[cod_mar] [int] NOT NULL,
	[descrip_mar] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_mar] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[cod_art] [int] NULL,
	[can_exi] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historial_acceso]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historial_acceso](
	[cod_usu] [int] NULL,
	[fec_ent] [datetime] NULL,
	[fec_sal] [datetime] NULL,
	[cod_hist] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_hist] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empresa](
	[cod_ter] [int] NULL,
	[nombre] [varchar](100) NULL,
	[rnc] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empleados](
	[cod_ter] [int] NULL,
	[apellidos] [varchar](50) NULL,
	[fecing] [datetime] NULL,
	[fecin] [datetime] NULL,
	[cod_dep] [int] NULL,
	[estado] [varchar](12) NULL,
	[cedula] [varchar](18) NULL,
	[correo] [varchar](50) NULL,
	[cel] [varchar](15) NULL,
	[cod_emp] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_emp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vehiculo]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vehiculo](
	[cod_veh] [int] NOT NULL,
	[cod_tipo] [int] NULL,
	[cod_mar] [int] NULL,
	[cod_model] [int] NULL,
	[cod_tran] [int] NULL,
	[cod_color] [int] NULL,
	[ano] [varchar](15) NULL,
	[cod_com] [int] NULL,
	[cod_cat] [int] NULL,
	[fec_reg] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_veh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[precio_venta]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[precio_venta](
	[cod_art] [int] NULL,
	[porc_gan] [varchar](12) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cod_cli] [int] NOT NULL,
	[cod_ter] [int] NULL,
	[apellido] [varchar](50) NULL,
	[cedula] [varchar](18) NULL,
	[ncf] [varchar](30) NULL,
	[correo] [varchar](50) NULL,
	[cel] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[suplidor]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[suplidor](
	[cod_sup] [int] NOT NULL,
	[cod_ter] [int] NULL,
	[cod_tip_sup] [int] NULL,
	[rnc] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_sup] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[riesgos]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[riesgos](
	[cod_riesgo] [int] NOT NULL,
	[descrip] [varchar](200) NULL,
	[fec_reg] [datetime] NULL,
	[cod_veh] [int] NULL,
	[cod_art] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_riesgo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cotizacion]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cotizacion](
	[num_cot] [int] NOT NULL,
	[cod_cli] [int] NULL,
	[cod_usu] [int] NULL,
	[fec_cot] [datetime] NULL,
	[estado] [varchar](50) NULL,
	[totalitbis] [varchar](50) NULL,
	[totaldesc] [varchar](50) NULL,
	[cod_veh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[num_cot] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[art_vs_sup]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[art_vs_sup](
	[cod_art] [int] NULL,
	[cod_sup] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vehiculo_vs_articulo]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculo_vs_articulo](
	[cod_veh] [int] NULL,
	[cod_art] [int] NULL,
	[fec_reg] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[recomend_vs_riesgo]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recomend_vs_riesgo](
	[cod_recom] [int] NULL,
	[cod_riesgo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_cot]    Script Date: 08/21/2014 01:56:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalle_cot](
	[num_cot] [int] NULL,
	[descripcion] [varchar](50) NULL,
	[cant] [int] NULL,
	[precio] [varchar](20) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK__art_vs_su__cod_a__6E01572D]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[art_vs_sup]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulo] ([cod_art])
GO
/****** Object:  ForeignKey [FK__art_vs_su__cod_s__6EF57B66]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[art_vs_sup]  WITH CHECK ADD FOREIGN KEY([cod_sup])
REFERENCES [dbo].[suplidor] ([cod_sup])
GO
/****** Object:  ForeignKey [FK__cliente__cod_ter__0CBAE877]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD FOREIGN KEY([cod_ter])
REFERENCES [dbo].[tercero] ([cod_ter])
GO
/****** Object:  ForeignKey [FK__cotizacio__cod_c__4316F928]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
/****** Object:  ForeignKey [FK__cotizacio__cod_u__440B1D61]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD FOREIGN KEY([cod_usu])
REFERENCES [dbo].[usuario] ([cod_usu])
GO
/****** Object:  ForeignKey [FK__cotizacio__cod_v__74AE54BC]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[cotizacion]  WITH CHECK ADD FOREIGN KEY([cod_veh])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
/****** Object:  ForeignKey [FK__detalle_c__num_c__45F365D3]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[detalle_cot]  WITH CHECK ADD FOREIGN KEY([num_cot])
REFERENCES [dbo].[cotizacion] ([num_cot])
GO
/****** Object:  ForeignKey [FK__empleados__cod_d__38996AB5]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD FOREIGN KEY([cod_dep])
REFERENCES [dbo].[departamento] ([cod_dep])
GO
/****** Object:  ForeignKey [FK__empleados__cod_t__37A5467C]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD FOREIGN KEY([cod_ter])
REFERENCES [dbo].[tercero] ([cod_ter])
GO
/****** Object:  ForeignKey [FK__empresa__cod_ter__3A81B327]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[empresa]  WITH CHECK ADD FOREIGN KEY([cod_ter])
REFERENCES [dbo].[tercero] ([cod_ter])
GO
/****** Object:  ForeignKey [FK__historial__cod_u__48CFD27E]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[historial_acceso]  WITH CHECK ADD FOREIGN KEY([cod_usu])
REFERENCES [dbo].[usuario] ([cod_usu])
GO
/****** Object:  ForeignKey [FK__inventari__cod_a__4AB81AF0]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulo] ([cod_art])
GO
/****** Object:  ForeignKey [FK__precio_ve__cod_a__4CA06362]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[precio_venta]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulo] ([cod_art])
GO
/****** Object:  ForeignKey [FK__recomend___cod_r__656C112C]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[recomend_vs_riesgo]  WITH CHECK ADD FOREIGN KEY([cod_recom])
REFERENCES [dbo].[recomendaciones] ([cod_recom])
GO
/****** Object:  ForeignKey [FK__recomend___cod_r__66603565]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[recomend_vs_riesgo]  WITH CHECK ADD FOREIGN KEY([cod_riesgo])
REFERENCES [dbo].[riesgos] ([cod_riesgo])
GO
/****** Object:  ForeignKey [FK__riesgos__cod_art__70DDC3D8]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[riesgos]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
/****** Object:  ForeignKey [FK__riesgos__cod_veh__6FE99F9F]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[riesgos]  WITH CHECK ADD FOREIGN KEY([cod_veh])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
/****** Object:  ForeignKey [FK__suplidor__cod_te__6B24EA82]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[suplidor]  WITH CHECK ADD FOREIGN KEY([cod_ter])
REFERENCES [dbo].[tercero] ([cod_ter])
GO
/****** Object:  ForeignKey [FK__suplidor__cod_ti__6C190EBB]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[suplidor]  WITH CHECK ADD FOREIGN KEY([cod_tip_sup])
REFERENCES [dbo].[tipo_suplidor] ([cod_tip_sup])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_ca__31EC6D26]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_cat])
REFERENCES [dbo].[categoria] ([cod_cat])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_co__300424B4]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_color])
REFERENCES [dbo].[color] ([cod_color])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_co__30F848ED]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_com])
REFERENCES [dbo].[combustible] ([cod_com])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_ma__2D27B809]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_mar])
REFERENCES [dbo].[marca] ([cod_mar])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_mo__2E1BDC42]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_model])
REFERENCES [dbo].[modelo] ([cod_model])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_ti__2C3393D0]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_tipo])
REFERENCES [dbo].[tipo_veh] ([cod_tipo])
GO
/****** Object:  ForeignKey [FK__vehiculo__cod_tr__2F10007B]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo]  WITH CHECK ADD FOREIGN KEY([cod_tran])
REFERENCES [dbo].[transmision] ([cod_tran])
GO
/****** Object:  ForeignKey [FK__vehiculo___cod_a__5629CD9C]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo_vs_articulo]  WITH CHECK ADD FOREIGN KEY([cod_art])
REFERENCES [dbo].[articulo] ([cod_art])
GO
/****** Object:  ForeignKey [FK__vehiculo___cod_v__5535A963]    Script Date: 08/21/2014 01:56:34 ******/
ALTER TABLE [dbo].[vehiculo_vs_articulo]  WITH CHECK ADD FOREIGN KEY([cod_veh])
REFERENCES [dbo].[vehiculo] ([cod_veh])
GO
