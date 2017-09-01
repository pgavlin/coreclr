using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_threading_timeout_TimeOutInfinite_TimeOutInfinite_
    {
        [OuterLoop]
        [Fact]
        public void _system_threading_timeout_TimeOutInfinite_TimeOutInfinite_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\threading\\timeout\\TimeOutInfinite\\TimeOutInfinite.cmd");
        }
    }
}
