using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_single_SingleNaN_SingleNaN_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleNaN_SingleNaN_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleNaN\\SingleNaN.cmd");
        }
    }
}
