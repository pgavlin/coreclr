using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIndexOf2b_ArrayIndexOf2b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIndexOf2b_ArrayIndexOf2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIndexOf2b\\ArrayIndexOf2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
