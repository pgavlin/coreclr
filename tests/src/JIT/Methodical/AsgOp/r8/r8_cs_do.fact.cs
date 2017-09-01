using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_r8_r8_cs_do_r8_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r8_r8_cs_do_r8_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r8\\r8_cs_do\\r8_cs_do.cmd");
        }
    }
}
