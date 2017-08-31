using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__relrotarg_objref__relrotarg_objref_
    {
        [Fact]
        public void _explicit_rotate__relrotarg_objref__relrotarg_objref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_relrotarg_objref\\_relrotarg_objref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
