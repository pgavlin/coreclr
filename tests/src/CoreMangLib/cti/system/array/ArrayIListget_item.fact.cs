using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIListget_item_ArrayIListget_item_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIListget_item_ArrayIListget_item_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIListget_item\\ArrayIListget_item.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
