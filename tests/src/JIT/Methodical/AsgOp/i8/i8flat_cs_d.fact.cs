using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_i8_i8flat_cs_d_i8flat_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i8_i8flat_cs_d_i8flat_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i8\\i8flat_cs_d\\i8flat_cs_d.cmd");
        }
    }
}
