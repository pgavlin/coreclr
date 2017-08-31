using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__dbgrotarg_double__dbgrotarg_double_
    {
        [Fact]
        public void _explicit_rotate__dbgrotarg_double__dbgrotarg_double_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_dbgrotarg_double\\_dbgrotarg_double.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
