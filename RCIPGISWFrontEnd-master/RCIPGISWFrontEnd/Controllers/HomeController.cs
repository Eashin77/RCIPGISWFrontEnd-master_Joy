using RCIPGISWFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace RCIPGISWFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var userName = "xen.dhaka";
                    //client.BaseAddress = new Uri("http://dev.betsbd.com:3015/");
                    //var responseTaskDivision = client.GetAsync("grissa/api/v1/Mobile/Divisions/GetDivisionsByPermission?userName=" + userName);
                    //var responseTaskDistrict = client.GetAsync("grissa/api/v1/Mobile/Divisions/GetDivisionsByPermission?userName=" + userName);
                    //var responseTaskRegion = client.GetAsync("grissa/api/v1/Mobile/Divisions/GetDivisionsByPermission?userName=" + userName);
                    //var responseTaskUpazila = client.GetAsync("grissa/api/v1/Mobile/Divisions/GetDivisionsByPermission?userName=" + userName);
                    //responseTaskDivision.Wait();
                    //responseTaskDistrict.Wait();
                    //responseTaskRegion.Wait();
                    //responseTaskUpazila.Wait();
                    //var resultDivision = responseTaskDivision.Result;
                    //var readTaskDivision = resultDivision.Content.ReadAsAsync<List<Division>>();
                    //readTaskDivision.Wait();
                    //List<Division> division = readTaskDivision.Result;
                    //var resultDistrict = responseTaskDistrict.Result;
                    //var readTaskDistrict = resultDistrict.Content.ReadAsAsync<List<District>>();
                    //readTaskDistrict.Wait();
                    //List<District> district = readTaskDistrict.Result;
                    //var resultUpazila = responseTaskUpazila.Result;
                    //var readTaskUpazila = resultUpazila.Content.ReadAsAsync<List<Upazila>>();
                    //readTaskUpazila.Wait();
                    //List<Upazila> upazila = readTaskUpazila.Result;
                    client.BaseAddress = new Uri("http://sso.lged.gov.bd/");
                    var responseTaskUserLocation = client.GetAsync("Services/Security/PublicUser/GetData?userName=" + userName);
                    responseTaskUserLocation.Wait();
                    var resultUserLocation = responseTaskUserLocation.Result;
                    var readTaskUserLocation = resultUserLocation.Content.ReadAsAsync<User>();
                    readTaskUserLocation.Wait();
                    User user= readTaskUserLocation.Result;
                    List<UserLocation> userLocation = user.UserLocations;
                    ViewBag.UserLocation = userLocation;
                    
                }
                catch (Exception error)
                {
                    return null;
                }

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}