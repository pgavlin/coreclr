using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_unboxnullable_d_unboxnullable_d_
    {
        [Fact]
        public void _nullabletypes_unboxnullable_d_unboxnullable_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\unboxnullable_d\\unboxnullable_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
