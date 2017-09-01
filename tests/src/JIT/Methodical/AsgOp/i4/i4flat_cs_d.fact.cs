using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_i4_i4flat_cs_d_i4flat_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i4_i4flat_cs_d_i4flat_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i4\\i4flat_cs_d\\i4flat_cs_d.cmd");
        }
    }
}
