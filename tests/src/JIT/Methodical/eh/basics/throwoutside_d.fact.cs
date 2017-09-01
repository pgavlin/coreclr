using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwoutside_d_throwoutside_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwoutside_d_throwoutside_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwoutside_d\\throwoutside_d.cmd");
        }
    }
}
