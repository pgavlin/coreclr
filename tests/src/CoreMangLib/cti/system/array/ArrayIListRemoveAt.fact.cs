using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIListRemoveAt_ArrayIListRemoveAt_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIListRemoveAt_ArrayIListRemoveAt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIListRemoveAt\\ArrayIListRemoveAt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
