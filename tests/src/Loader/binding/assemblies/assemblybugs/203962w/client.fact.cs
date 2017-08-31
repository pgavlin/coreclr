using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    class _assemblies_assemblybugs_203962w_client_client_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_assemblybugs_203962w_client_client_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\assemblybugs\\203962w\\client\\client.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
