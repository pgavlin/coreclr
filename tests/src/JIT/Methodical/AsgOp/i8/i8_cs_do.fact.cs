using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _AsgOp_i8_i8_cs_do_i8_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _AsgOp_i8_i8_cs_do_i8_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\AsgOp\\i8\\i8_cs_do\\i8_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
