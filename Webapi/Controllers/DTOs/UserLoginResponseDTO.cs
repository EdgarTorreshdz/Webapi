using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi.Controllers.DTOs
{
  public class UserLoginResponseDTO
  {
    public string Token { get; set; }
    public bool Login { get; set; }
    public List<string> Errors { get; set; }
  }
}
