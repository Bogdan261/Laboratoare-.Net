
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/24/2020 11:49:32
-- Generated from EDMX file: C:\Users\Bogdan\source\repos\PostComment\PostComment\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Laborator6];
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

-- Creating table 'PostSet'
CREATE TABLE [dbo].[PostSet] (
    [PostId] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Domain] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'CommentSet'
CREATE TABLE [dbo].[CommentSet] (
    [CommentId] int IDENTITY(1,1) NOT NULL,
    [Text] nvarchar(max)  NOT NULL,
    [PostPostId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PostId] in table 'PostSet'
ALTER TABLE [dbo].[PostSet]
ADD CONSTRAINT [PK_PostSet]
    PRIMARY KEY CLUSTERED ([PostId] ASC);
GO

-- Creating primary key on [CommentId] in table 'CommentSet'
ALTER TABLE [dbo].[CommentSet]
ADD CONSTRAINT [PK_CommentSet]
    PRIMARY KEY CLUSTERED ([CommentId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PostPostId] in table 'CommentSet'
ALTER TABLE [dbo].[CommentSet]
ADD CONSTRAINT [FK_PostComment]
    FOREIGN KEY ([PostPostId])
    REFERENCES [dbo].[PostSet]
        ([PostId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PostComment'
CREATE INDEX [IX_FK_PostComment]
ON [dbo].[CommentSet]
    ([PostPostId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------