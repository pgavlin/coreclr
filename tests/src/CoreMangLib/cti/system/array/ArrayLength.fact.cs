using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_array_ArrayLength_ArrayLength_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLength_ArrayLength_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLength\\ArrayLength.cmd");
        }
    }
}
