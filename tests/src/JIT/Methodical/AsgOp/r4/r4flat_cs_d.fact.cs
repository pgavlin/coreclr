using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_r4_r4flat_cs_d_r4flat_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r4_r4flat_cs_d_r4flat_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r4\\r4flat_cs_d\\r4flat_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
