using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _72162_Test72162_Test72162_
    {
        [OuterLoop]
        [Fact]
        public void _72162_Test72162_Test72162_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\72162\\Test72162\\Test72162.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
