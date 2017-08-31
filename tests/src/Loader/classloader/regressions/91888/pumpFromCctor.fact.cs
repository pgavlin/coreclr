using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_91888_pumpFromCctor_pumpFromCctor_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_91888_pumpFromCctor_pumpFromCctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\91888\\pumpFromCctor\\pumpFromCctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
