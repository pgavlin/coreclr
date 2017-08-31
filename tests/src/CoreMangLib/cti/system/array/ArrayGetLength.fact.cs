using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayGetLength_ArrayGetLength_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetLength_ArrayGetLength_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetLength\\ArrayGetLength.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
