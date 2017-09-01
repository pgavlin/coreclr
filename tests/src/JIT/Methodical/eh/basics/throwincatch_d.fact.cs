using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwincatch_d_throwincatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwincatch_d_throwincatch_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwincatch_d\\throwincatch_d.cmd");
        }
    }
}
