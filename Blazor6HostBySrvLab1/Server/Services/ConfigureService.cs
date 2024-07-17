namespace Blazor6HostBySrvLab1.Server.Services
{
    /// <summary>
    /// Configure (AppSettings) 設定檔服務
    /// </summary>
    public class ConfigureService
    {
        private readonly IConfiguration _configuration;

        public ConfigureService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<string> GetConfigValue(string sectionName)
        {
            return Task.Factory.StartNew(() =>
                _configuration.GetSection("appSettings").GetSection(sectionName).Value);
        }
    }
}
