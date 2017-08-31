using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIndexOf4_ArrayIndexOf4_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIndexOf4_ArrayIndexOf4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIndexOf4\\ArrayIndexOf4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
