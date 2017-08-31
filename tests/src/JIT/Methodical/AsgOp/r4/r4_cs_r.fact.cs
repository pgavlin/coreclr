using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_r4_r4_cs_r_r4_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r4_r4_cs_r_r4_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r4\\r4_cs_r\\r4_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
