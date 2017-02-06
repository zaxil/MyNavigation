CREATE TABLE [dbo].[Addresses]
(
	[TraceId] INT NOT NULL PRIMARY KEY, 
    [DeparturePlace] NCHAR(50) NULL, 
    [DestinationPlace] NCHAR(50) NULL, 
    [CreateDate] DATETIME NULL
)
