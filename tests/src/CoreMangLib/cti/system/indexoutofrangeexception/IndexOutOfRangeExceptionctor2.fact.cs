using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_indexoutofrangeexception_IndexOutOfRangeExceptionctor2_IndexOutOfRangeExceptionctor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_indexoutofrangeexception_IndexOutOfRangeExceptionctor2_IndexOutOfRangeExceptionctor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\indexoutofrangeexception\\IndexOutOfRangeExceptionctor2\\IndexOutOfRangeExceptionctor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
