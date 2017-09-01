using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    public class _assemblies_assemblybugs_102140_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_assemblybugs_102140_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\assemblybugs\\102140\\test\\test.cmd");
        }
    }
}
