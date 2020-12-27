using System.Linq;
using System.Net.Http;
using System.Collections.Generic;
using Jhohan.Modules.DNNModuleTest.Services.ViewModels;
using DotNetNuke.Web.Api;
using DotNetNuke.Security;
using DotNetNuke.Entities.Users;

namespace Jhohan.Modules.DNNModuleTest.Services
{
	[SupportedModules("DNNModuleTest")]
	[DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
	public class UserController : DnnApiController
	{
		public UserController() { }

		public HttpResponseMessage GetList()
		{

			var userlist = DotNetNuke.Entities.Users.UserController.GetUsers(this.PortalSettings.PortalId);
			var users = userlist.Cast<UserInfo>().ToList()
				   .Select(user => new UserViewModel(user))
				   .ToList();

			return Request.CreateResponse(users);
		}
	}
}
