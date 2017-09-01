using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_r8_r8flat_cs_ro_r8flat_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r8_r8flat_cs_ro_r8flat_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r8\\r8flat_cs_ro\\r8flat_cs_ro.cmd");
        }
    }
}
