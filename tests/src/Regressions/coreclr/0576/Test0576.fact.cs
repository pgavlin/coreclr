using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0576_Test0576_Test0576_
    {
        [OuterLoop]
        [Fact]
        public void _0576_Test0576_Test0576_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0576\\Test0576\\Test0576.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
