using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__opt_relrotarg_double__opt_relrotarg_double_
    {
        [Fact]
        public void _explicit_rotate__opt_relrotarg_double__opt_relrotarg_double_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_opt_relrotarg_double\\_opt_relrotarg_double.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
