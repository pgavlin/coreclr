using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_castclassenum_d_castclassenum_d_
    {
        [Fact]
        public void _nullabletypes_castclassenum_d_castclassenum_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\castclassenum_d\\castclassenum_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
