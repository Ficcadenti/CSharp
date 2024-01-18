﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System.Text;
using System.Text.Json.Serialization;

namespace CiaoMondo.Controllers
{
    public record Response
    {
        public string? sysdate {get;set;}
    }

    [Route("api/[controller]")]
    [ApiController]
    public class CiaoMondoController : ControllerBase
    {
        [HttpGet("ciao/{uid}/{pwd}")]
        public IActionResult Ciao(string uid,string pwd)
        {
            MySqlConnection con;
            MySqlDataReader reader;

            string server = "192.168.100.30";
            string database = "interopmaker";
            string username = uid;
            string password = pwd;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            con = new MySqlConnection(connectionString);

            try
            {
                con.Open();

                string query = "SELECT SYSDATE()";
                MySqlCommand cmd = new MySqlCommand(query, con);
                reader = cmd.ExecuteReader(); 
                try
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    while (reader.Read())
                    {
                        stringBuilder.Append(reader.GetDateTime(0));
                    }
                    con.Close();

                    return StatusCode(StatusCodes.Status200OK, new Response{sysdate=stringBuilder.ToString()});
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
