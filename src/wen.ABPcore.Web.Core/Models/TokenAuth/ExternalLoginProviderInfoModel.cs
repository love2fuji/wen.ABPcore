using Abp.AutoMapper;
using wen.ABPcore.Authentication.External;

namespace wen.ABPcore.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
