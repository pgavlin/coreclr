using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_overflowexception_OverflowExceptionCtor1_OverflowExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_overflowexception_OverflowExceptionCtor1_OverflowExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\overflowexception\\OverflowExceptionCtor1\\OverflowExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
