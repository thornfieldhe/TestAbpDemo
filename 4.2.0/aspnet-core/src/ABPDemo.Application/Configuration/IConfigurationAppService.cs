using System.Threading.Tasks;
using ABPDemo.Configuration.Dto;

namespace ABPDemo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
