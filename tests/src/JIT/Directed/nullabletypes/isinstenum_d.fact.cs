using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstenum_d_isinstenum_d_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstenum_d_isinstenum_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstenum_d\\isinstenum_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
