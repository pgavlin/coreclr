using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_branchbackwardswithcatch_r_branchbackwardswithcatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchbackwardswithcatch_r_branchbackwardswithcatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchbackwardswithcatch_r\\branchbackwardswithcatch_r.cmd");
        }
    }
}
