
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/09/2018 17:14:37
-- Generated from EDMX file: C:\Users\Dark-Heart\OneDrive\Documents\Visual Studio 2017\Projects\EMPLOI-ARASL\EMPLOI-ARASL\arasl.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ARASL];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Chomeurs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Chomeurs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Chomeurs'
CREATE TABLE [dbo].[Chomeurs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(max)  NOT NULL,
    [prenom] nvarchar(max)  NOT NULL,
    [dob] datetime  NULL,
    [villagenaiss] nvarchar(max)  NULL,
    [tel] nvarchar(max)  NOT NULL,
    [mail] nvarchar(max)  NOT NULL,
    [lieuresidenc] nvarchar(max)  NULL,
    [diplome] nvarchar(max)  NOT NULL,
    [formation] nvarchar(max)  NULL,
    [employe] bit  NULL,
    [actif] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Chomeurs'
ALTER TABLE [dbo].[Chomeurs]
ADD CONSTRAINT [PK_Chomeurs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------