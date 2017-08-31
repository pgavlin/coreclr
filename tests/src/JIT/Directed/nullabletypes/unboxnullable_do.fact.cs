using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_unboxnullable_do_unboxnullable_do_
    {
        [Fact]
        public void _nullabletypes_unboxnullable_do_unboxnullable_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\unboxnullable_do\\unboxnullable_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
