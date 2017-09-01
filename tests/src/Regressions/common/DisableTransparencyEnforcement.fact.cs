using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _DisableTransparencyEnforcement_DisableTransparencyEnforcement_
    {
        [OuterLoop]
        [Fact]
        public void _DisableTransparencyEnforcement_DisableTransparencyEnforcement_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\DisableTransparencyEnforcement\\DisableTransparencyEnforcement.cmd");
        }
    }
}
