using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioWebApp.Models;
using PortfolioWebApp.Data;

namespace PortfolioWebApp.Controllers{

    [Route("connections")]
    public class ConnectionsController : Controller {

   
    [HttpPost("[action]")]
    public IActionResult postConnection(){
        try{

            ConnectionModel newConnection = new ConnectionModel();
            newConnection.assignNewObject();

            using(GeneralData gd = new GeneralData()){
                gd.Add(newConnection);
                gd.SaveChanges();
            }


            return new ObjectResult(200);
        } catch{
            return new ObjectResult(500);
        }
    }
    }
}