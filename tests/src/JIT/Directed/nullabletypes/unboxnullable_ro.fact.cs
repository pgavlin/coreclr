using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_unboxnullable_ro_unboxnullable_ro_
    {
        [Fact]
        public void _nullabletypes_unboxnullable_ro_unboxnullable_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\unboxnullable_ro\\unboxnullable_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
