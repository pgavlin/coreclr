using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_single_SingleToSingle_SingleToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_single_SingleToSingle_SingleToSingle_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\single\\SingleToSingle\\SingleToSingle.cmd");
        }
    }
}
