using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayReserse1_ArrayReserse1_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayReserse1_ArrayReserse1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayReserse1\\ArrayReserse1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
