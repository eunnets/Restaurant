IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND  TABLE_NAME = 'Dish'))
BEGIN
    CREATE TABLE [dbo].[Dish] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(100) NOT NULL,
        [Image] nvarchar(100) NOT NULL,
        [Category] nvarchar(30) NOT NULL,
        [Label] nvarchar(30) NOT NULL,
        [Price] decimal NOT NULL,
        [Featured] bit NOT NULL,
        [Description] nvarchar(100) NOT NULL,
        [Created] datetime2 NOT NULL,
        [CreatedBy] nvarchar(100) NOT NULL,
        [Updated] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_Dish] PRIMARY KEY ([Id])
    );
END;
GO

IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND  TABLE_NAME = 'Comment'))
BEGIN
    CREATE TABLE [dbo].[Comment] (
        [Id] uniqueidentifier NOT NULL,
        [DishId] int NOT NULL,
        [Rating] int NOT NULL,
        [Contents] nvarchar(500) NOT NULL,
        [Created] datetime2 NOT NULL,
        [CreatedBy] nvarchar(100) NOT NULL,
        [Updated] datetime2 NOT NULL,
        [UpdatedBy] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_Comment] PRIMARY KEY ([Id])
    );
END;
GO