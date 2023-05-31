using MyCreateProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;

namespace MyCreateProject.Controllers
{
    public class MovieController : Controller
    {
        string conString = "Data Source=REV-PG02C4Y5;Initial Catalog=Demo;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ContentResult Save(Movie movie)
        {
            string status = "";
            //sqlconnection class
            using(SqlConnection con = new SqlConnection(conString))
            {
                string command="insert into movie (moviename,director,genre,ticketprice) values (@moviename,@director,@genre,@ticketprice)";
                using (SqlCommand cmd = new SqlCommand(command, con))
                {
                    con.Open();
                  //  cmd.Parameters.AddWithValue("@movieid", movie.MovieId);
                    cmd.Parameters.AddWithValue("@moviename", movie.MovieName);
                    cmd.Parameters.AddWithValue("@director", movie.Director);
                    cmd.Parameters.AddWithValue("@genre", movie.Genre);
                    cmd.Parameters.AddWithValue("@ticketprice", movie.TicketPrice);

                    status = (cmd.ExecuteNonQuery() >= 1) ? "Record is successfully inserted" : "Record is not saved";
                    status += "<br";

                }

                using(SqlCommand cmd=new SqlCommand("select * from movie",con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        status +="<br>Movie Id :" + sdr["movieid"] +
                                 " < br > Movie Name: " + sdr["moviename"] + 
                            "< br > Director " + sdr["director"] + 
                            "< br > Genre: " + sdr["genre"] + 
                            "< br > Ticket Price: " + sdr["ticketprice"] ;
                    }
                }
            
            }

            return Content(status);
        }
    }
}