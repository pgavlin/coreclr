using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayGetUpperBound_ArrayGetUpperBound_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetUpperBound_ArrayGetUpperBound_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetUpperBound\\ArrayGetUpperBound.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
