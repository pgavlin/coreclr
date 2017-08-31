using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_tostring_do_tostring_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_tostring_do_tostring_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\tostring_do\\tostring_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
