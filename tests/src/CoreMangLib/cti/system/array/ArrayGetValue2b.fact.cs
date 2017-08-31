using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayGetValue2b_ArrayGetValue2b_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetValue2b_ArrayGetValue2b_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetValue2b\\ArrayGetValue2b.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
