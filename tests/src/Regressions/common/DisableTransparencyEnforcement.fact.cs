using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _DisableTransparencyEnforcement_DisableTransparencyEnforcement_
    {
        [OuterLoop]
        [Fact]
        public void _DisableTransparencyEnforcement_DisableTransparencyEnforcement_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\DisableTransparencyEnforcement\\DisableTransparencyEnforcement.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
