using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0069_date_date_
    {
        [OuterLoop]
        [Fact]
        public void _0069_date_date_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0069\\date\\date.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
