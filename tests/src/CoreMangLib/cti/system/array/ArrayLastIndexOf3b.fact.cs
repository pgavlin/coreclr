using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayLastIndexOf3b_ArrayLastIndexOf3b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLastIndexOf3b_ArrayLastIndexOf3b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLastIndexOf3b\\ArrayLastIndexOf3b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
