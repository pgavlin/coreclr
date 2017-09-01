using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_branchbackwardswithfinally_r_branchbackwardswithfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchbackwardswithfinally_r_branchbackwardswithfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchbackwardswithfinally_r\\branchbackwardswithfinally_r.cmd");
        }
    }
}
