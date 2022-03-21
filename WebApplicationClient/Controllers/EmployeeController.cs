using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApplicationClient.Models;

namespace WebApplicationClient.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<EmployeeModel> EmpInfo;
            HttpResponseMessage response = GlobaleVariables.httpClient.GetAsync("Employes").Result;
            EmpInfo = response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
            return View(EmpInfo);
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new EmployeeModel());
            else
            {
                HttpResponseMessage response = GlobaleVariables.httpClient.GetAsync("Employes/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<EmployeeModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(EmployeeModel emp)
        {
            if (emp.id == 0)
            {
                HttpResponseMessage response = GlobaleVariables.httpClient.PostAsJsonAsync("Employes", emp).Result;
                TempData["success"] = "Employé ajouté";
            }
            else
            {
                HttpResponseMessage response = GlobaleVariables.httpClient.PutAsJsonAsync("Employes/"+emp.id, emp).Result;
                TempData["success"] = "Employé modifié";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobaleVariables.httpClient.DeleteAsync("Employes/" + id.ToString()).Result;
            TempData["success"] = "Employé supprimé";
            return RedirectToAction("Index");
        }
    }
}