using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1333_testInterface_testInterface_
    {
        [OuterLoop]
        [Fact]
        public void _1333_testInterface_testInterface_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1333\\testInterface\\testInterface.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
