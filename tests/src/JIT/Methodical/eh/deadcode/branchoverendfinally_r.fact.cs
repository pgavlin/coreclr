using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_branchoverendfinally_r_branchoverendfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_branchoverendfinally_r_branchoverendfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\branchoverendfinally_r\\branchoverendfinally_r.cmd");
        }
    }
}
