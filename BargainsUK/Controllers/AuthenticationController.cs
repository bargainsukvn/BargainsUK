using Microsoft.AspNetCore.Mvc;
using BargainsUK.Controllers.Models;

namespace app.Controllers {
    [Route ("api/[controller]")]
    public class AuthenticationController : Controller {

        [HttpPost ("authenticateUser")]
        public IActionResult AuthenticateUser (string username, string password) {
            if (string.IsNullOrEmpty (username) && string.IsNullOrEmpty (password))
                return Ok (Unauthorized ());

            return Ok (
                new UserModel {
                    Firstname = "Adrise",
                        Lastname = "Younis",
                        Username = "Ay01"
                }
            );
        }

        [HttpGet ("{userID}")]
        public IActionResult GetUser (int userID) {

            UserModel _UserModel = null;

            if (userID > 0) {
                _UserModel.ID = 0;
                _UserModel.Firstname = "Adrise";
                _UserModel.Lastname = "Younis";
                _UserModel.Username = "Ay01";
                _UserModel.Password = "HelloWorld";
            }
            return Ok (_UserModel);
        }

    }
}