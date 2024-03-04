using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using System.Diagnostics;
using System.Net.Http.Json;

namespace Kreta.HttpService.Services
{
    public class EducationLevelService : BaseService<EducationLevel, EducationLevelDto>, IEducationLevelService
    {
        public EducationLevelService(IHttpClientFactory? httpClientFactory, EducationLevelAssambler assambler) : base(httpClientFactory, assambler)
        {
        }

        public async Task<List<EducationLevel>> SelectAllIncludedAsync()
        {
            if (_httpClient is not null)
            {
                try
                {
                    List<EducationLevelDto>? resultDto = await _httpClient.GetFromJsonAsync<List<EducationLevelDto>>($"api/EducationLevel/included");
                    if (resultDto is not null)
                    {
                        List<EducationLevel> result = resultDto.Select(entity => _assambler.ToModel(entity)).ToList();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return new List<EducationLevel>();
        }
    }
}
