using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _GitHub_7685_Test7685_Test7685_
    {
        [OuterLoop]
        [Fact]
        public void _GitHub_7685_Test7685_Test7685_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\GitHub_7685\\Test7685\\Test7685.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
