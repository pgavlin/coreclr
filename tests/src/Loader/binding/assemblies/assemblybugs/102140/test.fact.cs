using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    class _assemblies_assemblybugs_102140_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_assemblybugs_102140_test_test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\assemblybugs\\102140\\test\\test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
