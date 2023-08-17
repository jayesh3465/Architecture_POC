using POC_DbContext.Model;

namespace POC_Services.Services
{
    public class ErrorLogServices : IErrorLogServices
    {


        private readonly IRepository<ErrorLog> _errorLogRepository;

        public ErrorLogServices(IRepository<ErrorLog> ErrorLogRepository)
        {
            _errorLogRepository = ErrorLogRepository;
        }
        public async Task<IEnumerable<ErrorLog>> GetAllErrorLogs()
        {
            return await _errorLogRepository.GetAll();
        }

        public async Task<ErrorLog> GetErrorLogById(int id)
        {
            return await _errorLogRepository.Get(id);
        }

        public async Task<ErrorLog> SaveErrorLog(ErrorLog ErrorLog)
        {

            await _errorLogRepository.Insert(ErrorLog);
            return ErrorLog;

        }

        public async Task<ErrorLog> UpdateErrorLog(ErrorLog ErrorLog)
        {
            if (ErrorLog != null)
            {
                await _errorLogRepository.Update(ErrorLog);
                return ErrorLog;
            }
            return ErrorLog;
        }

        public async Task<int> DeleteErrorLog(int id)
        {
            var ErrorLog = await _errorLogRepository.Get(id);
            await _errorLogRepository.Delete(ErrorLog);
            return id;
        }
    }
}
