
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/08/2018 14:17:26
-- Generated from EDMX file: c:\users\dark-heart\onedrive\documents\visual studio 2017\Projects\EMPLOI-ARASL\EMPLOI-ARASL\arasl.edmx
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


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Chomeurs'
CREATE TABLE [dbo].[Chomeurs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(max)  NOT NULL,
    [prenom] nvarchar(max)  NOT NULL,
    [dob] datetime  NOT NULL,
    [villagenaiss] nvarchar(max)  NOT NULL,
    [tel] int  NOT NULL,
    [mail] nvarchar(max)  NOT NULL,
    [lieuresidenc] nvarchar(max)  NOT NULL,
    [diplome] nvarchar(max)  NOT NULL,
    [formation] nvarchar(max)  NOT NULL,
    [employe] bit  NOT NULL,
    [actif] bit  NOT NULL
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