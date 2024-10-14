// See https://aka.ms/new-console-template for more information
using OfficeOpenXml;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
var excelPackage = new ExcelPackage("Out.xlsx", "Template.xlsx",null);
await excelPackage.SaveAsync();
