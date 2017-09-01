using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_branchoutoftryfinally_d_branchoutoftryfinally_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_branchoutoftryfinally_d_branchoutoftryfinally_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\branchoutoftryfinally_d\\branchoutoftryfinally_d.cmd");
        }
    }
}
