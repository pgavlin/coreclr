using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_argumentoutofrangeexception_ArgumentOutOfRangeExceptionMessage_ArgumentOutOfRangeExceptionMessage_
    {
        [OuterLoop]
        [Fact]
        public void _system_argumentoutofrangeexception_ArgumentOutOfRangeExceptionMessage_ArgumentOutOfRangeExceptionMessage_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\argumentoutofrangeexception\\ArgumentOutOfRangeExceptionMessage\\ArgumentOutOfRangeExceptionMessage.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
