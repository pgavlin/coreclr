using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_single_SingleEpsilon_SingleEpsilon_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleEpsilon_SingleEpsilon_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleEpsilon\\SingleEpsilon.cmd");
        }
    }
}
