using GGlease.Model.DB;
using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IEquipmentService
    {
        Task<ValidatedModel<IEnumerable<EquipmentAdminListModel>>> GetEquipmentsAsync();
        Task<ValidatedModel<IEnumerable<BasicModel>>> GetSellerCompaniesOfEquipmentAsync(int equipmentId);
        Task<ValidatedModel<IEnumerable<BasicModel>>> GetEquipmentsByGroupIdGuestAsync(int groupId);
    }
}