using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    public class _assemblies_assemblybugs_203962w_client_client_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_assemblybugs_203962w_client_client_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\assemblybugs\\203962w\\client\\client.cmd");
        }
    }
}
