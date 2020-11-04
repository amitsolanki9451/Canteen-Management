USE [MCarbonLab]
GO

/********* Object:  StoredProcedure [dbo].[rpt_GetRecoveryWtByRecoveryWtDatenShift]    Script Date: 8/5/2019 12:55:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 
	CREATE PROCEDURE [dbo].[rpt_GetRecoveryWtByRecoveryWtDatenShift] 
	( 
		@FromDate  DateTime= null,
		@ToDate  DateTime=null,
		@Shift varchar(100)=null
	) 
	AS 
	BEGIN 
	SET NOCOUNT ON;  
	BEGIN TRY 
	Declare @SQLQuery AS NVarchar(4000) 
	Declare @ParamDefinition AS NVarchar(2000) 
	Declare @temp_Shift as nvarchar(1000)

set @temp_Shift=Replace(@Shift,',',''',''')

	Set @SQLQuery = ' 
	SELECT * FROM tblRecoveryWt WITH (NOLOCK) WHERE  IsActive =1'
	If @FromDate Is Not Null AND LTRIM(RTRIM(@FromDate)) <> '1/1/1900 12:00:00 AM' 
	Set @SQLQuery = @SQLQuery + ' And (Convert(date,RecoveryWtDate) >=  @FromDate )'   
	If @ToDate Is Not Null AND LTRIM(RTRIM(@ToDate)) <> '1/1/1900 12:00:00 AM' 
	Set @SQLQuery = @SQLQuery + ' And (Convert(date,RecoveryWtDate) <=  @ToDate )' 
	If @Shift  Is Not Null AND LTRIM(RTRIM(@Shift)) <> '' 	
	set @SQLQuery=@SQLQuery + 'AND ShiftTypeName in (''' + @temp_Shift + ''')'

Set @ParamDefinition = '
@FromDate  Date ,	
@ToDate  Date ,	 
@Shift varchar(1000)'
	Execute sp_Executesql @SQLQuery, @ParamDefinition,
	@FromDate,
	@ToDate,
    @Shift
	END TRY 
	BEGIN CATCH   
	ROLLBACK 
	DECLARE @error_message NVARCHAR(MAX)   
	SELECT  @error_message = ERROR_MESSAGE() ;  
	RAISERROR(@error_message,16,1)      
	END CATCH ;     
	END 

GO


