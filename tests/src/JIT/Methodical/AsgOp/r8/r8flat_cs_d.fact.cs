using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_r8_r8flat_cs_d_r8flat_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r8_r8flat_cs_d_r8flat_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r8\\r8flat_cs_d\\r8flat_cs_d.cmd");
        }
    }
}
