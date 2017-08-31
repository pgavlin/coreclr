using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstenum_r_isinstenum_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstenum_r_isinstenum_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstenum_r\\isinstenum_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
