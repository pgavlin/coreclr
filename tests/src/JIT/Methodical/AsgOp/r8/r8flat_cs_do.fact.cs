using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_r8_r8flat_cs_do_r8flat_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_r8_r8flat_cs_do_r8flat_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\r8\\r8flat_cs_do\\r8flat_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
