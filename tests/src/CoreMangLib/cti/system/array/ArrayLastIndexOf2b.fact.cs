using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayLastIndexOf2b_ArrayLastIndexOf2b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLastIndexOf2b_ArrayLastIndexOf2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLastIndexOf2b\\ArrayLastIndexOf2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
