using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwoutside_r_throwoutside_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwoutside_r_throwoutside_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwoutside_r\\throwoutside_r.cmd");
        }
    }
}
