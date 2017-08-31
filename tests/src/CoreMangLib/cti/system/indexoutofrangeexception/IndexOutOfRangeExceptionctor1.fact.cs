using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_indexoutofrangeexception_IndexOutOfRangeExceptionctor1_IndexOutOfRangeExceptionctor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_indexoutofrangeexception_IndexOutOfRangeExceptionctor1_IndexOutOfRangeExceptionctor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\indexoutofrangeexception\\IndexOutOfRangeExceptionctor1\\IndexOutOfRangeExceptionctor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
