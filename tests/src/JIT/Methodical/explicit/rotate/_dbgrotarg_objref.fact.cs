using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__dbgrotarg_objref__dbgrotarg_objref_
    {
        [Fact]
        public void _explicit_rotate__dbgrotarg_objref__dbgrotarg_objref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_dbgrotarg_objref\\_dbgrotarg_objref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
