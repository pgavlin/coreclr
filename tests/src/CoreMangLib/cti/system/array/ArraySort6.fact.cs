using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArraySort6_ArraySort6_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArraySort6_ArraySort6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArraySort6\\ArraySort6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
