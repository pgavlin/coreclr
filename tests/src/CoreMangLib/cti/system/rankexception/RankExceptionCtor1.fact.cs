using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_rankexception_RankExceptionCtor1_RankExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_rankexception_RankExceptionCtor1_RankExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\rankexception\\RankExceptionCtor1\\RankExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
