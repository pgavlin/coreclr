using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_single_SingleIsNaN_SingleIsNaN_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleIsNaN_SingleIsNaN_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleIsNaN\\SingleIsNaN.cmd");
        }
    }
}
