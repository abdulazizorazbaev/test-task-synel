using CSVReader.DbContexts;
using CSVReader.Dtos;
using CSVReader.Entities;
using LumenWorks.Framework.IO.Csv;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CSVReader.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public ActionResult IndexAsync()
    {
        AppDbContext dbContext = new AppDbContext();
        var employees = dbContext.Employees.ToList();
        return View("Index",employees);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult CreateAsync(IFormFile upload)
    {
        if (ModelState.IsValid)
        {
            if (upload != null && upload.Length > 0)
            {
                if (upload.FileName.EndsWith(".csv"))
                {
                    Stream stream = upload.OpenReadStream();
                    
                    DataTable csvTable = new DataTable();
                    AppDbContext dbContext = new AppDbContext();
                    using (CsvReader csvReader = new CsvReader(new StreamReader(stream), true))
                    {                                                     
                        csvTable.Load(csvReader);
                        List<string> values = new List<string>();

                        for (int i = 0; i <= csvTable.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j <= csvTable.Columns.Count - 1; j++)
                            {
                                var cell = csvTable.Rows[i][j];
                                values.Add(cell.ToString()!);
                            }
                            Employee employee = new Employee()
                            {
                                PayrollNumber = values[0],
                                Forename = values[1],
                                Surname = values[2],
                                DateOfBirth = values[3],
                                Telephone = values[4],
                                Mobile = values[5],
                                Address = values[6],
                                Address2 = values[7],
                                Postcode = values[8],
                                Email = values[9],
                                StartDate = values[10]
                            };
                            dbContext.Employees.Add(employee);

                            values.Clear();
                        }
                        dbContext.SaveChanges();
                    }
                    var employees = dbContext.Employees.ToList();
                    return View("Index",employees);
                }
                else
                {
                    ModelState.AddModelError("File", "This file format is not supported");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("File", "Please Upload Your file");
            }
        }
        return View();
    }

    public ActionResult Update(long employeeId)
    {
        AppDbContext dbContext = new AppDbContext();
        var emp = dbContext.Employees.Find(employeeId);
        return View("Update",emp);
    }

    [HttpPost]
    public ActionResult UpdateAsync(long employeeId, EmployeeUpdateDto dto)
    {
        if (ModelState.IsValid)
        {
            AppDbContext dbContext = new AppDbContext();
            var employee = dbContext.Employees.Find(employeeId);
            if (employee != null)
            {
                employee.PayrollNumber = dto.PayrollNumber;
                employee.Forename = dto.Forename;
                employee.Surname = dto.Surname;
                employee.DateOfBirth = dto.DateOfBirth;
                employee.Telephone = dto.Telephone;
                employee.Mobile = dto.Mobile;
                employee.Email = dto.Email;
                /*            employee.Address = dto.Address;
                            employee.Address2 = dto.Address2;
                            employee.Postcode = dto.Postcode;
                            employee.StartDate = dto.StartDate;*/
            }
            dbContext.SaveChanges();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
        else return Update(employeeId);
    }

    public ActionResult Delete(long employeeId)
    {
        AppDbContext appDbContext = new AppDbContext();
        var employee = appDbContext.Employees.Find(employeeId);
        if (employee != null)
        {
            appDbContext.Employees.Remove(employee);
            appDbContext.SaveChanges();
        }
        return RedirectToAction("Index", "Home", new { Area = "" });
    }

    public ActionResult SortAsync()
    {
        AppDbContext dbContext = new AppDbContext();
        var employees = dbContext.Employees.OrderBy(surname => surname.Surname).ToList();
        return View("Index",employees);
    }

    public ActionResult SearchAsync(string search)
    {
        AppDbContext context = new AppDbContext();
        var employees = context.Employees.Where(x => x.Surname.Contains(search)).ToList();
        return View("Index", employees);
    }
}