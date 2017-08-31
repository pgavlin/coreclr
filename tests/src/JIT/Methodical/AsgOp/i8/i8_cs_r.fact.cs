using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_i8_i8_cs_r_i8_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i8_i8_cs_r_i8_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i8\\i8_cs_r\\i8_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
