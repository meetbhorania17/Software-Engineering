CREATE TABLE [dbo].[productInformation] (
    [Ref.No.]                        INT            IDENTITY (1, 1) NOT NULL,
    [Company Name]                   NVARCHAR (MAX) NULL,
    [Software Name]                  NVARCHAR (50)  NULL,
    [Company Website ]               NVARCHAR (50)  NULL,
    [Company Established]            DATE           NULL,
    [Location Countries]             NVARCHAR (50)  NULL,
    [Location Cities]                NVARCHAR (50)  NULL,
    [Contact Telephone No.]          NVARCHAR (50)  NULL,
    [Address]                        NVARCHAR (MAX) NULL,
    [No. of Employee]                INT            NULL,
    [Internal Professional Services] NVARCHAR (50)  NULL,
    [Last Demo Date ]                DATE           NULL,
    [Last Reviewed Date]             DATE           NULL,
    [Business Areas]                 NVARCHAR (50)  NULL,
    [Modules]                        NVARCHAR (50)  NULL,
    [Financial Service Client Types] VARCHAR (50)   NULL,
    [Cloud: Enabled/ Native /Based]  NVARCHAR (50)  NULL,
    [Addtional Information ]         NVARCHAR (MAX) NULL,
    [Document to attach?]            BIT            NULL,
    PRIMARY KEY CLUSTERED ([Ref.No.] ASC)
);

--INSERT INTO YourTableName
--SELECT * FROM OPENROWSET('Microsoft.ACE.OLEDB.12.0', 
   --'Excel 12.0;Database=D:\2nd Year\Software engineering\Example Vendor and Product information.xlsx;HDR=YES', 'SELECT * FROM [Vendor list$]');
