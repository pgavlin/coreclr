using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_deadtryfinally_r_deadtryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadtryfinally_r_deadtryfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadtryfinally_r\\deadtryfinally_r.cmd");
        }
    }
}
