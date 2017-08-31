using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIListRemove_ArrayIListRemove_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIListRemove_ArrayIListRemove_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIListRemove\\ArrayIListRemove.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
