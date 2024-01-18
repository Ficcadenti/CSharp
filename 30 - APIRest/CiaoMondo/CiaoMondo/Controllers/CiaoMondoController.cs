using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CiaoMondo.Controllers
{
    public record Response
    {
        public string? sysdate {get;set;}
        public string? ip {get;set;}
        public string? uid {get;set;}
        public string? pwd {get;set;}
    }

    public record Request
    {
        [Required]
        public string? ip {get;set;}
        [Required]
        public string? uid {get;set;}
        [Required]
        public string? pwd {get;set;}
    }

    [Route("api/[controller]")]
    [ApiController]
    public class CiaoMondoController : ControllerBase
    {
        [HttpPost]
        //[Route("ciao/{ip}/{uid}/{pwd}")]
        [Route("ciao")]
        //public IActionResult Ciao([FromBody]Request request,string ip,string uid,string pwd)
        public IActionResult Ciao([FromBody]Request request)
        {
            string database = "interopmaker";
            string connectionString = "SERVER=" + request.ip + ";" + "DATABASE=" + database + ";" + "UID=" + request.uid + ";" + "PASSWORD=" + request.pwd + ";";

            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();

                string query = "SELECT SYSDATE()";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader(); 

                try
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    while (reader.Read())
                    {
                        stringBuilder.Append(reader.GetDateTime(0));
                    }
                    con.Close();

                    return StatusCode(StatusCodes.Status200OK, new Response{sysdate=stringBuilder.ToString(), ip=request.ip, uid=request.uid, pwd=request.pwd});
                }
                finally
                {
                    Console.WriteLine("");
                    con.Close();
                }
                
                
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        return StatusCode(StatusCodes.Status500InternalServerError, "Cannot connect to server.  Contact administrator");
                    case 1045:
                        return StatusCode(StatusCodes.Status500InternalServerError, "Invalid username/password, please try again");
                    default:
                        return StatusCode(StatusCodes.Status500InternalServerError, "Internal Error");
                }
            }

        }

        [HttpGet("arrivederci")]
        public IActionResult Arrivederci()
        {
            return Ok("Arrivederci Mondo !!!");
        }
    }
}
