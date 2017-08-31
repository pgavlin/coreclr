using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_i4_i4flat_cs_ro_i4flat_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i4_i4flat_cs_ro_i4flat_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i4\\i4flat_cs_ro\\i4flat_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
