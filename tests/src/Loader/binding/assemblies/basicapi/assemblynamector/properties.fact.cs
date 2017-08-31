using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    class _assemblies_basicapi_assemblynamector_properties_properties_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_basicapi_assemblynamector_properties_properties_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\basicapi\\assemblynamector\\properties\\properties.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
