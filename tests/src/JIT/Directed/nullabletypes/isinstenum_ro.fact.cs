using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _nullabletypes_isinstenum_ro_isinstenum_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstenum_ro_isinstenum_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstenum_ro\\isinstenum_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
