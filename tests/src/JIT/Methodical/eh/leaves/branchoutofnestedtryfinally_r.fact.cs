using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_branchoutofnestedtryfinally_r_branchoutofnestedtryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchoutofnestedtryfinally_r_branchoutofnestedtryfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchoutofnestedtryfinally_r\\branchoutofnestedtryfinally_r.cmd");
        }
    }
}
