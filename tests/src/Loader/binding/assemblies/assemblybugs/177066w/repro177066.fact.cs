using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    class _assemblies_assemblybugs_177066w_repro177066_repro177066_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_assemblybugs_177066w_repro177066_repro177066_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\assemblybugs\\177066w\\repro177066\\repro177066.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
