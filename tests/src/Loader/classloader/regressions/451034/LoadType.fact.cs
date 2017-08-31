using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_451034_LoadType_LoadType_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_451034_LoadType_LoadType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\451034\\LoadType\\LoadType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
