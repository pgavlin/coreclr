using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_emptyfinally_r_emptyfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_emptyfinally_r_emptyfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\emptyfinally_r\\emptyfinally_r.cmd");
        }
    }
}
