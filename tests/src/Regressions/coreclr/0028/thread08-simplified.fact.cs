using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0028_thread08_simplified_thread08_simplified_
    {
        [OuterLoop]
        [Fact]
        public void _0028_thread08_simplified_thread08_simplified_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0028\\thread08-simplified\\thread08-simplified.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
