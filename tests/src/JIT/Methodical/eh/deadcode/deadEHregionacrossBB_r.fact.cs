using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_deadEHregionacrossBB_r_deadEHregionacrossBB_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadEHregionacrossBB_r_deadEHregionacrossBB_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadEHregionacrossBB_r\\deadEHregionacrossBB_r.cmd");
        }
    }
}
