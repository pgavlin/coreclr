using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_r4_r4_cs_ro_r4_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r4_r4_cs_ro_r4_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r4\\r4_cs_ro\\r4_cs_ro.cmd");
        }
    }
}
