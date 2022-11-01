using GYF.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYF.Business
{
    public class AuthenticationBusiness
    {
        private readonly UnitOfWork unitOfWork;
        public AuthenticationBusiness(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task Authenticate(string userName, string password)
        {
            var users = await unitOfWork.AppUserRepository.GetAsync(x => x.Name == userName & x.Password == password);
            if (users.Count() != 1)
                throw new Exception("Credenciales inválidas");
        }
    }
}
