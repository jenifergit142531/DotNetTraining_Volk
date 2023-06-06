
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/05/2023 03:13:58
-- Generated from EDMX file: C:\Users\JeniferY\May_Vd\CoreMVC1\ModelfirstApproach\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbapproach];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Author] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BookInventories'
CREATE TABLE [dbo].[BookInventories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Quantity] nvarchar(max)  NOT NULL,
    [BookId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookInventories'
ALTER TABLE [dbo].[BookInventories]
ADD CONSTRAINT [PK_BookInventories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BookId] in table 'BookInventories'
ALTER TABLE [dbo].[BookInventories]
ADD CONSTRAINT [FK_BookBookInventory]
    FOREIGN KEY ([BookId])
    REFERENCES [dbo].[Books]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookBookInventory'
CREATE INDEX [IX_FK_BookBookInventory]
ON [dbo].[BookInventories]
    ([BookId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------