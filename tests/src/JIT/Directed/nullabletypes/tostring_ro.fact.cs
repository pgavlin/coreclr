using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_tostring_ro_tostring_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_tostring_ro_tostring_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\tostring_ro\\tostring_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
