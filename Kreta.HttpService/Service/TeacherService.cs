using Kreta.Shared.Dtos;
using Kreta.Shared.Responses;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Net;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SchoolCitizens;

namespace Kreta.HttpService.Service
{
        public class TeacherService : ITeacherService
        {
            private readonly HttpClient? _httpClient;

            public TeacherService(IHttpClientFactory? httpClientFactory)
            {
                if (httpClientFactory is not null)
                {
                    _httpClient = httpClientFactory.CreateClient("KretaApi");
                }
            }

            public async Task<List<Teacher>> SelectAllTeacher()
            {
                if (_httpClient is not null)
                {
                    try
                    {
                        List<TeacherDto>? resultDto = await _httpClient.GetFromJsonAsync<List<TeacherDto>>("api/Teacher");
                        if (resultDto is not null)
                        {
                            List<Teacher> result = resultDto.Select(studentDto => studentDto.ToModel()).ToList();
                            return result;
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                return new List<Teacher>();
            }

            public async Task<ControllerResponse> UpdateAsync(Teacher teacher)
            {
                ControllerResponse defaultResponse = new();
                if (_httpClient is not null)
                {
                    try
                    {
                        HttpResponseMessage httpResponse = await _httpClient.PutAsJsonAsync("api/Teacher", teacher.ToDto());
                        if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                        {
                            string content = await httpResponse.Content.ReadAsStringAsync();
                            ControllerResponse? response = JsonConvert.DeserializeObject<ControllerResponse>(content);
                            if (response is null)
                            {
                                defaultResponse.ClearAndAddError("A törlés http kérés hibát okozott!");
                            }
                            else return response;
                        }
                        else if (!httpResponse.IsSuccessStatusCode)
                        {
                            httpResponse.EnsureSuccessStatusCode();
                        }
                        else
                        {
                            return defaultResponse;
                        }
                    }

                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                defaultResponse.ClearAndAddError("Az adatok frissítés nem lehetséges!");
                return defaultResponse;
            }

            public async Task<ControllerResponse> DeleteAsync(Guid id)
            {
                ControllerResponse defaultResponse = new();
                if (_httpClient is not null)
                {
                    try
                    {
                        HttpResponseMessage httpResponse = await _httpClient.DeleteAsync($"api/Teacher/{id}");
                        if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                        {
                            string content = await httpResponse.Content.ReadAsStringAsync();
                            ControllerResponse? response = JsonConvert.DeserializeObject<ControllerResponse>(content);
                            if (response is null)
                            {
                                defaultResponse.ClearAndAddError("A törlés http kérés hibát okozott!");
                            }
                            else return response;
                        }
                        else if (!httpResponse.IsSuccessStatusCode)
                        {
                            httpResponse.EnsureSuccessStatusCode();
                        }
                        else
                        {
                            return defaultResponse;
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                defaultResponse.ClearAndAddError("Az adatok törlése nem lehetséges!");
                return defaultResponse;
            }


            public async Task<ControllerResponse> InsertAsync(Teacher teacher)
            {
                ControllerResponse defaultResponse = new();
                if (_httpClient is not null)
                {
                    try
                    {
                        HttpResponseMessage httpResponse = await _httpClient.PostAsJsonAsync("api/Teacher", teacher);
                        if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
                        {
                            string content = await httpResponse.Content.ReadAsStringAsync();
                            ControllerResponse? response = JsonConvert.DeserializeObject<ControllerResponse>(content);
                            if (response is null)
                            {
                                defaultResponse.ClearAndAddError("A mentés http kérés hibát okozott!");
                            }
                            else return response;
                        }
                        else if (!httpResponse.IsSuccessStatusCode)
                        {
                            httpResponse.EnsureSuccessStatusCode();
                        }
                        else
                        {
                            return defaultResponse;
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                defaultResponse.ClearAndAddError("Az adatok mentése nem lehetséges!");
                return defaultResponse;
            }
        }
}
