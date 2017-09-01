using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_r8_r8_cs_ro_r8_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r8_r8_cs_ro_r8_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r8\\r8_cs_ro\\r8_cs_ro.cmd");
        }
    }
}
