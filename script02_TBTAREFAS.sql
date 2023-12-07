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

