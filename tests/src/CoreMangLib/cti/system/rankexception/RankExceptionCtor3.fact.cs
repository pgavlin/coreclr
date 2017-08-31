using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_rankexception_RankExceptionCtor3_RankExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_rankexception_RankExceptionCtor3_RankExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\rankexception\\RankExceptionCtor3\\RankExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
