USE [ProductsDb]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 16.12.2021 16:36:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
	[Sales] [nvarchar](50) NOT NULL,
	[SellerID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Smartphones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Smartphones_dbo.Sellers_SellerID] FOREIGN KEY([SellerID])
REFERENCES [dbo].[Sellers] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_dbo.Smartphones_dbo.Sellers_SellerID]
GO

