using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__relrotarg_valref__relrotarg_valref_
    {
        [Fact]
        public void _explicit_rotate__relrotarg_valref__relrotarg_valref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_relrotarg_valref\\_relrotarg_valref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
