using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwoutside_ro_throwoutside_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwoutside_ro_throwoutside_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwoutside_ro\\throwoutside_ro.cmd");
        }
    }
}
