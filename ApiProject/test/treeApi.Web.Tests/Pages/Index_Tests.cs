using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace treeApi.Pages;

public class Index_Tests : treeApiWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
