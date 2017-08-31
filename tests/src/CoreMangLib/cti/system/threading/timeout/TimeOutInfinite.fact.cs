using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_threading_timeout_TimeOutInfinite_TimeOutInfinite_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_timeout_TimeOutInfinite_TimeOutInfinite_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\timeout\\TimeOutInfinite\\TimeOutInfinite.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
