using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayGetLowerBound_ArrayGetLowerBound_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetLowerBound_ArrayGetLowerBound_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetLowerBound\\ArrayGetLowerBound.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
