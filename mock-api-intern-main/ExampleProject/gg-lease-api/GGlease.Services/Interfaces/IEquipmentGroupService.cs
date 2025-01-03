using GGlease.Model.DB;
using GGlease.Model.ViewModel;

namespace GGlease.Services.Interfaces
{
    public interface IEquipmentGroupService
    {
        Task<ValidatedModel<IEnumerable<EquipmentGroupAdminListModel>>> GeAllAsync();
        Task<ValidatedModel<IEnumerable<BasicModel>>> GetAllGuestAsync();
        Task<ValidatedModel<IEnumerable<EquipmentGroupListModel>>> GetAllWithEquipmentsGuestAsync();
        Task OrderRanksByNameAlphebetically();
    }
}