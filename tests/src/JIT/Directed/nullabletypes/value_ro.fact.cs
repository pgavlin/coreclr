using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_value_ro_value_ro_
    {
        [Fact]
        public void _nullabletypes_value_ro_value_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\value_ro\\value_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
