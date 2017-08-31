using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayLastIndexOf3_ArrayLastIndexOf3_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayLastIndexOf3_ArrayLastIndexOf3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayLastIndexOf3\\ArrayLastIndexOf3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
