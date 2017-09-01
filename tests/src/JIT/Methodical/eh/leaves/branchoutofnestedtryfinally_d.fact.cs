using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_branchoutofnestedtryfinally_d_branchoutofnestedtryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchoutofnestedtryfinally_d_branchoutofnestedtryfinally_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchoutofnestedtryfinally_d\\branchoutofnestedtryfinally_d.cmd");
        }
    }
}
