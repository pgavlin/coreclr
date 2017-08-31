using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__il_relrotarg_objref__il_relrotarg_objref_
    {
        [Fact]
        public void _explicit_rotate__il_relrotarg_objref__il_relrotarg_objref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_il_relrotarg_objref\\_il_relrotarg_objref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
