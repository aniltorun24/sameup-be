using AutoMapper;
using AutoMapper.QueryableExtensions;
using GGlease.Data;
using GGlease.Model.ViewModel;
using GGlease.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GGlease.Services.Concrete
{
    public class MaturityOptionService : IMaturityOptionService
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public MaturityOptionService(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
            
        }

        public async Task<ValidatedModel<IEnumerable<MaturityOptionModel>>> GetMaturityOptionsAsync()
        {
            var list = await _dataContext.MaturityOptions
                .ProjectTo<MaturityOptionModel>(_mapper.ConfigurationProvider)
                .OrderBy(x=>x.Rank)
                .ToListAsync();
            return new ValidatedModel<IEnumerable<MaturityOptionModel>>(list);
        }

        public async Task<ValidatedModel<MaturityOptionModel>> GetByIdAsync(int id)
        {
            var maturityOption = await _dataContext.MaturityOptions
                .Where(x => x.Id == id)
                .ProjectTo<MaturityOptionModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();

            if (maturityOption == null) return new ValidatedModel<MaturityOptionModel>("İşlem başarısız");

            return new ValidatedModel<MaturityOptionModel>(maturityOption);
        }
    }
}