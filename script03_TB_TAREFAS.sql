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

CREATE TABLE [TB_TAREFAS] (
    [IdTarefa] int NOT NULL IDENTITY,
    [DescTarefa] nvarchar(max) NULL,
    [StatusTarefa] bit NOT NULL,
    [DataCriacao] datetime2 NOT NULL,
    [NomeTarefa] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TB_TAREFAS] PRIMARY KEY ([IdTarefa])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231207194715_InitialCreate', N'7.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [TB_TAREFAS] ADD [TarefaClass] int NOT NULL DEFAULT 0;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231207201941_MigracaoTarefas', N'7.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdTarefa', N'DataCriacao', N'DescTarefa', N'NomeTarefa', N'StatusTarefa', N'TarefaClass') AND [object_id] = OBJECT_ID(N'[TB_TAREFAS]'))
    SET IDENTITY_INSERT [TB_TAREFAS] ON;
INSERT INTO [TB_TAREFAS] ([IdTarefa], [DataCriacao], [DescTarefa], [NomeTarefa], [StatusTarefa], [TarefaClass])
VALUES (1, '2023-12-07T17:35:39.5608357-03:00', N'Passear Com o Tobias no parque pois está um dia lindo', N'Passear com o Cachorro', CAST(0 AS bit), 1),
(2, '2023-12-07T17:35:39.5608360-03:00', N'Fazer o almoço para a mamãe', N'Fazer o almoço', CAST(0 AS bit), 2),
(3, '2023-12-07T17:35:39.5608361-03:00', N'Estudar para a prova de matemática', N'Estudar', CAST(0 AS bit), 3),
(4, '2023-12-07T17:35:39.5608363-03:00', N'Fazer o trabalho de história', N'Fazer o trabalho', CAST(0 AS bit), 4);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdTarefa', N'DataCriacao', N'DescTarefa', N'NomeTarefa', N'StatusTarefa', N'TarefaClass') AND [object_id] = OBJECT_ID(N'[TB_TAREFAS]'))
    SET IDENTITY_INSERT [TB_TAREFAS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231207203539_MigracaoTarefasFoi', N'7.0.4');
GO

COMMIT;
GO

