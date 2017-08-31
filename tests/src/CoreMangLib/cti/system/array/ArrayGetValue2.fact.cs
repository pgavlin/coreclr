using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayGetValue2_ArrayGetValue2_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetValue2_ArrayGetValue2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetValue2\\ArrayGetValue2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
