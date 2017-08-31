using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_tostring_r_tostring_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_tostring_r_tostring_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\tostring_r\\tostring_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
