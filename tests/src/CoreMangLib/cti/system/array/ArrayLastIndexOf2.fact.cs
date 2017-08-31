using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayLastIndexOf2_ArrayLastIndexOf2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLastIndexOf2_ArrayLastIndexOf2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLastIndexOf2\\ArrayLastIndexOf2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
