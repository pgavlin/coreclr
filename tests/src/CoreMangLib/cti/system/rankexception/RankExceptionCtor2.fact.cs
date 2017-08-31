using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_rankexception_RankExceptionCtor2_RankExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_rankexception_RankExceptionCtor2_RankExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\rankexception\\RankExceptionCtor2\\RankExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
