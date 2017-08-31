using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__il_dbgrotarg_float__il_dbgrotarg_float_
    {
        [Fact]
        public void _explicit_rotate__il_dbgrotarg_float__il_dbgrotarg_float_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_il_dbgrotarg_float\\_il_dbgrotarg_float.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
