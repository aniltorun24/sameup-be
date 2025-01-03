dotnet ef migrations add AddingCompanyToApplicationForm --project "GGlease.Data" --startup-project "GGlease.API"
dotnet ef migrations remove --project "GGlease.Data" --startup-project "GGlease.API"
dotnet ef database update --project "GGlease.Data" --startup-project "GGlease.API"
dotnet ef migrations script 20240306225939_EquipmentWithGroups 20240701073529_AddingCompanyToApplicationForm  --project "GGlease.Data" --startup-project "GGlease.API" > script.sql
dotnet ef migrations script 20240306215647_EquipmentWithGroups 20240306220004_EquipmentWithGroups2  --project "GGlease.Data" --startup-project "GGlease.API" > script.sql





-- revert
dotnet ef database update "UpdateEquipmentDataMig" --project "GGlease.Data" --startup-project "GGlease.API"
---

-- publish - Mac M2
cd GGlease.API & dotnet clean & dotnet build -c Release & dotnet publish -c Release --os win --arch x64 && open GGlease.API/bin/Release/net6.0/win-x64/publish/


docRef: Kidokit

info: 
cd GGlease.API & dotnet clean & dotnet build -c Release -p:TargetFramwork:net6.0 & dotnet publish -c Release --os win --arch x64 && open GGlease.API/bin/Release/net6.0/win-x64/publish/
