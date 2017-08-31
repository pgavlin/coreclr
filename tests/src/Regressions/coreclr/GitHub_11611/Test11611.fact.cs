using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _GitHub_11611_Test11611_Test11611_
    {
        [OuterLoop]
        [Fact]
        public void _GitHub_11611_Test11611_Test11611_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\GitHub_11611\\Test11611\\Test11611.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
