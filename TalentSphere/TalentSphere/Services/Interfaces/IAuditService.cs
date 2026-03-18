using System.Threading.Tasks;
using TalentSphere.DTOs;
using TalentSphere.Models;

namespace TalentSphere.Services.Interfaces
{
    public interface IAuditService
    {
        Task<AuditLog> CreateAuditAsync(CreateAuditLogDTO dto);
        Task<AuditLog> GetByIdAsync(int id);
    }
}
