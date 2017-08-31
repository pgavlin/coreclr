using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_value_d_value_d_
    {
        [Fact]
        public void _nullabletypes_value_d_value_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\value_d\\value_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
