using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__opt_relrotarg_valref__opt_relrotarg_valref_
    {
        [Fact]
        public void _explicit_rotate__opt_relrotarg_valref__opt_relrotarg_valref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_opt_relrotarg_valref\\_opt_relrotarg_valref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
