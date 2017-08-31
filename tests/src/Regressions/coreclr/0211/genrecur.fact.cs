using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0211_genrecur_genrecur_
    {
        [OuterLoop]
        [Fact]
        public void _0211_genrecur_genrecur_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0211\\genrecur\\genrecur.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
