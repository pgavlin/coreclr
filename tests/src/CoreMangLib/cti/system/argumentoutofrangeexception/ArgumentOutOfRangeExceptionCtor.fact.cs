using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_argumentoutofrangeexception_ArgumentOutOfRangeExceptionCtor_ArgumentOutOfRangeExceptionCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_argumentoutofrangeexception_ArgumentOutOfRangeExceptionCtor_ArgumentOutOfRangeExceptionCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\argumentoutofrangeexception\\ArgumentOutOfRangeExceptionCtor\\ArgumentOutOfRangeExceptionCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
