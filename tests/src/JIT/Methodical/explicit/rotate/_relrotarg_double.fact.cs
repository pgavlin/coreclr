using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__relrotarg_double__relrotarg_double_
    {
        [Fact]
        public void _explicit_rotate__relrotarg_double__relrotarg_double_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_relrotarg_double\\_relrotarg_double.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
