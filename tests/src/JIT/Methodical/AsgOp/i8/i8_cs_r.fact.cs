using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_i8_i8_cs_r_i8_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i8_i8_cs_r_i8_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i8\\i8_cs_r\\i8_cs_r.cmd");
        }
    }
}
