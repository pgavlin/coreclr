using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIListInsert_ArrayIListInsert_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIListInsert_ArrayIListInsert_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIListInsert\\ArrayIListInsert.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
