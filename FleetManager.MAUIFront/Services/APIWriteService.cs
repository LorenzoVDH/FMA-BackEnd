using FleetManager.MAUIFront.MVVM.DTOs;
using FleetManager.MAUIFront.MVVM.Models;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json; 

namespace FleetManager.MAUIFront.Services;
public static class APIWriteService {
    private static readonly string _baseURL = "http://10.0.2.2:7031/Write";

    public static async Task<HttpResponseMessage> CreateInquiryAsync(InquiryCreateDTO inquiry) {
        using (var client = new HttpClient()) {
            string URL = $"{_baseURL}/Inquiry";
            var json = JsonConvert.SerializeObject(inquiry);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(URL, content);

            return response.EnsureSuccessStatusCode();
        }
    }
}
