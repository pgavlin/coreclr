using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_r4_r4flat_cs_ro_r4flat_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r4_r4flat_cs_ro_r4flat_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r4\\r4flat_cs_ro\\r4flat_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
