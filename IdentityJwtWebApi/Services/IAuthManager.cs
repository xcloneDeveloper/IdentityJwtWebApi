using IdentityJwtWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityJwtWebApi.Services
{
	public interface IAuthManager
	{
		Task<bool> ValidateUser(LoginUserDTO userDTO);
		Task<string> CreateToken();
	}
}
