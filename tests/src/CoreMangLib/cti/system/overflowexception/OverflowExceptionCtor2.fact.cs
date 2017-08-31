using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_overflowexception_OverflowExceptionCtor2_OverflowExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_overflowexception_OverflowExceptionCtor2_OverflowExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\overflowexception\\OverflowExceptionCtor2\\OverflowExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
