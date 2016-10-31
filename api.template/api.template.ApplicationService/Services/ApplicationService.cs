using api.template.Infra.UnitOfWork;

namespace api.template.ApplicationService.Services
{

    public class ApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Commit()
        {         
            _unitOfWork.Commit();
            return true;
        }

        public void Rollback(string message)
        {         
            _unitOfWork.RollBack();
        }

        public void Rollback()
        {
            _unitOfWork.RollBack();
        }
    }
}
