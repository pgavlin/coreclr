using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_unboxnullable_r_unboxnullable_r_
    {
        [Fact]
        public void _nullabletypes_unboxnullable_r_unboxnullable_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\unboxnullable_r\\unboxnullable_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
