using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_array_ArrayGetLength_ArrayGetLength_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetLength_ArrayGetLength_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetLength\\ArrayGetLength.cmd");
        }
    }
}
