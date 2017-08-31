using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_i4_i4_cs_r_i4_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i4_i4_cs_r_i4_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i4\\i4_cs_r\\i4_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
