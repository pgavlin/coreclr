using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_indexoutofrangeexception_IndexOutOfRangeExceptionctor3_IndexOutOfRangeExceptionctor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_indexoutofrangeexception_IndexOutOfRangeExceptionctor3_IndexOutOfRangeExceptionctor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\indexoutofrangeexception\\IndexOutOfRangeExceptionctor3\\IndexOutOfRangeExceptionctor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
