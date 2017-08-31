using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__dbgrotarg_float__dbgrotarg_float_
    {
        [Fact]
        public void _explicit_rotate__dbgrotarg_float__dbgrotarg_float_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_dbgrotarg_float\\_dbgrotarg_float.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
