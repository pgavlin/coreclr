using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIListset_item_ArrayIListset_item_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIListset_item_ArrayIListset_item_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIListset_item\\ArrayIListset_item.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
