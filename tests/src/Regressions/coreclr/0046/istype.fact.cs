using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0046_istype_istype_
    {
        [OuterLoop]
        [Fact]
        public void _0046_istype_istype_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0046\\istype\\istype.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
