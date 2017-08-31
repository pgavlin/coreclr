using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayICollectionget_Count_ArrayICollectionget_Count_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayICollectionget_Count_ArrayICollectionget_Count_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayICollectionget_Count\\ArrayICollectionget_Count.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
