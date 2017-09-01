using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _AsgOp_i8_i8_cs_ro_i8_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i8_i8_cs_ro_i8_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i8\\i8_cs_ro\\i8_cs_ro.cmd");
        }
    }
}
