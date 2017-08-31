using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_r8_r8flat_cs_r_r8flat_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r8_r8flat_cs_r_r8flat_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r8\\r8flat_cs_r\\r8flat_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
