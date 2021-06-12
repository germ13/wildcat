# To regenerate model in Powershell ISE: place cursor in line that you want to execute and hit F*

# Local
dotnet ef dbcontext scaffold "Server=.;Database=Wildcat;user id=WildcatUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir PCC\Wildcat --force 

# Dev
 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=Wildcat;user id=WildcatUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir PCC\Wildcat --force 

 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=HeatsSecured;user id=LoupeUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir MCNJ\HeatsSecured --force
 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=SecureHeatCards;user id=LoupeUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir MCNJ\SecureHeatCards --force
 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=SecureHeatTreatBatchBook;user id=LoupeUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir MCNJ\SecureHeatTreatBatchBook --force
 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=DCR;user id=LoupeUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir MCNJ\DCR --force
 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=IDR;user id=LoupeUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir MCNJ\IDR --force

 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=DefaultLoupe;user id=WildcatUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir PCC\Loupe --force

 dotnet ef dbcontext scaffold "Server=SHCA-SQL03;Database=ShultzPro;user id=ShultzUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\ShultzPro --force
 dotnet ef dbcontext scaffold "Server=SHCA-SQL03;Database=ShultzBBx;user id=ShultzUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\ShultzBBx --force

 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01;Database=SHCAEngineering;user id=WildcatUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\Grinders\Wildcat --force
 dotnet ef dbcontext scaffold "Server=SHCA-SQL03;Database=EngineeringData;user id=ShultzEngineeringUser;password=ShultzEngineeringUserPwd123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\EngineeringData --force

 dotnet ef dbcontext scaffold "Server=Duncan\datacollection;Database=FGA;user id=DC_User;password=DC_Userpwd;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\Grinders\FGA --force
 dotnet ef dbcontext scaffold "Server=Duncan\datacollection;Database=FGQ;user id=DC_User;password=DC_Userpwd;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\Grinders\FGQ --force
 dotnet ef dbcontext scaffold "Server=Duncan\datacollection;Database=FGX;user id=DC_User;password=DC_Userpwd;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\Grinders\FGX --force
 dotnet ef dbcontext scaffold "Server=Duncan\datacollection;Database=FGD;user id=DC_User;password=DC_Userpwd;" Microsoft.EntityFrameworkCore.SqlServer --output-dir SHCA\Grinders\FGD --force
 
 dotnet ef dbcontext scaffold "Server=WGFC-DEV-SQL01\PCC03;Database=PCC03_Integration;user id=IntegrationUser;password=IntegrationUserPwd123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir PCC\PCC03Integration --force

 # QA
 dotnet ef dbcontext scaffold "Server=WGFC-QA-SQL01;Database=Wildcat;user id=WildcatUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir PCC\Wildcat --force 
 dotnet ef dbcontext scaffold "Server=WGFC-QA-SQL01;Database=CFCALoupe;user id=LoupeUser;password=Password123!;" Microsoft.EntityFrameworkCore.SqlServer --output-dir PCC\Loupe --force

