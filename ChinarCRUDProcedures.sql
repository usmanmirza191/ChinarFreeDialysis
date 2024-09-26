USE [ChinarDialysisCentre];
GO

IF OBJECT_ID('[dbo].[usp_tbl_box_donationSelect]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_box_donationSelect] 
END 
GO
CREATE PROC [dbo].[usp_tbl_box_donationSelect] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Box_Id], [Amount], [Collection_Date], [Collected_By], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted] 
	FROM   [dbo].[tbl_box_donation] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_box_donationInsert]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_box_donationInsert] 
END 
GO
CREATE PROC [dbo].[usp_tbl_box_donationInsert] 
    @Box_Id int,
    @Amount decimal(18, 0) = NULL,
    @Collection_Date datetime = NULL,
    @Collected_By int,
    @Created_By int = NULL,
    @Created_At datetime = NULL,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL,
    @Is_Deleted bit = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[tbl_box_donation] ([Box_Id], [Amount], [Collection_Date], [Collected_By], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted])
	SELECT @Box_Id, @Amount, @Collection_Date, @Collected_By, @Created_By, @Created_At, @Updated_By, @Updated_At, @Is_Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Box_Id], [Amount], [Collection_Date], [Collected_By], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted]
	FROM   [dbo].[tbl_box_donation]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_box_donationUpdate]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_box_donationUpdate] 
END 
GO
CREATE PROC [dbo].[usp_tbl_box_donationUpdate] 
    @Id int,
    @Box_Id int,
    @Amount decimal(18, 0) = NULL,
    @Collection_Date datetime = NULL,
    @Collected_By int,
    @Created_By int = NULL,
    @Created_At datetime = NULL,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL,
    @Is_Deleted bit = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[tbl_box_donation]
	SET    [Box_Id] = @Box_Id, [Amount] = @Amount, [Collection_Date] = @Collection_Date, [Collected_By] = @Collected_By, [Created_By] = @Created_By, [Created_At] = @Created_At, [Updated_By] = @Updated_By, [Updated_At] = @Updated_At, [Is_Deleted] = @Is_Deleted
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Box_Id], [Amount], [Collection_Date], [Collected_By], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted]
	FROM   [dbo].[tbl_box_donation]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_box_donationDelete]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_box_donationDelete] 
END 
GO
CREATE PROC [dbo].[usp_tbl_box_donationDelete] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[tbl_box_donation]
	WHERE  [Id] = @Id

	COMMIT
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

IF OBJECT_ID('[dbo].[usp_tbl_boxesSelect]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_boxesSelect] 
END 
GO
CREATE PROC [dbo].[usp_tbl_boxesSelect] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Box_No], [Box_Name], [Location], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted] 
	FROM   [dbo].[tbl_boxes] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_boxesInsert]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_boxesInsert] 
END 
GO
CREATE PROC [dbo].[usp_tbl_boxesInsert] 
    @Box_No int,
    @Box_Name nvarchar(50) = NULL,
    @Location nvarchar(50) = NULL,
    @Created_By int,
    @Created_At datetime,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL,
    @Is_Deleted bit = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[tbl_boxes] ([Box_No], [Box_Name], [Location], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted])
	SELECT @Box_No, @Box_Name, @Location, @Created_By, @Created_At, @Updated_By, @Updated_At, @Is_Deleted
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Box_No], [Box_Name], [Location], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted]
	FROM   [dbo].[tbl_boxes]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_boxesUpdate]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_boxesUpdate] 
END 
GO
CREATE PROC [dbo].[usp_tbl_boxesUpdate] 
    @Id int,
    @Box_No int,
    @Box_Name nvarchar(50) = NULL,
    @Location nvarchar(50) = NULL,
    @Created_By int,
    @Created_At datetime,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL,
    @Is_Deleted bit = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[tbl_boxes]
	SET    [Box_No] = @Box_No, [Box_Name] = @Box_Name, [Location] = @Location, [Created_By] = @Created_By, [Created_At] = @Created_At, [Updated_By] = @Updated_By, [Updated_At] = @Updated_At, [Is_Deleted] = @Is_Deleted
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Box_No], [Box_Name], [Location], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Deleted]
	FROM   [dbo].[tbl_boxes]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_boxesDelete]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_boxesDelete] 
END 
GO
CREATE PROC [dbo].[usp_tbl_boxesDelete] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[tbl_boxes]
	WHERE  [Id] = @Id

	COMMIT
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

IF OBJECT_ID('[dbo].[usp_tbl_membersSelect]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_membersSelect] 
END 
GO
CREATE PROC [dbo].[usp_tbl_membersSelect] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [First_Name], [Last_Name], [Mobile_No], [Whatsapp_No], [Cnic], [Address], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Active] 
	FROM   [dbo].[tbl_members] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_membersInsert]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_membersInsert] 
END 
GO
CREATE PROC [dbo].[usp_tbl_membersInsert] 
    @First_Name nvarchar(50),
    @Last_Name nvarchar(50) = NULL,
    @Mobile_No nvarchar(50),
    @Whatsapp_No nvarchar(50) = NULL,
    @Cnic nvarchar(50) = NULL,
    @Address nchar(10) = NULL,
    @Created_By int = NULL,
    @Created_At datetime = NULL,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL,
    @Is_Active bit = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[tbl_members] ([First_Name], [Last_Name], [Mobile_No], [Whatsapp_No], [Cnic], [Address], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Active])
	SELECT @First_Name, @Last_Name, @Mobile_No, @Whatsapp_No, @Cnic, @Address, @Created_By, @Created_At, @Updated_By, @Updated_At, @Is_Active
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [First_Name], [Last_Name], [Mobile_No], [Whatsapp_No], [Cnic], [Address], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Active]
	FROM   [dbo].[tbl_members]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_membersUpdate]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_membersUpdate] 
END 
GO
CREATE PROC [dbo].[usp_tbl_membersUpdate] 
    @Id int,
    @First_Name nvarchar(50),
    @Last_Name nvarchar(50) = NULL,
    @Mobile_No nvarchar(50),
    @Whatsapp_No nvarchar(50) = NULL,
    @Cnic nvarchar(50) = NULL,
    @Address nchar(10) = NULL,
    @Created_By int = NULL,
    @Created_At datetime = NULL,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL,
    @Is_Active bit = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[tbl_members]
	SET    [First_Name] = @First_Name, [Last_Name] = @Last_Name, [Mobile_No] = @Mobile_No, [Whatsapp_No] = @Whatsapp_No, [Cnic] = @Cnic, [Address] = @Address, [Created_By] = @Created_By, [Created_At] = @Created_At, [Updated_By] = @Updated_By, [Updated_At] = @Updated_At, [Is_Active] = @Is_Active
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [First_Name], [Last_Name], [Mobile_No], [Whatsapp_No], [Cnic], [Address], [Created_By], [Created_At], [Updated_By], [Updated_At], [Is_Active]
	FROM   [dbo].[tbl_members]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_membersDelete]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_membersDelete] 
END 
GO
CREATE PROC [dbo].[usp_tbl_membersDelete] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[tbl_members]
	WHERE  [Id] = @Id

	COMMIT
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

IF OBJECT_ID('[dbo].[usp_tbl_members_donationSelect]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_members_donationSelect] 
END 
GO
CREATE PROC [dbo].[usp_tbl_members_donationSelect] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Donated_By], [Received_By], [Donation_Date], [Amount], [Donation_Source], [Donation_Receipt], [Created_By], [Created_At], [Is_Deleted], [Updated_By], [Updated_At] 
	FROM   [dbo].[tbl_members_donation] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_members_donationInsert]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_members_donationInsert] 
END 
GO
CREATE PROC [dbo].[usp_tbl_members_donationInsert] 
    @Donated_By int = NULL,
    @Received_By int = NULL,
    @Donation_Date datetime = NULL,
    @Amount decimal(18, 0),
    @Donation_Source int = NULL,
    @Donation_Receipt nvarchar(100) = NULL,
    @Created_By int,
    @Created_At datetime,
    @Is_Deleted bit = NULL,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[tbl_members_donation] ([Donated_By], [Received_By], [Donation_Date], [Amount], [Donation_Source], [Donation_Receipt], [Created_By], [Created_At], [Is_Deleted], [Updated_By], [Updated_At])
	SELECT @Donated_By, @Received_By, @Donation_Date, @Amount, @Donation_Source, @Donation_Receipt, @Created_By, @Created_At, @Is_Deleted, @Updated_By, @Updated_At
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Donated_By], [Received_By], [Donation_Date], [Amount], [Donation_Source], [Donation_Receipt], [Created_By], [Created_At], [Is_Deleted], [Updated_By], [Updated_At]
	FROM   [dbo].[tbl_members_donation]
	WHERE  [Id] = SCOPE_IDENTITY()
	-- End Return Select <- do not remove
               
	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_members_donationUpdate]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_members_donationUpdate] 
END 
GO
CREATE PROC [dbo].[usp_tbl_members_donationUpdate] 
    @Id int,
    @Donated_By int = NULL,
    @Received_By int = NULL,
    @Donation_Date datetime = NULL,
    @Amount decimal(18, 0),
    @Donation_Source int = NULL,
    @Donation_Receipt nvarchar(100) = NULL,
    @Created_By int,
    @Created_At datetime,
    @Is_Deleted bit = NULL,
    @Updated_By int = NULL,
    @Updated_At datetime = NULL
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[tbl_members_donation]
	SET    [Donated_By] = @Donated_By, [Received_By] = @Received_By, [Donation_Date] = @Donation_Date, [Amount] = @Amount, [Donation_Source] = @Donation_Source, [Donation_Receipt] = @Donation_Receipt, [Created_By] = @Created_By, [Created_At] = @Created_At, [Is_Deleted] = @Is_Deleted, [Updated_By] = @Updated_By, [Updated_At] = @Updated_At
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Donated_By], [Received_By], [Donation_Date], [Amount], [Donation_Source], [Donation_Receipt], [Created_By], [Created_At], [Is_Deleted], [Updated_By], [Updated_At]
	FROM   [dbo].[tbl_members_donation]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
IF OBJECT_ID('[dbo].[usp_tbl_members_donationDelete]') IS NOT NULL
BEGIN 
    DROP PROC [dbo].[usp_tbl_members_donationDelete] 
END 
GO
CREATE PROC [dbo].[usp_tbl_members_donationDelete] 
    @Id int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[tbl_members_donation]
	WHERE  [Id] = @Id

	COMMIT
GO
----------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------

