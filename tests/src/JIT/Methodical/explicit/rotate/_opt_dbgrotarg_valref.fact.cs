using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__opt_dbgrotarg_valref__opt_dbgrotarg_valref_
    {
        [Fact]
        public void _explicit_rotate__opt_dbgrotarg_valref__opt_dbgrotarg_valref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_opt_dbgrotarg_valref\\_opt_dbgrotarg_valref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
