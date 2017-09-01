using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwincatch_r_throwincatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwincatch_r_throwincatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwincatch_r\\throwincatch_r.cmd");
        }
    }
}
