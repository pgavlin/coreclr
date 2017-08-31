using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstenum_do_isinstenum_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstenum_do_isinstenum_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstenum_do\\isinstenum_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
