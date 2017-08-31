using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayIListIndexOF_ArrayIListIndexOF_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayIListIndexOF_ArrayIListIndexOF_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayIListIndexOF\\ArrayIListIndexOF.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
