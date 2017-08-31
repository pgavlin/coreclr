using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__il_dbgrotarg_objref__il_dbgrotarg_objref_
    {
        [Fact]
        public void _explicit_rotate__il_dbgrotarg_objref__il_dbgrotarg_objref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_il_dbgrotarg_objref\\_il_dbgrotarg_objref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
