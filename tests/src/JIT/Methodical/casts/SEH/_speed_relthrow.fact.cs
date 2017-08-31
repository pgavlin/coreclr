using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__speed_relthrow__speed_relthrow_
    {
        [Fact]
        public void _casts_SEH__speed_relthrow__speed_relthrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_speed_relthrow\\_speed_relthrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
