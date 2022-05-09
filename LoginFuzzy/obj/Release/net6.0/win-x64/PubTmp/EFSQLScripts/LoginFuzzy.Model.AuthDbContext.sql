IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402111345_AddAuthentication')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220402111345_AddAuthentication', N'6.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402235330_Extend_IdentityUser')
BEGIN
    CREATE TABLE [Futbolista] (
        [IdFutbolista] int NOT NULL IDENTITY,
        [nombre] nvarchar(max) NULL,
        [altura] float NOT NULL,
        [peso] float NOT NULL,
        [musculatura] float NOT NULL,
        [velocidad] float NOT NULL,
        [resistencia] float NOT NULL,
        [agilidad] float NOT NULL,
        [confianza] float NOT NULL,
        [concentracion] float NOT NULL,
        [decisiones] float NOT NULL,
        [creatividad] float NOT NULL,
        [dribling] float NOT NULL,
        [pases] float NOT NULL,
        [DC] float NOT NULL,
        [DL] float NOT NULL,
        [PT] float NOT NULL,
        [MC] float NOT NULL,
        [FW] float NOT NULL,
        [Id] nvarchar(450) NULL,
        CONSTRAINT [PK_Futbolista] PRIMARY KEY ([IdFutbolista]),
        CONSTRAINT [FK_Futbolista_AspNetUsers_Id] FOREIGN KEY ([Id]) REFERENCES [AspNetUsers] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402235330_Extend_IdentityUser')
BEGIN
    CREATE INDEX [IX_Futbolista_Id] ON [Futbolista] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220402235330_Extend_IdentityUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220402235330_Extend_IdentityUser', N'6.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    ALTER TABLE [Futbolista] DROP CONSTRAINT [FK_Futbolista_AspNetUsers_Id];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'DC');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [DC];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'DL');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [DL];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'FW');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [FW];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'MC');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [MC];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'PT');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [PT];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'agilidad');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [agilidad];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'altura');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [altura];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'concentracion');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [concentracion];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'confianza');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [confianza];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'creatividad');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [creatividad];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'decisiones');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [decisiones];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'dribling');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [dribling];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'musculatura');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [musculatura];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'nombre');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [nombre];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'pases');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [pases];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'peso');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [peso];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'resistencia');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [resistencia];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    DECLARE @var17 sysname;
    SELECT @var17 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'velocidad');
    IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var17 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [velocidad];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    EXEC sp_rename N'[Futbolista].[Id]', N'ApplicationUserId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    EXEC sp_rename N'[Futbolista].[IX_Futbolista_Id]', N'IX_Futbolista_ApplicationUserId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    ALTER TABLE [Futbolista] ADD CONSTRAINT [FK_Futbolista_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403044840_Cambios_Tablas')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220403044840_Cambios_Tablas', N'6.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] DROP CONSTRAINT [FK_Futbolista_AspNetUsers_ApplicationUserId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    DROP INDEX [IX_Futbolista_ApplicationUserId] ON [Futbolista];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    DECLARE @var18 sysname;
    SELECT @var18 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Futbolista]') AND [c].[name] = N'ApplicationUserId');
    IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Futbolista] DROP CONSTRAINT [' + @var18 + '];');
    ALTER TABLE [Futbolista] DROP COLUMN [ApplicationUserId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [DC] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [DL] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [FW] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [Id] nvarchar(450) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [MC] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [PT] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [agilidad] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [altura] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [concentracion] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [confianza] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [creatividad] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [decisiones] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [dribling] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [musculatura] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [nombre] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [pases] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [peso] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [resistencia] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD [velocidad] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    CREATE INDEX [IX_Futbolista_Id] ON [Futbolista] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    ALTER TABLE [Futbolista] ADD CONSTRAINT [FK_Futbolista_AspNetUsers_Id] FOREIGN KEY ([Id]) REFERENCES [AspNetUsers] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220403045141_Cambios_AgergandoID')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220403045141_Cambios_AgergandoID', N'6.0.3');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220413023341_NuevoCampoFinalizacion')
BEGIN
    ALTER TABLE [Futbolista] ADD [finalizacion] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220413023341_NuevoCampoFinalizacion')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220413023341_NuevoCampoFinalizacion', N'6.0.3');
END;
GO

COMMIT;
GO

