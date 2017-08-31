using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_overflowexception_OverflowExceptionCtor3_OverflowExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_overflowexception_OverflowExceptionCtor3_OverflowExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\overflowexception\\OverflowExceptionCtor3\\OverflowExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
