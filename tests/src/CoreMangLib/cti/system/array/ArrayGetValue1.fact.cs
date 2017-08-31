using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayGetValue1_ArrayGetValue1_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetValue1_ArrayGetValue1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetValue1\\ArrayGetValue1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
