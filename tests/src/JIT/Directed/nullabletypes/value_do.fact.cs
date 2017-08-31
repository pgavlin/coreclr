using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_value_do_value_do_
    {
        [Fact]
        public void _nullabletypes_value_do_value_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\value_do\\value_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
