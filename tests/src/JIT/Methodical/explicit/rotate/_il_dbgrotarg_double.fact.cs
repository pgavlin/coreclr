using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__il_dbgrotarg_double__il_dbgrotarg_double_
    {
        [Fact]
        public void _explicit_rotate__il_dbgrotarg_double__il_dbgrotarg_double_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_il_dbgrotarg_double\\_il_dbgrotarg_double.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
