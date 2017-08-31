using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIndexOf2_ArrayIndexOf2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIndexOf2_ArrayIndexOf2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIndexOf2\\ArrayIndexOf2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
