using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_r8_r8flat_cs_r_r8flat_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r8_r8flat_cs_r_r8flat_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r8\\r8flat_cs_r\\r8flat_cs_r.cmd");
        }
    }
}
