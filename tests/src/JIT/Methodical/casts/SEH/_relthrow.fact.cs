using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__relthrow__relthrow_
    {
        [Fact]
        public void _casts_SEH__relthrow__relthrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_relthrow\\_relthrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
