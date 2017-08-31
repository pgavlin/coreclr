using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_value_r_value_r_
    {
        [Fact]
        public void _nullabletypes_value_r_value_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\value_r\\value_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
