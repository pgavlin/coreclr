using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_tostring_d_tostring_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_tostring_d_tostring_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\tostring_d\\tostring_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
