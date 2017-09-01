using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_deadtrycatch_r_deadtrycatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_deadtrycatch_r_deadtrycatch_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\deadtrycatch_r\\deadtrycatch_r.cmd");
        }
    }
}
