using POC_DbContext.Model;

namespace POC_Services.Interface
{
    public interface IErrorLogServices
    {
        Task<IEnumerable<ErrorLog>> GetAllErrorLogs();

        Task<ErrorLog> GetErrorLogById(int id);

        Task<ErrorLog> SaveErrorLog(ErrorLog category);

        Task<ErrorLog> UpdateErrorLog(ErrorLog category);

        Task<int> DeleteErrorLog(int id);

    }
}
