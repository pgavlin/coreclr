using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_i4_i4_cs_d_i4_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i4_i4_cs_d_i4_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i4\\i4_cs_d\\i4_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
