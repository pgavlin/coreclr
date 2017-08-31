using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__relrotarg_float__relrotarg_float_
    {
        [Fact]
        public void _explicit_rotate__relrotarg_float__relrotarg_float_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_relrotarg_float\\_relrotarg_float.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
