using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__dbgrotarg_valref__dbgrotarg_valref_
    {
        [Fact]
        public void _explicit_rotate__dbgrotarg_valref__dbgrotarg_valref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_dbgrotarg_valref\\_dbgrotarg_valref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
