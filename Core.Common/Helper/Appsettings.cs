using Microsoft.Extensions.Configuration;

namespace Core.Common.Helper
{
    /// <summary>
    /// appsettings.json 配置文件帮助类
    /// </summary>
    public class Appsettings
    {
        private static IConfiguration Configuration { get; set; }
        public Appsettings(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 读取配置文件节点值
        /// </summary>
        /// <param name="sections">键名</param>
        /// <returns>键值</returns>
        public static string GetValue(params string[] sections)
        {
            try
            {
                if (sections.Any())
                {
                    return Configuration[string.Join(":", sections)];
                }
            }
            catch (Exception) { }

            return string.Empty;
        }
    }
}
