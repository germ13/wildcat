REM COPY THIS TO C:\PROGRAM FILES\BATCHFILES\

CD C:\GIT\STEVEWILDCAT\WILDCAT.ENTITIES

REM STEP 1: CONVERT VIEWS TO TABLES, STEP 2: CONVERT VARCHAR TO NVARCHAR2, STEP 3: ADD PRIMARY KEY, STEP 4: GO INTO MODEL CONTEXT AND REMOVE ANY SPECIAL PREFIX YOU MAY HAVE USED TO DISTINGUISH THE TABLE FROM THE ORIGINAL VIEW;
REM IN YOUR CASE, YOU REMOVE CORE_ FROM THE TABLE NAMES.  NONE OF THESE LIMITATIONS STEM FROM USING ORACLE 11.  ORACLE 18 IS NO BETTER.  THEY ARE LIMITATIONS OF CORE EF (VS STANDARD .NET)  HOPEFULLY
REM CORE EF WILL LATER SUPPORT VIEWS, WITHOUT PK AND VARCHAR IN ORACLE.

REM FOR IDENTITY_INSERT C ERRORS, GET YOUR OBJECT INTO VERSION 12 OR HIGHER (DEVLEGY); IF COPYING FROM DEVLCFW TO DEVLEGY YOU MUST REMOVE THE TABLESPACE IN 2 PLACES
REM NOTE, DEVLEGY CAN TAKE YOUR TABLES AS SCHEMA  OBJECTS BUT THE SAMPLE DATA INSERT IS NOT POSSIBLE AS OF 5/2019 BECAUSE THE UNDERLYING VIEWS DONT EXIST ON DEVLEGY

REM COPY THIS BACK INTO ModelContext:
REM optionsBuilder.UseOracle("data source=houcfwdb2.precastcorp.com:1613/pccfw;user id=apps;password=appsnprd;");
REM optionsBuilder.UseOracle("data source=vulcan.precastcorp.com:1522/devlcfw;user id=apps;password=appsnprd;");

rem dotnet ef dbcontext scaffold "data source=marsdb.precastcorp.com:1574/devlegy;user id=apps;password=appsnprd;" Microsoft.EntityFrameworkCore.Oracle -o CFCA\PLANNING -t WIP_ENTITIES_SHELL -t CFW_ACCU_MULT_COUNT -t CFW_ACCU_BAR_DISTRO -t CFW_ACCU_SN -t CFW_ACCU_INVENTORY -t CFW_ACCU_CUT_TICKET -t CFW_ACCU_PLAN_HEADER -f -v

rem dotnet ef dbcontext scaffold "server=WGFC-DEV-SQL01,1433;Database=WGSecurity;user id=WildcatUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer -o SHCA\WGFCDEVSQL01\WGSecurity -f -v
dotnet ef dbcontext scaffold "server=WGFC-DEV-SQL01,1433;Database=SawCalc;user id=sawcalc;password=sawcalc123!!;" Microsoft.EntityFrameworkCore.SqlServer -o CFCA\Saws -f -v
rem dotnet ef dbcontext scaffold "server=WGFC-DEV-SQL01,1433;Database=Wildcat;user id=WildcatUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer -o PCC\Wildcat -f -v

pause
