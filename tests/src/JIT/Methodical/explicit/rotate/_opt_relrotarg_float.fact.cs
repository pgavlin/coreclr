using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__opt_relrotarg_float__opt_relrotarg_float_
    {
        [Fact]
        public void _explicit_rotate__opt_relrotarg_float__opt_relrotarg_float_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_opt_relrotarg_float\\_opt_relrotarg_float.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
